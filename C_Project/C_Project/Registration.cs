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


        public bool fun()
        {
            var user = from n in context.Accounts
                       select n;
            bool res = false;

            foreach (var item in user)
            {
                if (item.AccountName == textBox_regist_username.Text)
                { res = true; }
                else { res = false; }
            }
            return res;
        }

        private void btn_regist_regist_Click(object sender, EventArgs e)
        {

            if (!fun())
            {

                Account addedAccount = new Account()
                {
                    AccountName = textBox_regist_username.Text,
                    AccountPassword = textBox_regist_password.Text,
                    TotalBudget = float.Parse(textBox_regist_totalBudget.Text)
                };
                context.Accounts.Add(addedAccount);
                context.SaveChanges();
                this.Hide();
                HF.Show();

            }
            else { MessageBox.Show("Used Username"); }
         
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox_regist_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))//letter
            {
                e.Handled = true;
                label2.Text = "This is a character only field";
            }
        }

        private void textBox_regist_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_regist_totalBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label3.Text = "This is a number only field";
                label3.ForeColor = Color.Red;

            }
        }
    }
}
