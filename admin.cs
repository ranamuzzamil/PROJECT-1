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

namespace User_Registration
{
    public partial class ADMIN : Form
    {
        public static string settext = "";

        public ADMIN()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string newcom = "select AdminId from Admin where AdminId='" + textBox1.Text + "' and PasswordAdmin='" + textBox3.Text + "' ";
            SqlDataAdapter adp = new SqlDataAdapter(newcom, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {
                settext = textBox1.Text;



                this.Hide();
                new ADMINHOME().Show();
            }

            else
            {


                MessageBox.Show("SENSITIVE CASSE!     ENTER ACURATE DATA");
            }


        
    }
    }
}
