using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Grifindo_Toys_PS
{
    public partial class Main : Form
    {
         
        public Main()
        {
            InitializeComponent();
        }

        private void emp_manage_btn_Click(object sender, EventArgs e)
        {
            //creating a new form for employee management
            Employee_Management employee_Management = new Employee_Management();
            employee_Management.Show();
        }

        private void EmpPic_Click(object sender, EventArgs e)
        {
            Employee_Management employee_Management = new Employee_Management();
            employee_Management.Show();
        }

        private void salary_btn_Click(object sender, EventArgs e)
        {
            //creating a new form for salary tracker form
            Salary_Tracker salary_tracker = new Salary_Tracker();
            salary_tracker.Show();
        }

        private void SalaryPic_Click_1(object sender, EventArgs e)
        {
            Salary_Tracker salary_tracker = new Salary_Tracker();
            salary_tracker.Show();
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            //creating a new form for Configuration Settings form
            Configuration_Settings configuration_settings = new Configuration_Settings();
            configuration_settings.Show();
        }

        private void SettingsPic_Click_1(object sender, EventArgs e)
        {
            Configuration_Settings configuration_settings = new Configuration_Settings();
            configuration_settings.Show();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            //Add web link URL
            string url = "https://www.forbes.com/advisor/business/payroll-management/";
            Process.Start(url);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            /*Creating exit fuction*/
            //Creating a confrimation box
            DialogResult result = MessageBox.Show("Are you sure you want to Logout ?", "Confirm to Logout" ,
                MessageBoxButtons.YesNo , MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        
    }
}
