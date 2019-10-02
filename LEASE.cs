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
    public partial class LEASE : Form
    {
        public static string settext = "";

        public LEASE()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string newcom = "select UserName from Table1 where UserName='" + textBox1.Text + "' and Address='" + textBox3.Text + "' ";
            SqlDataAdapter adp = new SqlDataAdapter(newcom, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {
                settext = textBox1.Text;


                MessageBox.Show("WE HAVE RECIEVED YOUR APPLICATION");

            }

            else
            {


                MessageBox.Show("PROVIDE MISSING INFORMATION");
            }


        
    }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string newcom = "select UserName from Table1 where UserName='" + textBox1.Text + "' and Address='" + textBox3.Text + "' ";
            SqlDataAdapter adp = new SqlDataAdapter(newcom, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >= 1)
            {
                settext = textBox1.Text;


                MessageBox.Show("YOU WILL RECIEVED A COPY IN SOME TIME");

            }

            else
            {


                MessageBox.Show("PLEASE PROVIDE ACCURATE INFORMATION");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DOCUMENT().Show();
        }
    }
}
