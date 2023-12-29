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
using System.Drawing.Printing;
using System.IO;

namespace Grifindo_Toys_PS
{
    public partial class Report_Generation : Form
    {
        static string SqlConnectionString = "Server = RASI-WORK-STATI; Database = Grifindo Toys; Integrated Security = true; ";
        SqlConnection sqlConnection = new SqlConnection(SqlConnectionString);

        public Report_Generation()
        {
            InitializeComponent();
        }

        private void JustLoad()
        {
            try
            {
                sqlConnection.Open();
                string loadAllQuery = "SELECT * FROM Salary_Tracker_Data";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(loadAllQuery, sqlConnection);
                var dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DGVReportGen.DataSource = dataset.Tables[0];
                sqlConnection.Close();

                RHeadingLbl.Text = "***-All Employee Salary Records-***" ;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
            }   
        }

        private void empMonSalReport()
        {

            try
            {
                sqlConnection.Open();
                string monSalQuery = "SELECT S.EmpNumber, S.EmpName, S.SalaryCycleBeginDate, S.SalaryCycleEndDate, E.MonSalary, E.Allowance, S.NumLeaves, S.AbsentDays, S.Holidays, " +
                    "S.OT * E.[OtRate(hr)] AS OT_Value, S.NoPayValue, S.BasePay, S.GrossPay " +
                    "FROM Salary_Tracker_Data S JOIN Emp_Management_Table E ON S.EmpNumber = E.EmpNumber WHERE E.EmpNumber = @REmpNoTbx AND S.EmpNumber = @REmpNoTbx " +
                    "AND S.SalaryCycleBeginDate = @ReportBeginDatePicker AND S.SalaryCycleEndDate = @ReportEndDatePicker ";
                SqlCommand command = new SqlCommand(monSalQuery, sqlConnection);
                command.Parameters.AddWithValue("@ReportBeginDatePicker", ReportBeginDatePicker.Value.Date);
                command.Parameters.AddWithValue("@ReportEndDatePicker", ReportEndDatePicker.Value.Date);
                command.Parameters.AddWithValue("@REmpNoTbx", REmpNoTbx.Text);
                SqlDataAdapter dataAdapter = new SqlDataAdapter (command);
                var dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DGVReportGen.DataSource = dataset.Tables[0];
                RHeadingLbl.Text = "***-Monthly Salary Report-***";             
                sqlConnection.Close();                        
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
            }           
        }

        private void overAllSummeryReport()
        {
            try
            {
                sqlConnection.Open();
                string monSalQuery = "SELECT S.EmpNumber, S.EmpName, S.SalaryCycleBeginDate, S.SalaryCycleEndDate, E.MonSalary, E.Allowance, S.NumLeaves, S.AbsentDays, S.Holidays, S.OT * E.[OtRate(hr)] AS OT_Value, " +
                    "S.NoPayValue, S.BasePay, S.GrossPay " +
                    "FROM Salary_Tracker_Data S JOIN Emp_Management_Table E ON S.EmpNumber = E.EmpNumber WHERE E.EmpNumber = @REmpNoTbx AND S.EmpNumber = @REmpNoTbx " +
                    "AND S.SalaryCycleBeginDate >= @ReportBeginDatePicker AND S.SalaryCycleEndDate <= @ReportEndDatePicker ";
                SqlCommand command = new SqlCommand(monSalQuery, sqlConnection);
                command.Parameters.AddWithValue("@ReportBeginDatePicker", ReportBeginDatePicker.Value.Date);
                command.Parameters.AddWithValue("@ReportEndDatePicker", ReportEndDatePicker.Value.Date);
                command.Parameters.AddWithValue("@REmpNoTbx", REmpNoTbx.Text);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                var dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DGVReportGen.DataSource = dataset.Tables[0];
                RHeadingLbl.Text = "***-Overall Salary Summery-***";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
            }
        }

        private void noPayReport()
        {
            try
            {
                sqlConnection.Open();
                string monSalQuery = "SELECT EmpNumber, EmpName, NoPayValue FROM Salary_Tracker_Data WHERE SalaryCycleBeginDate >= @ReportBeginDatePicker AND SalaryCycleEndDate <= @ReportEndDatePicker ";       
                SqlCommand command = new SqlCommand(monSalQuery, sqlConnection);
                command.Parameters.AddWithValue("@ReportBeginDatePicker", ReportBeginDatePicker.Value.Date);
                command.Parameters.AddWithValue("@ReportEndDatePicker", ReportEndDatePicker.Value.Date);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                var dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DGVReportGen.DataSource = dataset.Tables[0];
                RHeadingLbl.Text = "***-No Pay Value Summary-***";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
            }
        }

