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
    public partial class frmUserReg : Form
    {
        public frmUserReg()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "" || txtContact.Text == "" || txtAnswer.Text == "")
            {
                MessageBox.Show("Incomplete Information!");
            } else
            {
                bool valid = false;
                bool validS = false;
                localhost.Service1 server = new localhost.Service1();
                server.registerUser(txtUserName.Text, txtPassword.Text, txtContact.Text, cmbQuestion.Text, txtAnswer.Text, out valid, out validS);
                MessageBox.Show("User Added!");
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtContact.Text = "";
                txtAnswer.Text = "";
            }
        }
    }
}
