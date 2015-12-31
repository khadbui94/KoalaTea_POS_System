using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoalaTea_Project_Root
{
    public partial class FormReceipt : Form
    {
        public FormReceipt()
        {
            InitializeComponent();
            FormLoginMenu.getBackStack().Pop();
        }

        FormPayment payment = (FormPayment)FormLoginMenu.getBackStack().Peek();

        private void receipt1()
        {

            Graphics graph = pictureBox1.CreateGraphics();

            Font font = new Font("Microsoft Sans Serif", 9);
            Brush brush = new SolidBrush(Color.Black);

            float fontHeight = font.GetHeight();

            int x = 10;
            int y = 10;
            int offset = 15;

            graph.DrawString("KOALA-TEA DIM SUM", font, brush, x + 70, y);
            graph.DrawString("123456 COSTA MESA", font, brush, x + 70, y + fontHeight + 5);
            graph.DrawString("(714) 7777 777", font, brush, x + 85, y + (float)2 * fontHeight + 10);

            graph.DrawString(DateTime.Now.ToString(), font, brush, x, y + 5 * fontHeight + 5);
            graph.DrawString("Server: Zach", font, brush, x + 210, y + 5 * fontHeight + 5);
            graph.DrawString("GST: 3", font, brush, x, y + 6 * fontHeight + 5);
            graph.DrawString("Tbl: 4 ", font, brush, x + 210, y + 6 * fontHeight + 5);
            graph.DrawString("Chk # 1107 ", font, brush, x + 210, y + 7 * fontHeight + 5);
            y += 10* (int)fontHeight + 5;

            if (payment.getFound())
            {
                graph.DrawString("DISCOUNT", font, brush, x + 10, y + offset);
                graph.DrawString(String.Format("{0:#\\%}", payment.getDiscount()), font, brush, x + 210, y + offset);
                y += (int)fontHeight + 5;
            }
            graph.DrawString("SUBTOTAL", font, brush, x + 10, y + offset);
            graph.DrawString(String.Format("{0:c}", payment.calculateSubTotal()), font, brush, x + 210, y + offset);

            graph.DrawString("TAX", font, brush, x + 10, y + offset + fontHeight + 5);
            graph.DrawString(String.Format("{0:c}", payment.calculateTax()), font, brush, x + 210, y + offset + fontHeight + 5);

            graph.DrawString("TOTAL", font, brush, x + 10, y + offset + 2 * fontHeight + 10);
            graph.DrawString(String.Format("{0:c}", payment.calculateTotal()), font, brush, x + 210, y + offset + 2 * fontHeight + 10);

            y = y + offset + (int)fontHeight + 10;

            string cardNumber = payment.getCardNumber();

            graph.DrawString("CASH PAYMENT ", font, brush, x + 10, y + offset + 2 * fontHeight + 10);
            graph.DrawString(String.Format("{0:c}", payment.getGivenAmount() == "" ? "0" : payment.getGivenAmount()), font, brush, x + 210, y + offset + 2 * fontHeight + 10);

            graph.DrawString("CHANGE ", font, brush, x + 10, y + offset + 3 * fontHeight + 20);
            graph.DrawString(String.Format("{0:c}", payment.getChange() == "" ? "0" : payment.getChange()), font, brush, x + 210, y + offset + 3 * fontHeight + 20);

            y += offset + 3 * (int)fontHeight;

            if (cardNumber != "")
            {
                graph.DrawString("CARD HOLDER", font, brush, x + 10, y + offset + 2 * fontHeight + 10);
                graph.DrawString(payment.getCardHolder(), font, brush, x + 175, y + offset + 2 * fontHeight + 10);

                graph.DrawString("CARD NUMBER", font, brush, x + 10, y + offset + 3 * fontHeight + 20);
                graph.DrawString("********-" + cardNumber.Substring(8), font, brush, x + 175, y + offset + 3 * fontHeight + 20);

                y += offset + (int)fontHeight;

                graph.DrawString("TIP", font, brush, x + 10, y + offset + 4 * fontHeight + 10);
                graph.DrawString("$______________________", font, brush, x + 75, y + offset + 4 * fontHeight + 10);

                graph.DrawString("TOTAL", font, brush, x + 10, y + offset + 6 * fontHeight + 20);
                graph.DrawString("$______________________", font, brush, x + 75, y + offset + 6 * fontHeight + 20);

                graph.DrawString("SIGNATURE", font, brush, x + 10, y + offset + 8 * fontHeight + 20);
                graph.DrawString("X________________", font, brush, x + 130, y + offset + 8 * fontHeight + 20);

                y += offset + 8 * (int)fontHeight + 20;
            }

            graph.DrawString("        CUSTOMER/CASHIER COPY!", font, brush, x + 10, y + offset + 3 * fontHeight + 5);
            graph.DrawString("    ==============================", font, brush, x + 8, y + offset + 4 * fontHeight + 5);
        }

        private void receipt2()
        {
            Graphics graph = pictureBox2.CreateGraphics();

            Font font = new Font("Microsoft Sans Serif", 9);
            Brush brush = new SolidBrush(Color.Black);

            float fontHeight = font.GetHeight();
            int x = 10;
            int y = 10;
            int offset = 15;

            graph.DrawString("KOALA-TEA DIM SUM", font, brush, x + 70, y);
            graph.DrawString("123456 COSTA MESA", font, brush, x + 70, y + fontHeight + 5);
            graph.DrawString("(714) 7777 777", font, brush, x + 85, y + (float)2 * fontHeight + 10);

            graph.DrawString(DateTime.Now.ToString(), font, brush, x, y + 5 * fontHeight + 5);
            graph.DrawString("Server: Zach", font, brush, x + 210, y + 5 * fontHeight + 5);
            graph.DrawString("GST: 3", font, brush, x, y + 6 * fontHeight + 5);
            graph.DrawString("Tbl: 4 ", font, brush, x + 210, y + 6 * fontHeight + 5);
            graph.DrawString("Chk # 1107 ", font, brush, x + 210, y + 7 * fontHeight + 5);
            graph.DrawString("TOTAL PRICE ", font, brush, x + 180, y + 8 * fontHeight + 10);

            y += 9 * (int)fontHeight + 5;

            foreach (tblProduct product in payment.products)
            {
                string productDescription = product.Description;
                string productTotal = String.Format("{0:c}", product.Price);

                graph.DrawString(productDescription, font, brush, x + 10, y + offset);
                graph.DrawString(productTotal, font, brush, x + 210, y + offset);

                offset += (int)fontHeight + 5;
            }

            offset += 15;

            if(payment.getFound())
            {
                graph.DrawString("DISCOUNT", font, brush, x + 10, y + offset);
                graph.DrawString(String.Format("{0:#\\%}", payment.getDiscount()), font, brush, x + 210, y + offset);
                y += (int)fontHeight + 5;
            }
            graph.DrawString("SUBTOTAL", font, brush, x + 10, y + offset);
            graph.DrawString(String.Format("{0:c}", payment.calculateSubTotal()), font, brush, x + 210, y + offset);

            graph.DrawString("TAX", font, brush, x + 10, y + offset + fontHeight + 5);
            graph.DrawString(String.Format("{0:c}", payment.calculateTax()), font, brush, x + 210, y + offset + fontHeight + 5);

            graph.DrawString("TOTAL", font, brush, x + 10, y + offset + 2 * fontHeight + 10);
            graph.DrawString(String.Format("{0:c}", payment.calculateTotal()), font, brush, x + 210, y + offset + 2 * fontHeight + 10);

            graph.DrawString("    THANK YOU! PLEASE COME AGAIN!", font, brush, x + 10, y + offset + 5 * fontHeight + 5);
            graph.DrawString("   ==============================", font, brush, x + 8, y + offset + 6 * fontHeight + 5);
        }

        private void resetBackToTableForm()
        {
            FormFrontPage.finalizeBill = false;
            
            //pop FormPayment
            FormLoginMenu.getBackStack().Peek().Hide();
            FormLoginMenu.getBackStack().Pop();

            //Reset FormOrder
            FormOrderPage orderForm;
            FormTableLayout tableLayout;
            orderForm = (FormOrderPage)FormLoginMenu.getBackStack().Peek();
            orderForm.resetFormOrderPage();

            //Reset current table
            FormLoginMenu.getBackStack().Pop();
            tableLayout = (FormTableLayout)FormLoginMenu.getBackStack().Peek();
           // tableLayout.Show();
            tableLayout.changeOrderImage();
            tableLayout.resetTable();

            //Pop to front page
            FormLoginMenu.getBackStack().Pop();
            FormFrontPage frontPage = (FormFrontPage)FormLoginMenu.getBackStack().Peek();
            frontPage.Show();

        }

        private void resetBackToFrontPage()
        {
            //pop FormPayment
            FormLoginMenu.getBackStack().Peek().Hide();
            FormLoginMenu.getBackStack().Pop();

            //Reset FormOrder
            FormOrderPage orderForm;
            orderForm = (FormOrderPage)FormLoginMenu.getBackStack().Peek();
            orderForm.resetFormOrderPage();

            //Pop to front page
            FormLoginMenu.getBackStack().Pop();
            FormFrontPage frontPage = (FormFrontPage)FormLoginMenu.getBackStack().Peek();
            frontPage.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!FormFrontPage.takeout)
                resetBackToTableForm();
            else
                resetBackToFrontPage();

            payment.setDefault();
            payment.resetDiscount();
            payment.resetFound();
            payment.Hide();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            receipt1();
            receipt2();
        }
    }
}
