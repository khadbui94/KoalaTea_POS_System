/**
    * TIMEOUT SESSION USAGE
    * 
    * SET timeToReduel() on FormActivate() event.
    * SET timeToNoDuel() on FormClosing() event.
    * TIMER Default = 180000 ms (3 minutes)
    * 
    * To change the interval, put this line after timeToReduel();
    * FormLoginMenu.getDuelTime().interval = "x miliseconds";
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
using System.Timers;


namespace KoalaTea_Project_Root
{
    public partial class FormLoginMenu : Form
    {       
        public FormLoginMenu()
        {
            // !IMPORTANT DON'T MODIFY THIS
            InitializeComponent();

            // test cases
            //loginTestCases();

            // push the loginpage as the first in the stack
            backStack.Push(this);

            // password protect
            inputPassword_LoginMenu.PasswordChar = '*';           
        }

        // create an object of the database
        private DatabaseEntities dbe = new DatabaseEntities();

        // create the frontpage
        private static FormFrontPage nextPage = new FormFrontPage();

        // keep track of the number of time the user fail to enter the proper crudential
        private int LoginAttempt = 0;

        // control if the user is able to login again if they get locked for fail attempt
        private bool lockOut = false;

        // Date & Time
        private DateTime THECLOCK = new DateTime();
        
        public DateTime getDateTime()
        {
            return THECLOCK;
        }

        //stack for back buttons:
        private static Stack<Form> backStack = new Stack<Form>(); 
        
        public static Stack<Form> getBackStack() 
        {
            return backStack; 
        }

        // calls the frontPage
        private void callFrontPage()
        {
            nextPage.Show();
            Hide();
            backStack.Push(getFrontPage());
        }

        public static Form getFrontPage()
        {
            return nextPage;
        }

        // create and call the adminPage
        private void callAdminPage() 
        {
            KoalaTea_Project_Root.Admin.FormAdminFrontPage nextPage = new KoalaTea_Project_Root.Admin.FormAdminFrontPage();
            nextPage.Show();
            Hide();
        }

        private void authenticateLogin()
        {
            // create an object of the database
            // DatabaseEntities dbe = new DatabaseEntities();

            // user's input 
            string id = inputUserName_LoginMenu.Text.ToString();
            string pw = inputPassword_LoginMenu.Text.ToString();

            // loops through all the rows in tblUser
            bool found = false;

            // loops through the table
            foreach (var temp in dbe.tblUsers)
            {
                // check the crudential
                if (temp.Username == id && temp.Password == pw)
                {
                    // authentication success message
                    FormError successForm = new FormError();

                    // success form configuration
                    successForm.changeLabel.Text = "Logging in...\nWelcome "
                        + temp.Firstname + " " + temp.Lastname;
                    successForm.Text = "Authentication Successful";
                    successForm.changeButtonOne.Hide();
                    successForm.changeButtonTwo.Hide();
                    successForm.changeTimer.Interval = 1500;    // timer to close success message in 1.5 seconds
                    successForm.changeTimer.Enabled = true;
                    successForm.Show();

                    found = true;

                    if (temp.Status.CompareTo("1") == 0)
                        callAdminPage();
                    else
                        callFrontPage();

                    LoginAttempt = 0;
                    break;
                }
            }

            if (!found) 
            {
                LoginAttempt++;
                cleanAll();

                // too many login attempt;
                if (LoginAttempt > 4)
                {
                    // locks the user out for 1 minutes
                    timerLockOut.Interval = 60000;  // milliseconds
                    timerLockOut.Enabled = true;
                    timerLockOut.Start();

                    // fail login message
                    FormError failForm = new FormError();

                    // fail form configuration
                    failForm.changeLabel.Text = "Login Unsuccesful\nToo many failed attempt.\nLocking Application.";
                    failForm.Text = "Authentication Unsuccessful";
                    failForm.changeButtonOne.Hide();
                    failForm.changeButtonTwo.Hide();
                    failForm.changeTimer.Interval = 3000;
                    failForm.changeTimer.Enabled = true;
                    failForm.ShowDialog();

                    lockOut = true;
                }
                else
                    loginFailForm();    
            }
            cleanAll(); // erase input field
        }
      
        // event when the user clicks on the login button. 
        private void btnLogin_LoginMenu_Click(object sender, EventArgs e)
        {
            // locked out?
            if (lockOut)
            {
                // show error form
                FormError lockmsg = new FormError();
                lockmsg.changeLabel.Text = "Locked. Please try again later.";
                lockmsg.changeButtonTwo.Hide();
                lockmsg.changeButtonOne.Text = "Ok";
                lockmsg.changeTimer.Interval = 5000; // auto close the error message after 5 seconds
                lockmsg.ShowDialog();
            }
            else
            {

                // check for empty input
                if (inputUserName_LoginMenu.Text == String.Empty || inputPassword_LoginMenu.Text == String.Empty)
                    loginFailForm();
                else
                    authenticateLogin();
            }
        }

        private void loginFailForm()
        {
            // fail login message
            FormError failForm = new FormError();

            // fail form configuration
            failForm.changeLabel.Text = "Cannot Login\nPlease check your id or password and try again.";
            failForm.changeTitle = "Authentication Attempt: " + LoginAttempt;

            // last notice before lock out
            if (LoginAttempt == 4)
                failForm.changeLabel.Text = "Warning:\nNext failure will lock the application.";

            failForm.changeButtonOne.Text = "Continue";
            failForm.changeButtonTwo.Hide();
            failForm.ShowDialog();
        }

        // clear all input field
        private void cleanAll()
        {
            inputUserName_LoginMenu.Clear();
            inputPassword_LoginMenu.Clear();
        }

        private void btnExit_LoginMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // static variable to keep track of time
        private static System.Windows.Forms.Timer TIME_OUT = new System.Windows.Forms.Timer();
        // private static System.Timers.Timer TIME_OUT = new System.Timers.Timer(); // wrong timer object


        // OLD NOT NEEDED ANYMORE

        /**
        // this is the configuration for the timer, it must be activated on each form load
        public static void timeToDuel()
        {
            TIME_OUT.Tick += new EventHandler(OnTimedEvent);  // event to run at x interval
            TIME_OUT.Interval = 180000; // time (milliseconds) before timeout
            TIME_OUT.Enabled = true;    // enables the timer
            TIME_OUT.Stop();            // stop & start resets the timer
            TIME_OUT.Start();
        }
         */

        // session timeout
        // you can comment this out to disable the timeout
        public static void OnTimedEvent(Object myObject, EventArgs e)
        {
            timeToNotDuel();    // stops the timer

            // calls the error form and change the title and text accordingly
            FormError timeoutBox = new FormError();

            // timeout form configuration
            timeoutBox.changeLabel.Text = "Inactivity Detected\nLogging off in 10 seconds...";
            timeoutBox.changeTimer.Interval = 10000;
            timeoutBox.changeTitle = "Session Timeout";
            timeoutBox.changeButtonOne.Text = "Stop";
            timeoutBox.changeButtonTwo.Hide();
            timeoutBox.changeTimer.Enabled = true;

            FormError.clickResult_FormError = false;
            timeoutBox.ShowDialog();

            if (!FormError.getClickResult_FormError())
            {
                // Application.Exit();
                Application.Restart();
            }
            else
            {
                timeToReduel();

                // TIME_OUT.Tick -= new EventHandler(OnTimedEvent);
                // timeToDuel();    
            }  
        }

        private void FormLoginMenu_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;

            // stops the timer when form loads
            timeToNotDuel();
        }

        // start session timeout count, when login page closes
        private void FormLoginMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            timeToNotDuel();
        }

        // returns the time object
        public static System.Windows.Forms.Timer getDuelTime()
        {
            return TIME_OUT;
        }

        // start the timer
        public static void timeToReduel()
        {
            TIME_OUT.Interval = 180000;   // default time interval
            TIME_OUT.Tick -= new EventHandler(OnTimedEvent);
            TIME_OUT.Tick += new EventHandler(OnTimedEvent);
            TIME_OUT.Start();
            TIME_OUT.Enabled = true;
        }

        // stop the timer
        public static void timeToNotDuel()
        {
            TIME_OUT.Tick -= new EventHandler(OnTimedEvent);
            TIME_OUT.Stop();
            TIME_OUT.Enabled = false;
        }


        // update the clock every second
        private void timerClock_Login_Tick(object sender, EventArgs e)
        {
            THECLOCK = DateTime.Now;
            lblClock_Login.Text = THECLOCK.ToLongTimeString();
            lblDate_Login.Text = THECLOCK.ToLongDateString();
        }

        // KEYBOARD STUFF

        // shows the keyboard when you click on the textbox
        private void inputUserName_LoginMenu_Click(object sender, EventArgs e)
        {
            callKeyboard(inputUserName_LoginMenu, 0);
        }

        private void inputPassword_LoginMenu_Click(object sender, EventArgs e)
        {
            callKeyboard(inputPassword_LoginMenu, 1);
        }

        private void inputUserName_LoginMenu_Enter(object sender, EventArgs e)
        {
            callKeyboard(inputUserName_LoginMenu, 0);
        }

        private void inputPassword_LoginMenu_Enter(object sender, EventArgs e)
        {
            callKeyboard(inputPassword_LoginMenu, 1);
        }

        void callKeyboard(TextBox sendTextbox, int i)
        {
            if (i == 0)
            {
                FormKeyboard keyboard = new FormKeyboard(sendTextbox);
                keyboard.ShowDialog();
            }
            else
            {
                FormKeyboard keyboard = new FormKeyboard(sendTextbox, this);
                keyboard.ShowDialog();
            }
        }

        // runs after the lockout is completed
        private void timerLockOut_Tick(object sender, EventArgs e)
        {
            lockOut = false;
            timerLockOut.Stop();
            LoginAttempt = 0;
        }

        private void FormLoginMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            timeToNotDuel();
        }
    }
}
