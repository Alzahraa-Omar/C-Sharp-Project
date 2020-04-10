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
    public partial class AddCategory : Form
    {
        Tadabeer context = new Tadabeer();
        int current_user = Login.CurrentAccoutId.FirstOrDefault();

        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void lbl_edit_addCost_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_addCategory_Click(object sender, EventArgs e)
        {




            var User_salary = from i in context.Accounts
                              where i.Id == current_user
                              select i.TotalBudget;



            var Total_category = context.Categories
                .Where(x => x.AccountId == Login.CurrentAccoutId.FirstOrDefault())
                .Sum(i => (float?)i.CategoryCost) ?? 0;

           


            if (float.Parse(textBox_addCategory_categoryCost.Text) <= ((User_salary.FirstOrDefault() - (User_salary.FirstOrDefault() * (10.0 / 100)) - Total_category)))
            {
                context.Categories.Add(new Category()
                {
                    CategoryName = textBox_addedCategory_categoryName.Text,
                    CategoryCost = float.Parse(textBox_addCategory_categoryCost.Text),
                    AccountId = Login.CurrentAccoutId.FirstOrDefault()
                });
                context.SaveChanges();
                Calculate_Budget(float.Parse(textBox_addCategory_categoryCost.Text));



            }
            else
            {
                MessageBox.Show("Watchout!! your budget lower than 10%");
            }




            //Account A = context.Accounts.Find(Login.CurrentAccoutId);

            ////if ((A.Budget - float.Parse(textBox_addCategory_categoryCost.Text))<(A.Budget*0.1))
            ////{
            ////    MessageBox.Show("Watchout!! your budget lower than 10%");

            ////}
            //Category addedCat = new Category()
            //{
            //    CategoryName = textBox_addedCategory_categoryName.Text,
            //    CategoryCost = float.Parse(textBox_addCategory_categoryCost.Text),
            //    AccountId = current_user
            //};

        }
        public void Calculate_Budget(double _Cost)
        {
            var _Budget = from input in context.Accounts
                          where input.Id == Login.CurrentAccoutId.FirstOrDefault()
                          select input;
            foreach (var item in _Budget)
            {
                item.Budget = item.Budget - _Cost;

            }
            context.SaveChanges();

        }
        private void textBox_edit_addedCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_edit_addCategory_Click(object sender, EventArgs e)
        {

        }

        private void textBox_edit_addCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_addCategory_categoryCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label1.Text = "This is a number only field";

            }
        }
    }
}
