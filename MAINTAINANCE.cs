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
    public partial class MAINTAINANCE : Form
    {
        public MAINTAINANCE()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOUR MAINTAINCE APPLICAION IS REVIEVED, PLEASE WAIT UNTILL IT IS APPROVED");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HOME().Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YOUR ALTERATION REQUEST TO THE PROPERTY WILL BE VERFIED SOON!");
        }
    }
}
