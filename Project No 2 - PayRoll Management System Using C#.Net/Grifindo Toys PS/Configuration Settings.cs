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
    public partial class Configuration_Settings : Form
    {
        static string connectionstring = "Server = RASI-WORK-STATI; Database = Grifindo Toys; Integrated Security = true";
        SqlConnection connection = new SqlConnection(connectionstring);

        public Configuration_Settings()
        {
            InitializeComponent();
        }

        private void Savesettings()
        {
            try
            {
                connection.Open();
                if (UserNameTbx.Text == "" && PasswordTbx.Text == "")
                {
                    string savequery = "UPDATE Settings_Table SET NumDaysForSalCycle = @NumDaysTbx, SalaryCycleBeginDate = @SalaryCyBeginDatePick, SalaryCycleEndDate = @SalaryCyEndDatePick " +
                        "EligibleLeavesPerYear = @MaxLeavesTbx ";
                    SqlCommand command = new SqlCommand(savequery, connection);

                    command.Parameters.AddWithValue("@NumDaysTbx", NumDaysTbx.Text);
                    command.Parameters.AddWithValue("@SalaryCyBeginDatePick", SalaryCyBeginDatePick.Text);
                    command.Parameters.AddWithValue("@SalaryCyEndDatePick", SalaryCyEndDatePick.Text);
                    command.Parameters.AddWithValue("@MaxLeavesTbx", MaxLeavesTbx.Text);

                    command.ExecuteNonQuery();//Executing insert command
                    MessageBox.Show("Record Updated Successfully", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (UserNameTbx.Text != "" && PasswordTbx.Text == "")
                {
                    string changepwquery = "SELECT UserName FROM Settings_Table WHERE UserName = @UserNameTbx ";
                    SqlCommand command1 = new SqlCommand(changepwquery, connection);
                    command1.Parameters.AddWithValue("@UserNameTbx", UserNameTbx.Text);
                    SqlDataReader reader = command1.ExecuteReader();
                    bool userNameIsAvailable = reader.Read();
                    if (userNameIsAvailable) 
                    {
                        MessageBox.Show("Please choose a different username if you wish to make changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        reader.Close();
                        DialogResult answer1 = MessageBox.Show("2Are you sure you want to change the username? This action is irreversible and will require you to use the new username for future logins. " +
                            "Please confirm your decision before proceeding."
                        , "Alart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer1 == DialogResult.Yes)
                        {
                            string savequery = "UPDATE Settings_Table SET NumDaysForSalCycle = @NumDaysTbx, SalaryCycleBeginDate = @SalaryCyBeginDatePick, SalaryCycleEndDate = @SalaryCyEndDatePick " +
                                "EligibleLeavesPerYear = @MaxLeavesTbx, UserName = @UserNameTbx "; 
                            SqlCommand command = new SqlCommand(savequery, connection);

                            command.Parameters.AddWithValue("@NumDaysTbx", NumDaysTbx.Text);
                            command.Parameters.AddWithValue("@SalaryCyBeginDatePick", SalaryCyBeginDatePick.Text);
                            command.Parameters.AddWithValue("@SalaryCyEndDatePick", SalaryCyEndDatePick.Text);
                            command.Parameters.AddWithValue("@MaxLeavesTbx", MaxLeavesTbx.Text);
                            command.Parameters.AddWithValue("@UserNameTbx", UserNameTbx.Text);

                            command.ExecuteNonQuery();//Executing insert command
                            MessageBox.Show("Record Updated Successfully! Your logins have also been updated accordingly.", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserNameTbx.Clear();
                        }
                        else
                        {

                        }
                    }
                    reader.Close();
                }

                else if (UserNameTbx.Text == "" && PasswordTbx.Text != "")
                {
                    string changepwquery = "SELECT Password FROM Settings_Table WHERE Password = @PasswordTbx";
                    SqlCommand command1 = new SqlCommand(changepwquery, connection);
                    command1.Parameters.AddWithValue("@PasswordTbx", PasswordTbx.Text);
                    SqlDataReader reader = command1.ExecuteReader();
                    bool PasswordIsAvailable = reader.Read();
                    if (PasswordIsAvailable)
                    {
                        MessageBox.Show("Please choose a different password if you wish to make changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        DialogResult answer1 = MessageBox.Show("1Are you sure you want to change the Password? This action is irreversible and will require you to use the new Password for future logins. " +
                            "Please confirm your decision before proceeding."
                        , "Alart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer1 == DialogResult.Yes)
                        {
                            string savequery = "UPDATE Settings_Table SET NumDaysForSalCycle = @NumDaysTbx, SalaryCycleBeginDate = @SalaryCyBeginDatePick, SalaryCycleEndDate = @SalaryCyEndDatePick " +
                                "EligibleLeavesPerYear = @MaxLeavesTbx, Password = @PasswordTbx "; 
                                
                            SqlCommand command = new SqlCommand(savequery, connection);

                            command.Parameters.AddWithValue("@NumDaysTbx", NumDaysTbx.Text);
                            command.Parameters.AddWithValue("@SalaryCyBeginDatePick", SalaryCyBeginDatePick.Text);
                            command.Parameters.AddWithValue("@SalaryCyEndDatePick", SalaryCyEndDatePick.Text);
                            command.Parameters.AddWithValue("@MaxLeavesTbx", MaxLeavesTbx.Text);
                            command.Parameters.AddWithValue("@PasswordTbx", PasswordTbx.Text);

                            command.ExecuteNonQuery();//Executing insert command
                            MessageBox.Show("Record Updated Successfully! Your logins have also been updated accordingly.", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PasswordTbx.Clear();
                        }
                        else
                        {

                        }
                    }
                    reader.Close();
                }
                else if (UserNameTbx.Text != "" || PasswordTbx.Text != "")
                {
                    string changepwquery = "SELECT UserName, Password FROM Settings_Table WHERE Username = @UserNameTbx AND Password = @PasswordTbx";
                    SqlCommand command1 = new SqlCommand(changepwquery, connection);
                    command1.Parameters.AddWithValue("@UserNameTbx", UserNameTbx.Text);
                    command1.Parameters.AddWithValue("@PasswordTbx", PasswordTbx.Text);
                    SqlDataReader reader = command1.ExecuteReader();
                    bool userNameAndpassWordAreAvailable = reader.Read();
                    if (userNameAndpassWordAreAvailable)
                    {
                        MessageBox.Show("Please choose a different username & password if you wish to make changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        DialogResult answer1 = MessageBox.Show("Are you sure you want to change the username & Password? This action is irreversible and will require you to use the new user name & password for future logins. " +
                            "Please confirm your decision before proceeding."
                        , "Alart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer1 == DialogResult.Yes)
                        {
                            string savequery = "UPDATE Settings_Table SET NumDaysForSalCycle = @NumDaysTbx, SalaryCycleBeginDate = @SalaryCyBeginDatePick, SalaryCycleEndDate = @SalaryCyEndDatePick " +
                                "EligibleLeavesPerYear = @MaxLeavesTbx, UserName = @UserNameTbx, Password = @PasswordTbx ";
                               
                            SqlCommand command = new SqlCommand(savequery, connection);

                            command.Parameters.AddWithValue("@NumDaysTbx", NumDaysTbx.Text);
                            command.Parameters.AddWithValue("@SalaryCyBeginDatePick", SalaryCyBeginDatePick.Text);
                            command.Parameters.AddWithValue("@SalaryCyEndDatePick", SalaryCyEndDatePick.Text);
                            command.Parameters.AddWithValue("@MaxLeavesTbx", MaxLeavesTbx.Text);
                            command.Parameters.AddWithValue("@UserNameTbx", UserNameTbx.Text);
                            command.Parameters.AddWithValue("@PasswordTbx", PasswordTbx.Text);

                            command.ExecuteNonQuery();//Executing insert command
                            MessageBox.Show("Record Updated Successfully! Your logins have also been updated accordingly.", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserNameTbx.Clear();
                            PasswordTbx.Clear();
                        }
                        else
                        {

                        }
                    }
                    reader.Close();       
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally 
            {
                connection.Close();
            }
        }

        private void NumOfDays()
        {
            //Getting current Month
            DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;

            //Getting Num of days in current month
            int numDays = DateTime.DaysInMonth(currentDate.Year, currentMonth);

            //Store in texbox
            NumDaysTbx.Text = numDays.ToString();
        }
        private void DateSet()
        {
            SalaryCyBeginDatePick.CustomFormat = "dd MMMM yyyy";
            SalaryCyBeginDatePick.Format = DateTimePickerFormat.Custom;
            SalaryCyBeginDatePick.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);

            SalaryCyEndDatePick.CustomFormat = "dd MMMM yyyy";
            SalaryCyEndDatePick.Format = DateTimePickerFormat.Custom;
            SalaryCyEndDatePick.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 28);
        }

        private void Configuration_Settings_Load(object sender, EventArgs e)
        {
            NumOfDays();
            DateSet();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmpPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Savesettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
