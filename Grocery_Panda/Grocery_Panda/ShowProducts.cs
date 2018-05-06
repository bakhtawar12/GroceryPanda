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
                    gvshowproducts.Columns[2].Visible = false;
                    gvshowproducts.Columns[4].Visible = false;
                }
            }
        }
    }
}
