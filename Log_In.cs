using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Main_Window
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();


            
        }

        public void StartForm()
        {
            Application.Run(new SplashScreen());

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
            
        }

        //Declaring global variable for the display username
        public static string username;
    
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BIT CODE DB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "SELECT * FROM Access WHERE Username = '"+txtUsername.Text.Trim()+"' AND Password = '"+txtPassword.Text.Trim()+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                username = txtUsername.Text;
                Form1 mainfrm = new Form1();
                mainfrm.Show();
                this.Hide();
                sqlcon.Close();

            }
            else 
            {
                MessageBox.Show("Check your Username & Password!");
                 txtUsername.Text = null;               
                 txtPassword.Text = null;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
