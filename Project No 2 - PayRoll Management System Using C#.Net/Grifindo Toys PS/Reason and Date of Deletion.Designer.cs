namespace Grifindo_Toys_PS
{
    partial class Reason_and_Date_of_Deletion
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
            this.ReasonForDelTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatePick = new System.Windows.Forms.DateTimePicker();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReasonForDelTBX
            // 
            this.ReasonForDelTBX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonForDelTBX.Location = new System.Drawing.Point(171, 26);
            this.ReasonForDelTBX.Multiline = true;
            this.ReasonForDelTBX.Name = "ReasonForDelTBX";
            this.ReasonForDelTBX.Size = new System.Drawing.Size(163, 73);
            this.ReasonForDelTBX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Reason for Deletion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date of Deletion";
            // 
            // DatePick
            // 
            this.DatePick.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePick.Location = new System.Drawing.Point(171, 115);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(163, 27);
            this.DatePick.TabIndex = 2;
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.OkBtn.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Location = new System.Drawing.Point(125, 171);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(95, 32);
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // Reason_and_Date_of_Deletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(343, 218);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.DatePick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReasonForDelTBX);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reason_and_Date_of_Deletion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reason and Date of Deletion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OkBtn;
        public System.Windows.Forms.TextBox ReasonForDelTBX;
        public System.Windows.Forms.DateTimePicker DatePick;
    }
}