using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KoalaTea_Project_Root.Admin
{
    public partial class FormAddItems : Form
    {

        private Byte[] picCateogry;
        private Byte[] picProduct;
        private Byte[] picProductSelected;

        DatabaseEntities dbe = new DatabaseEntities(); 
 
        public FormAddItems()
        {
            InitializeComponent();
            display();
            txtCategoryName_EditItems.Text = "";
            txtProductName_EditItems.Text = "";
            txtProductPrice_EditItems.Text = "";

        }

        private void loadBackGround(object sender, EventArgs e)
        {
            this.BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void open(PictureBox pictureBox1)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif|JPNs|*.jpn|PNGs|*.png";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                }
            }
            catch { }
        }

        private void cleanAll(GroupBox gb)
        {
            foreach (Control myControl in gb.Controls)
            {
                if (myControl is TextBox)
                    myControl.Text = "";
            }
        }

        private void btnUIploadCategoryImage_EditItems_Click(object sender, EventArgs e)
        {
            open(pbCategoryImage_EditItems);
        }

        private void btnUploadProductImage_EditItems_Click(object sender, EventArgs e)
        {
            open(pbProductImage_EditItems);
        }

        private void bntUploadSelectedProd_Click(object sender, EventArgs e)
        {
            open(pbSelectedProduct);
        }

        private void btnAddProduct_EditItems_Click(object sender, EventArgs e)
        {
            tblProduct newProd = new tblProduct(); 
            if (pbProductImage_EditItems.Image != null) 
            //get image
            {
                MemoryStream ms = new MemoryStream();
                //MemoryStream ms1 = new MemoryStream();
                pbProductImage_EditItems.Image.Save(ms, pbProductImage_EditItems.Image.RawFormat);
                //pbSelectedProduct.Image.Save(ms1, pbSelectedProduct.Image.RawFormat);
                picProduct = ms.GetBuffer();
                //picProductSelected = ms1.GetBuffer();
                ms.Close();
                //ms1.Close();
                //cmd.Parameters.AddWithValue("@picture", picProduct);

                newProd.Image = picProduct; 
            }

           if (pbSelectedProduct.Image != null)
           {
               MemoryStream ms = new MemoryStream();
               //MemoryStream ms1 = new MemoryStream();
               //pbProductImage_EditItems.Image.Save(ms, pbProductImage_EditItems.Image.RawFormat);
               pbSelectedProduct.Image.Save(ms, pbSelectedProduct.Image.RawFormat);
               // = ms.GetBuffer();
               picProductSelected = ms.GetBuffer();
               ms.Close();
               //ms1.Close();
               //cmd.Parameters.AddWithValue("@picture1", picProductSelected);

               newProd.selectedImage = picProductSelected;
           }

             //get categoryID 
           int ID = (int)cmbSelectCategoryAddProduct_EditItems.SelectedValue;

           if (txtProductName_EditItems.Text != "" && txtProductPrice_EditItems.Text != "")
           {
               string description = txtProductName_EditItems.Text;
               decimal price = decimal.Parse(txtProductPrice_EditItems.Text);
               newProd.Description = description;
               newProd.CategoryID = ID;
               newProd.Price = price;


               dbe.tblProducts.Add(newProd);
               dbe.SaveChanges();
               display();
               //FormOrderPage orderpage = new FormOrderPage();
               //orderpage.AddProductsToTabbedPanel(); 

               //MessageBox.Show("Product Saved");
               FormError successMessage = new FormError();
               successMessage.changeButtonTwo.Hide();
               successMessage.changeTitle = "Saved";
               successMessage.changeLabel.Text = "Product Saved";
               successMessage.ShowDialog();
           }
           else
           {
               FormError msg = new FormError();
               msg.changeButtonTwo.Hide();
               msg.changeLabel.Text = "Missing Information. Cannot Add.";
               msg.ShowDialog();

           }

           // after saving category, reset fields:
           cleanAll(gbAddProduct);
           pbProductImage_EditItems.Image = null;
           pbSelectedProduct.Image = null;

        }

        private void btnAddCategory_EditItems_Click(object sender, EventArgs e)
        {
            tblCategory category = new tblCategory();

            if (pbCategoryImage_EditItems.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pbCategoryImage_EditItems.Image.Save(ms, pbCategoryImage_EditItems.Image.RawFormat);
                picCateogry = ms.GetBuffer();
                ms.Close();
                category.CategoryImage = picCateogry;

            }

                //cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@picture", picCateogry);
                //cmd.CommandText = "insert into tblCategory (Description, CategoryImage) values ('" + txtCategoryName_EditItems.Text.ToString() + "', @picture)";
                //cn.Open();
                //cmd.ExecuteNonQuery();
                //cn.Close();

            if (txtCategoryName_EditItems.Text != "")
            {
                category.Description = txtCategoryName_EditItems.Text.ToString();
                dbe.tblCategories.Add(category);
                dbe.SaveChanges();
                display();
          
                FormError msg = new FormError();
                msg.changeButtonTwo.Hide();
                msg.changeLabel.Text = "Category Saved";
                 msg.ShowDialog();
            }

            else
            {
                FormError msg = new FormError();
                msg.changeButtonTwo.Hide();
                msg.changeLabel.Text = "Missing Information. Cannot Add.";
                msg.ShowDialog();

            }

              //after saving category, reset fields:
            cleanAll(gbAddCategory_EditItems);
            pbCategoryImage_EditItems.Image = null;
                

        
        }

        //filter to see what products in each category
        private void cmbFilterCategory_EditItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //selected filter to see items
  
            var data = from p in FormAdminFrontPage.dbe.tblProducts
                       where p.CategoryID == (int)cmbFilterCategory_EditItems.SelectedValue
                       select p;

            dataGridViewTblProducts.DataSource = data.ToList(); 
        }

        private void btnBack_EditItems_Click(object sender, EventArgs e)
        {

            FormAdminFrontPage admin = new FormAdminFrontPage();
            admin.Show();
            this.Hide(); 
        }

        private void btnViewAllProducts_EditItems_Click(object sender, EventArgs e)
        {
            var data = from p in FormAdminFrontPage.dbe.tblProducts select p;

            dataGridViewTblProducts.DataSource = data.ToList(); 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            display();
        }

        private void display()
        {
            DatabaseEntities db = new DatabaseEntities();

            cmbFilterCategory_EditItems.DataSource = db.tblCategories.ToList();
            cmbFilterCategory_EditItems.DisplayMember = "Description";
            cmbFilterCategory_EditItems.ValueMember = "CategoryID";

            cmbSelectCategoryAddProduct_EditItems.DataSource = db.tblCategories.ToList();
            cmbSelectCategoryAddProduct_EditItems.DisplayMember = "Description";
            cmbSelectCategoryAddProduct_EditItems.ValueMember = "CategoryID";

            dataGridViewTblProducts.DataSource = db.tblProducts.ToList();

            dataGridViewTblProducts.Columns["Price"].DefaultCellStyle.Format = "c";
            dataGridViewTblProducts.Columns["tblTransactionItems"].Visible = false;
            dataGridViewTblProducts.Columns["tblCategory"].Visible = false;
            dataGridViewTblProducts.Columns["CategoryID"].Visible = false;
            dataGridViewTblProducts.Columns["selectedImage"].Visible = false;

            // change the font properties of the data grid
            foreach (DataGridViewColumn c in dataGridViewTblProducts.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
            }

            txtCategoryName_EditItems.Text = "";
            txtProductName_EditItems.Text = "";
            txtProductPrice_EditItems.Text = "";

        }

        private void txtCategoryName_EditItems_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txtCategoryName_EditItems);
            keyboard.ShowDialog();
        }

        private void txtProductName_EditItems_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txtProductName_EditItems);
            keyboard.ShowDialog();
        }

        private void txtProductPrice_EditItems_Click(object sender, EventArgs e)
        {
            FormCalculator numpad = new FormCalculator(txtProductPrice_EditItems);
            numpad.ShowDialog();
        }

        private void FormAddItems_Activated(object sender, EventArgs e)
        {
            FormLoginMenu.timeToReduel();
        }

        private void FormAddItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLoginMenu.timeToNotDuel();
        }

      
      
    }
}
