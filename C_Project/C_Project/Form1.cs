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
    public partial class Form1 : Form
    {
        Registration RF = new Registration();
        Login LF = new Login();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            RF.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            LF.ShowDialog();
        }
    }
}
