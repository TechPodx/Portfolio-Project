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
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;

namespace Grifindo_Toys_PS
{
    public partial class Salary_Tracker : Form
    {
        static string sqlconnectionstring = "Server = RASI-WORK-STATI; Database = Grifindo Toys; Integrated Security = true;";
        SqlConnection sqlconnection = new SqlConnection(sqlconnectionstring);

        public Salary_Tracker()
        {
            InitializeComponent();       
        }

        private void ClearForm1()
        {
            SearchEmpTbx.Clear();
            EmpNoTbx.Clear();
            EmpNameTbx.Clear();
            BeginDatePicker.ResetText();
            EndDatePicker.ResetText();
            NoPayvalueTbx.Clear();
            NumLeavesTbx.Clear();
            AbsentDaysTbx.Clear();
            HolidaysTbx.Clear();
            OthrsTbx.Clear();
            BasePTbx.Clear();
            GrossPTbx.Clear();
        }

        private void ClearForm2()
        {
            EmpNoTbx.Clear();
            EmpNameTbx.Clear();
            BeginDatePicker.ResetText();
            EndDatePicker.ResetText();
            NoPayvalueTbx.Clear();
            NumLeavesTbx.Clear();
            AbsentDaysTbx.Clear();
            HolidaysTbx.Clear();
            OthrsTbx.Clear();
            BasePTbx.Clear();
            GrossPTbx.Clear();
        }

        private void ClearForm3()
        {
            
            NoPayvalueTbx.Clear();
            NumLeavesTbx.Clear();
            AbsentDaysTbx.Clear();
            HolidaysTbx.Clear();
            OthrsTbx.Clear();
            BasePTbx.Clear();
            GrossPTbx.Clear();
        }

