﻿using System;
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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;


        string connectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
            DisplayValue();
        }
        public void DisplayValue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from House", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }





        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {


        }
            
        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HOME().Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void TxtSearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchData(txtSearchBox.Text);
        }

        public void SearchData(string search)
        {
            con.Open();
            string query = "select* from House where Postcode like'%" + search + "%' ";
            adpt = new SqlDataAdapter(query, con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();


        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
