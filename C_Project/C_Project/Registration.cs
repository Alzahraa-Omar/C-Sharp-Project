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
    public partial class Registration : Form
    {
        Tadabeer context = new Tadabeer();
        Home HF = new Home();
        public Registration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_regist_addcategory_Click(object sender, EventArgs e)
        {

        }

        private void lbl_regist_username_Click(object sender, EventArgs e)
        {

        }

        private void btn_regist_regist_Click(object sender, EventArgs e)
        {
            
            foreach (var item in context.Accounts)
            {
                if (item.AccountName == textBox_regist_username.Text)
                { MessageBox.Show("Used Username"); }
                else
                {
                    Account addedAccount = new Account()
                    {
                        AccountName = textBox_regist_username.Text,
                        AccountPassword = textBox_regist_password.Text,
                        TotalBudget = float.Parse(textBox_regist_totalBudget.Text)
                    };
                    context.Accounts.Add(addedAccount);
                    context.SaveChanges();
                }
                this.Hide();
                HF.Show();
            }
            
        }
    }
}
