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
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserReg c = new frmUserReg();
            this.Close();
            c.Show();
        }

        private void lbForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserResetPass g = new frmUserResetPass();
            this.Close();
            g.Show();
        
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Incomplete information");
            }
            else
            {
                bool valid = false;
                bool validS = false;
                localhost.Service1 server = new localhost.Service1();
                server.validUser(txtName.Text, txtPassword.Text, out valid, out validS);
                if (valid)
                {
                    MessageBox.Show("Welcome!");
                }
                else
                {
                    MessageBox.Show("wrong username or password!");
                }
            }
        }
    }
}
