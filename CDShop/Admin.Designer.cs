using System.Drawing;
using System.Windows.Forms;

namespace CDShop
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAdminPortal = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBillDetails = new System.Windows.Forms.Button();
            this.btnAllUser = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnCDManagement = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 61);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.lblAdminPortal);
            this.panel3.Controls.Add(this.lblAdminName);
            this.panel3.Location = new System.Drawing.Point(321, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 58);
            this.panel3.TabIndex = 5;
            // 
            // lblAdminPortal
            // 
            this.lblAdminPortal.AutoSize = true;
            this.lblAdminPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPortal.ForeColor = System.Drawing.Color.Black;
            this.lblAdminPortal.Location = new System.Drawing.Point(92, 0);
            this.lblAdminPortal.Name = "lblAdminPortal";
            this.lblAdminPortal.Size = new System.Drawing.Size(150, 29);
            this.lblAdminPortal.TabIndex = 4;
            this.lblAdminPortal.Text = "Admin Portal";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.Black;
            this.lblAdminName.Location = new System.Drawing.Point(92, 30);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(79, 29);
            this.lblAdminName.TabIndex = 3;
            this.lblAdminName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(755, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "RockStar CD Shop";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBilling);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnBillDetails);
            this.panel2.Controls.Add(this.btnAllUser);
            this.panel2.Controls.Add(this.btnUserManagement);
            this.panel2.Controls.Add(this.btnCDManagement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 52);
            this.panel2.TabIndex = 2;
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.Location = new System.Drawing.Point(810, 3);
            this.btnBilling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(137, 46);
            this.btnBilling.TabIndex = 8;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(953, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBillDetails
            // 
            this.btnBillDetails.BackColor = System.Drawing.Color.Lime;
            this.btnBillDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillDetails.Location = new System.Drawing.Point(640, 4);
            this.btnBillDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBillDetails.Name = "btnBillDetails";
            this.btnBillDetails.Size = new System.Drawing.Size(164, 44);
            this.btnBillDetails.TabIndex = 6;
            this.btnBillDetails.Text = "Bill Details";
            this.btnBillDetails.UseVisualStyleBackColor = false;
            this.btnBillDetails.Click += new System.EventHandler(this.btnBillDetails_Click);
            // 
            // btnAllUser
            // 
            this.btnAllUser.BackColor = System.Drawing.Color.Lime;
            this.btnAllUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllUser.Location = new System.Drawing.Point(457, 2);
            this.btnAllUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllUser.Name = "btnAllUser";
            this.btnAllUser.Size = new System.Drawing.Size(177, 46);
            this.btnAllUser.TabIndex = 5;
            this.btnAllUser.Text = "All User";
            this.btnAllUser.UseVisualStyleBackColor = false;
            this.btnAllUser.Click += new System.EventHandler(this.btnAllUser_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.Lime;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(231, 2);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(208, 48);
            this.btnUserManagement.TabIndex = 4;
            this.btnUserManagement.Text = "UserManagement";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnCDManagement
            // 
            this.btnCDManagement.BackColor = System.Drawing.Color.Lime;
            this.btnCDManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDManagement.Location = new System.Drawing.Point(11, 0);
            this.btnCDManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCDManagement.Name = "btnCDManagement";
            this.btnCDManagement.Size = new System.Drawing.Size(214, 48);
            this.btnCDManagement.TabIndex = 3;
            this.btnCDManagement.Text = "CDManagement";
            this.btnCDManagement.UseVisualStyleBackColor = false;
            this.btnCDManagement.Click += new System.EventHandler(this.btnCDManagement_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 113);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1078, 631);
            this.panelContainer.TabIndex = 3;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 744);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnExit;
        private Button btnBillDetails;
        private Button btnAllUser;
        private Button btnUserManagement;
        private Button btnCDManagement;
        private Panel panelContainer;
        private Button btnBilling;
        private Label lblAdminName;
        private Label lblAdminPortal;
        private Panel panel3;
    }
}