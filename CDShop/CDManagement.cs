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
    public partial class CDManagement : UserControl
    {
        private DataAccess Da {  get; set; }
        public CDManagement()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        public void PopulateGridView(string sql = "SELECT cdInfo.CdID,cdInfo.CdName,cdInfo.Price,cdInfo.Quantity,cdInfo.Catagory FROM cdInfo")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCD.AutoGenerateColumns = false;//true chilo
            this.dgvCD.DataSource = ds.Tables[0];
        }

        private void AutoIdGenerate()
        {
            var sql = "select cdInfo.CdID from cdInfo order by cdInfo.CdID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            int newId = Convert.ToInt32(oldId);
            this.txtId.Text = (++newId).ToString();
        }

        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtName.Text = "";
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
            this.cmbCategory.SelectedIndex = -1;

            this.txtSearch.Clear();

            this.dgvCD.ClearSelection();
            this.AutoIdGenerate();//eta disi jate clear er por new id ta show kore ei kaj ta usemanagement e o krte hbe
        }

        private bool IsValidToSave()
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtName.Text)
                || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCategory.Text)
                || String.IsNullOrEmpty(this.txtQuantity.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return false;
            }
        }

        private void dgvCD_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvCD.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvCD.CurrentRow.Cells[1].Value.ToString();
            this.txtQuantity.Text = this.dgvCD.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.dgvCD.CurrentRow.Cells[3].Value.ToString();
            this.cmbCategory.Text = this.dgvCD.CurrentRow.Cells[4].Value.ToString();
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
                var sql = "SELECT * FROM cdInfo where cdInfo.CdID = '" + this.txtId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = @"INSERT INTO cdInfo(CdName, Quantity, Price, Catagory) 
                                VALUES('" + this.txtName.Text + @"', 
                                '" + this.txtQuantity.Text + @"', 
                                '" + this.txtPrice.Text + @"',
                                '" + this.cmbCategory.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("CD data has been added properly");
                    else
                        MessageBox.Show("CD data saving failed");
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
                var sql = "SELECT * FROM cdInfo where cdInfo.CdID = '" + this.txtId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    query = @"UPDATE cdInfo
                            SET CdName = '" + this.txtName.Text + @"',
                            Quantity = '" + this.txtQuantity.Text + @"',
                            price = '" + this.txtPrice.Text + @"',
                            Catagory = '" + this.cmbCategory.Text + @"'
                            WHERE CdID = '" + this.txtId.Text + "'; ";

                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("CD data has been updated properly");
                    else
                        MessageBox.Show("CD data upgradation failed");
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
                if (this.dgvCD.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var id = this.dgvCD.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvCD.CurrentRow.Cells["CdName"].Value.ToString();
                var query = "delete from cdInfo where CdID = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("CD data remove failed");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM cdInfo where cdInfo.CdName like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearAll();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        
    }
}
