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
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Runtime.Remoting.Messaging;

namespace Grifindo_Toys_PS
{
    public partial class Employee_Management : Form
    {
        static string connectionstring = "Server = RASI-WORK-STATI; Database = Grifindo Toys; Integrated Security = true";
        SqlConnection connection = new SqlConnection(connectionstring);

        
        public Employee_Management()
        {
            InitializeComponent();
        }

        private void EmpDetailsClear() //Form clear method added
        {
            SearchEmpNoBar.Clear();
            EmpNoTBX.Clear();
            EmpNameTXB.Clear();
            dob.ResetText();
            Gender.ResetText();
            EmpTypeTBX.ResetText();
            IdNoTbx.Clear();
            PositionTBX.Clear();
            EduTbx.Clear();
            SalaryTbx.Clear();
            OtTbx.Clear();
            AllowanceTbx.Clear();

        }

        private void AddEmployee()
        {
            if (EmpNoTBX.Text == "" || EmpNameTXB.Text == "")
            {
                MessageBox.Show("Missing Employee Information", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    connection.Open();
                    string EmpNoQuery = "SELECT * FROM Emp_Management_Table WHERE EmpNumber = @EmpNoTBX";
                    SqlCommand command = new SqlCommand(EmpNoQuery, connection);
                    command.Parameters.AddWithValue("@EmpNoTBX", EmpNoTBX.Text);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Employee Number already exists in the database.", "Duplicate Employee Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try//try catch block
                        {
                            connection.Open();//Open conncetion
                            string insertValues = "INSERT INTO Emp_Management_Table VALUES (@EmpNumber, @EmpName, @DOB, @Gender, @EmpType, @IdNumber, @Position," +
                                "@HighestEduQualification, @MonSalary, @OtRate, @Allowance)";
                            SqlCommand command1 = new SqlCommand(insertValues, connection);
                            command1.Parameters.AddWithValue("@EmpNumber", EmpNoTBX.Text);
                            command1.Parameters.AddWithValue("@EmpName", EmpNameTXB.Text);
                            command1.Parameters.AddWithValue("@DOB", dob.Value);
                            command1.Parameters.AddWithValue("@Gender", Gender.Text);
                            command1.Parameters.AddWithValue("@EmpType", EmpTypeTBX.Text);
                            command1.Parameters.AddWithValue("@IdNumber", IdNoTbx.Text);
                            command1.Parameters.AddWithValue("@Position", PositionTBX.Text);
                            command1.Parameters.AddWithValue("@HighestEduQualification", EduTbx.Text);
                            command1.Parameters.AddWithValue("@MonSalary", SalaryTbx.Text);
                            command1.Parameters.AddWithValue("@OtRate", OtTbx.Text);
                            command1.Parameters.AddWithValue("@Allowance", AllowanceTbx.Text);

                            command1.ExecuteNonQuery();//Executing insert command
                            MessageBox.Show("New Record Added", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EmpDetailsClear();//Once after adding employee records, form will be cleared
                            connection.Close();
                        }
                        catch (Exception ex) //Closing catch block
                        {
                            MessageBox.Show("An error occurred: " + ex.Message); //If there is an exception, this msg will appear
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }   
        }

        private void UpdateEmployeeRec()
        {
            if(EmpNoTBX.Text == "" || EmpNameTXB.Text == "")
            {
                MessageBox.Show("Missing Employee Information", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection.Open();
                    string updatequery = "SELECT * FROM Emp_Management_Table WHERE EmpNumber = @EmpNoTBX";
                    SqlCommand command = new SqlCommand(updatequery, connection);
                    command.Parameters.AddWithValue("@EmpNoTBX", EmpNoTBX.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (EmpNameTXB.Text == reader["EmpName"].ToString() && dob.Value == Convert.ToDateTime(reader["DOB"]) && Gender.Text == reader["Gender"].ToString() && EmpTypeTBX.Text == reader["EmpType"].ToString() &&
                            IdNoTbx.Text == reader["IdNumber"].ToString() && PositionTBX.Text == reader["Position"].ToString() && EduTbx.Text == reader["HighestEduQualification"].ToString() &&
                            SalaryTbx.Text == reader["MonSalary"].ToString() && OtTbx.Text == reader["OtRate(hr)"].ToString() && AllowanceTbx.Text == reader["Allowance"].ToString())
                        { 
                            reader.Close();
                            MessageBox.Show("No changes were made to the employee information. Please update employee information", "No Information Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            reader.Close();
                            connection.Close();

                            try//try catch block
                            {
                                connection.Open();
                                string insertValues = "UPDATE Emp_Management_Table SET EmpName = @EmpName, dob = @DOB, Gender = @Gender, EmpType = @EmpType," +
                                    "IdNumber = @IdNumber, Position = @Position, HighestEduQualification = @HighestEduQualification, MonSalary = @MonSalary, [OtRate(hr)] = @OtRate," +
                                    "Allowance = @Allowance WHERE EmpNumber = @EmpNoTBX";
                                SqlCommand command1 = new SqlCommand(insertValues, connection); //sql command
                                command1.Parameters.AddWithValue("@EmpNoTBX", EmpNoTBX.Text);
                                command1.Parameters.AddWithValue("@EmpName", EmpNameTXB.Text);
                                command1.Parameters.AddWithValue("@DOB", dob.Value);
                                command1.Parameters.AddWithValue("@Gender", Gender.Text);
                                command1.Parameters.AddWithValue("@EmpType", EmpTypeTBX.Text);
                                command1.Parameters.AddWithValue("@IdNumber", IdNoTbx.Text);
                                command1.Parameters.AddWithValue("@Position", PositionTBX.Text);
                                command1.Parameters.AddWithValue("@HighestEduQualification", EduTbx.Text);
                                command1.Parameters.AddWithValue("@MonSalary", SalaryTbx.Text);
                                command1.Parameters.AddWithValue("@OtRate", OtTbx.Text);
                                command1.Parameters.AddWithValue("@Allowance", AllowanceTbx.Text);
                                command1.ExecuteNonQuery();//Executing insert command

                                MessageBox.Show("New Record Updated", "Database Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                EmpDetailsClear();//Once after updating employee records, form will be cleared
                            }
                            catch (Exception ex) //Closing catch block
                            {
                                MessageBox.Show("An error occurred: " + ex.Message); //If there is an exception, this msg will appear
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Employee Not Found");
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
        }

        private void SearchEmployees()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Emp_Management_Table WHERE EmpNumber = @SearchEmpNoBar", connection);
                command.Parameters.AddWithValue("@SearchEmpNoBar", SearchEmpNoBar.Text);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    EmpNoTBX.Text = dataReader[0].ToString();
                    EmpNameTXB.Text = dataReader[1].ToString();
                    dob.Text = dataReader[2].ToString();
                    Gender.Text = dataReader[3].ToString();
                    EmpTypeTBX.Text = dataReader[4].ToString();
                    IdNoTbx.Text = dataReader[5].ToString();    
                    PositionTBX.Text = dataReader[6].ToString();
                    EduTbx.Text = dataReader[7].ToString();
                    SalaryTbx.Text = dataReader[8].ToString();
                    OtTbx.Text = dataReader[9].ToString();
                    AllowanceTbx.Text = dataReader[10].ToString();
                }
                else
                {
                    MessageBox.Show("Employee Not Found");
                    SearchEmpNoBar.Clear();
                }
                connection.Close();
            }
            catch (Exception ex) //Closing catch block
            {
                MessageBox.Show("An error occurred: " + ex.Message); //If there is an exception, this msg will appear
            }
        }

        private void DeleteEmployees()
        {
            if (EmpNoTBX.Text == "" || EmpNameTXB.Text == "")
            {
                MessageBox.Show("Missing Employee Information. Please load the employee details first that you want to delete", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if ((EmpNoTBX.Text) != (""))
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this item? This action cannot be undone.",
                            "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            using (var Reason_and_Date_of_Deletion = new Reason_and_Date_of_Deletion())
                            {
                                if (Reason_and_Date_of_Deletion.ShowDialog() == DialogResult.OK)
                                {

                                    string reason = Reason_and_Date_of_Deletion.ReasonForDelTBX.Text;
                                    DateTime deletionDate = Reason_and_Date_of_Deletion.DatePick.Value;

                                    connection.Open();
                                    string deleteQuery = "DELETE FROM Emp_Management_Table WHERE EmpNumber = '" + EmpNoTBX.Text + "'; ";
                                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Employee Deleted Successfully", "Deleted Employee", MessageBoxButtons.OK);
                                    connection.Close();

                                    connection.Open();
                                    string insertQuery = "INSERT INTO Deleted_Employees_Details (EmpNumber, EmpName, DOB, Gender, EmpType, IdNumber, Position, DateofResignation, Reason)" +
                                        "VALUES ('" + EmpNoTBX.Text + "', '" + EmpNameTXB.Text + "', '" + dob.Value.Date.ToString("yyyy-MM-dd") + "', '" + Gender.SelectedItem.ToString() + "'," +
                                        "'" + EmpTypeTBX.SelectedItem.ToString() + "', '" + IdNoTbx.Text + "', '" + PositionTBX.Text + "', '" + deletionDate.ToString("yyyy-MM-dd") + "', '" + reason + "')";
                                    SqlCommand command1 = new SqlCommand(insertQuery, connection);
                                    command1.ExecuteNonQuery();
                                    MessageBox.Show("Deleted Records added Successfully", "Deleted Employee", MessageBoxButtons.OK);
                                    EmpDetailsClear();
                                    connection.Close();
                                }
                            }
                        }
                        else
                        {
                            this.EmpDetailsClear();
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

        private void ViewCurrentEmployeeRec()
        {
            connection.Open();
            string viewQuery = "SELECT * FROM Emp_Management_Table";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(viewQuery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            EmpDGV.DataSource = dataset.Tables[0];
            connection.Close();
        }

        private void ViewPastEmployeeRec()
        {
            connection.Open(); 
            string viewQuery = "SELECT * FROM Deleted_Employees_Details";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(viewQuery, connection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var dataset = new DataSet();
            dataAdapter.Fill(dataset);
            EmpDGV.DataSource = dataset.Tables[0];
            connection.Close();
        }

        private void ViewFromDataGrid()
        {
            if (EmpDGV.Columns.Count == 11)
            {
                EmpNoTBX.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
                EmpNameTXB.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
                dob.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
                Gender.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
                EmpTypeTBX.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
                IdNoTbx.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
                PositionTBX.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();
                EduTbx.Text = EmpDGV.SelectedRows[0].Cells[7].Value.ToString();
                SalaryTbx.Text = EmpDGV.SelectedRows[0].Cells[8].Value.ToString();
                OtTbx.Text = EmpDGV.SelectedRows[0].Cells[9].Value.ToString();
                AllowanceTbx.Text = EmpDGV.SelectedRows[0].Cells[10].Value.ToString();

            }
            else
            {
                EmpNoTBX.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
                EmpNameTXB.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
                dob.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
                Gender.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
                EmpTypeTBX.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
                IdNoTbx.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
                PositionTBX.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();

                //Change the label name
                label8.Text = "Date of Resignation";
                SalaryTbx.Text = EmpDGV.SelectedRows[0].Cells[7].Value.ToString();

                //Change the label name
                label9.Text = "Reason for Resignation";
                OtTbx.Text = EmpDGV.SelectedRows[0].Cells[8].Value.ToString();

                AllowanceTbx.Text = "No Record Found";
                EduTbx.Text = "No Record Found";
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
           EmpDetailsClear();//When clear button click, em_form_clear function call
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateEmployeeRec();  
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteEmployees();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadCurrentEmpBtn_Click(object sender, EventArgs e)
        {
            ViewCurrentEmployeeRec();
        }

        private void LoadPastEmp_Click(object sender, EventArgs e)
        {
            ViewPastEmployeeRec();
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewFromDataGrid();
        }

        private void EmpPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
