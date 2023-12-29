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
    public partial class Reason_and_Date_of_Deletion : Form
    {
        static string connectionstring = "Server = RASI-WORK-STATI; Database = Grifindo Toys; Integrated Security = true";
        SqlConnection connection = new SqlConnection(connectionstring);

        public Reason_and_Date_of_Deletion()
        {
            InitializeComponent(); 
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            //Getting values from user and store it in variables
            string reason = ReasonForDelTBX.Text;
            DateTime dateOfDeletion = DatePick.Value;

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
