using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab03.Datasets;
using Lab03.Processing;

namespace Lab03
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private string CollectSourceData(out InitialData data)
        {
            data = new InitialData();

            try
            {
                double length = Double.Parse(rodLenBox.Text, CultureInfo.InvariantCulture);
                double radius = Double.Parse(rodRadBox.Text, CultureInfo.InvariantCulture);
                double tEnv = Double.Parse(TEnvBox.Text, CultureInfo.InvariantCulture);
                double alpha0 = Double.Parse(Alpha0Box.Text, CultureInfo.InvariantCulture);
                double alphaN = Double.Parse(AlphaNBox.Text, CultureInfo.InvariantCulture);
                double k0 = Double.Parse(K0Box.Text, CultureInfo.InvariantCulture);
                double kN = Double.Parse(KNBox.Text, CultureInfo.InvariantCulture);
                double density = Double.Parse(FluxBox.Text, CultureInfo.InvariantCulture);
                double step = Double.Parse(StepBox.Text, CultureInfo.InvariantCulture);
                double x0 = Double.Parse(X0Box.Text, CultureInfo.InvariantCulture);
                bool debug = DoDebugPrintBox.Checked;

                data.X0 = x0;
                data.DoDebugPrint = debug;
                data.RodLength = length;
                data.RodRadius = radius;
                data.Alpha0 = alpha0;
                data.AlphaN = alphaN;
                data.K0 = k0;
                data.Kn = kN;
                data.EnvironmentTemperature = tEnv;
                data.HeatFluxDensity = density;
                data.Step = step;
                

                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            string errorMessage = CollectSourceData(out var data);
            if (String.IsNullOrEmpty(errorMessage))
            {
                ProcessForm processForm = new ProcessForm(data);
                processForm.Show();
                processForm.StartCalculation();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}
