namespace Grifindo_Toys_PS
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.emp_manage_btn = new System.Windows.Forms.Button();
            this.salary_btn = new System.Windows.Forms.Button();
            this.setting_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpPic = new System.Windows.Forms.PictureBox();
            this.SalaryPic = new System.Windows.Forms.PictureBox();
            this.SettingsPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_manage_btn
            // 
            this.emp_manage_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.emp_manage_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emp_manage_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_manage_btn.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_manage_btn.ForeColor = System.Drawing.Color.Black;
            this.emp_manage_btn.Location = new System.Drawing.Point(46, 21);
            this.emp_manage_btn.Name = "emp_manage_btn";
            this.emp_manage_btn.Size = new System.Drawing.Size(233, 216);
            this.emp_manage_btn.TabIndex = 1;
            this.emp_manage_btn.Text = "Employee Management";
            this.emp_manage_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emp_manage_btn.UseVisualStyleBackColor = false;
            this.emp_manage_btn.Click += new System.EventHandler(this.emp_manage_btn_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.salary_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_btn.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_btn.ForeColor = System.Drawing.Color.Black;
            this.salary_btn.Location = new System.Drawing.Point(320, 21);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.Size = new System.Drawing.Size(233, 216);
            this.salary_btn.TabIndex = 2;
            this.salary_btn.Text = "Salary Tracker";
            this.salary_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salary_btn.UseVisualStyleBackColor = false;
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click);
            // 
            // setting_btn
            // 
            this.setting_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.setting_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting_btn.Font = new System.Drawing.Font("Britannic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_btn.ForeColor = System.Drawing.Color.Black;
            this.setting_btn.Location = new System.Drawing.Point(591, 21);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(240, 216);
            this.setting_btn.TabIndex = 3;
            this.setting_btn.Text = "Configuration Settings";
            this.setting_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.BackColor = System.Drawing.Color.Azure;
            this.help_btn.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_btn.Location = new System.Drawing.Point(79, 335);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(129, 55);
            this.help_btn.TabIndex = 4;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = false;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Azure;
            this.logout_btn.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(653, 336);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(129, 55);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(224, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "PAYROLL MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(343, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Developed By Rasintha Lahiru";
            // 
            // EmpPic
            // 
            this.EmpPic.BackColor = System.Drawing.Color.FloralWhite;
            this.EmpPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EmpPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpPic.Image = ((System.Drawing.Image)(resources.GetObject("EmpPic.Image")));
            this.EmpPic.Location = new System.Drawing.Point(114, 47);
            this.EmpPic.Name = "EmpPic";
            this.EmpPic.Size = new System.Drawing.Size(100, 100);
            this.EmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmpPic.TabIndex = 7;
            this.EmpPic.TabStop = false;
            this.EmpPic.Click += new System.EventHandler(this.EmpPic_Click);
            // 
            // SalaryPic
            // 
            this.SalaryPic.BackColor = System.Drawing.Color.FloralWhite;
            this.SalaryPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SalaryPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalaryPic.Image = ((System.Drawing.Image)(resources.GetObject("SalaryPic.Image")));
            this.SalaryPic.Location = new System.Drawing.Point(395, 49);
            this.SalaryPic.Name = "SalaryPic";
            this.SalaryPic.Size = new System.Drawing.Size(84, 80);
            this.SalaryPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalaryPic.TabIndex = 8;
            this.SalaryPic.TabStop = false;
            this.SalaryPic.Click += new System.EventHandler(this.SalaryPic_Click_1);
            // 
            // SettingsPic
            // 
            this.SettingsPic.BackColor = System.Drawing.Color.FloralWhite;
            this.SettingsPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingsPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsPic.Image = ((System.Drawing.Image)(resources.GetObject("SettingsPic.Image")));
            this.SettingsPic.Location = new System.Drawing.Point(664, 43);
            this.SettingsPic.Name = "SettingsPic";
            this.SettingsPic.Size = new System.Drawing.Size(97, 97);
            this.SettingsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsPic.TabIndex = 9;
            this.SettingsPic.TabStop = false;
            this.SettingsPic.Click += new System.EventHandler(this.SettingsPic_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.SettingsPic);
            this.panel1.Controls.Add(this.SalaryPic);
            this.panel1.Controls.Add(this.EmpPic);
            this.panel1.Controls.Add(this.setting_btn);
            this.panel1.Controls.Add(this.salary_btn);
            this.panel1.Controls.Add(this.emp_manage_btn);
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 263);
            this.panel1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(877, 405);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.help_btn);
            this.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grifindo Toys Payroll System";
            ((System.ComponentModel.ISupportInitialize)(this.EmpPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button emp_manage_btn;
        private System.Windows.Forms.Button salary_btn;
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox EmpPic;
        private System.Windows.Forms.PictureBox SalaryPic;
        private System.Windows.Forms.PictureBox SettingsPic;
        private System.Windows.Forms.Panel panel1;
    }
}

