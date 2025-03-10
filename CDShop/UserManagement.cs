using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDShop
{
    public partial class UserManagement : UserControl
    {
        private DataAccess Da { get; set; }
        public UserManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        public void PopulateGridView(string sql = "SELECT * FROM userInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUser.AutoGenerateColumns = false;// true chilo kintu amra custom table use krbo ty false 
            this.dgvUser.DataSource = ds.Tables[0];
        }

        private void AutoIdGenerate()
        {
            var sql = "select userInfo.UserID from userInfo order by userInfo.UserID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');  //U-001  //  temp[0] = U, temp[1] = 001
            int num = Convert.ToInt32(temp[1]);
            string newId = "U-" + (++num).ToString("d3");
            this.txtId.Text = newId;
        }

        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtName.Text = "";
            this.txtPassword.Clear();
            this.txtPhone.Clear();
            this.txtSalary.Clear();
            this.dtpStartDate.Text = "";
            this.cmbType.SelectedIndex = -1;

            this.txtSearch.Clear();

            this.dgvUser.ClearSelection();
            this.AutoIdGenerate();
        }
        private bool IsValidBangladeshiPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^(?:\+?88)?01[0-9]\d{8}$");

            return regex.IsMatch(phoneNumber);
        }

        private bool IsValidToSave()
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtName.Text)
                || String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrEmpty(this.cmbType.Text)
                || String.IsNullOrEmpty(this.txtPhone.Text) || String.IsNullOrEmpty(this.txtSalary.Text)
                || String.IsNullOrEmpty(this.dtpStartDate.Text))
                {
                    return false;
                }
                else
                {
                    if (IsValidBangladeshiPhoneNumber(this.txtPhone.Text))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Bangladeshi phone number.\n" + "Example : 01731849660");
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
           // this.AutoIdGenerate();//eta already clear funtion ase
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM userInfo where userInfo.UserName like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
            this.txtPassword.Text = this.dgvUser.CurrentRow.Cells[1].Value.ToString();
            this.txtName.Text = this.dgvUser.CurrentRow.Cells[2].Value.ToString();
            this.txtPhone.Text = this.dgvUser.CurrentRow.Cells[3].Value.ToString();
            this.txtSalary.Text = this.dgvUser.CurrentRow.Cells[4].Value.ToString();
            this.dtpStartDate.Text = this.dgvUser.CurrentRow.Cells[5].Value.ToString();
            this.cmbType.Text = this.dgvUser.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information Correctly");
                    return;
                }

                string query = null;
                var sql = "select * from userInfo where UserID = '" + this.txtId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = @"INSERT INTO userInfo(UserID, UserPass, UserName, UserPhone, UserSalary, StartDate, Role) 
                                VALUES('" + this.txtId.Text + @"', 
                                '" + this.txtPassword.Text + @"', 
                                '" + this.txtName.Text + @"', 
                                '" + this.txtPhone.Text + @"', 
                                '" + this.txtSalary.Text + @"', 
                                '" + this.dtpStartDate.Text + @"',
                                '" + this.cmbType.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data has been added properly");
                    else
                        MessageBox.Show("User data saving failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information Correctly");
                    return;
                }

                string query = null;
                var sql = "select * from userInfo where UserID = '" + this.txtId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    query = @"UPDATE userInfo
                            SET UserPass = '" + this.txtPassword.Text + @"',
                            UserName = '" + this.txtName.Text + @"',
                            UserPhone = '" + this.txtPhone.Text + @"',
                            UserSalary = '" + this.txtSalary.Text + @"',
                            StartDate = '" + this.dtpStartDate.Text + @"',
                            Role = '" + this.cmbType.Text + @"'
                            WHERE UserID = '" + this.txtId.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("User data has been updated properly");
                    else
                        MessageBox.Show("User data upgradation failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
                var query = "delete from userInfo where UserID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("User data remove failed");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }

        }


        

       

        private void btnSeePass_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (this.txtPassword.PasswordChar == '*')
            {
                this.txtPassword.PasswordChar = '\0'; // Show password
                this.btnSeePass.Text = "Hide Password"; // Update button text
            }
            else
            {
                this.txtPassword.PasswordChar = '*'; // Hide password
                this.btnSeePass.Text = "See Password"; // Update button text
            }

            //MessageBox.Show("Button Clicked!"); // Debug message
        }
    }
}
