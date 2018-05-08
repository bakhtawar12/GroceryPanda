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
            this.dataGridViewProdcuts = new System.Windows.Forms.DataGridView();
            this.btnAddtoOrder = new System.Windows.Forms.Button();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.lbViewOrder = new System.Windows.Forms.LinkLabel();
            this.btShowProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdcuts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStores
            // 
            this.cmbStores.FormattingEnabled = true;
            this.cmbStores.Location = new System.Drawing.Point(98, 13);
            this.cmbStores.Name = "cmbStores";
            this.cmbStores.Size = new System.Drawing.Size(121, 21);
            this.cmbStores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stores";
            // 
            // dataGridViewProdcuts
            // 
            this.dataGridViewProdcuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdcuts.Location = new System.Drawing.Point(184, 76);
            this.dataGridViewProdcuts.Name = "dataGridViewProdcuts";
            this.dataGridViewProdcuts.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewProdcuts.TabIndex = 2;
            // 
            // btnAddtoOrder
            // 
            this.btnAddtoOrder.Location = new System.Drawing.Point(349, 245);
            this.btnAddtoOrder.Name = "btnAddtoOrder";
            this.btnAddtoOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddtoOrder.TabIndex = 3;
            this.btnAddtoOrder.Text = "Add to Order";
            this.btnAddtoOrder.UseVisualStyleBackColor = true;
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.Location = new System.Drawing.Point(13, 308);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(43, 13);
            this.lbLogout.TabIndex = 4;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Log out";
            // 
            // lbViewOrder
            // 
            this.lbViewOrder.AutoSize = true;
            this.lbViewOrder.Location = new System.Drawing.Point(365, 299);
            this.lbViewOrder.Name = "lbViewOrder";
            this.lbViewOrder.Size = new System.Drawing.Size(59, 13);
            this.lbViewOrder.TabIndex = 5;
            this.lbViewOrder.TabStop = true;
            this.lbViewOrder.Text = "View Order";
            // 
            // btShowProducts
            // 
            this.btShowProducts.Location = new System.Drawing.Point(226, 13);
            this.btShowProducts.Name = "btShowProducts";
            this.btShowProducts.Size = new System.Drawing.Size(90, 23);
            this.btShowProducts.TabIndex = 6;
            this.btShowProducts.Text = "Show Products";
            this.btShowProducts.UseVisualStyleBackColor = true;
            this.btShowProducts.Click += new System.EventHandler(this.btShowProducts_Click);
            // 
            // frmUserStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 333);
            this.Controls.Add(this.btShowProducts);
            this.Controls.Add(this.lbViewOrder);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.btnAddtoOrder);
            this.Controls.Add(this.dataGridViewProdcuts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStores);
            this.Name = "frmUserStores";
            this.Text = "Stores";
            this.Load += new System.EventHandler(this.frmUserStores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdcuts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProdcuts;
        private System.Windows.Forms.Button btnAddtoOrder;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.LinkLabel lbViewOrder;
        private System.Windows.Forms.Button btShowProducts;
    }
}