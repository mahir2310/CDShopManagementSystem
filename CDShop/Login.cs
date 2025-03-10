using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CDShop;

namespace CDShop
{
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        

       
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserID.Text) || String.IsNullOrEmpty(this.txtPass.Text))
                return false;
            else
                return true;
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string sql = "Select * from userInfo where UserID = '" + this.txtUserID.Text + "' and UserPass = '" + this.txtPass.Text + "';";

                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var name = ds.Tables[0].Rows[0][2].ToString();
                    var id = ds.Tables[0].Rows[0][0].ToString();
                    var role = ds.Tables[0].Rows[0][6].ToString();
                    //MessageBox.Show(name + id + role);

                    if (role == "Admin")
                    {
                        this.Hide();
                     
                        new Admin(id, name,this).Show();
                        
                        

                    }
                    else if (role == "Employee")
                    {
                        this.Hide();
                 
                        new Employee(id, name,this).Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("The UserName or Password you entered is incorrect, Try Again");
                    txtUserID.Clear();
                    txtPass.Clear();
                    txtUserID.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }


        }

        

        private void Login_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Application is exiting.");
            Application.Exit(); // Ensure the application exits completely

        }

        


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtPass.Clear();
            txtUserID.Focus();
        }

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (this.txtPass.PasswordChar == '*')
            {
                this.txtPass.PasswordChar = '\0'; // Show password
                this.btnSeePass.Text = "Hide Password"; // Update button text
            }
            else
            {
                this.txtPass.PasswordChar = '*'; // Hide password
                this.btnSeePass.Text = "See Password"; // Update button text
            }

            //MessageBox.Show("Button Clicked!"); // Debug message
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit(); // Ensure the application exits completely
            MessageBox.Show("Application is exiting.");
        }
    }
}
