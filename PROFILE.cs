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
    public partial class PROFILE : Form
    {
        public static string settext = "";
        public PROFILE()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void PROFILE_Load(object sender, EventArgs e)
        {
            label5.Text = Form4.settext;
            label6.Text = EMAIL.settext;
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOUR CHOICE HAS BEEN SAVED");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                
            
            this.Hide();
            new EMAIL().Show();

            

            }

        private void Button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            new HOME().Show();
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new PASSWORD().Show();
        }
    }
}
