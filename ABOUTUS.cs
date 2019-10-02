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
    public partial class ABOUTUS : Form
    {
        public ABOUTUS()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ABOUTUS_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HOME().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PAYMENT().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FINANCE().Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new MAINTAINANCE().Show();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new DOCUMENT().Show();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || textBox1.Text == "")
                MessageBox.Show("please fill all fields");
            else
            {
                SqlConnection sqlCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("FEEDBACKAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@UserId", txtFirstName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Email", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Feedback", textBox2.Text.Trim());
                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Feedback submitted sucessfull");
                Clear();
            }
        }
        
        void Clear()
        {
            txtFirstName.Text = textBox1.Text = textBox2.Text = "";
        }
        
    }
}
