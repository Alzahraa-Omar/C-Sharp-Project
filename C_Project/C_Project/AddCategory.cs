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
            Account A = context.Accounts.Find(Login.CurrentAccoutId);

            //if ((A.Budget - float.Parse(textBox_addCategory_categoryCost.Text))<(A.Budget*0.1))
            //{
            //    MessageBox.Show("Watchout!! your budget lower than 10%");
                
            //}
            Category addedCat = new Category()
            {
                CategoryName = textBox_addedCategory_categoryName.Text,
                CategoryCost = float.Parse(textBox_addCategory_categoryCost.Text),
                AccountId = Login.CurrentAccoutId
            };
            
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
    }
}
