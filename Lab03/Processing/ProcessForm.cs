using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab03.Datasets;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Lab03.Processing
{
    public partial class ProcessForm : Form
    {
        private InitialData _data;
        private Thread _processingThread;

        private IList<double> _yVals, _xVals;
        private string _formTitle;

        delegate void ProcessFormAction();

        public ProcessForm(InitialData data)
        {
            InitializeComponent();

            _data = data;
            _formTitle = Text;
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public void StartCalculation()
        {
            if (_processingThread == null)
            {
                _processingThread = new Thread(ProcessingBackground);
                _processingThread.Start();
                Text = _formTitle + " (ожидайте...)";
            }
            else
            {
                throw new InvalidOperationException("Processing is already in run");
            }
        }

        public bool IsProcessingOnline
        {
            get
            {
                if (_processingThread == null)
                    return false;
                return _processingThread.IsAlive;
            }
        }

        private void PrintGraphics()
        {
            Text = _formTitle + " (готово)";

            PlotView plotView = Plot;

            var myModel = new PlotModel { Title = "Температура стержня" };
            plotView.Model = myModel;

            LineSeries line = new LineSeries();
            
            for (int i = 0; i < _yVals.Count; i++)
            {
                line.Points.Add(new DataPoint(_xVals[i], _yVals[i]));
            }

            plotView.Model.Series.Add(line);
        }

        private void ProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsProcessingOnline)
            {
                _processingThread.Abort();
                _processingThread = null;
            }
        }

        private void ProcessingBackground()
        {
            ProcessingUtils proc = new ProcessingUtils();
            proc.Process(_data, out  _yVals, out _xVals);
            
            ProcessFormAction action = new ProcessFormAction(PrintGraphics);
            this.BeginInvoke(action);
        }
    }
}
