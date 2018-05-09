namespace Grocery_Panda
{
    partial class frmConfirmOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirmorder = new System.Windows.Forms.Button();
            this.lbMainPage = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(407, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnConfirmorder
            // 
            this.btnConfirmorder.Location = new System.Drawing.Point(357, 309);
            this.btnConfirmorder.Name = "btnConfirmorder";
            this.btnConfirmorder.Size = new System.Drawing.Size(91, 23);
            this.btnConfirmorder.TabIndex = 1;
            this.btnConfirmorder.Text = "Confirm Order";
            this.btnConfirmorder.UseVisualStyleBackColor = true;
            this.btnConfirmorder.Click += new System.EventHandler(this.btnConfirmorder_Click);
            // 
            // lbMainPage
            // 
            this.lbMainPage.AutoSize = true;
            this.lbMainPage.Location = new System.Drawing.Point(12, 348);
            this.lbMainPage.Name = "lbMainPage";
            this.lbMainPage.Size = new System.Drawing.Size(102, 13);
            this.lbMainPage.TabIndex = 2;
            this.lbMainPage.TabStop = true;
            this.lbMainPage.Text = "Back To Main Page";
            this.lbMainPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbMainPage_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Bill";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(317, 273);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(100, 20);
            this.txtBill.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(332, 364);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 386);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMainPage);
            this.Controls.Add(this.btnConfirmorder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmConfirmOrder";
            this.Text = "Confirm Order";
            this.Load += new System.EventHandler(this.frmConfirmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmorder;
        private System.Windows.Forms.LinkLabel lbMainPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}