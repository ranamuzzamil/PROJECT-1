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
    public partial class USERACCESS : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;


        string connectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\SEMESTER  4 IIBIT\\ITECH # 3208 PROJECT 1\\team work\\visual studios\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");



        public USERACCESS()
        {
            InitializeComponent();
            disp_data();
        }


        public void DisplayValue()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Access", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }


        private void USERACCESS_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ADMINHOME().Show();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void Button3_Click(object sender, EventArgs e)
        {


        }

        private void Button2_Click(object sender, EventArgs e)
        {
        

            MessageBox.Show("ACCESS GRANTED SUCESSFULLY");





        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Access";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("ACCESS REMOVED SUCESSFULLY");
        }
    }
}
