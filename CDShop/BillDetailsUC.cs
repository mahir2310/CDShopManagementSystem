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
    public partial class BillDetailsUC : UserControl
    {
        private DataAccess Da { get; set; }



        public BillDetailsUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }
        public void PopulateGridView(string sql = "SELECT billInfo.BillID,userInfo.UserID,userInfo.UserName,billInfo.TotalBill,billInfo.BillingDate,customerInfo.CustomerID,customerInfo.CustomerName,customerInfo.CustomerPhone FROM billInfo INNER JOIN customerInfo ON billInfo.CustomerID=customerInfo.CustomerID INNER JOIN userInfo ON userInfo.UserID=billInfo.UserID;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvBillDetails.AutoGenerateColumns = false;//true chilo
            this.dgvBillDetails.DataSource = ds.Tables[0];
        }

        

        private void btnTotalSale_Click(object sender, EventArgs e)
        {

            float TotalSales = 0;

            for (int i = 0; i < dgvBillDetails.Rows.Count; i++)
            {
                // Convert the Value to a float, ensuring null or invalid data is handled
                if (dgvBillDetails.Rows[i].Cells[3].Value != null && float.TryParse(dgvBillDetails.Rows[i].Cells[3].Value.ToString(), out float cellValue))
                {
                    TotalSales += cellValue;
                }
            }

            this.txtTotalSale.Text = TotalSales.ToString("F2"); // Format as needed, e.g., 2 decimal places
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Verbatim string for the SQL query
            string sql = @"
        SELECT 
            billInfo.BillID, 
            userInfo.UserID, 
            userInfo.UserName, 
            billInfo.TotalBill, 
            billInfo.BillingDate, 
            customerInfo.CustomerID, 
            customerInfo.CustomerName, 
            customerInfo.CustomerPhone 
        FROM 
            billInfo 
        INNER JOIN 
            customerInfo 
            ON billInfo.CustomerID = customerInfo.CustomerID 
        INNER JOIN 
            userInfo 
            ON userInfo.UserID = billInfo.UserID 
        WHERE 
            customerInfo.CustomerName LIKE '" + this.txtSearch.Text + @"%';";

            // Call the method to populate the grid view with filtered results
            this.PopulateGridView(sql);
        }

       
    }
}
