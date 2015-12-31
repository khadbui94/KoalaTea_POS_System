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
    public partial class FormAdminFrontPage : Form
    {

        //database for admin to add data:
        public static DatabaseEntities dbe = new DatabaseEntities();
       
        public FormAdminFrontPage()
        {
            InitializeComponent();
        }

        //change image from jpg,png to byte
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void btnLogout_Admin_Click(object sender, EventArgs e)
        {
            FormLoginMenu nextPage = new FormLoginMenu();
            nextPage.Show();
            this.Hide();
        }

        private static FormAddItems editItems = new FormAddItems();

        private void btnEditItem_Admin_Click(object sender, EventArgs e)
        {
            editItems.Show();
            this.Hide(); 
        }

        private void FormAdminFrontPage_Activated(object sender, EventArgs e)
        {
            // timer reset on form show
            // FormLoginMenu.timeToDuel();
            FormLoginMenu.timeToReduel();
        }

        private void FormAdminFrontPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLoginMenu.timeToNotDuel();
        }

        private void FormAdminFrontPage_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnEditUser_Admin_Click(object sender, EventArgs e)
        {
            FormAddEditEmployees nextPage = new FormAddEditEmployees();
            nextPage.Show();
            this.Hide();
        }

        private void btnReport_Admin_Click(object sender, EventArgs e)
        {
            notImplemented("Report [Not Implemented]");
        }

        private void btnPrint_Admin_Click(object sender, EventArgs e)
        {
            notImplemented("Print [Not Implemented]");
        }

        private void btnSettings_Admin_Click(object sender, EventArgs e)
        {
            notImplemented("Settings [Not Implemented]");
        }

        private void notImplemented(string message)
        {
            FormError incomplete = new FormError();
            incomplete.changeButtonOne.Text = "OK";
            incomplete.changeLabel.Text = message;
            incomplete.changeTitle = "Incomplete Functionality";
            incomplete.changeButtonTwo.Hide();
            incomplete.ShowDialog();
        }

        private void btnEditDeleteItems_Click(object sender, EventArgs e)
        {
            FormEditItems nextpage = new FormEditItems();
            nextpage.Show();

            this.Hide(); 
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            FormDisplayStat nextPage = new FormDisplayStat();
            nextPage.Show();

            this.Hide();
        }

        private void btnAddEditPromo_Click(object sender, EventArgs e)
        {
            (new FormAddEditPromoCode()).Show();
            this.Hide(); 
        }
    }
}
