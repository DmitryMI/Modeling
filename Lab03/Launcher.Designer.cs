namespace Lab03
{
    partial class Launcher
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rodLenBox = new System.Windows.Forms.TextBox();
            this.rodRadBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TEnvBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FluxBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.K0Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KNBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AlphaNBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Alpha0Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StepBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.DoDebugPrintBox = new System.Windows.Forms.CheckBox();
            this.X0Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходные данные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина стержня (см):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rodLenBox
            // 
            this.rodLenBox.Location = new System.Drawing.Point(166, 68);
            this.rodLenBox.Name = "rodLenBox";
            this.rodLenBox.Size = new System.Drawing.Size(100, 20);
            this.rodLenBox.TabIndex = 3;
            this.rodLenBox.Text = "10";
            // 
            // rodRadBox
            // 
            this.rodRadBox.Location = new System.Drawing.Point(166, 94);
            this.rodRadBox.Name = "rodRadBox";
            this.rodRadBox.Size = new System.Drawing.Size(100, 20);
            this.rodRadBox.TabIndex = 5;
            this.rodRadBox.Text = "0.5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Радиус стержня (см):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TEnvBox
            // 
            this.TEnvBox.Location = new System.Drawing.Point(166, 120);
            this.TEnvBox.Name = "TEnvBox";
            this.TEnvBox.Size = new System.Drawing.Size(100, 20);
            this.TEnvBox.TabIndex = 7;
            this.TEnvBox.Text = "300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Температура среды (К):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FluxBox
            // 
            this.FluxBox.Location = new System.Drawing.Point(166, 146);
            this.FluxBox.Name = "FluxBox";
            this.FluxBox.Size = new System.Drawing.Size(100, 20);
            this.FluxBox.TabIndex = 9;
            this.FluxBox.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Плотность теплового потока:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // K0Box
            // 
            this.K0Box.Location = new System.Drawing.Point(166, 172);
            this.K0Box.Name = "K0Box";
            this.K0Box.Size = new System.Drawing.Size(100, 20);
            this.K0Box.TabIndex = 11;
            this.K0Box.Text = "0.2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "К. теплопров. в начале:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // KNBox
            // 
            this.KNBox.Location = new System.Drawing.Point(166, 198);
            this.KNBox.Name = "KNBox";
            this.KNBox.Size = new System.Drawing.Size(100, 20);
            this.KNBox.TabIndex = 13;
            this.KNBox.Text = "0.5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "К. теплопров. в конце:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AlphaNBox
            // 
            this.AlphaNBox.Location = new System.Drawing.Point(166, 250);
            this.AlphaNBox.Name = "AlphaNBox";
            this.AlphaNBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaNBox.TabIndex = 17;
            this.AlphaNBox.Text = "9E-3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "К. теплоотд. в конце:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Alpha0Box
            // 
            this.Alpha0Box.Location = new System.Drawing.Point(166, 224);
            this.Alpha0Box.Name = "Alpha0Box";
            this.Alpha0Box.Size = new System.Drawing.Size(100, 20);
            this.Alpha0Box.TabIndex = 15;
            this.Alpha0Box.Text = "1E-2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "К. теплоотд. в начале:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StepBox
            // 
            this.StepBox.Location = new System.Drawing.Point(166, 276);
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(100, 20);
            this.StepBox.TabIndex = 19;
            this.StepBox.Text = "1E-2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Шаг:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LaunchButton
            // 
            this.LaunchButton.Location = new System.Drawing.Point(191, 308);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(75, 23);
            this.LaunchButton.TabIndex = 20;
            this.LaunchButton.Text = "Запуск";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // DoDebugPrintBox
            // 
            this.DoDebugPrintBox.AutoSize = true;
            this.DoDebugPrintBox.Location = new System.Drawing.Point(9, 313);
            this.DoDebugPrintBox.Name = "DoDebugPrintBox";
            this.DoDebugPrintBox.Size = new System.Drawing.Size(112, 17);
            this.DoDebugPrintBox.TabIndex = 21;
            this.DoDebugPrintBox.Text = "Отладочная инф.";
            this.DoDebugPrintBox.UseVisualStyleBackColor = true;
            // 
            // X0Box
            // 
            this.X0Box.Location = new System.Drawing.Point(166, 42);
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(100, 20);
            this.X0Box.TabIndex = 23;
            this.X0Box.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "X0 (см):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 343);
            this.Controls.Add(this.X0Box);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DoDebugPrintBox);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.StepBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AlphaNBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Alpha0Box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.KNBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.K0Box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FluxBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TEnvBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rodRadBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rodLenBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Launcher";
            this.Text = "Уравнение теплопроводности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rodLenBox;
        private System.Windows.Forms.TextBox rodRadBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TEnvBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FluxBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox K0Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KNBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AlphaNBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Alpha0Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StepBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.CheckBox DoDebugPrintBox;
        private System.Windows.Forms.TextBox X0Box;
        private System.Windows.Forms.Label label11;
    }
}

