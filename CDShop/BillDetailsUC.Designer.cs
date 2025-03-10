using System.Windows.Forms;

namespace CDShop
{
    partial class BillDetailsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.btnTotalSale = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALL BILL DETAILS";
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.AllowUserToAddRows = false;
            this.dgvBillDetails.AllowUserToDeleteRows = false;
            this.dgvBillDetails.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.UserID,
            this.UserName,
            this.TotalBill,
            this.BillingDate,
            this.CustomerID,
            this.CustomerName,
            this.CustomerPhone});
            this.dgvBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBillDetails.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBillDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvBillDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.ReadOnly = true;
            this.dgvBillDetails.RowHeadersWidth = 62;
            this.dgvBillDetails.Size = new System.Drawing.Size(1029, 363);
            this.dgvBillDetails.TabIndex = 1;
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.HeaderText = "BillID";
            this.BillID.MinimumWidth = 8;
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            this.BillID.Width = 150;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.MinimumWidth = 8;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 150;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "BillerName";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 150;
            // 
            // TotalBill
            // 
            this.TotalBill.DataPropertyName = "TotalBill";
            this.TotalBill.HeaderText = "TotalBill";
            this.TotalBill.MinimumWidth = 8;
            this.TotalBill.Name = "TotalBill";
            this.TotalBill.ReadOnly = true;
            this.TotalBill.Width = 150;
            // 
            // BillingDate
            // 
            this.BillingDate.DataPropertyName = "BillingDate";
            this.BillingDate.HeaderText = "BillingDate";
            this.BillingDate.MinimumWidth = 8;
            this.BillingDate.Name = "BillingDate";
            this.BillingDate.ReadOnly = true;
            this.BillingDate.Width = 150;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 8;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 150;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.MinimumWidth = 8;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 150;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.DataPropertyName = "CustomerPhone";
            this.CustomerPhone.HeaderText = "CustomerPhone";
            this.CustomerPhone.MinimumWidth = 8;
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.ReadOnly = true;
            this.CustomerPhone.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBillDetails);
            this.panel1.Location = new System.Drawing.Point(27, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 363);
            this.panel1.TabIndex = 2;
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSale.Location = new System.Drawing.Point(931, 109);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(125, 30);
            this.txtTotalSale.TabIndex = 3;
            // 
            // btnTotalSale
            // 
            this.btnTotalSale.BackColor = System.Drawing.Color.Yellow;
            this.btnTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalSale.ForeColor = System.Drawing.Color.Red;
            this.btnTotalSale.Location = new System.Drawing.Point(620, 100);
            this.btnTotalSale.Name = "btnTotalSale";
            this.btnTotalSale.Size = new System.Drawing.Size(305, 50);
            this.btnTotalSale.TabIndex = 4;
            this.btnTotalSale.Text = "Total Sales in Amount Tk";
            this.btnTotalSale.UseVisualStyleBackColor = false;
            this.btnTotalSale.Click += new System.EventHandler(this.btnTotalSale_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearch.Location = new System.Drawing.Point(27, 116);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "SerachByCustomer Name";
            // 
            // BillDetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnTotalSale);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BillDetailsUC";
            this.Size = new System.Drawing.Size(1078, 631);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DataGridView dgvBillDetails;
        private Panel panel1;
        private TextBox txtTotalSale;
        private Button btnTotalSale;
        private TextBox txtSearch;
        private Label label2;
        private DataGridViewTextBoxColumn BillID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn TotalBill;
        private DataGridViewTextBoxColumn BillingDate;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerPhone;
    }
}
