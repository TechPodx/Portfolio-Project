using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grifindo_Toys_PS
{
    public partial class Login : Form
    {
        static string sqlconnectionstring = "Server = RASI-WORK-STATI; Database = Grifindo Toys; Integrated Security = true;";
        SqlConnection sqlconnection = new SqlConnection(sqlconnectionstring);
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameLoginTbx.Text == "" || PasswordLoginTbx.Text == "")
            {
                MessageBox.Show("Please enter valid input");
            }
            else
            {
                try
                {
                    sqlconnection.Open();
                    string loginquery = "SELECT UserName, Password FROM Settings_Table WHERE UserName = @UsernameLoginTbx AND Password = @PasswordLoginTbx ";
                    SqlCommand command = new SqlCommand(loginquery, sqlconnection);
                    command.Parameters.AddWithValue("@UsernameLoginTbx", UsernameLoginTbx.Text);
                    command.Parameters.AddWithValue("@PasswordLoginTbx", PasswordLoginTbx.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    bool loginMatch = reader.Read();
                    if (loginMatch)
                    {
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is invalid");
                        sqlconnection.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsernameLoginTbx.Clear();
            PasswordLoginTbx.Clear();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
