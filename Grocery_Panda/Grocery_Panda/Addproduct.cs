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
    public partial class Addproduct : Form
    {
        public Addproduct()
        {
            InitializeComponent();
        }

        private void Addproduct_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            foreach(localhost.Store s in sc.shoowstores())
            {
                comboBox1.Items.Add(s.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            foreach (localhost.Store s in sc.shoowstores())
            {
                if (comboBox1.GetItemText(comboBox1.SelectedItem) == s.Name)
                {
                    localhost.Product p = new localhost.Product();
                    bool yes = true;
                    bool yes2 = true;
                    sc.addStoreProducts(s, txtproductname.Text, int.Parse(txtprice.Text), yes2, int.Parse(txtquantity.Text), yes);

                }
            }
            MessageBox.Show("Product is Added to" + comboBox1.Text);
            txtprice.Text = "";
            txtproductname.Text = "";
            txtquantity.Text = "";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowProducts s = new ShowProducts();
            s.Show();
            this.Hide();
        }
    }
}
