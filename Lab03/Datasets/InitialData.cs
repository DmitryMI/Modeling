using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Datasets
{
    public struct InitialData
    {
        public double X0;

        public double RodLength;
        public double RodRadius;
        public double EnvironmentTemperature;
        public double HeatFluxDensity;
        public double Alpha0;
        public double AlphaN;
        public double K0;
        public double Kn;
        public double Step;

        public bool DoDebugPrint;

        private double bk => (Kn * RodLength) / (Kn - K0);
        private double ak => -K0 * bk;

        private double bAlpha => (AlphaN * RodLength) / (AlphaN - Alpha0);
        private double aAlpha => -Alpha0 * bAlpha;

        public double k(double x) => ak / (x - bk);

        public double alpha(double x) => aAlpha / (x - bAlpha);

        public double XnP05(double x) =>
            2 * k(x) * k(x + Step) / (k(x) + k(x + Step));

        public double XnM05(double x) =>
            2 * k(x) * k(x - Step) / (k(x) + k(x - Step));

        public double p(double x) => 2 * alpha(x) / RodRadius;

        public double f(double x) => 2 * alpha(x) / RodRadius * EnvironmentTemperature;
    }
}
