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
    public partial class Form4 : Form
    {

        public static string settext = "";



        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string newcom = "select UserName from Table1 where UserName='" + textBox1.Text + "' and Password='" +textBox3.Text+ "' ";
            SqlDataAdapter adp = new SqlDataAdapter(newcom, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count >=1)
            {
                settext = textBox1.Text;

               

                this.Hide();
                new HOME().Show();
            }

            else
            {


                MessageBox.Show("Invalid Login or Password");
            }


        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new forget().Show();
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ADMIN().Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