        private void basePayReport()
        {
            try
            {
                sqlConnection.Open();
                string monSalQuery = "SELECT EmpNumber, EmpName, BasePay FROM Salary_Tracker_Data WHERE SalaryCycleBeginDate >= @ReportBeginDatePicker AND SalaryCycleEndDate <= @ReportEndDatePicker ";
                SqlCommand command = new SqlCommand(monSalQuery, sqlConnection);
                command.Parameters.AddWithValue("@ReportBeginDatePicker", ReportBeginDatePicker.Value.Date);
                command.Parameters.AddWithValue("@ReportEndDatePicker", ReportEndDatePicker.Value.Date);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                var dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DGVReportGen.DataSource = dataset.Tables[0];
                RHeadingLbl.Text = "***-Base Pay Value Summary-***";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
            }
        }

        private void grossPayReport()
        {
            try
            {
                sqlConnection.Open();
                string monSalQuery = "SELECT EmpNumber, EmpName, GrossPay FROM Salary_Tracker_Data WHERE SalaryCycleBeginDate >= @ReportBeginDatePicker AND SalaryCycleEndDate <= @ReportEndDatePicker ";
                SqlCommand command = new SqlCommand(monSalQuery, sqlConnection);
                command.Parameters.AddWithValue("@ReportBeginDatePicker", ReportBeginDatePicker.Value.Date);
                command.Parameters.AddWithValue("@ReportEndDatePicker", ReportEndDatePicker.Value.Date);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                var dataset = new DataSet();
                dataAdapter.Fill(dataset);
                DGVReportGen.DataSource = dataset.Tables[0];
                RHeadingLbl.Text = "***-Gross Pay Value Summary-***";
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data from the database: " + ex.Message);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DGVReportGen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Set the DGV to be printed
            Bitmap bitmap = new Bitmap(DGVReportGen.Width, DGVReportGen.Height);
            DGVReportGen.DrawToBitmap(bitmap, new Rectangle(0, 0, DGVReportGen.Width, DGVReportGen.Height));

            float ratio = bitmap.Width / (float)bitmap.Height;
            RectangleF rectangle = e.MarginBounds;
            if ((float)e.MarginBounds.Width / e.MarginBounds.Height > ratio)
            {
                rectangle.Width = e.MarginBounds.Height * ratio;
            }
            else
            {
                rectangle.Height = e.MarginBounds.Width / ratio;
            }
            e.Graphics.DrawImage(bitmap, rectangle);
            e.HasMorePages = false;
        }

        private void CvsFileDownload()
        {
            SaveFileDialog savefiledialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv) |*.csv",
                FileName = "Grifindo Data.csv"
            };

            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter streamwriter = new StreamWriter(savefiledialog.FileName))
                    {
                        StringBuilder rowData = new StringBuilder(); // To get headers
                        for (int i = 0; i < DGVReportGen.Columns.Count; i++)
                        {
                            rowData.Append(DGVReportGen.Columns[i].HeaderText);
                            if (i < DGVReportGen.Columns.Count - 1)
                                rowData.Append(",");
                        }
                       streamwriter.WriteLine(rowData.ToString());

                        foreach (DataGridViewRow rows in DGVReportGen.Rows) // To get row data
                        {
                            StringBuilder rowData1 = new StringBuilder();
                            for (int j = 0; j < DGVReportGen.Columns.Count; j++)
                            {
                                if (rows.Cells[j].Value != null)
                                    rowData1.Append(rows.Cells[j].Value.ToString());
                                if (j < DGVReportGen.Columns.Count - 1)
                                    rowData1.Append(",");
                            } 
                            streamwriter.WriteLine(rowData1.ToString());
                        }
                    }
                    MessageBox.Show("CSV file downloaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while downloading the CSV file: " + ex.Message);
                }
            }
        }

        private void SalaryPic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSalaryRecBtn_Click(object sender, EventArgs e) //Load button functions
        {
            if (REmpNoTbx.Text == "" && TypeCbx.Text == "")
            {
                JustLoad();
            }           
            else if (REmpNoTbx.Text != "" && TypeCbx.Text == "Monthly Report")
            {
                empMonSalReport();
            }
            else if (REmpNoTbx.Text != "" && TypeCbx.Text == "Overall Summary")
            {
                overAllSummeryReport();
            }
            else if (REmpNoTbx.Text == "" && TypeCbx.Text == "No Pay Value")
            {
                noPayReport();
            }
            else if (REmpNoTbx.Text == "" && TypeCbx.Text == "Base Pay Value")
            {
                basePayReport();
            }
            else if (REmpNoTbx.Text == "" && TypeCbx.Text == "Gross Pay Value")
            {
                grossPayReport();
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            //Adding print button event handlers
            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = true;
            printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = printDoc;
            printPreview.ShowDialog();
        }

        private void Downloadbtn_Click(object sender, EventArgs e)
        {
            CvsFileDownload();
        }
    }
}
