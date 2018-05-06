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
    public partial class frmAddStore : Form
    {
        public frmAddStore()
        {
            InitializeComponent();
        }

        private void btnAddStores_Click(object sender, EventArgs e)
        {
            localhost.Store st = new localhost.Store();
            st.Name = txtName.Text;
            st.Address = txtAdress.Text;
            localhost.Service1 sc = new localhost.Service1();
            sc.addstore(st);
            MessageBox.Show("Store is added");
            txtName.Text = "";
            txtAdress.Text = "";

        }

        private void btnViewStores_Click(object sender, EventArgs e)
        {
            frmAdminShowStore frm = new frmAdminShowStore();
            frm.Show();
            this.Hide();
        }
    }
}
