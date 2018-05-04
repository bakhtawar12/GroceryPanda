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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdminRegistration reg = new frmAdminRegistration();
            this.Hide();
            reg.Show();

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUserReg b = new frmUserReg();
            this.Hide();
            b.Show();
        }
    }
}
