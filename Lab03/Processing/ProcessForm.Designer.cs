using OxyPlot.WindowsForms;

namespace Lab03.Processing
{
    partial class ProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private OxyPlot.WindowsForms.PlotView Plot;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Plot = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // Plot
            // 
            this.Plot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plot.Location = new System.Drawing.Point(0, 0);
            this.Plot.Name = "Plot";
            this.Plot.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.Plot.Size = new System.Drawing.Size(546, 405);
            this.Plot.TabIndex = 0;
            this.Plot.Text = "plot1";
            this.Plot.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.Plot.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.Plot.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 405);
            this.Controls.Add(this.Plot);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        
    }
}