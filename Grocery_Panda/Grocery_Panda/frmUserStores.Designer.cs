namespace Grocery_Panda
{
    partial class frmUserStores
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddtoOrder = new System.Windows.Forms.Button();
            this.lbshoworder = new System.Windows.Forms.LinkLabel();
            this.cmbProduts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cmbStores
            // 
            this.cmbStores.FormattingEnabled = true;
            this.cmbStores.Location = new System.Drawing.Point(166, 17);
            this.cmbStores.Name = "cmbStores";
            this.cmbStores.Size = new System.Drawing.Size(121, 21);
            this.cmbStores.TabIndex = 0;
            this.cmbStores.TextChanged += new System.EventHandler(this.cmbStores_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stores";
            // 
            // btnAddtoOrder
            // 
            this.btnAddtoOrder.Location = new System.Drawing.Point(281, 166);
            this.btnAddtoOrder.Name = "btnAddtoOrder";
            this.btnAddtoOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddtoOrder.TabIndex = 3;
            this.btnAddtoOrder.Text = "Add to Order";
            this.btnAddtoOrder.UseVisualStyleBackColor = true;
            this.btnAddtoOrder.Click += new System.EventHandler(this.btnAddtoOrder_Click);
            // 
            // lbshoworder
            // 
            this.lbshoworder.AutoSize = true;
            this.lbshoworder.Location = new System.Drawing.Point(78, 236);
            this.lbshoworder.Name = "lbshoworder";
            this.lbshoworder.Size = new System.Drawing.Size(88, 13);
            this.lbshoworder.TabIndex = 7;
            this.lbshoworder.TabStop = true;
            this.lbshoworder.Text = "Show Your Order";
            this.lbshoworder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbshoworder_LinkClicked);
            // 
            // cmbProduts
            // 
            this.cmbProduts.FormattingEnabled = true;
            this.cmbProduts.Location = new System.Drawing.Point(166, 94);
            this.cmbProduts.Name = "cmbProduts";
            this.cmbProduts.Size = new System.Drawing.Size(121, 21);
            this.cmbProduts.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(316, 268);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmUserStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 322);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProduts);
            this.Controls.Add(this.lbshoworder);
            this.Controls.Add(this.btnAddtoOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStores);
            this.Name = "frmUserStores";
            this.Text = "Stores";
            this.Load += new System.EventHandler(this.frmUserStores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddtoOrder;
        private System.Windows.Forms.LinkLabel lbshoworder;
        private System.Windows.Forms.ComboBox cmbProduts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}