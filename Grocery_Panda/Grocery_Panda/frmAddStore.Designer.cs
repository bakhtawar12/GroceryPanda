namespace Grocery_Panda
{
    partial class frmAddStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lbProducts = new System.Windows.Forms.LinkLabel();
            this.btnAddStores = new System.Windows.Forms.Button();
            this.btnViewStores = new System.Windows.Forms.Button();
            this.lbback = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adress";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(221, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(221, 127);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(100, 20);
            this.txtAdress.TabIndex = 4;
            // 
            // lbProducts
            // 
            this.lbProducts.AutoSize = true;
            this.lbProducts.Location = new System.Drawing.Point(101, 302);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(49, 13);
            this.lbProducts.TabIndex = 7;
            this.lbProducts.TabStop = true;
            this.lbProducts.Text = "Products";
            this.lbProducts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbProducts_LinkClicked);
            // 
            // btnAddStores
            // 
            this.btnAddStores.Location = new System.Drawing.Point(277, 201);
            this.btnAddStores.Name = "btnAddStores";
            this.btnAddStores.Size = new System.Drawing.Size(63, 23);
            this.btnAddStores.TabIndex = 8;
            this.btnAddStores.Text = "Add Store";
            this.btnAddStores.UseVisualStyleBackColor = true;
            this.btnAddStores.Click += new System.EventHandler(this.btnAddStores_Click);
            // 
            // btnViewStores
            // 
            this.btnViewStores.Location = new System.Drawing.Point(344, 259);
            this.btnViewStores.Name = "btnViewStores";
            this.btnViewStores.Size = new System.Drawing.Size(81, 22);
            this.btnViewStores.TabIndex = 9;
            this.btnViewStores.Text = "View Stores";
            this.btnViewStores.UseVisualStyleBackColor = true;
            this.btnViewStores.Click += new System.EventHandler(this.btnViewStores_Click);
            // 
            // lbback
            // 
            this.lbback.AutoSize = true;
            this.lbback.Location = new System.Drawing.Point(29, 344);
            this.lbback.Name = "lbback";
            this.lbback.Size = new System.Drawing.Size(32, 13);
            this.lbback.TabIndex = 10;
            this.lbback.TabStop = true;
            this.lbback.Text = "Back";
            this.lbback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbback_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(421, 344);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmAddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 377);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbback);
            this.Controls.Add(this.btnViewStores);
            this.Controls.Add(this.btnAddStores);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddStore";
            this.Text = "Add Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.LinkLabel lbProducts;
        private System.Windows.Forms.Button btnAddStores;
        private System.Windows.Forms.Button btnViewStores;
        private System.Windows.Forms.LinkLabel lbback;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}