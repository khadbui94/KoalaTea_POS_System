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
    public partial class FormAddEditPromoCode : Form
    {
        DatabaseEntities dbe = new DatabaseEntities(); 
        public FormAddEditPromoCode()
        {
            InitializeComponent();

            display(); 
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text.Length > 10)
            {
                FormError successMessage = new FormError();
                successMessage.changeButtonTwo.Hide();
                successMessage.changeTitle = "Error";
                successMessage.changeLabel.Text = "Invalid!";
                successMessage.ShowDialog();

                txtBoxSearch.Text = "";

            }
            else
            {
                if (txtBoxSearch.Text != "")
                {
                    string searchText = txtBoxSearch.Text.ToLower();

                    List<tblPromotion> list = dbe.tblPromotions.Where(p => p.ID.ToString() == searchText
                                                || p.PromoCode.ToLower() == searchText
                                                || p.PromoCode.ToLower().StartsWith(searchText)).ToList();


                    if (list.Count == 0)
                    {
                        FormError successMessage = new FormError();
                        successMessage.changeButtonTwo.Hide();
                        successMessage.changeTitle = "Error";
                        successMessage.changeLabel.Text = "Cannot find the promotional code!";
                        successMessage.ShowDialog();

                        txtBoxSearch.Text = "";
                    }

                    else
                        tblPromotionDataGridView.DataSource = list;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxPromoCode.Text != "" && txtBoxDiscount.Text != ""
                && txtBoxPromoCode.Text.Length <= 10 && txtBoxPromoCode.Text.Length >= 5)
            {
                bool foundPromoCode = dbe.tblPromotions.Any(p => p.PromoCode == txtBoxPromoCode.Text);

                int discount = int.Parse(txtBoxDiscount.Text);
                bool matchDiscount = dbe.tblPromotions.Any(p => p.Discount == discount);

                if (!foundPromoCode || (foundPromoCode && matchDiscount))
                {
                    tblPromotion newPromoCode = new tblPromotion();
                    newPromoCode.PromoCode = txtBoxPromoCode.Text;
                    newPromoCode.Discount = int.Parse(txtBoxDiscount.Text);

                    dbe.tblPromotions.Add(newPromoCode);
                    dbe.SaveChanges();

                    FormError successMessage = new FormError();
                    successMessage.changeButtonTwo.Hide();
                    successMessage.changeTitle = "Sucessful";
                    successMessage.changeLabel.Text = "Added sucessfully!";
                    successMessage.ShowDialog();

                    //refresh data
                    display();

                }

                else
                {
                    FormError successMessage = new FormError();
                    successMessage.changeButtonTwo.Hide();
                    successMessage.changeTitle = "Error";
                    successMessage.changeLabel.Text = "The same codes have to \nhave the same discount percentage. \nTry again!";
                    successMessage.ShowDialog();

                }

            }

            else
            {
                if (txtBoxPromoCode.Text.Length < 5 || txtBoxPromoCode.Text.Length > 10)
                {
                    FormError successMessage = new FormError();
                    successMessage.changeButtonTwo.Hide();
                    successMessage.changeTitle = "Error";
                    successMessage.changeLabel.Text = "Invalid Promotional Code.\nCode need to be 5-10 characters.\nTry again!";
                    successMessage.ShowDialog();
                }

                else
                {
                    FormError successMessage = new FormError();
                    successMessage.changeButtonTwo.Hide();
                    successMessage.changeTitle = "Error";
                    successMessage.changeLabel.Text = "Missing Information.\nTry again!";
                    successMessage.ShowDialog();

                }

            }

                //reset:
                txtBoxPromoCode.Clear(); 
                txtBoxDiscount.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormError confirmDialog = new FormError();
            confirmDialog.changeLabel.Text = "Delete this Promotional Code?\n"
                + tblPromotionDataGridView.CurrentRow.Cells[0].Value + "."
                 + tblPromotionDataGridView.CurrentRow.Cells[1].Value;

            confirmDialog.changeTitle = "Confirm Delete";
            confirmDialog.changeButtonTwo.Text = "Cancel";
            confirmDialog.ShowDialog();


            if (FormError.getClickResult_FormError())
            {
                int remove = (int)tblPromotionDataGridView.CurrentRow.Cells[0].Value;

                tblPromotion code = dbe.tblPromotions.First(p => p.ID == remove);

                dbe.tblPromotions.Remove(code);
                dbe.SaveChanges();

                FormError sucessful = new FormError();
                sucessful.changeTitle = "Confirmation.";
                sucessful.changeLabel.Text = "Deleted sucessfully!";
                sucessful.changeButtonTwo.Hide();
                sucessful.changeButtonTwo.Hide();
                sucessful.ShowDialog();


                //refresh data:
                display();

                if (tblPromotionDataGridView.Rows.Count == 0)
                    cmbDiscount.Text = ""; 

            }

            txtBoxSearch.Text = "";
            txtBoxDiscount.Text = ""; 

        }

        private void cmbDiscount_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var data = from p in dbe.tblPromotions
                       where p.Discount == (int)cmbDiscount.SelectedValue
                       select p;
            

            tblPromotionDataGridView.DataSource = data.ToList(); 

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            (new FormAdminFrontPage()).Show();
            this.Hide(); 
        }

        private void display()
        {
            List<tblPromotion> data = new List<tblPromotion>();

            foreach(tblPromotion promo in dbe.tblPromotions)
            {
                data.Add(promo);
            }

            for (int i = 0; i < data.Count(); i++)
            {
                for(int j = i + 1; j < data.Count(); j++)
                {
                    if(data[i].Discount == data[j].Discount)
                    {
                        data.Remove(data[j]);
                    }
                }
            }

            cmbDiscount.DataSource = data;
            cmbDiscount.DisplayMember = "Discount";
            cmbDiscount.ValueMember = "Discount";
       
            tblPromotionDataGridView.DataSource = dbe.tblPromotions.ToList();
            tblPromotionDataGridView.Columns["Discount"].DefaultCellStyle.Format = "0\\%";
            // change the font properties of the data grid
            foreach (DataGridViewColumn c in tblPromotionDataGridView.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
            }

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            display(); 
        }

        private void FormAddEditPromoCode_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.main_background_1; 
        }

        private void comboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            string comboDisplay = ((tblPromotion)e.ListItem).Discount.ToString();
            e.Value = comboDisplay + "%"; 
        }

        private void txtBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "")
            {
                display();
            }

        }

        private void txtBoxDiscount_Click(object sender, EventArgs e)
        {
            FormCalculator calculator = new FormCalculator(txtBoxDiscount);
            calculator.ShowDialog();
        }

        private void txtBoxSearch_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txtBoxSearch, btnSearch);
            keyboard.ShowDialog();
        }

        private void txtBoxPromoCode_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txtBoxPromoCode);
            keyboard.ShowDialog();
        }

        private void FormAddEditPromoCode_Activated(object sender, EventArgs e)
        {
            FormLoginMenu.timeToReduel();
        }

        private void FormAddEditPromoCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLoginMenu.timeToNotDuel();
        }
    }
}
