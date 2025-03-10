using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDShop
{
    public partial class Billing : Form
    {
        private DataAccess Da { get; set; }
        private Login Fl { get; set; }
        private string Role;
        private string ID { get; set; }
        private string Name { get; set; }

     
        private int Stock { get; set; }
        private string CDID { get; set; }
        private string BillID { get; set; }
        private static int n = 1;
        private float GrdTotal = 0f;
        public Billing()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();

            this.BillAutoIdGenerate();

            this.CustomerAutoIdGenerate();
        }
        public Billing(string id, string name, string role, Login fl) : this()
        {
            this.ID = id;
            this.Name = name;
            this.Role = role;
            this.lblBillerName.Text = name;
            string formattedDate = DateTime.Now.ToString("yyyy-MM-dd");
            this.lblDate.Text = formattedDate;
            this.Fl = fl;
        }

        private void CustomerAutoIdGenerate()
        {
            var sql = "select CustomerID from customerInfo order by CustomerID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            int newId = Convert.ToInt32(oldId);
            this.txtCID.Text = (++newId).ToString();
        }

        public void PopulateGridView(string sql = "select * from cdInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCD.AutoGenerateColumns = false;//true chilo 
            this.dgvCD.DataSource = ds.Tables[0];
        }
        private void ClearAllProductDetails()
        {
            this.txtCusName.Text = "";
            this.txtName.Text = "";
            this.txtCusPhone.Text = "";
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
            this.dgvCD.ClearSelection();
            Stock = 0;
            this.CustomerAutoIdGenerate();  
        }

        private bool IsValidToAddProduct()
        {
            try
            {
                int value = Convert.ToInt32(this.txtQuantity.Text);
                if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtPrice.Text)
                    || value <= 0)
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

       


        

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM cdInfo where cdInfo.CdName like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void UpdateStock()
        {
            try
            {
                int newQty = this.Stock - Convert.ToInt32(txtQuantity.Text);
                string CID = this.CDID;
                string query = @"UPDATE cdInfo
                        SET Quantity = '" + newQty + @"'
                        WHERE CdID = '" + CID + "'; ";

                this.Da.ExecuteDMLQuery(query);

                this.ClearAllProductDetails();
                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

       


        

        //perfectly print serial on printpreview but in finalgridview because of stativ n, it is remaining after one bill done


        private void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(txtQuantity.Text);
                float priceInfloat = Convert.ToSingle(txtPrice.Text);
                float total = quantity * priceInfloat;

                if (string.IsNullOrEmpty(txtName.Text) || quantity > Stock)
                {
                    MessageBox.Show("Invalid input or insufficient stock");
                    return;
                }

                

                // Use AddRow with explicit column values
                dgvFinalBill.Rows.Add(
                    n.ToString(),           // Column1 (S.No)
                    this.txtName.Text,      // Column2 (CD Name)
                    quantity,               // Column3 (Quantity)
                    priceInfloat,           // Column4 (Price)
                    "Taka " + total         // Column5 (Total)
                );

                n++;
                GrdTotal += total;
                lblTotalBill.Text = $"Taka {GrdTotal}";
                UpdateStock();
                ClearAllProductDetails();
                PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }





        private void BillAutoIdGenerate()
        {
            var sql = "select BillID from billInfo order by BillID desc;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            int newId = Convert.ToInt32(oldId);
            this.lblBillId.Text = (++newId).ToString();
            this.BillID = this.lblBillId.Text;
        }

        private void dgvCD_DoubleClick_1(object sender, EventArgs e)
        {
            this.CDID = this.dgvCD.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dgvCD.CurrentRow.Cells[1].Value.ToString();
            this.Stock = Convert.ToInt32(this.dgvCD.CurrentRow.Cells[2].Value.ToString());
            this.txtPrice.Text = this.dgvCD.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearAllProductDetails();
            this.PopulateGridView();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFinalBill.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvFinalBill.SelectedRows[0];

                    int quantity = Convert.ToInt32(selectedRow.Cells[2].Value);
                    string productName = selectedRow.Cells[1].Value.ToString();

                    dgvFinalBill.Rows.Remove(selectedRow);

                    //debugCOde for refreshing serial no after remove
                    //final cart e ekta item remove er por n abar new item add korle
                    //serial maintain hocchilo na n static howai oikarone
                    //finarbill gridview er row count kore serially n re 1 theke abar update korsi loop diye 
                    n = 1;
                    for (int i = 0; i < dgvFinalBill.Rows.Count; i++)
                    {
                        dgvFinalBill.Rows[i].Cells[0].Value = n.ToString();
                        n++;
                    }

                    RestoreStock(productName, quantity);

                    float rowTotal = float.Parse(selectedRow.Cells[4].Value.ToString().Replace("Taka ", ""));
                    GrdTotal -= rowTotal;
                    lblTotalBill.Text = "Taka " + GrdTotal;
                    this.PopulateGridView();
                }
                else
                {
                    MessageBox.Show("Please select an item to remove.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }








        private void RestoreStock(string productName, int quantity)
        {
            try
            {
                string query = $"UPDATE cdInfo SET Quantity = Quantity + '{quantity}' WHERE CdName = '{productName}'";//database er quanttiy+ekhner quantity
                var count = this.Da.ExecuteDMLQuery(query);

                if (count > 0)
                {
                    MessageBox.Show("Item removed from cart and stock restored.");
                }
                else
                {
                    MessageBox.Show("Stock restoration failed. CD not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message);
            }
        }

        //jhamela ase button er name change kora lagbe..btnback
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Role == "Admin")
                {
                    this.Hide();
                    new Admin(ID, Name, Fl).Show();

                }
                else 
                {
                    this.Hide();
                    new Employee(ID, Name, Fl).Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message);
            }

        }

        private bool IsValidToAddCustomer()
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtCusName.Text) || String.IsNullOrEmpty(this.txtCusPhone.Text))
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //
            //Add Customer To Database
            //
            n = 1;//confirm bill er por n ke ager obosthai niye jacchi
            try
            {
                if (!this.IsValidToAddCustomer())
                {
                    MessageBox.Show("Please fill all the Customer information Correctly");
                    return;
                }

                string query = null;
                var sql = "select * from customerInfo where CustomerID = '" + this.txtCID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    query = @"INSERT INTO customerInfo(CustomerName, CustomerPhone) 
                                VALUES('" + this.txtCusName.Text + @"',
                                '" + this.txtCusPhone.Text + "');";
                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Customer data has been added properly");
                    else
                        MessageBox.Show("Customer data adding failed");
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has been found:\n" + exc.Message);
            }

            //
            //Add BillInfo To Database
            //


            try
            {
                if (!this.IsValidToAddCustomer())
                {
                    MessageBox.Show("Please fill all the Customer information Correctly");
                    return;
                }

                string query = null;
                var date = DateTime.Now.Date;
                string formattedDate = date.ToString("yyyy-MM-dd");
                var sql = "select * from billInfo where BillID = '" + this.lblBillId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    //
                    //To Refresh The Database 
                    //
                    var sql1 = "select * from customerInfo where CustomerID = '" + this.txtCID.Text + "';";
                    var ds1 = this.Da.ExecuteQuery(sql1);
                    if (ds1.Tables[0].Rows.Count == 1)
                    {
                        query = @"INSERT INTO billInfo(UserID,BillingDate,TotalBill,CustomerID) 
                                    VALUES('" + ID + @"', 
                                    '" + formattedDate + @"', 
                                    '" + GrdTotal + @"',
                                    '" + this.txtCID.Text + "');";
                        var count = this.Da.ExecuteDMLQuery(query);

                        if (count == 1)
                            MessageBox.Show("Billing data has been added properly");
                        else
                            MessageBox.Show("Billing data adding failed");
                    }

                }
                this.ClearAllProductDetails();
                //debug entry
                //this.BillAutoIdGenerate(); //eta print er pore genrate korsi
                //dgvFinalBill.Rows.Remove(dr);  //etai maybe jhamela korsilo just ekta row remove kore
                
            }
            catch (Exception exc)
            {
                //MessageBox.Show("Error has been found:\n" + exc.Message);
                //ekhane error ashtesilo
            }



            //debugging row koita ase check krtesi

            //MessageBox.Show($"Total Rows: {dgvFinalBill.Rows.Count}, Grand Total: {GrdTotal}");

            //
            //Print Preview
            //

            try
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 600, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            //debugcode billid ekhaner age generate korle print e porer id print hoye jacchilo ty print er kajer poer id generate korsi

            this.BillAutoIdGenerate();

            dgvFinalBill.Rows.Clear();//print er pore cart clear kore dicchi


        }


        //int SNo,Quantity, position = 80;
        //int serial=0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

       // string price, total, proName;


        


         //this shows printpreview  perfectly!!!happyyyyy!!!
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
         {
             try
             {
                 // Print Header
                 var date = DateTime.Now.Date;
                 string formattedDate = date.ToString("yyyy-MM-dd");
                 e.Graphics.DrawString("RockStar CD SHOP", new Font("Monotype Corsiva", 14, FontStyle.Italic), Brushes.Red, new Point(200, 10));
                 e.Graphics.DrawString($"BillID: {lblBillId.Text}    Biller Name: {lblBillerName.Text}    Date: {formattedDate}",
                                        new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 40));
                 e.Graphics.DrawString(new string('*', 80), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, 60));

                 // Table Headers
                 e.Graphics.DrawString("SNo", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 80));
                 e.Graphics.DrawString("CD Name", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 80));
                 e.Graphics.DrawString("Quantity", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 80));
                 e.Graphics.DrawString("Price", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(300, 80));
                 e.Graphics.DrawString("Total", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(400, 80));

                 // Initialize position and serial number
                 int position = 100;
                 int serial = 1;
                 bool hasItems = false;

                 foreach (DataGridViewRow row in dgvFinalBill.Rows)
                 {
                     if (row.IsNewRow) continue;

                     string cdName = Convert.ToString(row.Cells[1].Value);
                     int quantity = Convert.ToInt32(row.Cells[2].Value);
                     string price = Convert.ToString(row.Cells[3].Value);
                     string total = Convert.ToString(row.Cells[4].Value).Replace("Taka ", "");

                     // Skip empty rows or rows with missing data
                     if (string.IsNullOrEmpty(cdName)) continue;

                     // Print each row's data
                     e.Graphics.DrawString(serial.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, position));
                     e.Graphics.DrawString(cdName, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, position));
                     e.Graphics.DrawString(quantity.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(200, position));
                     e.Graphics.DrawString(price, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(300, position));
                     e.Graphics.DrawString(total, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(400, position));

                     position += 20; // Move to the next line
                     serial++;

                     hasItems = true;
                 }

                 // If no items, print a message
                 if (!hasItems)
                 {
                     e.Graphics.DrawString("No items in the bill.", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, new Point(10, position));
                 }

                 // Print footer (Grand Total)
                 e.Graphics.DrawString(new string('*', 80), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(10, position + 10));
                 e.Graphics.DrawString($"Grand Total: Taka {GrdTotal}", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(300, position + 30));
                 e.Graphics.DrawString("Thank you for shopping with us!", new Font("Monotype Corsiva", 12, FontStyle.Italic), Brushes.Red, new Point(150, position + 60));
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error during printing: " + ex.Message);
             }
         }

       

    }
}
