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
    public partial class AllUser : UserControl
    {
        private DataAccess Da { get; set; }
        public AllUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }

        public void PopulateGridView(string sql = "SELECT * FROM userInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvAllUser.AutoGenerateColumns = false; //true chilo kintu custom gridview use koray false korsi

            this.dgvAllUser.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM userInfo where userInfo.UserName like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

       

        
    }
}