        private void SearchEmployees()
        {
            if (SearchEmpTbx.Text == "")
            {
                MessageBox.Show("Please Enter Employee Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EmpNoTbx.Text != "" || EmpNameTbx.Text != "")
            {
                ClearForm2();
            }
            else
            {
                try
                {
                    sqlconnection.Open();
                    string searchQuery = "SELECT E.EmpNumber, E.EmpName, S.SalaryCycleBeginDate, S.SalaryCycleEndDate, S.NumLeaves, S.AbsentDays, S.Holidays, S.OT, S.NoPayValue, S.BasePay, S.GrossPay " +
                    "FROM Emp_Management_Table E " +
                    "LEFT JOIN Salary_Tracker_Data S ON E.EmpNumber = S.EmpNumber " +
                    "WHERE E.EmpNumber = @SearchEmpTbx";
                    SqlCommand command = new SqlCommand(searchQuery, sqlconnection);
                    command.Parameters.AddWithValue("@SearchEmpTbx", SearchEmpTbx.Text);
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        EmpNoTbx.Text = dataReader["EmpNumber"].ToString();
                        EmpNameTbx.Text = dataReader["EmpName"].ToString();                     
                        SearchEmpTbx.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Employee number is not available in database. Please register employee first.");
                        SearchEmpTbx.Clear();
                    }
                    sqlconnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AddEmpSalaryRecord()
        {
            if (EmpNoTbx.Text == "")
            {
                MessageBox.Show("Please enter the employee's number in the search bar.", "Information Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (EmpNoTbx.Text != "" && EmpNameTbx.Text != "" && (OthrsTbx.Text == "" || (BasePTbx.Text) == "" || GrossPTbx.Text == ""))
            {
                MessageBox.Show("Please fill mandatory fields", "Information Required", MessageBoxButtons.OK, MessageBoxIcon.Information);

                label11.Text = "No Pay Value*";
                label11.ForeColor = Color.Red;

                label12.Text = "Base Pay*";
                label12.ForeColor = Color.Red;

                label10.Text = "Gross Pay*";
                label10.ForeColor = Color.Red;
            }
            else 
            {
                try
                {
                    sqlconnection.Open();
                    string defaultDateQuery = "SELECT SalaryCycleBeginDate, SalaryCycleEndDate FROM Settings_Table  WHERE SalaryCycleBeginDate >= @BeginDatePicker AND SalaryCycleEndDate >= @EndDatePicker";
                    SqlCommand command = new SqlCommand(defaultDateQuery, sqlconnection);
                    command.Parameters.AddWithValue("@BeginDatePicker", BeginDatePicker.Value.Date);
                    command.Parameters.AddWithValue("@EndDatePicker", EndDatePicker.Value.Date);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        try
                        { 
                            reader.Close();
                            string checkquery = "SELECT EmpNumber, SalaryCycleBeginDate, SalaryCycleEndDate FROM Salary_Tracker_Data " +
                                "WHERE EmpNumber = @EmpNoTBX AND SalaryCycleBeginDate = @BeginDatePicker AND SalaryCycleEndDate = @EndDatePicker ";
                            SqlCommand command0 = new SqlCommand(checkquery, sqlconnection);
                            command0.Parameters.AddWithValue("@EmpNoTbx", EmpNoTbx.Text);
                            command0.Parameters.AddWithValue("@BeginDatePicker", BeginDatePicker.Value.Date);
                            command0.Parameters.AddWithValue("@EndDatePicker", EndDatePicker.Value.Date);
                            SqlDataReader reader0 = command0.ExecuteReader();
                            if (reader0.Read())
                            {
                                MessageBox.Show("Salary record already exists for this month. You cannot add a new record for the same month. " +
                                    "Instead, you can update salary records.", "Duplicate salary record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                UpdateBtn.BackColor = Color.DarkGray;
                                reader0.Close();
                            }
                            else
                            {
                                reader0.Close();
                                string check1query = "SELECT EmpNumber FROM Emp_Management_Table WHERE EmpNumber = @EmpNoTBX ";                                 
                                SqlCommand command1 = new SqlCommand(check1query, sqlconnection);
                                command1.Parameters.AddWithValue("@EmpNoTbx", EmpNoTbx.Text);
                                //command1.Parameters.AddWithValue("@BeginDatePicker", BeginDatePicker.Value.Date);
                                //command1.Parameters.AddWithValue("@EndDatePicker", EndDatePicker.Value.Date);
                                SqlDataReader reader1 = command1.ExecuteReader();
                                if (reader1.Read())
                                {
                                    reader1.Close();
                                    string addquery = "INSERT INTO Salary_Tracker_Data (EmpNumber, EmpName, SalaryCycleBeginDate, SalaryCycleEndDate, NumLeaves, AbsentDays, Holidays, OT, NoPayValue, BasePay, GrossPay)" +
                                        " VALUES ('" + EmpNoTbx.Text + "', '" + EmpNameTbx.Text + "', '" + BeginDatePicker.Value.Date.ToString("yyyy-MM-dd") + "', " +
                                        "'" + EndDatePicker.Value.Date.ToString("yyyy-MM-dd") + "', '" + NumLeavesTbx.Text + "', '" + AbsentDaysTbx.Text + "', '" + HolidaysTbx.Text + "', " +
                                        "'" + OthrsTbx.Text + "', '" + NoPayvalueTbx.Text + "', '" + BasePTbx.Text + "', '" + GrossPTbx.Text + "') ";
                                    SqlCommand command2 = new SqlCommand(addquery, sqlconnection);
                                    command2.ExecuteNonQuery();
                                    MessageBox.Show("Salary Record Added", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    reader1.Close();
                                    ClearForm1();
                                }
                                else
                                {
                                    MessageBox.Show("Employee does not exist. You cannot update the salary for a non-existing Employee. Please register the Employee first.",
                                        "Employee Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    reader1.Close();
                                    ClearForm1();

                                }
                                reader1.Close();
                            }
                            reader0.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }                       
                    }
                    else
                    {
                        MessageBox.Show("You can not select future dates that have not yet arrived", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    sqlconnection.Close();
                }   
            }           
        }

        private void UpdateEmployee()
        {
            if (EmpNoTbx.Text == "")
            {
                MessageBox.Show("Missing Employee Information", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    sqlconnection.Open();
                    string checkupdatequery = "SELECT * FROM Salary_Tracker_Data WHERE EmpNumber = @EmpNoTbx";
                    SqlCommand command = new SqlCommand(checkupdatequery, sqlconnection);
                    command.Parameters.AddWithValue("@EmpNoTbx", EmpNoTbx.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (EmpNameTbx.Text == reader["EmpName"].ToString() && BeginDatePicker.Value == Convert.ToDateTime(reader["SalaryCycleBeginDate"]) &&
                        EndDatePicker.Value == Convert.ToDateTime(reader["SalaryCycleEndDate"]) && NumLeavesTbx.Text == reader["NumLeaves"].ToString() && AbsentDaysTbx.Text == reader["AbsentDays"].ToString() &&
                        HolidaysTbx.Text == reader["Holidays"].ToString() && OthrsTbx.Text == reader["OT"].ToString() && NoPayvalueTbx.Text == reader["NoPayValue"].ToString() &&
                        BasePTbx.Text == reader["BasePay"].ToString() && GrossPTbx.Text == reader["GrossPay"].ToString())
                        {
                            MessageBox.Show("No changes were made to the employee salary records. Please make the necessary updates before clicking the update button.", 
                                "No Change Made", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (AbsentDaysTbx.Text != reader["AbsentDays"].ToString() || OthrsTbx.Text != reader["OT"].ToString())
                            {
                                button4.ForeColor = Color.Red;
                                button2.ForeColor = Color.Red;
                                button3.ForeColor = Color.Red;
                                sqlconnection.Close();

                                if (CalNoPayBtnClick == true && CalBasePayBtnClick == true && CalGrossPayBtnClick == true)
                                {

                                    try//try catch block
                                    {
                                        sqlconnection.Open();
                                        string insertValues = "UPDATE Salary_Tracker_Data SET EmpName = @EmpNameTbx, NumLeaves = @NumLeavesTbx," +
                                            "AbsentDays = @AbsentDaysTbx, Holidays = @HolidaysTbx, OT = @OthrsTbx, NoPayValue = @NoPayvalueTbx, BasePay = @BasePTbx," +
                                            "GrossPay = @GrossPTbx WHERE EmpNumber = @EmpNoTBX";
                                        SqlCommand command1 = new SqlCommand(insertValues, sqlconnection); //sql command
                                        command1.Parameters.AddWithValue("@EmpNoTbx", EmpNoTbx.Text);
                                        command1.Parameters.AddWithValue("@EmpNameTbx", EmpNameTbx.Text);
                                        command1.Parameters.AddWithValue("@NumLeavesTbx", NumLeavesTbx.Text);
                                        command1.Parameters.AddWithValue("@AbsentDaysTbx", AbsentDaysTbx.Text);
                                        command1.Parameters.AddWithValue("@HolidaysTbx", HolidaysTbx.Text);
                                        command1.Parameters.AddWithValue("@OthrsTbx", OthrsTbx.Text);
                                        command1.Parameters.AddWithValue("@NoPayvalueTbx", NoPayvalueTbx.Text);
                                        command1.Parameters.AddWithValue("@BasePTbx", BasePTbx.Text);
                                        command1.Parameters.AddWithValue("@GrossPTbx", GrossPTbx.Text);
                                        command1.ExecuteNonQuery();//Executing insert command
                                        sqlconnection.Close();

                                        ClearForm1();//Once after updating employee records, form will be cleared
                                        MessageBox.Show("Salary Record Updated", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        
                                        button4.ForeColor = Color.Black;
                                        button2.ForeColor = Color.Black;
                                        button3.ForeColor = Color.Black;

                                        CalNoPayBtnClick = false;
                                        CalBasePayBtnClick = false;
                                        CalGrossPayBtnClick = false;
                                    }
                                    catch (Exception ex) //Closing catch block
                                    {
                                        MessageBox.Show("An error occurred: " + ex.Message); //If there is an exception, this msg will appear
                                    }
                                    finally
                                    {
                                        sqlconnection.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please click \"all three Calculate buttons\" before updating the data");
                                }

                            }
                            else
                            {
                                reader.Close();
                                sqlconnection.Close();

                                try//try catch block
                                {
                                    sqlconnection.Open();
                                    string insertValues = "UPDATE Salary_Tracker_Data SET EmpName = @EmpNameTbx, NumLeaves = @NumLeavesTbx," +
                                        "AbsentDays = @AbsentDaysTbx, Holidays = @HolidaysTbx, OT = @OthrsTbx, NoPayValue = @NoPayvalueTbx, BasePay = @BasePTbx," +
                                        "GrossPay = @GrossPTbx WHERE EmpNumber = @EmpNoTBX";
                                    SqlCommand command1 = new SqlCommand(insertValues, sqlconnection); //sql command
                                    command1.Parameters.AddWithValue("@EmpNoTbx", EmpNoTbx.Text);
                                    command1.Parameters.AddWithValue("@EmpNameTbx", EmpNameTbx.Text);
                                    command1.Parameters.AddWithValue("@NumLeavesTbx", NumLeavesTbx.Text);
                                    command1.Parameters.AddWithValue("@AbsentDaysTbx", AbsentDaysTbx.Text);
                                    command1.Parameters.AddWithValue("@HolidaysTbx", HolidaysTbx.Text);
                                    command1.Parameters.AddWithValue("@OthrsTbx", OthrsTbx.Text);
                                    command1.Parameters.AddWithValue("@NoPayvalueTbx", NoPayvalueTbx.Text);
                                    command1.Parameters.AddWithValue("@BasePTbx", BasePTbx.Text);
                                    command1.Parameters.AddWithValue("@GrossPTbx", GrossPTbx.Text);
                                    command1.ExecuteNonQuery();//Executing insert command

                                    MessageBox.Show("Salary Record Updated", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ClearForm1();//Once after updating employee records, form will be cleared
                                }
                                catch (Exception ex) //Closing catch block
                                {
                                    MessageBox.Show("An error occurred: " + ex.Message); //If there is an exception, this msg will appear
                                }
                                finally
                                {
                                    sqlconnection.Close();
                                }
                            }

                        }
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Employee Not Found. Please add employee first");
                        ClearForm1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    sqlconnection.Close();
                }
            }
        }

        private void LoadEmp()
        {
            try
            {
                sqlconnection.Open();
                string loadQuery = "SELECT NumLeaves, AbsentDays, Holidays, OT, NoPayValue, BasePay, GrossPay FROM Salary_Tracker_Data " +
                    "WHERE EmpNumber = @EmpNoTbx AND SalaryCycleBeginDate = @BeginDatePicker AND SalaryCycleEndDate = @EndDatePicker ";
                SqlCommand command = new SqlCommand(loadQuery, sqlconnection);
                command.Parameters.AddWithValue("@EmpNoTbx", EmpNoTbx.Text);
                command.Parameters.AddWithValue("@BeginDatePicker", BeginDatePicker.Value.Date);
                command.Parameters.AddWithValue("@EndDatePicker", EndDatePicker.Value.Date);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    NumLeavesTbx.Text = reader["NumLeaves"].ToString();
                    AbsentDaysTbx.Text = reader["AbsentDays"].ToString();
                    HolidaysTbx.Text = reader["Holidays"].ToString();
                    OthrsTbx.Text = reader["OT"].ToString();
                    NoPayvalueTbx.Text = reader["NoPayValue"].ToString();
                    BasePTbx.Text = reader["BasePay"].ToString();
                    GrossPTbx.Text = reader["GrossPay"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found. Please add new record");
                    ClearForm3();
                }
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DeleteSalaryRec()
        {
            if (EmpNoTbx.Text == "" || EmpNameTbx.Text == "")
            {
                MessageBox.Show("Missing Employee Information. Please load the employee details first before delete", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if ((EmpNoTbx.Text) != (""))
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this record? This action cannot be undone.",
                            "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            using (var Reason_and_Date_of_Deletion = new Reason_and_Date_of_Deletion())
                            {
                                if (Reason_and_Date_of_Deletion.ShowDialog() == DialogResult.OK)
                                {

                                    string reason = Reason_and_Date_of_Deletion.ReasonForDelTBX.Text;
                                    DateTime deletionDate = Reason_and_Date_of_Deletion.DatePick.Value;

                                    sqlconnection.Open();
                                    string deleteQuery = "DELETE FROM Salary_Tracker_Data WHERE EmpNumber = @EmpNoTbx AND SalaryCycleBeginDate = @BeginDatePicker AND SalaryCycleEndDate = @EndDatePicker ";
                                    SqlCommand command = new SqlCommand(deleteQuery, sqlconnection);
                                    command.Parameters.AddWithValue("@EmpNoTbx", EmpNoTbx.Text);
                                    command.Parameters.AddWithValue("@BeginDatePicker", BeginDatePicker.Value.Date);
                                    command.Parameters.AddWithValue("@EndDatePicker", EndDatePicker.Value.Date);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Salary record deleted successfully", "Deleted Employee", MessageBoxButtons.OK);
                                    sqlconnection.Close();

                                    sqlconnection.Open();
                                    string insertQuery = "INSERT INTO Deleted_Salary_Records (EmpNumber, EmpName, SalaryCycleBeginDate, SalaryCycleEndDate, NumLeaves, AbsentDays, Holidays, OT, NoPayValue, " +
                                        "BasePay, GrossPay, ReasonforDeletion, DateofDeletion)" +
                                        "VALUES ('" + EmpNoTbx.Text + "', '" + EmpNameTbx.Text + "', '" + BeginDatePicker.Value.Date.ToString("yyyy-MM-dd") + "', '" + EndDatePicker.Value.Date.ToString("yyyy-MM-dd") + "'," +
                                        "'" + NumLeavesTbx.Text + "', '" + AbsentDaysTbx.Text + "', '" + HolidaysTbx.Text + "', '" + OthrsTbx.Text + "', '" + NoPayvalueTbx.Text + "', " +
                                        "'" + BasePTbx.Text + "', '" + GrossPTbx.Text + "', '" + reason + "', '" + deletionDate.ToString("yyyy-MM-dd") + "')";
                                    SqlCommand command1 = new SqlCommand(insertQuery, sqlconnection);
                                    command1.ExecuteNonQuery();
                                    MessageBox.Show("Deleted Records added Successfully", "Deleted Employee", MessageBoxButtons.OK);
                                    ClearForm1();
                                    sqlconnection.Close();
                                }
                            }
                        }
                        else
                        {
                            this.ClearForm1();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee Not Found");
                    }
                }
                catch (Exception ex) //Closing catch block
                {
                    MessageBox.Show("An error occurred: " + ex.Message); //If there is an exception, this msg will appear
                }
            }
        }

        private void ViewSalaryRec()
        {
            sqlconnection.Open();
            string viewQuery = "SELECT * FROM Salary_Tracker_Data";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(viewQuery, sqlconnection);
            //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            SalaryEmpDGV.DataSource = dataset.Tables[0];
            sqlconnection.Close();
        }

        private void CalNoPay()
        {
            try
            {
                sqlconnection.Open();
                String getInfoQuery = "SELECT E.MonSalary, E.[OtRate(hr)], E.Allowance, ST.NumDaysForSalCycle " +
                    "FROM Emp_Management_Table E " +
                    "CROSS JOIN Settings_Table ST ";

                SqlCommand command = new SqlCommand(getInfoQuery, sqlconnection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    decimal monSalary = Convert.ToDecimal(reader["MonSalary"]);
                    decimal otRate = Convert.ToDecimal(reader["OtRate(hr)"]);
                    decimal allowance = Convert.ToDecimal(reader["Allowance"]);
                    decimal salCycleDateRange = Convert.ToDecimal(reader["NumDaysForSalCycle"]);

                    decimal otHours = Convert.ToDecimal(OthrsTbx.Text);
                    decimal absentDays = Convert.ToDecimal(AbsentDaysTbx.Text);

                    //Calculate the Total Salary
                    decimal totalSalary = monSalary + (otRate * otHours) + allowance;

                    //Calculate the Nopay
                    decimal noPayValue = (totalSalary / salCycleDateRange) * absentDays;

                    NoPayvalueTbx.Text = noPayValue.ToString("0.00");
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Information not found");
                }
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void CalBasePay()
        {
            try
            {
                sqlconnection.Open();
                String getInfoQuery = "SELECT MonSalary, [OtRate(hr)], Allowance FROM Emp_Management_Table";
                SqlCommand command = new SqlCommand(getInfoQuery, sqlconnection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    decimal monSalary = Convert.ToDecimal(reader["MonSalary"]);
                    decimal otRate = Convert.ToDecimal(reader["OtRate(hr)"]);
                    decimal allowance = Convert.ToDecimal(reader["Allowance"]);
                    decimal otHours = Convert.ToDecimal(OthrsTbx.Text);

                    //Calculate the BasePay
                    decimal basePay = monSalary + allowance + (otRate * otHours);

                    BasePTbx.Text = basePay.ToString("0.00");
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Information not found");
                }
                sqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    
        private void CalGrossPay()
        {
            decimal percentage = 10;

            decimal basePay = Convert.ToDecimal(BasePTbx.Text);
            decimal noPayValue = Convert.ToDecimal(NoPayvalueTbx.Text);
            decimal grossPay = basePay - (noPayValue + (basePay * (percentage / 100)));

            GrossPTbx.Text = grossPay.ToString("0.00");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalaryPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEmpSalaryRecord();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateEmployee();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSalaryRec();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm1();
        }

        private void LoadSalaryRecBtn_Click(object sender, EventArgs e)
        {
            ViewSalaryRec();
        }

        private bool CalNoPayBtnClick = false;
        private void button4_Click(object sender, EventArgs e)
        {
            CalNoPay();
            CalNoPayBtnClick = true;

        }

        private bool CalBasePayBtnClick = false;
        private void button2_Click(object sender, EventArgs e)
        {
            CalBasePay();
            CalBasePayBtnClick = true;
        }

        private bool CalGrossPayBtnClick = false;
        private void button3_Click(object sender, EventArgs e)
        {
            CalGrossPay();
            CalGrossPayBtnClick = true;
        }

        private void GenReportBtn_Click(object sender, EventArgs e)
        {
            Report_Generation report_generation = new Report_Generation();
            report_generation.Show();
        }

        private void BeginDatePicker_Leave(object sender, EventArgs e)
        {
            if (EmpNoTbx.Text != "" && EmpNameTbx.Text != "")
            {
                if (BeginDatePicker.Value.Day != 1)
                {
                    MessageBox.Show("You have picked an incorrect begin date. Please make sure to select the Salary Cycle begin date as the \"1st of every month\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BeginDatePicker.Value = new DateTime(BeginDatePicker.Value.Year, BeginDatePicker.Value.Month, 1);
                }
            }
            else
            {
                MessageBox.Show("Please load employee record first");
            }
               
        }

        private void EndDatePicker_Leave(object sender, EventArgs e)
        {
            if (EmpNoTbx.Text != "" && EmpNameTbx.Text != "")
            {
                if (BeginDatePicker.Value.Day == 1)
                {
                    if (EndDatePicker.Value.Day == 28)
                    {
                        LoadEmp();
                    }
                    else
                    {
                        MessageBox.Show("You have picked an incorrect end date. Please make sure to select the Salary Cycle end date as the \"28th of every month\".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EndDatePicker.Value = new DateTime(EndDatePicker.Value.Year, EndDatePicker.Value.Month, 28);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please load employee record first");
            }

        }

        
    }
}
