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
    public partial class frmUserStores : Form
    {
        private bool is_customer = false;
        public frmUserStores()
        {
            InitializeComponent();
        }

        private void frmUserStores_Load(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            BindingSource source = new BindingSource();
            foreach(localhost.Store s in ser.shoowstores())
            {
                cmbStores.Items.Add(s.Name);
            }
        }

        private void lbshoworder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConfirmOrder y = new frmConfirmOrder();
            this.Close();
            y.Show();
        }

        private void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            foreach (localhost.Store str in ser.shoowstores())
            {
                if (str.Name == cmbStores.Text)
                {
                    foreach (localhost.Product p in str.Products)
                    {
                        if(p.Name == cmbProduts.Text)
                        {
                            ser.orderProduct(p);
                            if (!is_customer)
                            {
                                ser.addCustomerToStore(cmbStores.Text);
                                is_customer = true;
                            }
                            MessageBox.Show("Product added to order list!");
                        }
                    }
                }
            }
        }

        private void cmbStores_TextChanged(object sender, EventArgs e)
        {
            is_customer = false;
            localhost.Service1 ser = new localhost.Service1();
            foreach(localhost.Store str in ser.shoowstores())
            {
                if (str.Name == cmbStores.Text)
                {
                    foreach (localhost.Product p in str.Products)
                    {
                        cmbProduts.Items.Add(p.Name);
                    }
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMain r = new frmMain();
            this.Hide();
            r.Show();
        }
    }
}
