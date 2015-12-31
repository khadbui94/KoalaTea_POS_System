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
    public partial class FormSelectItemsToAdd : Form
    {
        private DatabaseEntities dbe = new DatabaseEntities();
        private List<tblProduct> productList = new List<tblProduct>();

        public FormSelectItemsToAdd()
        {
            InitializeComponent();
            //create tab panel
            CreateTabbedPanel();

            //add products to tab panel && add items to list
            AddProductsToTabbedPanel(); 

        }
  
        private void AddProductsToTabbedPanel()
        {  
            //to go to each tab
            int i = 1;

            foreach(TabPage tp in tbControlItems_addItems.TabPages)
            {
                var data = from p in dbe.tblProducts where p.CategoryID == i select p;
                var dataList = data.ToList();


                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Size = new Size(1269, 669);

                foreach(tblProduct tprod in dataList)
                {
                    Button btnProduct = new Button();
                    btnProduct.Size = new Size(160, 160);
                    btnProduct.Text = tprod.Description;
                    btnProduct.BackColor = Color.Green;

                    btnProduct.Tag = tprod;
                    btnProduct.Click += new EventHandler(UpdateProductList); 

                    flp.Controls.Add(btnProduct);
                }

                flp.AutoScroll = true; 
                tp.Controls.Add(flp);
                i++; 
            }

        }

        void UpdateProductList(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            tblProduct p = (tblProduct)b.Tag;

            if(b.BackColor == Color.Green)
            {
                productList.Add(p);
                b.BackColor = Color.Blue;
             
            }

            else
            {
                productList.Remove(p);
                b.BackColor = Color.Green; 
            }

        }

        private void CreateTabbedPanel()
        {
            foreach(tblCategory category in dbe.tblCategories)
            {
                tbControlItems_addItems.TabPages.Add(category.CategoryID.ToString(), category.Description);
            }

            foreach (TabPage tb in tbControlItems_addItems.TabPages)
            {
                tb.BackColor = Color.Wheat;
                tb.BorderStyle = BorderStyle.Fixed3D;
            }
            
        }

        private void FormAddItem_Load(object sender, EventArgs e)
        {
            BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void addItem_Button_Cancel_Click(object sender, EventArgs e)
        {
            //how back function:
            FormLoginMenu.getBackStack().Pop().Hide();
            FormLoginMenu.getBackStack().Peek().Show();

            resetButtonToGreen(); 
        }


        private void btn_add_FormAddItem_Click(object sender, EventArgs e)
        {
            if (productList.Count > 0)
            {
                Stack<Form> tempStack = new Stack<Form>();

                tempStack.Push(FormLoginMenu.getBackStack().Peek());

                FormLoginMenu.getBackStack().Pop();

                FormOrderPage orderPage = (FormOrderPage)FormLoginMenu.getBackStack().Peek();

                FormLoginMenu.getBackStack().Push(tempStack.Peek());

                tempStack.Pop();

                resetButtonToGreen();

                //Add items to FormOrderPage.products so that they can be displayed on orderList
                for (int i = 0; i < productList.Count; i++)
                    orderPage.products.Add(productList.ElementAt(i));
                productList.Clear();
            }

            FormLoginMenu.getBackStack().Pop().Hide();
            FormLoginMenu.getBackStack().Peek().Show();
        }

        //reset all button after clicking button cancel or add 
        private void resetButtonToGreen()
        {
           foreach(TabPage tab in tbControlItems_addItems.TabPages)
           {
               foreach(Control myControl in tab.Controls)
               {
                   FlowLayoutPanel flp = (FlowLayoutPanel)myControl; 

                   foreach(Control ct in flp.Controls)
                   {
                       if (ct is Button)
                           ct.BackColor = Color.Green; 
                   }                   

               }

           }
         
        }

        // timer restart when form is activated
        private void FormAddItem_Activated(object sender, EventArgs e)
        {
            FormLoginMenu.timeToDuel();
            FormLoginMenu.timeToReduel();
        }

        // stop timer on form change
        private void FormAddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLoginMenu.timeToNotDuel();
        }

        private void textBox_search_FormAddItem_Click(object sender, EventArgs e)
        {
            // highlight the text on click
            textBox_search_FormAddItem.SelectAll();
        }



    }
}
