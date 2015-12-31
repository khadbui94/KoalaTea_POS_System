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
    public partial class FormPaymentCash : Form
    {
        public FormPaymentCash()
        {
            InitializeComponent();
        }

        private void FormPaymentCash_Shown(object sender, EventArgs e)
        {
            // set background image
            BackgroundImage = global::KoalaTea_Project_Root.Properties.Resources.main_background_1;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
