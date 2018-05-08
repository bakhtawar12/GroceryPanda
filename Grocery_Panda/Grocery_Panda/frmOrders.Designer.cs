namespace Grocery_Panda
{
    partial class frmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbStores = new System.Windows.Forms.ComboBox();
            this.cmbOrdres = new System.Windows.Forms.ComboBox();
            this.lbStores = new System.Windows.Forms.Label();
            this.lbOrders = new System.Windows.Forms.Label();
            this.btnServe = new System.Windows.Forms.Button();
            this.lbHome = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cmbStores
            // 
            this.cmbStores.FormattingEnabled = true;
            this.cmbStores.Location = new System.Drawing.Point(124, 39);
            this.cmbStores.Name = "cmbStores";
            this.cmbStores.Size = new System.Drawing.Size(121, 21);
            this.cmbStores.TabIndex = 0;
            this.cmbStores.TextChanged += new System.EventHandler(this.cmbStores_TextChanged);
            // 
            // cmbOrdres
            // 
            this.cmbOrdres.FormattingEnabled = true;
            this.cmbOrdres.Location = new System.Drawing.Point(124, 99);
            this.cmbOrdres.Name = "cmbOrdres";
            this.cmbOrdres.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdres.TabIndex = 1;
            // 
            // lbStores
            // 
            this.lbStores.AutoSize = true;
            this.lbStores.Location = new System.Drawing.Point(36, 42);
            this.lbStores.Name = "lbStores";
            this.lbStores.Size = new System.Drawing.Size(32, 13);
            this.lbStores.TabIndex = 2;
            this.lbStores.Text = "Store";
            // 
            // lbOrders
            // 
            this.lbOrders.AutoSize = true;
            this.lbOrders.Location = new System.Drawing.Point(36, 107);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(82, 13);
            this.lbOrders.TabIndex = 3;
            this.lbOrders.Text = "Customer Name";
            // 
            // btnServe
            // 
            this.btnServe.Location = new System.Drawing.Point(172, 218);
            this.btnServe.Name = "btnServe";
            this.btnServe.Size = new System.Drawing.Size(75, 23);
            this.btnServe.TabIndex = 4;
            this.btnServe.Text = "Serve Order";
            this.btnServe.UseVisualStyleBackColor = true;
            this.btnServe.Click += new System.EventHandler(this.btnServe_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Location = new System.Drawing.Point(16, 227);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(35, 13);
            this.lbHome.TabIndex = 5;
            this.lbHome.TabStop = true;
            this.lbHome.Text = "Home";
            this.lbHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbHome_LinkClicked);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbHome);
            this.Controls.Add(this.btnServe);
            this.Controls.Add(this.lbOrders);
            this.Controls.Add(this.lbStores);
            this.Controls.Add(this.cmbOrdres);
            this.Controls.Add(this.cmbStores);
            this.Name = "frmOrders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStores;
        private System.Windows.Forms.ComboBox cmbOrdres;
        private System.Windows.Forms.Label lbStores;
        private System.Windows.Forms.Label lbOrders;
        private System.Windows.Forms.Button btnServe;
        private System.Windows.Forms.LinkLabel lbHome;
    }
}