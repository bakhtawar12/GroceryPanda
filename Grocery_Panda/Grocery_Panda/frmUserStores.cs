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

        private void btShowProducts_Click(object sender, EventArgs e)
        {
            localhost.Service1 ser = new localhost.Service1();
            BindingSource source = new BindingSource();
            source.DataSource = ser.getStoreProducts(cmbStores.Text);
            dataGridViewProdcuts.DataSource = source;
        }
    }
}
