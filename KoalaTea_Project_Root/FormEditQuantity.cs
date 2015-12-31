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
    public partial class FormEditQuantity : Form
    {
        List<tblProduct> productList = new List<tblProduct>(); 

        public FormEditQuantity()
        {
            InitializeComponent();
        }

        private void FormEditQuantity_Load(object sender, EventArgs e)
        {
            txtQuanity_editQuantity.Select();
            this.BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
        }

        private void addItem_Button_Cancel_Click_1(object sender, EventArgs e)
        {
            //how back function:
            FormLoginMenu.getBackStack().Pop().Hide();
            FormLoginMenu.getBackStack().Peek().Show();

            txtQuanity_editQuantity.Text = ""; 
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtQuanity_editQuantity.Text += btn.Text; 
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuanity_editQuantity.Clear();
        }

        private void addItem_Button_Item_Next_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQuanity_editQuantity.Text) && FormOrderPage.selectedProduct != null)
            {
                Stack<Form> tempStack = new Stack<Form>();

                tempStack.Push(FormLoginMenu.getBackStack().Peek());

                FormLoginMenu.getBackStack().Pop();

                FormOrderPage orderPage = (FormOrderPage)FormLoginMenu.getBackStack().Peek();

                FormLoginMenu.getBackStack().Push(tempStack.Peek());

                tempStack.Pop();

                int num = int.Parse(txtQuanity_editQuantity.Text);

                for (int i = 0; i < num; i++)
                {
                    tblProduct addProduct = FormOrderPage.selectedProduct;
                    productList.Add(addProduct);
                }


          
                    
                    foreach (tblProduct prod in orderPage.products.ToList())
                    {
                        if (prod.Description == FormOrderPage.selectedProduct.Description)
                            orderPage.products.Remove(prod);
                    }

                    for (int i = 0; i < productList.Count; i++)
                        orderPage.products.Add(productList.ElementAt(i));

                    orderPage.subTotalTextChanged(); 

                

                productList.Clear();


            }

            //done -> reset everything back:
            FormOrderPage.selectedProduct = new tblProduct();
            txtQuanity_editQuantity.Clear();
            FormLoginMenu.getBackStack().Pop().Hide();
            FormLoginMenu.getBackStack().Peek().Show();
        
        }

    }
}
