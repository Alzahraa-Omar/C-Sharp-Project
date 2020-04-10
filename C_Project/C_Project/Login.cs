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
    public partial class Login : Form
    {
        public static IQueryable<int> CurrentAccoutId;
        Tadabeer context = new Tadabeer();
        public void Current_User(string _userName, string _password)
        {

            var check_user = from i in context.Accounts
                             where i.AccountName == _userName
                             select i;

            foreach (var item in check_user)
            {
                if (_userName == item.AccountName && _password == item.AccountPassword)
                {
                    CurrentAccoutId = from i in context.Accounts
                                where i.AccountName == _userName
                                select i.Id;

                    AddCategory form = new AddCategory();

                    form.Show();


                }
                else { MessageBox.Show("this name not found"); }

            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_enter_Click(object sender, EventArgs e)
        {
            Current_User(txtUserName.Text, txtPassword.Text);
            

        }
    }
}
