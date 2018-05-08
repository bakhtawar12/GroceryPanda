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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnConfirmorder
            // 
            this.btnConfirmorder.Location = new System.Drawing.Point(226, 242);
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
            this.lbMainPage.Location = new System.Drawing.Point(13, 264);
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
            this.label1.Location = new System.Drawing.Point(126, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Bill";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(197, 203);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(100, 20);
            this.txtBill.TabIndex = 4;
            // 
            // frmConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 289);
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
    }
}