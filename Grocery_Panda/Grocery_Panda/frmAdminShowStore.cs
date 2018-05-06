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
    public partial class frmAdminShowStore : Form
    {
        public frmAdminShowStore()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddStore ad = new frmAddStore();
            ad.Show();
            this.Hide();
        }

        private void frmAdminShowStore_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            BindingSource s = new BindingSource();
            s.DataSource=sc.shoowstores();
            Gvshowallstore.DataSource = s;
        }
    }
}
