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
    public partial class FormAddItemQuantity : Form
    {
        public FormAddItemQuantity()
        {
            InitializeComponent();
        }

        private void FormAddItemQuantity_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
        }

        private void addItem_Button_Cancel_Click(object sender, EventArgs e)
        {
            //how back function:
            FormLoginMenu.getBackStack().Pop().Hide();
            FormLoginMenu.getBackStack().Peek().Show();  
        }

        // restart timer on activation of form
        private void FormAddItemQuantity_Activated(object sender, EventArgs e)
        {
            FormLoginMenu.timeToDuel();
            FormLoginMenu.timeToReduel();
        }

        // stop the timer when form is changed
        private void FormAddItemQuantity_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLoginMenu.timeToNotDuel();
        }


    }
}
