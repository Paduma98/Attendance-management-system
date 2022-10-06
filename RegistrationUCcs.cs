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
    public partial class RegistrationUCcs : UserControl
    {
        public RegistrationUCcs()
        {
            InitializeComponent();
        }

        //Declaring global variable for Gender
        public static string Gender;
        //Declaring global variable for Level
        public static string Level;
        //
        public static string BatchSelect;


        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == string.Empty || txtFname.Text == string.Empty || txtLname.Text == string.Empty)
            {
                MessageBox.Show("Check your StudentID or Name!");
                txtStudentID.Text = null;
                txtFname.Text = null;
                txtLname.Text = null;

            }
            else if (Gender == null || Level == null)
            {
                MessageBox.Show("Gender OR Level Fields are empty!");
            }
            else if (txtMobileNo.Text == string.Empty || txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Mobile Number OR Email Fields are empty!");
            }
            else if (txtCourseName.Text == string.Empty)
            {
                MessageBox.Show("Please enter the course name!");

            }
          
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BIT CODE DB.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "INSERT INTO Registration (StudentID,Fname,Lname,MobileNo,Email,Gender,RegDate,Level,Batch,CourseName) VALUES ('" + this.txtStudentID.Text + "', '" + this.txtFname.Text + "','" + this.txtLname.Text + "','" + this.txtMobileNo.Text + "','" + this.txtEmail.Text + "','" + Gender + "','" + RegDate.Value.ToString() + "','" + Level + "','" + BatchSelect + "','" + txtCourseName.Text + "')";
                SqlCommand cmd = new SqlCommand(query, sqlcon);

                try
                {
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully!");

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

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void radioDegree_CheckedChanged(object sender, EventArgs e)
        {
            Level = "Degree";
        }

        private void radioCertficate_CheckedChanged(object sender, EventArgs e)
        {
            Level = "Certificate";

        }

        private void radioDiploma_CheckedChanged(object sender, EventArgs e)
        {
            Level = "Diploma";

        }


        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = null;
            txtFname.Text = null;
            txtLname.Text = null;
            txtMobileNo.Text = null;
            txtEmail.Text = null;
            radioMale.Checked = false;
            radioFemale.Checked = false;
            RegDate.CustomFormat = null;
            radioDegree.Checked = false;
            radioCertficate.Checked = false;
            radioDiploma.Checked = false;
            txtCourseName.Text = null;
            radio1.Checked = false;
            radio2.Checked = false;
            radio3.Checked = false;
            


                
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
