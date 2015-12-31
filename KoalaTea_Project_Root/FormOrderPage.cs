using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoalaTea_Project_Root
{
    public partial class FormOrderPage : Form
    {
        public BindingList<tblProduct> products = new BindingList<tblProduct>();
        public List<tblProduct> productList = new List<tblProduct>();
        DatabaseEntities dbe = new DatabaseEntities();

        public FormOrderPage()
        {
            InitializeComponent();

            listBoxOrderItems.DataSource = products;
            listBoxOrderItems.DisplayMember = "Description";
            listBoxOrderItems.ValueMember = "Price";
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }

        /*
         * From tableLayout to orderPage, click back to back to tableLayout
         * From frontPage to orderPage, click back to back to frontPage
         */

        private void btnBack_FormOrderPage_Click(object sender, EventArgs e)
        {
            //how back function:
            FormLoginMenu.getBackStack().Pop().Hide();
            FormLoginMenu.getBackStack().Peek().Show();

            tbControlItems.Controls.Clear(); 

            textBox_search.Text = "";
        }

        private void FormOrderPage_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void remove_formOrderPage_Click(object sender, EventArgs e)
        {
            //Removes item from listBoxOrderItems
            tblProduct p = new tblProduct();
            p = (tblProduct)listBoxOrderItems.SelectedItem;
            products.Remove(p);

            //updates list after removing
            listBoxOrderItems.Refresh();

            //calculate subTotal and display in textbox again
            calculateSubTotal();
            subTotal_textBox.Text = string.Format("{0:c}", calculateSubTotal());

        }

        private FormEditQuantity editQuan = new FormEditQuantity();
        public static tblProduct selectedProduct = new tblProduct();
        private void quantity_formOrderPage_Click(object sender, EventArgs e)
        {
            if (products.Count != 0)
            {
                selectedProduct = (tblProduct)listBoxOrderItems.SelectedItem;
                FormLoginMenu.getBackStack().Push(editQuan);
                editQuan.ShowDialog();

                listBoxOrderItems.Refresh();
            }

            else
            {
                FormError errorBox = new FormError();
                errorBox.changeTitle = "Error";
                errorBox.changeLabel.Text = "Nothing to edit quantity!";
                errorBox.changeButtonTwo.Hide();
                errorBox.ShowDialog();
            }

        }

        //format how currency prints out
        private void formatList(object sender, ListControlConvertEventArgs e)
        {

            //cast item to products
            string currentDescription = ((tblProduct)e.ListItem).Description;
            //format the price into currency
            string currentPrice = String.Format("{0:c}", ((tblProduct)e.ListItem).Price);
            //pad
            string currentDescriptionPadded = currentDescription.PadRight(25);

            e.Value = currentDescriptionPadded + currentPrice;

        }

        public decimal calculateSubTotal()
        {
            decimal subTotal = 0;
            if (products.Count > 0)
            {
                foreach (tblProduct product in products)
                {
                    subTotal += product.Price;
                }
            }

            return subTotal;
        }

        private void displaySubtotal(object sender, EventArgs e)
        {
            subTotal_textBox.Text = string.Format("{0:c}", calculateSubTotal());
        }

        private void btnAddOneMore_OrderPage_Click(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                //add one item from listBoxOrderItems
                tblProduct p = new tblProduct();
                p = (tblProduct)listBoxOrderItems.SelectedItem;

                //products.Remove(p);
                //products.Add(p);
                products.Add(p);

                //updates list after adding
                listBoxOrderItems.Refresh();

                //calculate subTotal and display in textbox again
                calculateSubTotal();
                subTotal_textBox.Text = string.Format("{0:c}", calculateSubTotal());
            }

        }

        private static FormPayment formPayment = new FormPayment();
        private void btnFinalizePrint_FormOrderPage_Click_1(object sender, EventArgs e)
        {
            FormLoginMenu.getBackStack().Push(formPayment);
            formPayment.Show();
            this.Hide();
        }

        private void btnSelectToAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < productList.Count; i++)
                products.Add(productList.ElementAt(i));
            productList.Clear();
            reset();

            calculateSubTotal();
            subTotal_textBox.Text = string.Format("{0:c}", calculateSubTotal());

            searched = true;
            textBox_search.Text = "";
        }

        FlowLayoutPanel flp = new FlowLayoutPanel();
        public void AddProductsToTabbedPanel()
        {
            //to go to each tab
            int i = 4;

            foreach (TabPage tp in tbControlItems.TabPages)
            {
                var data = from p in dbe.tblProducts where p.CategoryID == i select p;
                var dataList = data.ToList();


                flp = new FlowLayoutPanel();
                flp.Size = new Size(1269, 670); //change it when u resize tab

                foreach (tblProduct tprod in dataList)
                {
                    Button btnProduct = new Button();
                    flp.AutoSize = true;
                    flp.AutoScroll = true;
                    flp.Dock = DockStyle.Fill;


                    flp.Controls.Add(createButton(tprod));
                }

                flp.AutoScroll = true;
                tp.Controls.Add(flp);
                i++;
            }

        }


        public void CreateTabbedPanel()
        {
            foreach (tblCategory category in dbe.tblCategories)
            {
                tbControlItems.TabPages.Add(category.CategoryID.ToString(), category.Description);
            }

            foreach (TabPage tb in tbControlItems.TabPages)
            {
                tb.BackColor = Color.Wheat;
                tb.BorderStyle = BorderStyle.Fixed3D;
            }

        }

        private Button createButton(tblProduct product)
        {
            //desgin button:
            Button btnProduct = new Button();
            btnProduct.Size = new Size(156, 151);
            btnProduct.Text = product.ProductID + "." + product.Description;
            btnProduct.ForeColor = Color.Red;
            btnProduct.TextAlign = ContentAlignment.BottomCenter;
            btnProduct.Font = new Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Bold);
            btnProduct.BackColor = Color.Green;

            //add images
            if (product.Image != null)
            {
                btnProduct.BackgroundImage = byteArrayToImage(product.Image);
                btnProduct.BackgroundImageLayout = ImageLayout.Stretch;
            }

            btnProduct.Tag = product;
            btnProduct.Click += new EventHandler(UpdateProductList);

            return btnProduct;
        }
        void UpdateProductList(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            tblProduct p = (tblProduct)b.Tag;

            if (b.BackColor == Color.Green)
            {
                productList.Add(p);
                b.BackColor = Color.Blue;

                if (p.Image != null && p.selectedImage != null)
                {
                    b.BackgroundImage = byteArrayToImage(p.selectedImage);
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                }

            }

            else
            {
                productList.Remove(p);
                b.BackColor = Color.Green;


                if (p.Image != null)
                {
                    b.BackgroundImage = byteArrayToImage(p.Image);
                    b.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }

        }

        private void FormOrderPage_Activated(object sender, EventArgs e)
        {
            // start the timer when form loads
            FormLoginMenu.timeToReduel();
        }

        private void FormOrderPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // stops the timer on form change
            FormLoginMenu.timeToNotDuel();
        }

        private void reset()
        {
            foreach (TabPage tab in tbControlItems.TabPages)
            {
                foreach (Control myControl in tab.Controls)
                {
                    FlowLayoutPanel flp1 = (FlowLayoutPanel)myControl;

                    foreach (Control ct in flp1.Controls)
                    {
                        if (ct is Button)
                        {
                            ct.BackColor = Color.Green;

                            tblProduct p = (tblProduct)ct.Tag;

                            if(p.Image != null)
                                ct.BackgroundImage = (byteArrayToImage(p.Image));
                        }
                    }

                }

            }


        }

        private void btnUnselctAll_Click(object sender, EventArgs e)
        {
            reset();
            productList.Clear(); 
        }

        private bool searched = false;
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text != "")
            {
                TabPage searchTab = new TabPage();
                string search = textBox_search.Text.ToLower(); ;

                bool found = dbe.tblProducts.Any(p => p.ProductID.ToString() == search || p.Description.ToLower() == search ||
                                           p.Description.ToLower().StartsWith(search)
                                           || (search.Length >= 3 && p.Description.ToLower().Contains(search)));

                if (found)
                {
                    searched = true;
                    flp = new FlowLayoutPanel();
                    flp.Size = new Size(1269, 669); // resize when change sizing

                    flp.AutoSize = true;
                    flp.AutoScroll = true;
                    flp.Dock = DockStyle.Fill;

                    List<tblProduct> list = dbe.tblProducts.Where(p => p.ProductID.ToString() == search || 
                                            p.Description.ToLower() == search ||
                                           p.Description.ToLower().StartsWith(search)
                                           || (search.Length >= 3 && p.Description.ToLower().Contains(search))).ToList();

                    foreach (tblProduct product in list)
                        flp.Controls.Add(createButton(product));

                    //showing the searching result:
                    searchTab.Controls.Add(flp);
                    tbControlItems.Controls.Clear();
                    tbControlItems.Controls.Add(searchTab);
                }

                if (!found)
                {
                    FormError errorBox = new FormError();
                    errorBox.changeTitle = "Error";
                    errorBox.changeLabel.Text = "Cannot find the product.";
                    errorBox.changeButtonTwo.Hide();
                    errorBox.ShowDialog();
                    textBox_search.Text = "";
                }
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (textBox_search.Text == "" && searched)
            {
                tbControlItems.Controls.Clear();
                //create tab panel
                CreateTabbedPanel();

                //add products to tab panel && add items to list
                AddProductsToTabbedPanel();
            }
        }

        private void textBox_search_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(textBox_search, this);
            keyboard.ShowDialog();
        }


        public void subTotalTextChanged()
        {
            subTotal_textBox.Text = string.Format("{0:c}", calculateSubTotal());
        }

        public void resetFormOrderPage()
        {
            products.Clear();
            calculateSubTotal();
            reset();
            
            //fix for multiple tab on order page
            tbControlItems.Controls.Clear();
        }
    }
}
