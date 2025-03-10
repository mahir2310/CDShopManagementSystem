using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDShop
{
    public partial class Employee : Form
    {


       
        private Login Fl { get; set; }
        private string ID { get; set; }
        private string Name { get; set; }

        private string role = "Employee";
        public Employee()
        {
            InitializeComponent();
        }

        public Employee(string id,  string name,Login fl) : this()
        {
            this.ID = id;
            this.Name = name;
            this.lblEmployeeName.Text = name + " Profile ";
            this.Fl= fl;
            
           
        }

        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fl.Show();


        }

        

        private void btnBillDetails_Click(object sender, EventArgs e)
        {
            BillDetailsUC billd = new BillDetailsUC();
            AddUserControl(billd);
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Billing(ID, Name,role,Fl).Show();
        }

       

    }
}
