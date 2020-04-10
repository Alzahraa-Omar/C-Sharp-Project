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
        Tadabeer context = new Tadabeer();
        int current_user = Login.CurrentAccoutId.FirstOrDefault();
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

        private void btnAddActivity_Click(object sender, EventArgs e)
        {
            var _Budget = from input in context.Accounts
                          where input.Id == current_user
                          select input;
            foreach (var item in _Budget)
            {
                if (Convert.ToDouble(txtActivityCost.Text) < (item.Budget - (item.TotalBudget * 10 / 100)))
                {
                    context.Activities.Add(new Activity()
                    {
                        ActivityName = txtAddBonus.Text,
                        ActivityCost = Convert.ToDouble(txtActivityCost.Text),
                       AccountId = item.Id
                    });

                    item.Budget = item.Budget - Convert.ToDouble(txtActivityCost.Text);



                }
                else if (Convert.ToDouble(txtActivityCost.Text) == (item.Budget - (item.TotalBudget * 10 / 100)))
                {
                    DialogResult result = MessageBox.Show("your budget recieved alow level  are you sure to add activity"
                          , "warnining", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        context.Activities.Add(new Activity()
                        {
                            ActivityName = txtAddBonus.Text,
                            ActivityCost = Convert.ToDouble(txtActivityCost.Text),
                            AccountId = Login.CurrentAccoutId.FirstOrDefault()
                        });
                        item.Budget = item.Budget - Convert.ToDouble(txtActivityCost.Text);


                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("your budget not enough"
                        , "warnining", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            context.SaveChanges();

        }

        private void AddBonus_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _Budget = from input in context.Accounts
                          where input.Id == current_user
                          select input;

            foreach (var item in _Budget)
            {
                item.Budget = item.Budget + Convert.ToDouble(txtAddBonus.Text);

            }
            context.SaveChanges();

        }

        private void txtActivityCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label1.Text = "This is a number only field";
                label1.ForeColor = Color.Red;

            }
        }

        private void txtAddBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            label2.Text = "This is a number only field";
            label2.ForeColor = Color.Red;
        }
    }
}
