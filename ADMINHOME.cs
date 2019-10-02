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
    public partial class ADMINHOME : Form
    {
        public ADMINHOME()
        {
            InitializeComponent();
        }

        private void ADMINHOME_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new USERACCESS().Show();
        }
    }
}
