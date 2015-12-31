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
    public partial class FormCalculator : Form
    {
        public FormCalculator(TextBox otherBox)
        {
            InitializeComponent();
            whichBox = otherBox;
        }

        public FormCalculator(TextBox otherBox, Button otherButton)
        {
            InitializeComponent();
            whichBox = otherBox;
            whichButton = otherButton;
            buttonNext = true;
        }

        private TextBox whichBox;
        private Button whichButton;
        bool buttonNext = false;

        private void addItem_Button_Item_Next_Click(object sender, EventArgs e)
        {
            whichBox.Text = txbPreview.Text;
            if (buttonNext) whichButton.PerformClick();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbPreview.Clear();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txbPreview.Text += "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            txbPreview.Select();

            // center the calculator
            int x = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2);
            int y = (Screen.PrimaryScreen.WorkingArea.Height/2) - (this.Height / 2);
            this.Location = new Point(x, y);
        }

        private void btnDot_FormCalculator_Click(object sender, EventArgs e)
        {
            txbPreview.Text += ".";
        }
    }
}
