using System.Drawing;
using System.Windows.Forms;

namespace CDShop
{
    partial class AllUser
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
            this.dgvAllUser = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALL USER INFORMATION";
            // 
            // dgvAllUser
            // 
            this.dgvAllUser.AllowUserToAddRows = false;
            this.dgvAllUser.AllowUserToDeleteRows = false;
            this.dgvAllUser.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAllUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserPass,
            this.UserName,
            this.UserPhone,
            this.UserSalary,
            this.StartDate,
            this.Role});
            this.dgvAllUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllUser.Location = new System.Drawing.Point(0, 0);
            this.dgvAllUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllUser.Name = "dgvAllUser";
            this.dgvAllUser.ReadOnly = true;
            this.dgvAllUser.RowHeadersWidth = 62;
            this.dgvAllUser.Size = new System.Drawing.Size(1028, 323);
            this.dgvAllUser.TabIndex = 1;
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
            // UserPass
            // 
            this.UserPass.DataPropertyName = "UserPass";
            this.UserPass.HeaderText = "UserPass";
            this.UserPass.MinimumWidth = 8;
            this.UserPass.Name = "UserPass";
            this.UserPass.ReadOnly = true;
            this.UserPass.Width = 150;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 150;
            // 
            // UserPhone
            // 
            this.UserPhone.DataPropertyName = "UserPhone";
            this.UserPhone.HeaderText = "UserPhone";
            this.UserPhone.MinimumWidth = 8;
            this.UserPhone.Name = "UserPhone";
            this.UserPhone.ReadOnly = true;
            this.UserPhone.Width = 150;
            // 
            // UserSalary
            // 
            this.UserSalary.DataPropertyName = "UserSalary";
            this.UserSalary.HeaderText = "UserSalary";
            this.UserSalary.MinimumWidth = 8;
            this.UserSalary.Name = "UserSalary";
            this.UserSalary.ReadOnly = true;
            this.UserSalary.Width = 150;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.MinimumWidth = 8;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 150;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 8;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 150;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(829, 167);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 35);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(824, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Search By Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAllUser);
            this.panel1.Location = new System.Drawing.Point(25, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 323);
            this.panel1.TabIndex = 28;
            // 
            // AllEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllEmployee";
            this.Size = new System.Drawing.Size(1078, 631);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private DataGridView dgvAllUser;
        private TextBox txtSearch;
        private Label label7;
        private Panel panel1;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserPass;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserPhone;
        private DataGridViewTextBoxColumn UserSalary;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn Role;
    }
}
