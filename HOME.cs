using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Registration
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            label1.Text = Form4.settext;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FINANCE().Show();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PAYMENT().Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MAINTAINANCE().Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DOCUMENT().Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ABOUTUS().Show();
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new PROFILE().Show();
        }
    }
}
