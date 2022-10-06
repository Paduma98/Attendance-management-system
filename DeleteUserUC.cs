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
    public partial class DeleteUserUC : UserControl
    {
        public DeleteUserUC()
        {
            InitializeComponent();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            
            if (txtStudentID1.Text == String.Empty || txtADUsername1.Text == String.Empty || txtADPassword1.Text == String.Empty)
            {
                MessageBox.Show("Some fields are missing!");
            }

            else if (txtADUsername1.Text != "admin" && txtADPassword1.Text != "admin123")
            {
                MessageBox.Show("Admin Username or Password Invalid!");
                
                
            }
            else
            {
                string studentID = txtStudentID1.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BIT CODE DB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "DELETE from Registration WHERE StudentID = '" + studentID + "'";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully");
                }
                catch ( SqlException se)
                {
                    MessageBox.Show("" + se);


                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            txtStudentID1.Text = null;
            txtADUsername1.Text = null;
            txtADPassword1.Text = null;
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            if (txtStudentID2.Text == String.Empty || txtADUsername2.Text == String.Empty || txtADPassword2.Text == String.Empty)
            {
                MessageBox.Show("Some fields are missing!");
            }

            else if (txtADUsername2.Text != "admin" && txtADPassword2.Text != "admin123")
            {
                MessageBox.Show("Admin Username or Password Invalid!");


            }
            else
            {
                string studentID = txtStudentID2.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BIT CODE DB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "DELETE from Attendance WHERE StudentID = '" + studentID + "'";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted successfully");
                }
                catch (SqlException se)
                {
                    MessageBox.Show("" + se);


                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtStudentID2.Text = null;
            txtADUsername2.Text = null;
            txtADPassword2.Text = null;
        }
    }
}
