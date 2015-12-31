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
    public partial class FormEditItems : Form
    {
        DatabaseEntities dbe = new DatabaseEntities(); 
        public FormEditItems()
        {
           
            InitializeComponent();

            cmbFilterCategory.DataSource = dbe.tblCategories.ToList();
            cmbFilterCategory.DisplayMember = "Description";
            cmbFilterCategory.ValueMember = "CategoryID";

            dataGridViewTblProducts.DataSource = dbe.tblProducts.ToList();

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
        }

        private void tblProductBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblProductBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void EditDeleteItems_Load(object sender, EventArgs e)
        {

            this.BackgroundImage = KoalaTea_Project_Root.Properties.Resources.main_background_1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTblProducts.Rows.Count != 0)
            {
                FormError confirmDialog = new FormError();
                confirmDialog.changeLabel.Text = "Delete this product?\n"
                    + dataGridViewTblProducts.CurrentRow.Cells[0].Value + "."
                    + dataGridViewTblProducts.CurrentRow.Cells[2].Value;

                confirmDialog.changeTitle = "Confirm Delete";
                confirmDialog.changeButtonTwo.Text = "Cancel";
                confirmDialog.ShowDialog();


                if (FormError.getClickResult_FormError())
                {
                    int remove = (int)dataGridViewTblProducts.CurrentRow.Cells[0].Value;

                    tblProduct product = dbe.tblProducts.First(p => p.ProductID == remove);

                    dbe.tblProducts.Remove(product);
                    dbe.SaveChanges();

                    dataGridViewTblProducts.DataSource = dbe.tblProducts.ToList();
                    FormError successMessage = new FormError();
                    successMessage.changeButtonTwo.Hide();
                    successMessage.changeTitle = "Deleted";
                    successMessage.changeLabel.Text = "Product Deleted";
                    successMessage.ShowDialog();
                }
            }
                txtBoxSearch.Text = "";
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           (new FormAdminFrontPage()).Show();
            this.Hide(); 
        }

        private void cmbFilterCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //selected filter to see items

            var data = from p in dbe.tblProducts
                       where p.CategoryID == (int)cmbFilterCategory.SelectedValue
                       select p;


            dataGridViewTblProducts.DataSource = data.ToList(); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtBoxSearch.Text != "")
            {
                string searchText = txtBoxSearch.Text.ToLower();

                List<tblProduct> list = dbe.tblProducts.Where(p => p.ProductID.ToString() == searchText 
                        || p.Description.ToLower() == searchText ||
                        p.Description.ToLower().StartsWith(searchText)
                        || (searchText.Length >= 3 && p.Description.ToLower().Contains(searchText))).ToList();

                if(list.Count == 0)
                {
                    FormError successMessage = new FormError();
                    successMessage.changeButtonTwo.Hide();
                    successMessage.changeTitle = "Error";
                    successMessage.changeLabel.Text = "Cannot found the product";
                    successMessage.ShowDialog();
                }

                else
                    dataGridViewTblProducts.DataSource = list; 

            }
        }

        private void txtBoxSearch_VisibleChanged(object sender, EventArgs e)
        {
            if(txtBoxSearch.Text == "")
            {
                dataGridViewTblProducts.DataSource = dbe.tblProducts.ToList(); 
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "")
            {
                dataGridViewTblProducts.DataSource = dbe.tblProducts.ToList();
            }   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int change = (int)dataGridViewTblProducts.CurrentRow.Cells[0].Value;
            bool found = false;
            if(txtBoxDescription.Text != "")
            {
                tblProduct product = dbe.tblProducts.First(p => p.ProductID == change);
                product.Description = txtBoxDescription.Text;
                dbe.SaveChanges();
                found = true; 
            }

            if(txtBoxPrice.Text != "")
            {
                decimal price = decimal.Parse(txtBoxPrice.Text);
                tblProduct product = dbe.tblProducts.First(p => p.ProductID == change);
                product.Price = price;
                dbe.SaveChanges();
                found = true;
            }

            if(found)
            {
                FormError successMessage = new FormError();
                successMessage.changeButtonTwo.Hide();
                successMessage.changeTitle = "Saved";
                successMessage.changeLabel.Text = "Saved change(s)";
                successMessage.ShowDialog();
            }

            else
            {
                FormError successMessage = new FormError();
                successMessage.changeButtonTwo.Hide();
                successMessage.changeTitle = "Error";
                successMessage.changeLabel.Text = "Nothing to save.";
                successMessage.ShowDialog();

            }

            clearAll(); 

        }

        private void clearAll()
        {
            txtBoxSearch.Text = "";
            txtBoxDescription.Text = "";
            txtBoxPrice.Text = ""; 
        }

        private void txtBoxSearch_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txtBoxSearch, this);
            keyboard.ShowDialog();
        }

        private void txtBoxDescription_Click(object sender, EventArgs e)
        {
            showKeyboard(txtBoxDescription);
        }

        private void showKeyboard(TextBox sender)
        {
            FormKeyboard keyboard = new FormKeyboard(sender);
            keyboard.ShowDialog();
        }

        private void txtBoxPrice_Click(object sender, EventArgs e)
        {
            FormCalculator numpad = new FormCalculator(txtBoxPrice);
            numpad.ShowDialog();
        }

        private void FormEditItems_Activated(object sender, EventArgs e)
        {
            FormLoginMenu.timeToReduel();
        }

        private void FormEditItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLoginMenu.timeToNotDuel();
        }
    }
}
