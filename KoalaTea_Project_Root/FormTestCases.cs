using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// using this form to recieve data from other form to test cases
namespace KoalaTea_Project_Root
{
    public partial class FormTestCases : Form
    {
        public FormTestCases()
        {
            InitializeComponent();
        }

        /**
         * FormTestCases Overloaded Constructor
         * Receives data and prints it in a list box.
         * 
         * Implementation is not completed yet
         * trying to figure out how to add rows/column
         * 
         * @param string[] an array of data to be printed out
         */
        public FormTestCases(string[] dataReceived)
        {
            InitializeComponent();
            int size = dataReceived.Length - 1;

            try
            {
                listResult.Columns.Add("input");
                listResult.Columns.Add("output");

                for (int i = 0; i < size; i++)
                {
                    listResult.Items.Add(dataReceived[i]);
                    listResult.Items[i].SubItems[1].Text = dataReceived[i+1];
                 
                }
            }
            catch
            {

            }
            Show();
        }
    }
}
