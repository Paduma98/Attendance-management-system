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
    public partial class ChangePass : UserControl
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            
            
            string username, old_password, new_password , conf_password;
            username = txtUsername.Text;
            old_password = txtOldPassword.Text;
            new_password = txtNewPassword.Text;
            conf_password = txtConfirmPassword.Text;

            if (username == string.Empty || old_password == string.Empty || new_password == string.Empty || conf_password == string.Empty)
            {
                MessageBox.Show("Some fields are missing! ");
            }
            else if (new_password != conf_password)
            {
                MessageBox.Show("Password not matched!");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BIT CODE DB.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "UPDATE Access SET Password = '" + new_password + "' WHERE Username = '" + username + "'";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Updated Successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    con.Close();

                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = null;
            txtOldPassword.Text = null;
            txtNewPassword.Text = null;
            txtConfirmPassword.Text = null;

        }
    }
}
