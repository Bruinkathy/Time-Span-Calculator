namespace TimeSpanCalculator
{
    partial class Calculator
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeNow = new System.Windows.Forms.Label();
            this.DateLabel1 = new System.Windows.Forms.Label();
            this.DateBox1 = new System.Windows.Forms.TextBox();
            this.DateLabel2 = new System.Windows.Forms.Label();
            this.DateBox2 = new System.Windows.Forms.TextBox();
            this.CalculationBox1 = new System.Windows.Forms.Label();
            this.CopyClipboard = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.Today = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeNow
            // 
            this.WelcomeNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcomeNow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WelcomeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeNow.ForeColor = System.Drawing.SystemColors.Control;
            this.WelcomeNow.Location = new System.Drawing.Point(116, 19);
            this.WelcomeNow.Name = "WelcomeNow";
            this.WelcomeNow.Size = new System.Drawing.Size(577, 65);
            this.WelcomeNow.TabIndex = 0;
            this.WelcomeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel1
            // 
            this.DateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel1.Location = new System.Drawing.Point(137, 128);
            this.DateLabel1.Name = "DateLabel1";
            this.DateLabel1.Size = new System.Drawing.Size(305, 20);
            this.DateLabel1.TabIndex = 1;
            this.DateLabel1.Text = "Please enter a date:\r\n\r\n";
            this.DateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateBox1
            // 
            this.DateBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox1.Location = new System.Drawing.Point(477, 126);
            this.DateBox1.Name = "DateBox1";
            this.DateBox1.Size = new System.Drawing.Size(111, 22);
            this.DateBox1.TabIndex = 2;
            // 
            // DateLabel2
            // 
            this.DateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel2.Location = new System.Drawing.Point(137, 183);
            this.DateLabel2.Name = "DateLabel2";
            this.DateLabel2.Size = new System.Drawing.Size(263, 50);
            this.DateLabel2.TabIndex = 4;
            this.DateLabel2.Text = "Enter a second date\r\nor click the \"Today\" button:\r\n";
            this.DateLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateBox2
            // 
            this.DateBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox2.Location = new System.Drawing.Point(477, 183);
            this.DateBox2.Name = "DateBox2";
            this.DateBox2.Size = new System.Drawing.Size(111, 22);
            this.DateBox2.TabIndex = 5;
            // 
            // CalculationBox1
            // 
            this.CalculationBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationBox1.Location = new System.Drawing.Point(112, 290);
            this.CalculationBox1.Name = "CalculationBox1";
            this.CalculationBox1.Size = new System.Drawing.Size(581, 100);
            this.CalculationBox1.TabIndex = 7;
            // 
            // CopyClipboard
            // 
            this.CopyClipboard.AutoSize = true;
            this.CopyClipboard.BackColor = System.Drawing.Color.Tan;
            this.CopyClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyClipboard.ForeColor = System.Drawing.Color.Snow;
            this.CopyClipboard.Location = new System.Drawing.Point(115, 402);
            this.CopyClipboard.Name = "CopyClipboard";
            this.CopyClipboard.Size = new System.Drawing.Size(132, 36);
            this.CopyClipboard.TabIndex = 8;
            this.CopyClipboard.Text = "Copy to Clipboard";
            this.CopyClipboard.UseVisualStyleBackColor = false;
            this.CopyClipboard.Click += new System.EventHandler(this.CopyClipboard_Click);
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.Color.Snow;
            this.Calculate.Location = new System.Drawing.Point(477, 230);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(192, 37);
            this.Calculate.TabIndex = 9;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Today
            // 
            this.Today.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Today.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Today.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Today.Location = new System.Drawing.Point(594, 176);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(75, 36);
            this.Today.TabIndex = 10;
            this.Today.Text = "Today";
            this.Today.UseVisualStyleBackColor = false;
            this.Today.Click += new System.EventHandler(this.Today_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.CopyClipboard);
            this.Controls.Add(this.CalculationBox1);
            this.Controls.Add(this.DateBox2);
            this.Controls.Add(this.DateLabel2);
            this.Controls.Add(this.DateBox1);
            this.Controls.Add(this.DateLabel1);
            this.Controls.Add(this.WelcomeNow);
            this.Name = "Calculator";
            this.Text = "Time Span Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeNow;
        private System.Windows.Forms.Label DateLabel1;
        private System.Windows.Forms.TextBox DateBox1;
        private System.Windows.Forms.Label DateLabel2;
        private System.Windows.Forms.TextBox DateBox2;
        private System.Windows.Forms.Label CalculationBox1;
        private System.Windows.Forms.Button CopyClipboard;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Today;
    }
}

