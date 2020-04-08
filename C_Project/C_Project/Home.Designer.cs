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
            this.tab_News = new System.Windows.Forms.TabPage();
            this.tab_HotDeal = new System.Windows.Forms.TabPage();
            this.tab_Profile = new System.Windows.Forms.TabPage();
            this.lbl_home_hotdeal_name = new System.Windows.Forms.Label();
            this.lbl_home_hotDeal_here = new System.Windows.Forms.Label();
            this.lbl_home_hotDeal_totalBudget = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_HotDeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tab_News);
            this.tabControl1.Controls.Add(this.tab_HotDeal);
            this.tabControl1.Controls.Add(this.tab_Profile);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(616, 463);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tab_News
            // 
            this.tab_News.Location = new System.Drawing.Point(4, 25);
            this.tab_News.Name = "tab_News";
            this.tab_News.Padding = new System.Windows.Forms.Padding(3);
            this.tab_News.Size = new System.Drawing.Size(616, 463);
            this.tab_News.TabIndex = 1;
            this.tab_News.Text = "News";
            this.tab_News.UseVisualStyleBackColor = true;
            // 
            // tab_HotDeal
            // 
            this.tab_HotDeal.Controls.Add(this.lbl_home_hotDeal_totalBudget);
            this.tab_HotDeal.Controls.Add(this.lbl_home_hotDeal_here);
            this.tab_HotDeal.Controls.Add(this.lbl_home_hotdeal_name);
            this.tab_HotDeal.Location = new System.Drawing.Point(4, 25);
            this.tab_HotDeal.Name = "tab_HotDeal";
            this.tab_HotDeal.Size = new System.Drawing.Size(616, 463);
            this.tab_HotDeal.TabIndex = 2;
            this.tab_HotDeal.Text = "Hot Deal";
            this.tab_HotDeal.UseVisualStyleBackColor = true;
            // 
            // tab_Profile
            // 
            this.tab_Profile.Location = new System.Drawing.Point(4, 25);
            this.tab_Profile.Name = "tab_Profile";
            this.tab_Profile.Size = new System.Drawing.Size(616, 463);
            this.tab_Profile.TabIndex = 3;
            this.tab_Profile.Text = "Profile";
            this.tab_Profile.UseVisualStyleBackColor = true;
            // 
            // lbl_home_hotdeal_name
            // 
            this.lbl_home_hotdeal_name.AutoSize = true;
            this.lbl_home_hotdeal_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_hotdeal_name.Location = new System.Drawing.Point(18, 18);
            this.lbl_home_hotdeal_name.Name = "lbl_home_hotdeal_name";
            this.lbl_home_hotdeal_name.Size = new System.Drawing.Size(94, 32);
            this.lbl_home_hotdeal_name.TabIndex = 0;
            this.lbl_home_hotdeal_name.Text = "Name";
            // 
            // lbl_home_hotDeal_here
            // 
            this.lbl_home_hotDeal_here.AutoSize = true;
            this.lbl_home_hotDeal_here.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_hotDeal_here.Location = new System.Drawing.Point(20, 83);
            this.lbl_home_hotDeal_here.Name = "lbl_home_hotDeal_here";
            this.lbl_home_hotDeal_here.Size = new System.Drawing.Size(363, 29);
            this.lbl_home_hotDeal_here.TabIndex = 1;
            this.lbl_home_hotDeal_here.Text = "Here is a HOT DEAL with your";
            // 
            // lbl_home_hotDeal_totalBudget
            // 
            this.lbl_home_hotDeal_totalBudget.AutoSize = true;
            this.lbl_home_hotDeal_totalBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home_hotDeal_totalBudget.Location = new System.Drawing.Point(389, 83);
            this.lbl_home_hotDeal_totalBudget.Name = "lbl_home_hotDeal_totalBudget";
            this.lbl_home_hotDeal_totalBudget.Size = new System.Drawing.Size(163, 29);
            this.lbl_home_hotDeal_totalBudget.TabIndex = 2;
            this.lbl_home_hotDeal_totalBudget.Text = "Total Budget";
            this.lbl_home_hotDeal_totalBudget.Click += new System.EventHandler(this.lbl_home_hotDeal_totalBudget_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.tab_HotDeal.ResumeLayout(false);
            this.tab_HotDeal.PerformLayout();
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
    }
}