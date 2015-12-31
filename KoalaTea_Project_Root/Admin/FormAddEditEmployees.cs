using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KoalaTea_Project_Root.Admin
{

    public partial class FormAddEditEmployees : Form
    {
        DatabaseEntities dbe = new DatabaseEntities();

        public FormAddEditEmployees()
        {
            InitializeComponent();
        }

        private void AddEditEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.tblUsers' table. You can move, or remove it, as needed.
            //this.tblUsersTableAdapter.Fill(this.databaseDataSet.tblUsers);

            this.BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            BackgroundImageLayout = ImageLayout.Stretch;

            dataGridViewTblUser.DataSource = dbe.tblUsers.ToList();

            // change the font properties of the data grid
            foreach(DataGridViewColumn c in dataGridViewTblUser.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
            }

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != "" && textBoxPassword.Text != "")
            {
                tblUser user = new tblUser();

                user.Firstname = txtBoxFirstName.Text;
                user.Lastname = txtBoxLastName.Text;
                user.Username = textBoxUserName.Text;
                user.Password = textBoxPassword.Text;
                user.Status = "0";

                bool valid = dbe.tblUsers.Any(p => p.Username == user.Username);

                if (valid)
                {
                    messageBox(4);
                    textBoxUserName.Clear();
                    textBoxPassword.Clear();
                }
                else
                {
                    dbe.tblUsers.Add(user);
                    dbe.SaveChanges();

                    messageBox(1);

                    // after saving category, reset fields:
                    txtBoxFirstName.Clear();
                    txtBoxLastName.Clear();
                    textBoxUserName.Clear();
                    textBoxPassword.Clear();

                    dataGridViewTblUser.DataSource = dbe.tblUsers.ToList();
                }
            }
            else
                messageBox(3);
          
        }


        private void AddEditEmployees_AddEmployeeEvent()
        {
            dataGridViewTblUser.DataSource = dbe.tblUsers.ToList();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormAdminFrontPage prevPage = new FormAdminFrontPage();
            prevPage.Show();

        }

        private void txtBoxFirstName_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txtBoxFirstName);
            keyboard.ShowDialog();
        }

        private void txtBoxLastName_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txtBoxLastName);
            keyboard.ShowDialog();
        }

        private void textBoxUserName_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(textBoxUserName);
            keyboard.ShowDialog();
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(textBoxPassword);
            keyboard.ShowDialog();
        }

        private void messageBox(int type)
        {
            FormError myMessageBox = new FormError();

            switch (type)
            {
                case 1:
                    myMessageBox.changeButtonTwo.Hide();
                    myMessageBox.changeLabel.Text = "Successful\nNew employee added.\n"
                        + txtBoxFirstName.Text + " " + txtBoxLastName.Text;
                    break;
                case 2:
                    myMessageBox.changeButtonTwo.Hide();
                    myMessageBox.changeLabel.Text = "Successful\nDelete employee.\n"
                        + txtBoxFirstName.Text + " " + txtBoxLastName.Text;
                    break;
                case 3:
                       myMessageBox.changeButtonTwo.Hide();
                    myMessageBox.changeLabel.Text = "Please fill out all the fields!"
                        + txtBoxFirstName.Text + " " + txtBoxLastName.Text;
                    break;
                case 4:
                     myMessageBox.changeButtonTwo.Hide();
                    myMessageBox.changeLabel.Text = "Sorry, that username is already taken!"
                        + txtBoxFirstName.Text + " " + txtBoxLastName.Text;
                    break;
            }

            myMessageBox.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTblUser.Rows.Count != 0)
            {

                FormError confirmDialog = new FormError();
                confirmDialog.changeLabel.Text = "Delete this account?\n"
                    + dataGridViewTblUser.CurrentRow.Cells[1].Value
                    + " " + dataGridViewTblUser.CurrentRow.Cells[2].Value;

                confirmDialog.changeTitle = "Confirm Delete";
                confirmDialog.changeButtonTwo.Text = "Cancel";
                confirmDialog.ShowDialog();


                if (FormError.getClickResult_FormError())
                {
                    int remove = (int)dataGridViewTblUser.CurrentRow.Cells[0].Value;

                    tblUser user = dbe.tblUsers.First(p => p.UserID == remove);
                    dbe.tblUsers.Remove(user);
                    dbe.SaveChanges();
                    messageBox(2);
                    dataGridViewTblUser.DataSource = dbe.tblUsers.ToList();
                    txtBoxSearch.Text = "";
                }
            }

           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtBoxSearch.Text != "")
            {
                string searchText = txtBoxSearch.Text.ToLower();

                List<tblUser> list = dbe.tblUsers.Where(p => p.UserID.ToString() == searchText || p.Lastname.ToLower() == searchText ||
                        p.Lastname.ToLower().StartsWith(searchText)
                        || (searchText.Length >= 3 && p.Lastname.ToLower().Contains(searchText) || p.Firstname.ToLower().Contains(searchText))
                        || p.Firstname.ToLower() == searchText || p.Firstname.ToLower().StartsWith(searchText)
                        || (searchText.Contains(p.Firstname) && searchText.Contains(p.Lastname))).ToList();


                if (list.Count == 0)
                {
                    FormError successMessage = new FormError();
                    successMessage.changeButtonTwo.Hide();
                    successMessage.changeTitle = "Error";
                    successMessage.changeLabel.Text = "Cannot find the employee.";
                    successMessage.ShowDialog();

                    txtBoxSearch.Text = "";
                }

                else
                    dataGridViewTblUser.DataSource = list;
            }

        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxSearch.Text == "")
            {
                dataGridViewTblUser.DataSource = dbe.tblUsers.ToList(); 
            }
        }

        private void txtBoxSearch_Click(object sender, EventArgs e)
        {
            FormKeyboard keyboard = new FormKeyboard(txtBoxSearch, this);
            keyboard.ShowDialog();
        }

        private void dataGridViewTblUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAddEditEmployees_Activated(object sender, EventArgs e)
        {
            FormLoginMenu.timeToReduel();
        }

        private void FormAddEditEmployees_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLoginMenu.timeToNotDuel();
        }

    }
}
