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
    public partial class ShowProducts : Form
    {
        public ShowProducts()
        {
            InitializeComponent();
        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            foreach (localhost.Store s in sc.shoowstores())
            {
                comboBox1.Items.Add(s.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            foreach(localhost.Store s in sc.shoowstores())
            {
                if (s.Name == comboBox1.Text)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = s.Products;
                    gvshowproducts.DataSource = source;
                    
                }
            }
        }

        private void gvshowproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            localhost.Product p = new localhost.Product();
            foreach(localhost.Store sto in sc.shoowstores())
            {
                if (sto.Name == comboBox1.Text)
                {
                    p=sto.Products[e.RowIndex];
                }
            }
            sc.getproduct(comboBox1.Text, p);
            foreach (localhost.Store s in sc.shoowstores())
            {
                if (s.Name == comboBox1.Text)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = s.Products;
                    gvshowproducts.DataSource = source;
                    
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
