using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Panda
{
    public partial class frmUserResetPass : Form
    {
        public frmUserResetPass()
        {
            InitializeComponent();
        }

        private void lbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserLogin d = new frmUserLogin();
            this.Hide();
            d.Show();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            bool valid = false;
            bool valids = false;
            localhost.Service1 server = new localhost.Service1();
            server.userChangePassword(txtName.Text, cmbQuestion.Text, txtAnswer.Text, txtNewPass.Text, out valid, out valids);
            if(valid)
            {
                MessageBox.Show("Password changed!");
                frmUserLogin a = new frmUserLogin();
                this.Close();
                a.Show();
            } else
            {
                MessageBox.Show("Password not changed!");
            }
        }
    }
}
