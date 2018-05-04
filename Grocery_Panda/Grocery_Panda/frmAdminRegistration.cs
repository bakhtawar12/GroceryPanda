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
    public partial class frmAdminRegistration : Form
    {
        public frmAdminRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "" || txtContact.Text == "" || txtAnswer.Text == "")
            {
                MessageBox.Show("Incomplete Information!");
            }
            else
            {
                bool valid = false;
                bool valids = false;
                localhost.Service1 server = new localhost.Service1();
                server.RegisterAdmin(txtUserName.Text, txtPassword.Text, txtContact.Text, cmbQuestion.Text, txtAnswer.Text, out valid, out valids);
                if (valid)
                {
                    MessageBox.Show("Admin Registered!");
                }
                else
                {
                    MessageBox.Show("Can not register more than one admin!");
                }
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtContact.Text = "";
                txtAnswer.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAdminLogin admin = new FrmAdminLogin();
            this.Close();
            admin.Show();
        }
    }
}
