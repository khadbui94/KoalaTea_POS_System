using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoalaTea_Project_Root.Admin
{
    public partial class FormDisplayStat : Form
    {
        public FormDisplayStat()
        {
            InitializeComponent();
            graph();
        }

        void graph()
        {
            using (DatabaseEntities dbe = new DatabaseEntities())
            {
                var list = from product in dbe.tblTransactionItems
                           group product by product.tblProduct.Description into g
                           select new { ProductID = g.Key, TotalUnitSold = g.Count() };

                chart1.ChartAreas[0].AxisY.Title = "Number of Product Sold";
                chart1.ChartAreas[0].AxisX.Title = "Products";

                foreach (var stat in list)
                    chart1.Series["Product"].Points.AddXY(stat.ProductID, stat.TotalUnitSold);

                // label fix
                chart1.ChartAreas[0].AxisX.Interval = 1;  
            }

            // display the chart in the center
            chart1.Left = (this.Width - chart1.Width) / 2;
            chart1.Top = (this.Height - chart1.Height) / 2;
        }

        private void btnBack_Stat_Click(object sender, EventArgs e)
        {
            FormAdminFrontPage admin = new FormAdminFrontPage();
            admin.Show();
            this.Hide(); 
        }

        private void FormDisplayStat_Activated(object sender, EventArgs e)
        {
            FormLoginMenu.timeToReduel();
        }

        private void FormDisplayStat_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLoginMenu.timeToNotDuel();
        }

    }
}
