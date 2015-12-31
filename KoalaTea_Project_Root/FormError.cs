/*
 * FormError()
 *      - Abstract error form
 *      - multiple modifiable properties.
 *      - Example in FormLoginMenu -> OnTimedEvent() event method.      
 * 
 * Using FormError()
 *
 * FormError myForm = new FormError();
 * myForm.changeLabel.Text = "Please try again";
 * myForm.changeButtonTwo.Hide();
 * 
 * myForm.ShowDialog(); // use showDialog instead of Show()
 *                      // this stops the application and the user
 *                      // must accept the form before continuing
 *                      
 * getClickResult()     // this returns true if the user clicks on buttonOne
 *                      // else return false
 *                      // useful for yes/no dialog option
 * 
 * you can use the changeX function to modify certain part of the form
 * 
 * x = 
 *  Label = error message
 *  title = error box, title
 *  buttonOne = the "Ok" button
 *  buttonTwo = the "No/Cancel" button
 *  timer = auto close timer, disabled by default. 
 *          you can enable this to have your error form 
 *          close automatically after interval = x
 * 
 * you change the object's property as needed
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
    public partial class FormError : Form
    {
        public FormError()
        {
            InitializeComponent();
        }

        // allow modification of this form's label from other form
        public Label changeLabel
        {
            get { return this.lblErrorMessage; }
            set { this.lblErrorMessage = value; }
        }

        // allow modification of this form's title from other form
        public string changeTitle
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        // allows modification of this form's button text from other form
        public Button changeButtonOne
        {
            get { return this.btnOne; }
            set { this.btnOne = value; }
        }

        // allows buttontwo to be modified
        public Button changeButtonTwo
        {
            get { return this.btnTwo; }
            set { this.btnTwo = value; }
        }

        // allows the timer to be modified
        public Timer changeTimer
        {
            get { return this.autoCloseTimer; }
            set { this.autoCloseTimer = value; }
        }

        // on form activation
        private void FormError_Activated(object sender, EventArgs e)
        {
            // center the message
            int x = (this.Width / 2) - (lblErrorMessage.Width / 2);
            int y = lblErrorMessage.Location.Y;
            lblErrorMessage.Location = new Point(x, y);
        }

        // static variable to determine if the user click accept or cancel
        public static bool clickResult_FormError = true;  
  
        private void btnTwo_Click(object sender, EventArgs e)
        {
            clickResult_FormError = false;
            this.Close();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            clickResult_FormError = true;
            this.Close();
        }

        public static bool getClickResult_FormError()
        {
            return clickResult_FormError;
        }

        private void FormError_Load(object sender, EventArgs e)
        {
            BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
        }

        private void autoCloseTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
