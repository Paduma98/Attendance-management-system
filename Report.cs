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
    public partial class Report : UserControl
    {
        //Declare connection string public
        public string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\BIT CODE DB.mdf;Integrated Security=True;Connect Timeout=30";
        public Report()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
            string qry = "SELECT * FROM Registration";

            SqlDataAdapter da = new SqlDataAdapter(qry, constring);
            DataSet ds = new DataSet();

            da.Fill(ds, "Registration");
            dgv1.DataSource = ds.Tables["Registration"];



        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            
            string qry = "SELECT * FROM Attendance";

            SqlDataAdapter da = new SqlDataAdapter(qry, constring);
            DataSet ds = new DataSet();

            da.Fill(ds, "Attendance");
            dgv2.DataSource = ds.Tables["Attendance"];
        }
    }
}
