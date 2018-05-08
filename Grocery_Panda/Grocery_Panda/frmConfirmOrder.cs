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

        private void frmConfirmOrder_Load(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.getOrderList();
            dataGridView1.DataSource = source;
            txtBill.Text = ser.getPrice();
        }

        private void btnConfirmorder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order confirmed!");
        }
    }
}
