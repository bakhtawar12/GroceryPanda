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
    public partial class frmConfirmOrder : Form
    {
        public frmConfirmOrder()
        {
            InitializeComponent();
        }

        private void lbMainPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserStores t = new frmUserStores();
            this.Close();
            t.Show();
        }
    }
}
