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


namespace Main_Window
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Log_In login = new Log_In();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty || txtConfirmPassword.Text == string.Empty) 
            {
                MessageBox.Show("Check Username or Password!");
                txtUsername.Text = null;
                txtPassword.Text = null;
                txtConfirmPassword.Text = null;

            }

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BIT CODE DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "INSERT INTO Access (Username,Password,ConfirmPassword) VALUES ('"+ txtUsername.Text +"', '"+ txtPassword.Text +"','"+ txtConfirmPassword.Text +"') ";
            SqlCommand cmd = new SqlCommand(query,sqlcon);
            
            try
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password not matched!");
                    txtUsername.Text = null;
                    txtPassword.Text = null;
                    txtConfirmPassword.Text = null;

                }
                else
                {
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully!");
                    txtUsername.Text = null;
                    txtPassword.Text = null;
                    txtConfirmPassword.Text = null;
                }


                
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
