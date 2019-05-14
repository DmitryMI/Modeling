using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab03.Datasets;

namespace Lab03.Processing
{
    class ProcessingUtils
    {
        private InitialData _data;

        private struct ThomasArguments
        {
            public List<double> A, B, C, D;

            public double K0, M0, P0, KN, MN, PN;
        }

        private void PrintValue(string name, IEnumerable<double> array)
        {
            Debug.Write(name + ": ");
            foreach (var e in array)
            {
                string val = e.ToString("0.0") + ", ";
                Debug.Write(val);
            }
            Debug.WriteLine("\n");
        }

        private void PrintValue(IEnumerable<double> array)
        {
            Debug.Write("debug: ");
            foreach (var e in array)
            {
                string val = e.ToString("0.0") + ", ";
                Debug.Write(val);
            }
            Debug.WriteLine("\n");
        }

        private void PrintValue(string name, double value)
        {
            Debug.WriteLine(name + ": " + value);
        }

        private void PrintValue(double value)
        {
            Debug.WriteLine("debug: " + value);
        }

        void CalculateCoefficients(List<double> A, List<double> B, List<double> C, List<double> D)
        {
            for (double x = _data.X0; x < _data.RodLength; x += _data.Step)
            {
                double an = _data.XnM05(x) / _data.Step;
                double cn = _data.XnP05(x) / _data.Step;
                double bn = an + cn + _data.p(x) * _data.Step;
                double dn = _data.f(x) * _data.Step;

                A.Add(an);
                B.Add(bn);
                C.Add(cn);
                D.Add(dn);
            }
        }

        void LeftBoundaryConditions(out double K0, out double M0, out double P0)
        {
            double xHalf = _data.XnP05(_data.X0);

            double p1 = _data.p(_data.X0 + _data.Step);
            double f1 = _data.f(_data.X0 + _data.Step);

            double p0 = _data.p(_data.X0);
            double f0 = _data.f(_data.X0);

            double pHalf = (p0 + p1) / 2;
            double h2 = _data.Step * _data.Step;

            K0 = xHalf + h2 * pHalf / 8 + h2 * p0 / 4;
            M0 = h2 * pHalf / 8 - xHalf;
            P0 = _data.Step * _data.HeatFluxDensity + h2 * (3 * f0 + f1) / 4;
        }

        void RightBoundaryConditions(out double KN, out double MN, out double PN)
        {
            double xHalf = _data.XnM05(_data.RodLength);

            double pN = _data.p(_data.RodLength);
            double pN1 = _data.p(_data.RodLength - _data.Step);

            double fN = _data.f(_data.RodLength);
            double fN1 = 2 * _data.alpha(_data.RodLength - _data.Step) / _data.RodRadius * _data.EnvironmentTemperature;

            KN = -(xHalf + _data.AlphaN * _data.Step) / _data.Step - _data.Step * (5 * pN + pN1) / 16;
            MN = xHalf / _data.Step - _data.Step * (pN + pN1) / 16;
            PN = -_data.AlphaN * _data.EnvironmentTemperature - _data.Step * (3 * fN + fN1) / 8;
        }

        List<double> ThomasAlgorithm(ThomasArguments args)
        {
            List<double> xi = new List<double>(args.A.Count)
            {
                Double.NaN, -args.M0 / args.K0
            };
            List<double> eta = new List<double>(args.A.Count)
            {
                Double.NaN, args.P0 / args.K0
            };

            // Straight running
            for (int i = 1; i < args.A.Count; i++)
            {
                double x = args.C[i] / (args.B[i] - args.A[i] * xi[i]);
                double e = (args.D[i] + args.A[i] * eta[i]) / (args.B[i] - args.A[i] * xi[i]);

                xi.Add(x);
                eta.Add(e);
            }

            // Reverse running
            List<double> y = new List<double>(args.A.Count)
            {
                (args.PN - args.MN * eta.Last()) / (args.KN + args.MN * xi.Last())
            };

            for (int i = args.A.Count - 2; i >= -1; i--)
            {
                double yi = xi[i + 1] * y[0] + eta[i + 1];
                y.Insert(0, yi);
            }

            return y;
        }


        public void Process(InitialData data, out IList<double> y, out IList<double> x)
        {
            _data = data;

            int countOfValues = (int)Math.Ceiling((data.RodLength - data.X0) / data.Step);

            // A B C D
            List<double> A = new List<double>(countOfValues);
            List<double> B = new List<double>(countOfValues);
            List<double> C = new List<double>(countOfValues);
            List<double> D = new List<double>(countOfValues);

            CalculateCoefficients(A, B, C, D);

            // Left boundary conditions. k0, m0, p0
            double k0, m0, p0;
            LeftBoundaryConditions(out k0, out m0, out p0);
            
            // Right boundary conditions. kN, mN, pN
            double kN, mN, pN;
            RightBoundaryConditions(out kN, out mN, out pN);
            
            ThomasArguments args = new ThomasArguments()
            {
                A = A, B = B, C = C, D = D,
                K0 = k0, M0 = m0, P0 = p0,
                KN = kN, MN = mN, PN = pN
            };

            y = ThomasAlgorithm(args);
            
            x = new List<double>(y.Count);
            double xi = _data.X0;
            for (int i = 0; i < y.Count; i++)
            {
                x.Add(xi);
                xi += _data.Step;
            }

            if (_data.DoDebugPrint)
            {
                PrintValue("A", A);
                PrintValue("B", B);
                PrintValue("C", C);
                PrintValue("D", D);

                PrintValue("K0", k0);
                PrintValue("M0", m0);
                PrintValue("P0", p0);

                PrintValue("KN", kN);
                PrintValue("MN", mN);
                PrintValue("PN", pN);
            }

        }

    }
}
