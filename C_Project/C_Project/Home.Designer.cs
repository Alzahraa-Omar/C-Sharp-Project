namespace C_Project
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.AddBonus = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAddBonus = new System.Windows.Forms.TextBox();
            this.groupBox_regist_category = new System.Windows.Forms.GroupBox();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.txtActivityCost = new System.Windows.Forms.TextBox();
            this.txtActivityName = new System.Windows.Forms.TextBox();
            this.lbl_regist_cost = new System.Windows.Forms.Label();
            this.lbl_regist_category = new System.Windows.Forms.Label();
            this.tab_News = new System.Windows.Forms.TabPage();
            this.tab_HotDeal = new System.Windows.Forms.TabPage();
            this.lbl_home_hotDeal_totalBudget = new System.Windows.Forms.Label();
            this.lbl_home_hotDeal_here = new System.Windows.Forms.Label();
            this.lbl_home_hotdeal_name = new System.Windows.Forms.Label();
            this.tab_Profile = new System.Windows.Forms.TabPage();
            this.btn_home_profile_edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.AddBonus.SuspendLayout();
            this.groupBox_regist_category.SuspendLayout();
            this.tab_HotDeal.SuspendLayout();
            this.tab_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tab_News);
            this.tabControl1.Controls.Add(this.tab_HotDeal);
            this.tabControl1.Controls.Add(this.tab_Profile);
            this.tabControl1.Location = new System.Drawing.Point(9, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.AddBonus);
            this.tabHome.Controls.Add(this.groupBox_regist_category);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Margin = new System.Windows.Forms.Padding(2);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(2);
            this.tabHome.Size = new System.Drawing.Size(697, 394);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // AddBonus
            // 
            this.AddBonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddBonus.Controls.Add(this.label2);
            this.AddBonus.Controls.Add(this.button1);
            this.AddBonus.Controls.Add(this.txtAddBonus);
            this.AddBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBonus.Location = new System.Drawing.Point(419, 92);
            this.AddBonus.Name = "AddBonus";
            this.AddBonus.Size = new System.Drawing.Size(259, 201);
            this.AddBonus.TabIndex = 5;
            this.AddBonus.TabStop = false;
            this.AddBonus.Text = "AddBonus";
            this.AddBonus.Enter += new System.EventHandler(this.AddBonus_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(94, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAddBonus
            // 
            this.txtAddBonus.Location = new System.Drawing.Point(72, 62);
            this.txtAddBonus.Name = "txtAddBonus";
            this.txtAddBonus.Size = new System.Drawing.Size(132, 24);
            this.txtAddBonus.TabIndex = 0;
            this.txtAddBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddBonus_KeyPress);
            // 
            // groupBox_regist_category
            // 
            this.groupBox_regist_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox_regist_category.Controls.Add(this.label1);
            this.groupBox_regist_category.Controls.Add(this.btnAddActivity);
            this.groupBox_regist_category.Controls.Add(this.txtActivityCost);
            this.groupBox_regist_category.Controls.Add(this.txtActivityName);
            this.groupBox_regist_category.Controls.Add(this.lbl_regist_cost);
            this.groupBox_regist_category.Controls.Add(this.lbl_regist_category);
            this.groupBox_regist_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_regist_category.Location = new System.Drawing.Point(7, 70);
            this.groupBox_regist_category.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_regist_category.Name = "groupBox_regist_category";
            this.groupBox_regist_category.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_regist_category.Size = new System.Drawing.Size(349, 246);
            this.groupBox_regist_category.TabIndex = 4;
            this.groupBox_regist_category.TabStop = false;
            this.groupBox_regist_category.Text = "Add Activity";
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.BackColor = System.Drawing.Color.Teal;
            this.btnAddActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddActivity.ForeColor = System.Drawing.Color.MintCream;
            this.btnAddActivity.Location = new System.Drawing.Point(92, 185);
            this.btnAddActivity.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(157, 38);
            this.btnAddActivity.TabIndex = 4;
            this.btnAddActivity.Text = "Ask";
            this.btnAddActivity.UseVisualStyleBackColor = false;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // txtActivityCost
            // 
            this.txtActivityCost.Location = new System.Drawing.Point(140, 109);
            this.txtActivityCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivityCost.Name = "txtActivityCost";
            this.txtActivityCost.Size = new System.Drawing.Size(152, 24);
            this.txtActivityCost.TabIndex = 3;
            this.txtActivityCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActivityCost_KeyPress);
            // 
            // txtActivityName
            // 
            this.txtActivityName.Location = new System.Drawing.Point(140, 54);
            this.txtActivityName.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivityName.Name = "txtActivityName";
            this.txtActivityName.Size = new System.Drawing.Size(152, 24);
            this.txtActivityName.TabIndex = 2;
            // 
            // lbl_regist_cost
            // 
            this.lbl_regist_cost.AutoSize = true;
            this.lbl_regist_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_cost.Location = new System.Drawing.Point(31, 105);
            this.lbl_regist_cost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_regist_cost.Name = "lbl_regist_cost";
            this.lbl_regist_cost.Size = new System.Drawing.Size(57, 24);
            this.lbl_regist_cost.TabIndex = 1;
            this.lbl_regist_cost.Text = "Cost :";
            // 
            // lbl_regist_category
            // 
            this.lbl_regist_category.AutoSize = true;
            this.lbl_regist_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_category.Location = new System.Drawing.Point(18, 50);
            this.lbl_regist_category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_regist_category.Name = "lbl_regist_category";
            this.lbl_regist_category.Size = new System.Drawing.Size(77, 24);
            this.lbl_regist_category.TabIndex = 0;
            this.lbl_regist_category.Text = "Activity :";
            // 
            // tab_News
            // 
            this.tab_News.Location = new System.Drawing.Point(4, 22);
            this.tab_News.Margin = new System.Windows.Forms.Padding(2);
            this.tab_News.Name = "tab_News";
            this.tab_News.Padding = new System.Windows.Forms.Padding(2);
            this.tab_News.Size = new System.Drawing.Size(697, 394);
            this.tab_News.TabIndex = 1;
            this.tab_News.Text = "News";
            this.tab_News.UseVisualStyleBackColor = true;
            // 
            // tab_HotDeal
            // 
            this.tab_HotDeal.Controls.Add(this.lbl_home_hotDeal_totalBudget);
            this.tab_HotDeal.Controls.Add(this.lbl_home_hotDeal_here);
            this.tab_HotDeal.Controls.Add(this.lbl_home_hotdeal_name);
            this.tab_HotDeal.Location = new System.Drawing.Point(4, 22);
            this.tab_HotDeal.Margin = new System.Windows.Forms.Padding(2);
            this.tab_HotDeal.Name = "tab_HotDeal";
            this.tab_HotDeal.Size = new System.Drawing.Size(697, 394);
            this.tab_HotDeal.TabIndex = 2;
            this.tab_HotDeal.Text = "Hot Deal";
            this.tab_HotDeal.UseVisualStyleBackColor = true;
            // 
            // lbl_home_hotDeal_totalBudget
            // 
            this.lbl_home_hotDeal_totalBudget.AutoSize = true;
            this.lbl_home_hotDeal_totalBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_hotDeal_totalBudget.Location = new System.Drawing.Point(292, 67);
            this.lbl_home_hotDeal_totalBudget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_home_hotDeal_totalBudget.Name = "lbl_home_hotDeal_totalBudget";
            this.lbl_home_hotDeal_totalBudget.Size = new System.Drawing.Size(128, 24);
            this.lbl_home_hotDeal_totalBudget.TabIndex = 2;
            this.lbl_home_hotDeal_totalBudget.Text = "Total Budget";
            this.lbl_home_hotDeal_totalBudget.Click += new System.EventHandler(this.lbl_home_hotDeal_totalBudget_Click);
            // 
            // lbl_home_hotDeal_here
            // 
            this.lbl_home_hotDeal_here.AutoSize = true;
            this.lbl_home_hotDeal_here.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_hotDeal_here.Location = new System.Drawing.Point(15, 67);
            this.lbl_home_hotDeal_here.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_home_hotDeal_here.Name = "lbl_home_hotDeal_here";
            this.lbl_home_hotDeal_here.Size = new System.Drawing.Size(293, 24);
            this.lbl_home_hotDeal_here.TabIndex = 1;
            this.lbl_home_hotDeal_here.Text = "Here is a HOT DEAL with your";
            // 
            // lbl_home_hotdeal_name
            // 
            this.lbl_home_hotdeal_name.AutoSize = true;
            this.lbl_home_hotdeal_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_hotdeal_name.Location = new System.Drawing.Point(14, 15);
            this.lbl_home_hotdeal_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_home_hotdeal_name.Name = "lbl_home_hotdeal_name";
            this.lbl_home_hotdeal_name.Size = new System.Drawing.Size(75, 26);
            this.lbl_home_hotdeal_name.TabIndex = 0;
            this.lbl_home_hotdeal_name.Text = "Name";
            // 
            // tab_Profile
            // 
            this.tab_Profile.Controls.Add(this.btn_home_profile_edit);
            this.tab_Profile.Location = new System.Drawing.Point(4, 22);
            this.tab_Profile.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Profile.Name = "tab_Profile";
            this.tab_Profile.Size = new System.Drawing.Size(697, 394);
            this.tab_Profile.TabIndex = 3;
            this.tab_Profile.Text = "Profile";
            this.tab_Profile.UseVisualStyleBackColor = true;
            // 
            // btn_home_profile_edit
            // 
            this.btn_home_profile_edit.Location = new System.Drawing.Point(331, 316);
            this.btn_home_profile_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_home_profile_edit.Name = "btn_home_profile_edit";
            this.btn_home_profile_edit.Size = new System.Drawing.Size(92, 36);
            this.btn_home_profile_edit.TabIndex = 0;
            this.btn_home_profile_edit.Text = "Edit Profile";
            this.btn_home_profile_edit.UseVisualStyleBackColor = true;
            this.btn_home_profile_edit.Click += new System.EventHandler(this.btn_home_profile_edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 418);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.AddBonus.ResumeLayout(false);
            this.AddBonus.PerformLayout();
            this.groupBox_regist_category.ResumeLayout(false);
            this.groupBox_regist_category.PerformLayout();
            this.tab_HotDeal.ResumeLayout(false);
            this.tab_HotDeal.PerformLayout();
            this.tab_Profile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tab_News;
        private System.Windows.Forms.TabPage tab_HotDeal;
        private System.Windows.Forms.Label lbl_home_hotDeal_totalBudget;
        private System.Windows.Forms.Label lbl_home_hotDeal_here;
        private System.Windows.Forms.Label lbl_home_hotdeal_name;
        private System.Windows.Forms.TabPage tab_Profile;
        private System.Windows.Forms.Button btn_home_profile_edit;
        private System.Windows.Forms.GroupBox groupBox_regist_category;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.TextBox txtActivityCost;
        private System.Windows.Forms.TextBox txtActivityName;
        private System.Windows.Forms.Label lbl_regist_cost;
        private System.Windows.Forms.Label lbl_regist_category;
        private System.Windows.Forms.GroupBox AddBonus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAddBonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}