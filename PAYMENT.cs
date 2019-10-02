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
    public partial class PAYMENT : Form
    {
        public static string settext = "";
        public PAYMENT()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HOME().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string newcom = "select Credit from Credit1 where Credit='" + textBox1.Text + "'  ";
            SqlDataAdapter adp = new SqlDataAdapter(newcom, con);
            DataSet ds = new DataSet();

            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("please fill all the fields");
            else if (dt.Rows.Count >= 1)
            {
                settext = textBox1.Text;


                MessageBox.Show("BILL HAVE BEAN PAID");
                textBox3.Text = textBox1.Text = textBox2.Text = textBox4.Text = "";
            }

            else
            {


                MessageBox.Show("INVALID CREDIT NUMBER OR DATA");
                textBox3.Text = textBox1.Text = textBox2.Text = textBox4.Text = "";
            }
             

                
        
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           

                textBox3.Text = textBox1.Text = textBox2.Text = textBox4.Text = String.Empty;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PLEASE CALL AT +61 457456334 ");
        }
    }
}
