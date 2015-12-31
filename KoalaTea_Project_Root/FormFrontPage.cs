using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace KoalaTea_Project_Root
{
    public partial class FormFrontPage : Form
    {
        public FormFrontPage()
        {
            InitializeComponent();
        }

        private void logout()
        {
            // empty the back stack
            while (FormLoginMenu.getBackStack().Count > 1)
                FormLoginMenu.getBackStack().Pop();

            FormLoginMenu.getBackStack().Peek().Show();
            this.Hide();
        }

        // selection button - exit - to a new logIn page
        private void selectExit_Click(object sender, EventArgs e)
        {
            logout();
        }

        //static so that it save the color changes in table layout:
        public static FormTableLayout tableLayout = new FormTableLayout();

        //dine-in:
        public static bool dineIn = false; 
        private void main_Button_DineIn_Click(object sender, EventArgs e)
        {
            reserved = false;
            checkIn = false;
            finalizeBill = false;
            takeout = false;

            tableLayout.changeOrderImage();
            tableLayout.setClearBtnbool(true);
            tableLayout.Show();
            this.Hide();

            dineIn = true;

           FormLoginMenu.getBackStack().Push(tableLayout);
        }


        //reserved:
        public static bool reserved = false;
        public void main_Button_Reserved_Click(object sender, EventArgs e)
        {
            //reserved not dineIn, not checkIn
            dineIn = false;
            checkIn = false;
            finalizeBill = false;
            takeout = false;

            tableLayout.changeOrderImage();
            tableLayout.setClearBtnbool(true);
            tableLayout.Show();
            this.Hide();

            reserved = true;

            FormLoginMenu.getBackStack().Push(tableLayout);
        }

        //log-out
        private void main_Button_Exit_Click(object sender, EventArgs e)
        {
            FormLoginMenu logInPage = new FormLoginMenu();
            logInPage.Show();
            this.Hide();  
        }

        //check-in for those reserved:
        public static bool checkIn = false;
        public void main_Button_CheckIn_Click(object sender, EventArgs e)
        {
            reserved = false;
            dineIn = false;
            finalizeBill = false;
            takeout = false;

            tableLayout.changeOrderImage();
            tableLayout.setClearBtnbool(true);
            tableLayout.Show();
            this.Hide();
            
            //turn on checkIn:
            checkIn = true;

            FormLoginMenu.getBackStack().Push(tableLayout);
        }

        public static bool takeout = false;
        private void btnTakeOut_FormFrontPage_Click(object sender, EventArgs e)
        {
            reserved = false;
            dineIn = false;
            finalizeBill = false;

            takeout = true;
            FormOrderPage order = new FormOrderPage();
            FormLoginMenu.getBackStack().Push(order);

            

            order.CreateTabbedPanel();
            order.AddProductsToTabbedPanel();

            order.Show();
            this.Hide();
        }

        private void FormFrontPage_Load(object sender, EventArgs e)
        {
            BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        // restarts the timer when the page is shown
        private void FormFrontPage_Activated(object sender, EventArgs e)
        {
            // timer reset on form show
            FormLoginMenu.timeToNotDuel();
            FormLoginMenu.timeToReduel();
        }

        // stop the timer when the form closes
        private void FormFrontPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLoginMenu.timeToNotDuel();
        }

        //btn Finalize Bill
        public static bool finalizeBill = false;
        private void btnEdit_frontPage_Click(object sender, EventArgs e)
        {
            reserved = false;
            checkIn = false;
            dineIn = false;
            takeout = false;
            finalizeBill = true;

            tableLayout.changeOrderImage();
            tableLayout.setClearBtnbool(false);
            tableLayout.Show();
            this.Hide();
            
            

            FormLoginMenu.getBackStack().Push(tableLayout);
        }


    }
}
