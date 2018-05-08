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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void lbHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminHome y = new frmAdminHome();
            this.Hide();
            y.Show();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            foreach(localhost.Store s in ser.shoowstores())
            {
                cmbStores.Items.Add(s.Name);
            }
        }

        private void cmbStores_TextChanged(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            foreach(localhost.Store s in ser.shoowstores())
            {
                foreach(localhost.User u in s.Customers)
                {
                    cmbOrdres.Items.Add(u.Username);
                }
            }
        }

        private void btnServe_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            ser.clearCustomer(cmbStores.Text, cmbOrdres.Text);
            foreach (localhost.Store s in ser.shoowstores())
            {
                foreach (localhost.User u in s.Customers)
                {
                    cmbOrdres.Items.Add(u.Username);
                }
            }
            MessageBox.Show("Order Served!");
        }
    }
}
