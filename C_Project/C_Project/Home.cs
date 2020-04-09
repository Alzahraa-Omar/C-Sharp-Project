using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class Home : Form
    {
        Edit EditForm = new Edit();
        public Home()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_home_hotDeal_totalBudget_Click(object sender, EventArgs e)
        {

        }

        private void btn_home_profile_edit_Click(object sender, EventArgs e)
        {
            EditForm.ShowDialog();
        }
    }
}
