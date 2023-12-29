namespace Grifindo_Toys_PS
{
    partial class Report_Generation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Generation));
            this.DGVReportGen = new Guna.UI.WinForms.GunaDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SalaryPic = new System.Windows.Forms.PictureBox();
            this.MiniBtn = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.LoadSalaryRecBtn = new System.Windows.Forms.Button();
            this.REmpNoTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportBeginDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ReportEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Downloadbtn = new System.Windows.Forms.PictureBox();
            this.PrintBtn = new System.Windows.Forms.PictureBox();
            this.RHeadingLbl = new System.Windows.Forms.Label();
            this.TypeCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReportGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Downloadbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVReportGen
            // 
            this.DGVReportGen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGVReportGen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVReportGen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVReportGen.BackgroundColor = System.Drawing.Color.White;
            this.DGVReportGen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVReportGen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVReportGen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVReportGen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVReportGen.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVReportGen.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVReportGen.EnableHeadersVisualStyles = false;
            this.DGVReportGen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVReportGen.Location = new System.Drawing.Point(1, 75);
            this.DGVReportGen.MultiSelect = false;
            this.DGVReportGen.Name = "DGVReportGen";
            this.DGVReportGen.ReadOnly = true;
            this.DGVReportGen.RowHeadersVisible = false;
            this.DGVReportGen.RowTemplate.Height = 23;
            this.DGVReportGen.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVReportGen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVReportGen.Size = new System.Drawing.Size(1300, 534);
            this.DGVReportGen.TabIndex = 0;
            this.DGVReportGen.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVReportGen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVReportGen.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVReportGen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVReportGen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVReportGen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVReportGen.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVReportGen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVReportGen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Salmon;
            this.DGVReportGen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVReportGen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVReportGen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGVReportGen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVReportGen.ThemeStyle.HeaderStyle.Height = 25;
            this.DGVReportGen.ThemeStyle.ReadOnly = true;
            this.DGVReportGen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVReportGen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVReportGen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGVReportGen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVReportGen.ThemeStyle.RowsStyle.Height = 23;
            this.DGVReportGen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVReportGen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 27);
            this.label1.TabIndex = 45;
            this.label1.Text = "Report Viewer";
            // 
            // SalaryPic
            // 
            this.SalaryPic.BackColor = System.Drawing.Color.RosyBrown;
            this.SalaryPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SalaryPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SalaryPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalaryPic.Image = ((System.Drawing.Image)(resources.GetObject("SalaryPic.Image")));
            this.SalaryPic.Location = new System.Drawing.Point(34, 3);
            this.SalaryPic.Name = "SalaryPic";
            this.SalaryPic.Size = new System.Drawing.Size(51, 47);
            this.SalaryPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalaryPic.TabIndex = 46;
            this.SalaryPic.TabStop = false;
            this.SalaryPic.Click += new System.EventHandler(this.SalaryPic_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.BackColor = System.Drawing.Color.Transparent;
            this.MiniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MiniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiniBtn.Image = ((System.Drawing.Image)(resources.GetObject("MiniBtn.Image")));
            this.MiniBtn.Location = new System.Drawing.Point(1232, 5);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.Size = new System.Drawing.Size(28, 28);
            this.MiniBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MiniBtn.TabIndex = 48;
            this.MiniBtn.TabStop = false;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(1263, 4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBtn.TabIndex = 47;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LoadSalaryRecBtn
            // 
            this.LoadSalaryRecBtn.BackColor = System.Drawing.Color.Azure;
            this.LoadSalaryRecBtn.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSalaryRecBtn.Location = new System.Drawing.Point(1001, 625);
            this.LoadSalaryRecBtn.Name = "LoadSalaryRecBtn";
            this.LoadSalaryRecBtn.Size = new System.Drawing.Size(128, 32);
            this.LoadSalaryRecBtn.TabIndex = 49;
            this.LoadSalaryRecBtn.Text = "Load Records";
            this.LoadSalaryRecBtn.UseVisualStyleBackColor = false;
            this.LoadSalaryRecBtn.Click += new System.EventHandler(this.LoadSalaryRecBtn_Click);
            // 
            // REmpNoTbx
            // 
            this.REmpNoTbx.BackColor = System.Drawing.Color.Linen;
            this.REmpNoTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.REmpNoTbx.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REmpNoTbx.Location = new System.Drawing.Point(94, 630);
            this.REmpNoTbx.Name = "REmpNoTbx";
            this.REmpNoTbx.Size = new System.Drawing.Size(65, 20);
            this.REmpNoTbx.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Emp No:";
            // 
            // ReportBeginDatePicker
            // 
            this.ReportBeginDatePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.ReportBeginDatePicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBeginDatePicker.Location = new System.Drawing.Point(268, 626);
            this.ReportBeginDatePicker.Name = "ReportBeginDatePicker";
            this.ReportBeginDatePicker.Size = new System.Drawing.Size(173, 27);
            this.ReportBeginDatePicker.TabIndex = 52;
            // 
            // ReportEndDatePicker
            // 
            this.ReportEndDatePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.ReportEndDatePicker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportEndDatePicker.Location = new System.Drawing.Point(537, 627);
            this.ReportEndDatePicker.Name = "ReportEndDatePicker";
            this.ReportEndDatePicker.Size = new System.Drawing.Size(173, 27);
            this.ReportEndDatePicker.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(175, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Begin Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(457, 631);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "End Date:";
            // 
            // Downloadbtn
            // 
            this.Downloadbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.Downloadbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Downloadbtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Downloadbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Downloadbtn.Image = ((System.Drawing.Image)(resources.GetObject("Downloadbtn.Image")));
            this.Downloadbtn.Location = new System.Drawing.Point(1156, 615);
            this.Downloadbtn.Name = "Downloadbtn";
            this.Downloadbtn.Size = new System.Drawing.Size(50, 50);
            this.Downloadbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Downloadbtn.TabIndex = 56;
            this.Downloadbtn.TabStop = false;
            this.Downloadbtn.Click += new System.EventHandler(this.Downloadbtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.PrintBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PrintBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrintBtn.Image")));
            this.PrintBtn.Location = new System.Drawing.Point(1225, 615);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(50, 50);
            this.PrintBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrintBtn.TabIndex = 57;
            this.PrintBtn.TabStop = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // RHeadingLbl
            // 
            this.RHeadingLbl.BackColor = System.Drawing.Color.Transparent;
            this.RHeadingLbl.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RHeadingLbl.ForeColor = System.Drawing.Color.Black;
            this.RHeadingLbl.Location = new System.Drawing.Point(270, 45);
            this.RHeadingLbl.Name = "RHeadingLbl";
            this.RHeadingLbl.Size = new System.Drawing.Size(731, 27);
            this.RHeadingLbl.TabIndex = 59;
            this.RHeadingLbl.Text = "Heading";
            this.RHeadingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeCbx
            // 
            this.TypeCbx.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCbx.FormattingEnabled = true;
            this.TypeCbx.Items.AddRange(new object[] {
            "Monthly Report",
            "Overall Summary",
            "No Pay Value",
            "Base Pay Value",
            "Gross Pay Value"});
            this.TypeCbx.Location = new System.Drawing.Point(779, 630);
            this.TypeCbx.Name = "TypeCbx";
            this.TypeCbx.Size = new System.Drawing.Size(173, 23);
            this.TypeCbx.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(730, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Type: ";
            // 
            // Report_Generation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1300, 669);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TypeCbx);
            this.Controls.Add(this.RHeadingLbl);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.Downloadbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReportEndDatePicker);
            this.Controls.Add(this.ReportBeginDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.REmpNoTbx);
            this.Controls.Add(this.LoadSalaryRecBtn);
            this.Controls.Add(this.MiniBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SalaryPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVReportGen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report_Generation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Generation";
            ((System.ComponentModel.ISupportInitialize)(this.DGVReportGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiniBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Downloadbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView DGVReportGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SalaryPic;
        private System.Windows.Forms.PictureBox MiniBtn;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.Button LoadSalaryRecBtn;
        private System.Windows.Forms.TextBox REmpNoTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ReportBeginDatePicker;
        private System.Windows.Forms.DateTimePicker ReportEndDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Downloadbtn;
        private System.Windows.Forms.PictureBox PrintBtn;
        private System.Windows.Forms.Label RHeadingLbl;
        private System.Windows.Forms.ComboBox TypeCbx;
        private System.Windows.Forms.Label label5;
    }
}