using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_Window
{
    public partial class Attendance : UserControl
    {
        public Attendance()
        {
            InitializeComponent();
        }
        //Declaring a global variable for the batchselect
        public static string BatchSelect;
        //Declaring a global variable for the attendance radio buttons
        public static string AttendanceStatus;

       
        
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == string.Empty || txtStudentName.Text == string.Empty)
            {
                MessageBox.Show("Required fields missing!");


            }
            else if (AttendanceStatus == null || BatchSelect == null)
            {
                MessageBox.Show("Please select the attendance & batch status!");
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BIT CODE DB.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "INSERT INTO Attendance (StudentID,StudentName,Batch,Date,Attendance) VALUES ('" + this.txtStudentID.Text + "', '" + this.txtStudentName.Text + "','" + BatchSelect + "','" + DateAttendance.Value.ToString() + "','" + AttendanceStatus + "') ";
                SqlCommand cmd = new SqlCommand(query, sqlcon);

                try
                {
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Attendance Marked!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);

                }
                finally
                {
                    sqlcon.Close();
                }
            }
        }

        private void radioPresent_CheckedChanged(object sender, EventArgs e)
        {
            AttendanceStatus = "Present";
        }

        private void radioAbsent_CheckedChanged(object sender, EventArgs e)
        {
            AttendanceStatus = "Absent";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = null;
            txtStudentName.Text = null;
            radio1.Checked = false;
            radio2.Checked = false;
            radio3.Checked = false;
            DateAttendance.CustomFormat = null;
            radioPresent.Checked = false;
            radioAbsent.Checked = false;

        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            BatchSelect = "19.1";
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            BatchSelect = "19.2";
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            BatchSelect = "20.1";
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
