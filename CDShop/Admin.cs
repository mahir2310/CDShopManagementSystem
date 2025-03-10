using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CDShop
{
    public partial class Admin : Form
    {
        private Login Fl { get; set; }
        private string ID { get; set; }
        //name ta comment kore disi
         private string Name { get; set; }
        private string role = "Admin";
        public Admin()
        {
            InitializeComponent();
        }
        public Admin(string id, string name,Login fl) : this()
        {
            this.ID = id;
            this.Name = name;
            this.lblAdminName.Text = name + " Profile ";
            this.Fl= fl;
          
          
        }
        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnCDManagement_Click(object sender, EventArgs e)
        {
            CDManagement cDManagement = new CDManagement();
            AddUserControl(cDManagement);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();
            AddUserControl(userManagement);
        }

        private void btnAllUser_Click(object sender, EventArgs e)
        {
            AllUser allUser = new AllUser();
            AddUserControl(allUser);
        }

        private void btnBillDetails_Click(object sender, EventArgs e)
        {
            BillDetailsUC billd = new BillDetailsUC();
            AddUserControl(billd);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Fl.Show();
            
          

        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            new Billing(ID, Name,role,Fl).Show();

        }

        

    }
}
