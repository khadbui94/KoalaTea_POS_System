using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoalaTea_Project_Root
{
    public partial class FormTableLayout : Form
    {
        public FormTableLayout()
        {
            InitializeComponent();
        }

        //back to the Main menu page:
        private void Back_button_Click(object sender, EventArgs e)
        {
            //how back function:
            FormLoginMenu.getBackStack().Pop().Hide(); 
            FormLoginMenu.getBackStack().Peek().Show();   
        }

        //array of tables:
        public const int NUMOFTABLES = 10;

        private static int[] tables = new int[NUMOFTABLES];
        private static List<FormOrderPage> nextPages = new List<FormOrderPage>(NUMOFTABLES);

        //current table selected
        private static int[] currentTable = new int[NUMOFTABLES];

        //An Array of control orderbtns
        private List<PictureBox> orderControlList = new List<PictureBox>(10); 
        //private void initializeNextPages()
        //{
        //    for (int i = 0; i < nextPages.Count; i++)
        //    {
        //        nextPages.ElementAt(i) = new FormOrderPage();
        //    }
        //}

        //we need to redo this comment: 
        // Table1-8, Room1-2 function
        /*
         * vacancy is GREEN
         * occupied is RED
         * reserved is BLUE
         * 
         * If click Dine-in from FrontPage, the tables/rooms will turn from GREEN to RED
         *          FrontPage -> Dine-In -> select GREEN tables/rooms -> becomes RED
         * If click to tables/rooms already reserved (BLUE) -> error message box show up
         * If click to tables/rooms second time, confirmation box will show up
         *          yes? will turn from RED TO GREEN
         * If click Reserved from FrontPage, the tables/rooms will turn from GREEN to BLUE
         *          FrontPage -> Reserved -> select GREEN tables/rooms -> becomes BLUE       
         * If click to tables/rooms second time, confirmation box will show up
         *          yes? will turn from BLUE TO GREEN
         * If click to tables/rooms already occupied (RED) -> error message box show up
         * If click Check-in from FrontPage, confirmation pops up
         *          yes? the tables/rooms will turn from BLUE to RED
         *          FrontPage -> Check-in -> select BLUE tables/rooms -> yes -> becomes RED
         * If click to tables/rooms empty (GREEN) -> error message box show up
         * If click to tables/rooms already occupied (RED) -> error message box show up
        */

        //table 1
        //0 for empty
        //1 for reserved
        //2 for dine-in/check-in
        
        private void updateTableStatus(int tableNum, Control tableButton, Control orderButton)
        {
            if (FormFrontPage.reserved)
            {
                if (tables[tableNum] == 1) //unselect reserved table:
                {
                    if (tableSelectionError(2) == true)
                        tables[tableNum] = 0;
                }

                else if (tables[tableNum] == 0) //if table is empty
                    tables[tableNum] = 1; //reserved a table

                else
                    tableSelectionError(0);
            }

            else if (FormFrontPage.checkIn)
            {
                if (tables[tableNum] == 1) //if it's a reserved table:
                {
                    if (tableSelectionError(3))
                        tables[tableNum] = 2;
                }

                else if (tables[tableNum] == 0) //not a reserved table:
                    tableSelectionError(1);

                else
                    tableSelectionError(0);
            }

            else if (FormFrontPage.dineIn)
            {
                if (tables[tableNum] == 2) //unselect a dineIn-already table
                {
                    if (tableSelectionError(2))
                        tables[tableNum] = 0;
                }

                else if (tables[tableNum] == 0) //if table is empty
                    tables[tableNum] = 2; //dine-in; occupied

                else
                    tableSelectionError(0);
            }

            switch (tables[tableNum])
            {
                case 0:
                    tableButton.BackColor = Color.Green;
                    orderButton.Hide();
                    break;
                case 1:
                    tableButton.BackColor = Color.Blue;
                    orderButton.Hide();
                    break;
                case 2:
                    orderButton.Show();
                    tableButton.BackColor = Color.Red;
                    break;

            }
        }

        /**
         *  tableSelectionError() display predefined custom error message dialog
         *  @param int an integer to specify the error message
         *  @return false if user select no/exit
         */
        private bool tableSelectionError(int errorCode)
        {
            // calls the error form and change the title and text accordingly
            FormError errorBox = new FormError();
            bool errorResult = true;

            switch(errorCode)
            {
                case 0:
                    errorBox.changeTitle = "Error";
                    errorBox.changeLabel.Text = "Please select another table or room.";
                    errorBox.changeButtonTwo.Hide();
                    errorBox.ShowDialog();
                    break;
                case 1:
                    errorBox.changeTitle = "Not Reserved";
                    errorBox.changeLabel.Text = "This table/room has not been reserved.";
                    errorBox.changeButtonTwo.Hide();
                    errorBox.ShowDialog();
                    break;
                case 2:
                    errorBox.changeTitle = "Unselect";
                    errorBox.changeLabel.Text = "Are you sure you want to unselect this?";
                    errorBox.changeButtonOne.Text = "Yes";
                    errorBox.changeButtonTwo.Text = "No";
                    errorBox.ShowDialog();
                    if (FormError.getClickResult_FormError())
                        errorResult = true;
                    else
                        errorResult = false;
                    break;
                case 3:
                    errorBox.changeTitle = "Check In?";
                    errorBox.changeLabel.Text = "Are you sure you want to check in?";
                    errorBox.changeButtonOne.Text = "Yes";
                    errorBox.changeButtonTwo.Text = "No";
                    errorBox.ShowDialog();
                    if (FormError.getClickResult_FormError())
                        errorResult = true;
                    else
                        errorResult = false;
                    break;
                case 4:
                    errorBox.changeTitle = "Reservation Only.";
                    errorBox.changeLabel.Text = "You can only make reservation.";
                    errorBox.changeButtonOne.Text = "OK";
                    errorBox.changeButtonTwo.Hide();
                    errorBox.ShowDialog();
                    break;
                default:
                    errorBox.changeTitle = "Error";
                    errorBox.changeLabel.Text = "Oops! Something went wrong.";
                    errorBox.changeButtonTwo.Enabled = false;
                    errorBox.ShowDialog();
                    break;
            }

            return errorResult;
        }

        // sets the current tables status to 1 and the other tables status to zero, in currentTable array
       private void updateCurrentTable(int tableNum)
        {
            //set all other tables to zero
            for (int i = 0; i < NUMOFTABLES; i++)
                currentTable[i] = 0;
           //set current table with marker
            currentTable[tableNum] = 1;
        }

        public void resetTable()
       {
           int index = 0;
           bool found = false;

            while(!found && index < NUMOFTABLES)
            {
                if (currentTable[index] == 1)
                    found = true;
                else
                    index++;
            }


            int num = index + 1;
           foreach (Control myControl in panelTable.Controls)
           {
               if (myControl is Button)
               {
                   if(myControl.TabIndex == index)
                   {
                       myControl.BackColor = Color.Green;
                   }
               }   
               else if (myControl is PictureBox)
               {
                  if ( myControl.Name.Contains("btnOrder" + num.ToString()))
                        myControl.Hide();
               }
           }
            //reset all tables to zero
           for (int i = 0; i < NUMOFTABLES; i++)
               currentTable[i] = 0;

           tables[index] = 0;
             
       }

        private void fillOrderControlList()
        {
            orderControlList.Add(btnOrder1_tableLayout);
            orderControlList.Add(btnOrder2_tableLayout);
            orderControlList.Add(btnOrder3_tableLayout);
            orderControlList.Add(btnOrder4_tableLayout);
            orderControlList.Add(btnOrder5_tableLayout);
            orderControlList.Add(btnOrder6_tableLayout);
            orderControlList.Add(btnOrder7_tableLayout);
            orderControlList.Add(btnOrder8_tableLayout);
            orderControlList.Add(btnOrder9_tableLayout);
            orderControlList.Add(btnOrder10_tableLayout);
        }

        public void changeOrderImage()
        {
            //KoalaTea_Project_Root.Properties.Resources.receiptIcon;
            fillOrderControlList();

            if(FormFrontPage.finalizeBill)
            {
                for (int i = 0; i < NUMOFTABLES; i++)
                {
                    if (tables[i] == 2)
                        orderControlList.ElementAt(i).Image = KoalaTea_Project_Root.Properties.Resources.paymentoption3; 
                }
            }
            else
            {
                 for (int i = 0; i < NUMOFTABLES; i++)
                {
                    if (tables[i] == 2)
                        orderControlList.ElementAt(i).Image =  KoalaTea_Project_Root.Properties.Resources.dining;
                   
                }
            }
           
        }

        public void setClearBtnbool(bool show)
        {
            btnClear_tableLayout.Visible = show;
        }

        private void formFrontPage_Button_Table1_Click(object sender, EventArgs e)
        {
            updateTableStatus(0, btnTable1_tableLayout, btnOrder1_tableLayout);
        }

        //table 2:
        private void formFrontPage_Button_Table2_Click(object sender, EventArgs e)
        {
            updateTableStatus(1, btnTable2_tableLayout, btnOrder2_tableLayout);

        }

        //table 3:
        private void formFrontPage_Button_Table3_Click(object sender, EventArgs e)
        {
            updateTableStatus(2, btnTable3_tableLayout, btnOrder3_tableLayout);
        }


        //table 4
        private void formFrontPage_Button_Table4_Click(object sender, EventArgs e)
        {
            updateTableStatus(3, btnTable4_tableLayout, btnOrder4_tableLayout);
        }

        //table 5:
        private void formFrontPage_Button_Table5_Click(object sender, EventArgs e)
        {
            updateTableStatus(4, btnTable5_tableLayout, btnOrder5_tableLayout);
        }

        //table 6
        private void formFrontPage_Button_Table6_Click(object sender, EventArgs e)
        {
            updateTableStatus(5, btnTable6_tableLayout, btnOrder6_tableLayout);
        }

        //Table7
        private void formFrontPage_Button_Table7_Click(object sender, EventArgs e)
        {
            updateTableStatus(6, btnTable7_tableLayout, btnOrder7_tableLayout); 
        }

        //table 8
        private void formFrontPage_Button_Table8_Click(object sender, EventArgs e)
        {
            updateTableStatus(7, btnTable8_tableLayout, btnOrder8_tableLayout);
        }

        //room 1
        private void formFrontPage_Button_Room1_Click(object sender, EventArgs e)
        {
            updateTableStatus(8, btnRoom1_tableLayout, btnOrder9_tableLayout); 
        }

        //room 2:
        private void formFrontPage_Button_Room2_Click_1(object sender, EventArgs e)
        {
            updateTableStatus(9, btnRoom2_tableLayout, btnOrder10_tableLayout);  
        }

        /*
         * Clear button is to reset everything
         * set every tables to empty (0s)
         * set every tables back to color GREEN
         */

        private void CLEAR_Click(object sender, EventArgs e)
        {
            bool empty = true;

            if(FormFrontPage.finalizeBill)
            {
                FormFrontPage.finalizeBill = false;
                changeOrderImage();
            }

            for (int i = 0; i < tables.Length; i++)
            {
                if (tables[i] != 0)
                    empty = false;
            }

            if (!empty)
            {

                FormError confirmDialog = new FormError();
                confirmDialog.changeLabel.Text = "Are you sure to clear all?\n";

                confirmDialog.changeTitle = "Confirm Delete";
                confirmDialog.changeButtonTwo.Text = "Cancel";
                confirmDialog.ShowDialog();


                if (FormError.getClickResult_FormError())
                {
                    for (int i = 0; i < tables.Length; i++) //reset for empty tables:
                    {
                        if (tables[i] != 0)
                        {
                            tables[i] = 0;

                            if (i == 0)
                            {
                                nextPage1 = new FormOrderPage();
                            }

                            else if (i == 1)
                            {
                                nextPage2 = new FormOrderPage();

                            }

                            else if (i == 2)
                            {
                                nextPage3 = new FormOrderPage();

                            }

                            else if (i == 3)
                            {
                                nextPage4 = new FormOrderPage();

                            }

                            else if (i == 4)
                            {
                                nextPage5 = new FormOrderPage();
                            }

                            else if (i == 5)
                            {
                                nextPage6 = new FormOrderPage();
                            }

                            else if (i == 6)
                            {
                                nextPage7 = new FormOrderPage();

                            }

                            else if (i == 7)
                            {
                                nextPage8 = new FormOrderPage();

                            }

                            else if (i == 8)
                            {
                                nextPage9 = new FormOrderPage();

                            }

                            else if (i == 9)
                            {
                                nextPage10 = new FormOrderPage();

                            }
                        }
                    }

                    foreach (Control myControl in panelTable.Controls)
                    {
                        if (myControl is Button)
                            myControl.BackColor = Color.Green;
                        if (myControl is PictureBox)
                        {
                            myControl.Hide();
                        }
                    }
                }
            }

            else
            {
                FormError confirmDialog = new FormError();
                confirmDialog.changeLabel.Text = "All tables/rooms are empty\n";

                confirmDialog.changeTitle = "OK.";
                confirmDialog.changeButtonTwo.Hide();
                confirmDialog.ShowDialog();
            }

        }

        /*
         * click into the button of order image will lead to order page
         * only dine-in or check in can lead to order page
         */ 

        private static FormOrderPage nextPage1 = new FormOrderPage();
        private static FormPayment paymentPage1 = new FormPayment();
        private void Order1_Click(object sender, EventArgs e)
        {
            updateCurrentTable(0);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage1.CreateTabbedPanel();
                nextPage1.AddProductsToTabbedPanel(); 
                nextPage1.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage1);
                
                
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage1);
                FormLoginMenu.getBackStack().Push(paymentPage1);

                paymentPage1.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private static FormOrderPage nextPage2 = new FormOrderPage();
        private static FormPayment paymentPage2 = new FormPayment();
        private void order2_Click(object sender, EventArgs e)
        {
            updateCurrentTable(1);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage2.CreateTabbedPanel();
                nextPage2.AddProductsToTabbedPanel();
                nextPage2.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage2);
               
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage2);
                FormLoginMenu.getBackStack().Push(paymentPage2);

                paymentPage2.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private static FormOrderPage nextPage3 = new FormOrderPage();
        private static FormPayment paymentPage3 = new FormPayment();
        private void order3_Click(object sender, EventArgs e)
        {
            updateCurrentTable(2);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage3.CreateTabbedPanel();
                nextPage3.AddProductsToTabbedPanel();
                nextPage3.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage3);
                
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage3);
                FormLoginMenu.getBackStack().Push(paymentPage3);

                paymentPage3.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private static FormOrderPage nextPage4 = new FormOrderPage();
        private static FormPayment paymentPage4 = new FormPayment();
        private void order4_Click(object sender, EventArgs e)
        {
            updateCurrentTable(3);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage4.CreateTabbedPanel();
                nextPage4.AddProductsToTabbedPanel();
                nextPage4.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage4);
                
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage4);
                FormLoginMenu.getBackStack().Push(paymentPage4);

                paymentPage4.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private static FormOrderPage nextPage5 = new FormOrderPage();
        private static FormPayment paymentPage5 = new FormPayment();
        private void order5_Click(object sender, EventArgs e)
        {
            updateCurrentTable(4);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage5.CreateTabbedPanel();
                nextPage5.AddProductsToTabbedPanel(); 
                nextPage5.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage5);
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage5);
                FormLoginMenu.getBackStack().Push(paymentPage5);

                paymentPage5.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private static FormOrderPage nextPage6 = new FormOrderPage();
        private static FormPayment paymentPage6 = new FormPayment();
        private void order6_Click(object sender, EventArgs e)
        {
            updateCurrentTable(5);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage6.CreateTabbedPanel();
                nextPage6.AddProductsToTabbedPanel(); 
                nextPage6.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage6);
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage6);
                FormLoginMenu.getBackStack().Push(paymentPage6);

                paymentPage6.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private static FormOrderPage nextPage7 = new FormOrderPage();
        private static FormPayment paymentPage7 = new FormPayment();
        private void order7_Click(object sender, EventArgs e)
        {
            updateCurrentTable(6);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage7.CreateTabbedPanel();
                nextPage7.AddProductsToTabbedPanel(); 
                nextPage7.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage7);
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage7);
                FormLoginMenu.getBackStack().Push(paymentPage7);

                paymentPage7.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private static FormOrderPage nextPage8 = new FormOrderPage();
        private static FormPayment paymentPage8 = new FormPayment();
        private void order8_Click(object sender, EventArgs e)
        {
            updateCurrentTable(7);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage8.CreateTabbedPanel();
                nextPage8.AddProductsToTabbedPanel(); 
                nextPage8.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage8);
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage8);
                FormLoginMenu.getBackStack().Push(paymentPage8);

                paymentPage8.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private static FormOrderPage nextPage9 = new FormOrderPage();
        private static FormPayment paymentPage9 = new FormPayment();
        private void order9_Click(object sender, EventArgs e)
        {
            updateCurrentTable(8);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage9.CreateTabbedPanel();
                nextPage9.AddProductsToTabbedPanel(); 
                nextPage9.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage9);
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage9);
                FormLoginMenu.getBackStack().Push(paymentPage9);

                paymentPage9.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private static FormOrderPage nextPage10 = new FormOrderPage();
        private static FormPayment paymentPage10 = new FormPayment();
        private void order10_Click(object sender, EventArgs e)
        {
            updateCurrentTable(9);

            if (FormFrontPage.dineIn || FormFrontPage.checkIn)
            {
                nextPage10.CreateTabbedPanel();
                nextPage10.AddProductsToTabbedPanel(); 
                nextPage10.Show();
                this.Hide();

                FormLoginMenu.getBackStack().Push(nextPage10);
            }
            else if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage10);
                FormLoginMenu.getBackStack().Push(paymentPage10);

                paymentPage10.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }

        private void FormTableLayoutDineIn_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FormTableLayoutDineIn_Activated(object sender, EventArgs e)
        {
            // start the timer when form loads
            FormLoginMenu.timeToReduel();
        }

        private void FormTableLayoutDineIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stop the timer on form change
            FormLoginMenu.timeToNotDuel();
        }

        private void btnOrder1_receipt_tableLayout_Click(object sender, EventArgs e)
        {
            updateCurrentTable(0);

             if (FormFrontPage.finalizeBill)
            {

                FormLoginMenu.getBackStack().Push(nextPage10);
                FormLoginMenu.getBackStack().Push(paymentPage10);

                paymentPage1.Show();
                this.Hide();
            }
            else
                tableSelectionError(4);
        }
    }
}
