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
    public partial class frmAdminHome : Form
    {
        public frmAdminHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddStore h = new frmAddStore();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addproduct h = new Addproduct();
            h.Show();
            this.Hide();
        }

        private void lbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain u = new frmMain();
            this.Hide();
            u.Show();
        }
    }
}
