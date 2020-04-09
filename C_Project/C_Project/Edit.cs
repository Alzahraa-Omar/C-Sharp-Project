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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btn_edit_addNewCategory_Click(object sender, EventArgs e)
        {
            AddCategory AddCategoryForm = new AddCategory();
            AddCategoryForm.ShowDialog();
        }
    }
}
