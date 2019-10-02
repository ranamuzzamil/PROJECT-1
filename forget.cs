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
    public partial class forget : Form
    {
        public forget()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==  "")
                MessageBox.Show("We have recieved your information and will contact you in an hour.");
            else 
                MessageBox.Show("Please provide some information or contact support");
            
        }
    }
}
