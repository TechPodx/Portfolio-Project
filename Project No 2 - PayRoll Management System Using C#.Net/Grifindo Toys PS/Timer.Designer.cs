namespace Grifindo_Toys_PS
{
    partial class Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar2 = new Guna.UI.WinForms.GunaProgressBar();
            this.ProgressBar1 = new Guna.UI.WinForms.GunaProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(43, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "PAYROLL MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(353, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Developed By Rasintha Lahiru";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.BackColor = System.Drawing.Color.White;
            this.ProgressBar2.BorderColor = System.Drawing.Color.Black;
            this.ProgressBar2.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.ProgressBar2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ProgressBar2.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBar2.Location = new System.Drawing.Point(232, 54);
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.ProgressMaxColor = System.Drawing.Color.MistyRose;
            this.ProgressBar2.ProgressMinColor = System.Drawing.Color.PowderBlue;
            this.ProgressBar2.Size = new System.Drawing.Size(160, 13);
            this.ProgressBar2.TabIndex = 8;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BorderColor = System.Drawing.Color.Black;
            this.ProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.ProgressBar1.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBar1.Location = new System.Drawing.Point(140, 209);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressMaxColor = System.Drawing.Color.PowderBlue;
            this.ProgressBar1.ProgressMinColor = System.Drawing.Color.MistyRose;
            this.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProgressBar1.Size = new System.Drawing.Size(160, 13);
            this.ProgressBar1.TabIndex = 9;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 276);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.ProgressBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI.WinForms.GunaProgressBar ProgressBar2;
        private Guna.UI.WinForms.GunaProgressBar ProgressBar1;
    }
}