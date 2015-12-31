/*
 * KEYBOARD() USAGE

 * // (1a) you MUST pass the textbox to call on
 * FormKeyboard keyboard = new Keyboard(myTextBox);
 * 
 * // (1b) you can pass the textbox and the form
 * // when the user hits enter with the onscreen keyboard it will click on the calling form's accept button
 * FormKeyboard keyboard = new Keyboard(myTextBox, this);
 * 
 * // (1c) you can also pass the textbox and a specific button
 * // selecting enter will click on the button you pass
 * // FormKeyboard keyboard = new Keyboard(myTextBox, someButton);
 * 
 * // (2) use showdialog to prevent the user from clicking on other windows
 * keyboard.ShowDialog();
 * 
*/

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
    public partial class FormKeyboard : Form
    {
        /**
         *  You must pass the inputBox that will call the keyboard.
         *  The overloaded constructor takes a button, example btnLogin or btnSearch and activate it when
         *  the user hits enter
         */
        public FormKeyboard(TextBox inputBox)
        {
            InitializeComponent();
            whichBox = inputBox;
            nextBtn = false;

            if (whichBox.Name.ToString() == "inputPassword_LoginMenu")
                lblPreview.PasswordChar = '*';
        }

        // overloaded constructor, when the user hits enter it will use the
        // calling class accept button event
        public FormKeyboard(TextBox inputBox, Form nextBox)
        {
            InitializeComponent();
            whichBox = inputBox;
            whichBoxNext = nextBox;
            nextBtn = true;

            if (whichBox.Name.ToString() == "inputPassword_LoginMenu")
                lblPreview.PasswordChar = '*';
        }

        public FormKeyboard(TextBox inputBox, Button acceptButton)
        {
            InitializeComponent();
            whichBox = inputBox;
            whichButton = acceptButton;
            submitBtn = true;
        }

        private TextBox whichBox;
        private Form whichBoxNext;
        private Button whichButton;

        private bool submitBtn = false;
        private bool nextBtn;
        private bool upperCase = false;

        private void FormKeyboard_Activated(object sender, EventArgs e)
        {
            // copy the input string to temp string
            lblPreview.Text = whichBox.Text;

            // center the keyboard
            int x = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2 );
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new Point(x, y);
        }

        private void FormKeyboard_Load(object sender, EventArgs e)
        {
            lblPreview.Text = whichBox.Text;
            lblPreview.Select();

            this.Opacity = .93;
            /*
            BackColor = Color.Lime;
            TransparencyKey = Color.Lime;

            foreach (Control myControl in this.Controls)
            {
                if (myControl is Panel)
                {
                    myControl.BackColor = Color.Lime;
                }
            }
            */
            
        }
        
        
        private void btnTide_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                lblPreview.Text = lblPreview.Text + "`";
            }
            else
            {
                lblPreview.Text = lblPreview.Text + "~";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                lblPreview.Text = lblPreview.Text + "!";
            }
            else
            {
                lblPreview.Text = lblPreview.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {

                lblPreview.Text = lblPreview.Text + "@";
            }
            else
            {
                //2";
                lblPreview.Text = lblPreview.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //#";
                lblPreview.Text = lblPreview.Text + "#";
            }
            else
            {
                //3";
                lblPreview.Text = lblPreview.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //$";
                lblPreview.Text = lblPreview.Text + "$";
            }
            else
            {
                //4";
                lblPreview.Text = lblPreview.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //%";
                lblPreview.Text = lblPreview.Text + "%";
            }
            else
            {
                //5";
                lblPreview.Text = lblPreview.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //^";
                lblPreview.Text = lblPreview.Text + "^";
            }
            else
            {
                //6";
                lblPreview.Text = lblPreview.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //&";
                lblPreview.Text = lblPreview.Text + "&";
            }
            else
            {
                //7";
                lblPreview.Text = lblPreview.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //*";
                lblPreview.Text = lblPreview.Text + "*";
            }
            else
            {
                //8";
                lblPreview.Text = lblPreview.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //(";
                lblPreview.Text = lblPreview.Text + "(";
            }
            else
            {
                //9";
                lblPreview.Text = lblPreview.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //)";
                lblPreview.Text = lblPreview.Text + ")";
            }
            else
            {
                //0";
                lblPreview.Text = lblPreview.Text + "0";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //_";
                lblPreview.Text = lblPreview.Text + "_";
            }
            else
            {
                //-";
                lblPreview.Text = lblPreview.Text + "-";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //+";
                lblPreview.Text = lblPreview.Text + "+";
            }
            else
            {
                //=";
                lblPreview.Text = lblPreview.Text + "=";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lblPreview.Text.Length > 0)
            {
                lblPreview.Text = lblPreview.Text.Substring(0, lblPreview.Text.Length - 1);
            }
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            lblPreview.Text = lblPreview.Text + "\t";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                lblPreview.Text = lblPreview.Text + "Q";
            }
            else
            {
                lblPreview.Text = lblPreview.Text + "q";
            }
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //W";
                lblPreview.Text = lblPreview.Text + "W";
            }
            else
            {
                //w";
                lblPreview.Text = lblPreview.Text + "w";
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //E";
                lblPreview.Text = lblPreview.Text + "E";
            }
            else
            {
                //e";
                lblPreview.Text = lblPreview.Text + "e";
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //R";
                lblPreview.Text = lblPreview.Text + "R";
            }
            else
            {
                //r";
                lblPreview.Text = lblPreview.Text + "r";
            }
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //T";
                lblPreview.Text = lblPreview.Text + "T";
            }
            else
            {
                //t";
                lblPreview.Text = lblPreview.Text + "t";
            }
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //Y";
                lblPreview.Text = lblPreview.Text + "Y";
            }
            else
            {
                //y";
                lblPreview.Text = lblPreview.Text + "y";
            }
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //U";
                lblPreview.Text = lblPreview.Text + "U";
            }
            else
            {
                //u";
                lblPreview.Text = lblPreview.Text + "u";
            }
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //I";
                lblPreview.Text = lblPreview.Text + "I";
            }
            else
            {
                //i";
                lblPreview.Text = lblPreview.Text + "i";
            }
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //O";
                lblPreview.Text = lblPreview.Text + "O";
            }
            else
            {
                //o";
                lblPreview.Text = lblPreview.Text + "o";
            }

        }

        private void btnP_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //P";
                lblPreview.Text = lblPreview.Text + "P";
            }
            else
            {
                //p";
                lblPreview.Text = lblPreview.Text + "p";
            }
        }

        private void btnBracetL_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //{";
                lblPreview.Text = lblPreview.Text + "{";
            }
            else
            {
                //[";
                lblPreview.Text = lblPreview.Text + "[";
            }
        }

        private void btnBracketR_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //}";
                lblPreview.Text = lblPreview.Text + "}";
            }
            else
            {
                //]";
                lblPreview.Text = lblPreview.Text + "]";
            }
        }

        private void btnBackslash_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //|";
                lblPreview.Text = lblPreview.Text + "|";
            }
            else
            {
                //\\";
                lblPreview.Text = lblPreview.Text + "\\";
            }
        }

        private void btnCAPS_Click(object sender, EventArgs e)
        {
            upperCase = upperCase == true ? false : true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //A";
                lblPreview.Text = lblPreview.Text + "A";
            }
            else
            {
                //a";
                lblPreview.Text = lblPreview.Text + "a";
            }
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //S";
                lblPreview.Text = lblPreview.Text + "S";
            }
            else
            {
                //s";
                lblPreview.Text = lblPreview.Text + "s";
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //D";
                lblPreview.Text = lblPreview.Text + "D";
            }
            else
            {
                //d";
                lblPreview.Text = lblPreview.Text + "d";
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //F";
                lblPreview.Text = lblPreview.Text + "F";
            }
            else
            {
                //f";
                lblPreview.Text = lblPreview.Text + "f";
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //G";
                lblPreview.Text = lblPreview.Text + "G";
            }
            else
            {
                //g";
                lblPreview.Text = lblPreview.Text + "g";
            }
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //H";
                lblPreview.Text = lblPreview.Text + "H";
            }
            else
            {
                //h";
                lblPreview.Text = lblPreview.Text + "h";
            }
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //J";
                lblPreview.Text = lblPreview.Text + "J";
            }
            else
            {
                //j";
                lblPreview.Text = lblPreview.Text + "j";
            }
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //K";
                lblPreview.Text = lblPreview.Text + "K";
            }
            else
            {
                //k";
                lblPreview.Text = lblPreview.Text + "k";
            }
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //L";
                lblPreview.Text = lblPreview.Text + "L";
            }
            else
            {
                //l";
                lblPreview.Text = lblPreview.Text + "l";
            }
        }

        private void btnSemicolon_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //:";
                lblPreview.Text = lblPreview.Text + ":";
            }
            else
            {
                //;";
                lblPreview.Text = lblPreview.Text + ";";
            }
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //\"";
                lblPreview.Text = lblPreview.Text + "\"";
            }
            else
            {
                //'";
                lblPreview.Text = lblPreview.Text + "'";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            whichBox.Text = lblPreview.Text;
            if (nextBtn) whichBoxNext.AcceptButton.PerformClick();
            if (submitBtn) whichButton.PerformClick();
            this.Close();
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //Z";
                lblPreview.Text = lblPreview.Text + "Z";
            }
            else
            {
                //z";
                lblPreview.Text = lblPreview.Text + "z";
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //X";
                lblPreview.Text = lblPreview.Text + "X";
            }
            else
            {
                //x";
                lblPreview.Text = lblPreview.Text + "x";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //C";
                lblPreview.Text = lblPreview.Text + "C";
            }
            else
            {
                //c";
                lblPreview.Text = lblPreview.Text + "c";
            }
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //V";
                lblPreview.Text = lblPreview.Text + "V";
            }
            else
            {
                //v";
                lblPreview.Text = lblPreview.Text + "v";
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //B";
                lblPreview.Text = lblPreview.Text + "B";
            }
            else
            {
                //b";
                lblPreview.Text = lblPreview.Text + "b";
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //N";
                lblPreview.Text = lblPreview.Text + "N";
            }
            else
            {
                //n";
                lblPreview.Text = lblPreview.Text + "n";
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //M";
                lblPreview.Text = lblPreview.Text + "M";
            }
            else
            {
                //m";
                lblPreview.Text = lblPreview.Text + "m";
            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //<";
                lblPreview.Text = lblPreview.Text + "<";
            }
            else
            {
                //,";
                lblPreview.Text = lblPreview.Text + ",";
            }
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //>";
                lblPreview.Text = lblPreview.Text + ">";
            }
            else
            {
                //.";
                lblPreview.Text = lblPreview.Text + ".";
            }
        }

        private void btnForwardSlash_Click(object sender, EventArgs e)
        {
            if (upperCase == true)
            {
                //?";
                lblPreview.Text = lblPreview.Text + "?";
            }
            else
            {
                ///";
                lblPreview.Text = lblPreview.Text + "/";
            }
        }

        private void btnCtrlL_Click(object sender, EventArgs e)
        {

        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltL_Click(object sender, EventArgs e)
        {

        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            // ";
            lblPreview.Text = lblPreview.Text + " ";
        }

        private void btnAltR_Click(object sender, EventArgs e)
        {

        }

        private void btnCtrlR_Click(object sender, EventArgs e)
        {

        }

        private void btnShiftL_Click(object sender, EventArgs e)
        {
            upperCase = upperCase == true ? false : true;
        }

        private void btnShiftR_Click(object sender, EventArgs e)
        {
            upperCase = upperCase == true ? false : true;
        }

        private void btnCloseUp_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panelZXCV_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
