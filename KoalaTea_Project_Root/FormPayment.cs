using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoalaTea_Project_Root
{
    public partial class FormPayment : Form
    {
        DatabaseEntities dbe = new DatabaseEntities();

        public BindingList<tblProduct> products = new BindingList<tblProduct>();

        private const decimal TAX = (decimal)0.08;

        public FormPayment()
        {
            InitializeComponent();

            listOrders.DataSource = products;
            listOrders.DisplayMember = "Description";
            listOrders.ValueMember = "Price";

            products.Clear();
        }

        private FormOrderPage getFormOrder()
        {
            Stack<Form> tempStack = new Stack<Form>();

            tempStack.Push(FormLoginMenu.getBackStack().Peek());

            FormLoginMenu.getBackStack().Pop();

            FormOrderPage orderPage = (FormOrderPage)FormLoginMenu.getBackStack().Peek();

            FormLoginMenu.getBackStack().Push(tempStack.Peek());

            tempStack.Pop();

            return orderPage;
        }

        private void copyProduct()
        {
            FormOrderPage orderPage = getFormOrder();

            if (orderPage.products.Count > 0)
            {
                foreach (tblProduct product in orderPage.products.ToList())
                {
                    products.Add(product);
                }
            }

        }


        public decimal calculateSubTotal()
        {
            decimal subTotal = getSubtotal();

            if (found)
                return subTotal - subTotal * discount / 100;

            return subTotal;
        }

        public decimal calculateTax()
        {
            decimal tax = calculateSubTotal() * TAX;

            return tax;
        }

        public decimal calculateTotal()
        {
            decimal total = calculateTax() + calculateSubTotal();

            return total;
        }


        private void txbTax_VisibleChanged(object sender, EventArgs e)
        {
            txbTax.Text = String.Format("{0:c}", calculateTax());
        }

        private void txbTotal_VisibleChanged(object sender, EventArgs e)
        {
            txbTotal.Text = string.Format("{0:c}", calculateTotal());
        }


        private void FormPayment_Activated(object sender, EventArgs e)
        {
            // start the timer when form loads
            convertToCash();
            FormLoginMenu.timeToReduel();
        }

        private void FormPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stop timer on form change
            FormLoginMenu.timeToNotDuel();
        }

        // error messages
        private void errorMessage(int errorCode)
        {
            FormError paymentError = new FormError();
            switch (errorCode)
            {
                case 0:

                    paymentError.changeLabel.Text = "Please enter a payment amount.";
                    paymentError.changeTitle = "Payment Error";
                    paymentError.changeButtonTwo.Hide();
                    break;
                case 1:
                    // successful payment
                    paymentError.changeLabel.Text = "Transaction Completed.";
                    paymentError.changeTitle = "Successful Payment";
                    paymentError.changeButtonTwo.Hide();
                    break;
                case 2:
                    // added 4/18
                    paymentError.changeLabel.Text = "Not enough to calculate change.";
                    paymentError.changeTitle = "Calculation Error";
                    paymentError.changeButtonTwo.Hide();
                    break;
                case 3:
                    // added 4/19
                    paymentError.changeLabel.Text = "Card Information not filled completely.";
                    paymentError.changeTitle = "Card Error";
                    paymentError.changeButtonTwo.Hide();
                    break;
                case 4:
                    paymentError.changeLabel.Text = "Invalid Card Number";
                    paymentError.changeTitle = "Card Error";
                    paymentError.changeButtonTwo.Hide();
                    break;
                case 5:
                    paymentError.changeLabel.Text = "Invalid CCV";
                    paymentError.changeTitle = "Card Error";
                    paymentError.changeButtonTwo.Hide();
                    break;
            }
            paymentError.ShowDialog();
        }

        // convert cashGiven to $$$
        private void convertToCash()
        {
            try
            {
                givenAmount = decimal.Parse(txbCashGiven.Text);
                txbCashGiven.Text = String.Format("{0:c}", givenAmount);
            }
            catch
            {
            }
        }

        private decimal givenAmount = 0;
        public decimal calculateChange()
        {
            decimal change = calculateTotal() < givenAmount ? givenAmount - calculateTotal() : 0;

            return change;
        }

        // boolean value tracks if change button is clicked
        private bool change = false;

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            if (txbCashGiven.Text == "")
            {
                errorMessage(0);
                return;
            }
            else
            {
                convertToCash();
                saveTransaction();
                if (givenAmount >= calculateTotal())
                {
                    txbChange.Text = string.Format("{0:c}", calculateChange());

                    FormReceipt nextPage = new FormReceipt();
                    FormLoginMenu.getBackStack().Push(nextPage);
                    nextPage.ShowDialog();
                }

            
                givenAmount = 0;
            }
        }

        private void txbSubTotal_VisibleChanged(object sender, EventArgs e)
        {
            txbSubTotal.Text = String.Format("{0:c}", calculateSubTotal());
        }

        private void listBoxOrderItems_payment_VisibleChanged(object sender, EventArgs e)
        {
            copyProduct();
        }

        private void listBoxOrderItems_payment_Format(object sender, ListControlConvertEventArgs e)
        {

            //cast item to products
            string currentDescription = ((tblProduct)e.ListItem).Description;
            //format the price into currency
            string currentPrice = String.Format("{0:c}", ((tblProduct)e.ListItem).Price);
            //pad
            string currentDescriptionPadded = currentDescription.PadRight(30);

            e.Value = currentDescriptionPadded + currentPrice;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (FormFrontPage.finalizeBill)
            {
                FormLoginMenu.getBackStack().Pop().Hide();
                FormLoginMenu.getBackStack().Pop().Hide();
                FormLoginMenu.getBackStack().Peek().Show();
            }
            else
            {
                FormLoginMenu.getBackStack().Pop().Hide();
                FormLoginMenu.getBackStack().Peek().Show();
            }
            products.Clear();
            givenAmount = 0;
            txbCashGiven.Clear();
            txbChange.Clear();
        }

        private decimal getSubtotal()
        {
            return getFormOrder().calculateSubTotal();
        }

        private void FormPayment_Shown(object sender, EventArgs e)
        {
            // set background image
            BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void txbCCV_Click(object sender, EventArgs e)
        {
            FormCalculator calculator = new FormCalculator(txbCCV);
            calculator.ShowDialog();
        }

        private void txbCardNumber_Click(object sender, EventArgs e)
        {
            FormCalculator calculator = new FormCalculator(txbCardNumber);
            calculator.ShowDialog();
        }

        private void txbCashGiven_Click(object sender, EventArgs e)
        {
            FormCalculator calculator = new FormCalculator(txbCashGiven);
            calculator.ShowDialog();
        }

        private decimal calculateBalance()
        {

            decimal balance = change ? (givenAmount > calculateTotal() ? 0 : calculateTotal()) : calculateTotal() - givenAmount;

            return balance;
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            if (txb_CardHolder.Text == "" || txbCardNumber.Text == "" || txbCCV.Text == "")
            {
                errorMessage(3);
                return;
            }
            else
            {
                if (txbCardNumber.Text.Length < 12)
                {
                    txbCardNumber.Clear();
                    txbCCV.Clear();
                    errorMessage(4);
                }

                else if (txbCCV.Text.Length < 3)
                {
                    txbCardNumber.Clear();
                    txbCCV.Clear();
                    errorMessage(5);
                }

                else
                {
                    saveTransaction();

                    FormReceipt nextPage = new FormReceipt();
                    FormLoginMenu.getBackStack().Push(nextPage);
                    nextPage.ShowDialog();

                   
                    givenAmount = 0;
                }
            }
        }

        private void txtBalance_VisibleChange(object sender, EventArgs e)
        {
            txb_Balance.Text = String.Format("{0:c}", calculateBalance());
        }

        private void txb_CardHolder_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txb_CardHolder);
            keyboard.ShowDialog();
        }

        private void saveTransaction()
        {
            tblTransaction transaction = new tblTransaction();
            transaction.TransactionDate = DateTime.Now;

            if (products.Count > 0)
                foreach (tblProduct product in products.ToList())
                    transaction.tblTransactionItems.Add(new tblTransactionItem() { ProductID = product.ProductID });

            dbe.tblTransactions.Add(transaction);
            dbe.SaveChanges();
        }

        public void setDefault()
        {
            txbChange.Clear();
            txbSubTotal.Text = String.Format("{0:c}", 0);
            txbTotal.Text = String.Format("{0:c}", 0);
            txbTax.Text = String.Format("{0:c}", 0);
            txbCashGiven.Clear();
            txb_CardHolder.Clear();
            txbCardNumber.Clear();
            txbCCV.Clear();
            txb_Balance.Text = String.Format("{0:c}", 0);
            products.Clear();
        }
        public bool getFound()
        {
            return this.found;
        }
        public void resetFound()
        {
            found = false;
        }
        public int getDiscount()
        {
            return discount;
        }
        public void resetDiscount()
        {
            discount = 0;
        }
        public string getChange()
        {
            return txbChange.Text;
        }
        public string getGivenAmount()
        {
            return txbCashGiven.Text;
        }

        public string getCardHolder()
        {
            return txb_CardHolder.Text;
        }

        public string getCardNumber()
        {
            return txbCardNumber.Text;
        }

        public string getSubTotal()
        {
            return txbSubTotal.Text;
        }

        public string getTax()
        {
            return txbTax.Text;
        }

        public string getTotal()
        {
            return txbTotal.Text;
        }
        bool found;
        int discount = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtBoxPromoCode.Text != "")
            {
                found = dbe.tblPromotions.Any(p => p.PromoCode.ToString() == txtBoxPromoCode.Text);

                if (found)
                {
                    tblPromotion promo = dbe.tblPromotions.First(p => p.PromoCode == txtBoxPromoCode.Text);
                    discount = promo.Discount;

                    txbTax.Text = string.Format("{0:c}", calculateTax());
                    txbSubTotal.Text = string.Format("{0:c}", calculateSubTotal());
                    txbTotal.Text = string.Format("{0:c}", calculateTotal());
                    txb_Balance.Text = string.Format("{0:c}", calculateBalance());

                    // removes the promotion code used from the database
                    dbe.tblPromotions.Remove(promo);

                    dbe.SaveChanges();

                    FormError error = new FormError();
                    error.changeTitle = "Successful.";
                    error.changeLabel.Text = "Successful!";
                    error.changeButtonTwo.Hide();
                    error.ShowDialog();
                }

                else
                {
                    FormError error = new FormError();
                    error.changeTitle = "Error.";
                    error.changeLabel.Text = "Invalid Promotional Code!";
                    error.changeButtonTwo.Hide();
                    error.ShowDialog();
                }

                txtBoxPromoCode.Text = "";
            }

        }

        private void txtBoxPromoCode_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txtBoxPromoCode, btnSubmit);
            keyboard.ShowDialog();
        }

        private void txbCashGiven_TextChanged(object sender, EventArgs e)
        {
            if (txbCashGiven.Text != "")
            {
                if (givenAmount >= calculateTotal())
                {
                    convertToCash();
                    change = true;
                    txbChange.Text = string.Format("{0:c}", calculateChange());
                }

                txb_Balance.Text = String.Format("{0:c}", calculateBalance());
            }
        }
    }
}
