namespace C_Project
{
    partial class Registration
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
            this.lbl_regist_username = new System.Windows.Forms.Label();
            this.lbl_regist_password = new System.Windows.Forms.Label();
            this.lbl_regist_budget = new System.Windows.Forms.Label();
            this.groupBox_regist_category = new System.Windows.Forms.GroupBox();
            this.btn_regist_addcategory = new System.Windows.Forms.Button();
            this.textBox_regist_cost = new System.Windows.Forms.TextBox();
            this.textBox_regist_category = new System.Windows.Forms.TextBox();
            this.lbl_regist_cost = new System.Windows.Forms.Label();
            this.lbl_regist_category = new System.Windows.Forms.Label();
            this.textBox_regist_username = new System.Windows.Forms.TextBox();
            this.textBox_regist_password = new System.Windows.Forms.TextBox();
            this.textBox_regist_totalBudget = new System.Windows.Forms.TextBox();
            this.btn_regist_regist = new System.Windows.Forms.Button();
            this.groupBox_regist_category.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_regist_username
            // 
            this.lbl_regist_username.AutoSize = true;
            this.lbl_regist_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_username.Location = new System.Drawing.Point(69, 43);
            this.lbl_regist_username.Name = "lbl_regist_username";
            this.lbl_regist_username.Size = new System.Drawing.Size(147, 29);
            this.lbl_regist_username.TabIndex = 0;
            this.lbl_regist_username.Text = "User Name :";
            this.lbl_regist_username.Click += new System.EventHandler(this.lbl_regist_username_Click);
            // 
            // lbl_regist_password
            // 
            this.lbl_regist_password.AutoSize = true;
            this.lbl_regist_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_password.Location = new System.Drawing.Point(69, 129);
            this.lbl_regist_password.Name = "lbl_regist_password";
            this.lbl_regist_password.Size = new System.Drawing.Size(132, 29);
            this.lbl_regist_password.TabIndex = 1;
            this.lbl_regist_password.Text = "Password :";
            // 
            // lbl_regist_budget
            // 
            this.lbl_regist_budget.AutoSize = true;
            this.lbl_regist_budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_budget.Location = new System.Drawing.Point(69, 214);
            this.lbl_regist_budget.Name = "lbl_regist_budget";
            this.lbl_regist_budget.Size = new System.Drawing.Size(102, 29);
            this.lbl_regist_budget.TabIndex = 2;
            this.lbl_regist_budget.Text = "Budget :";
            // 
            // groupBox_regist_category
            // 
            this.groupBox_regist_category.Controls.Add(this.btn_regist_addcategory);
            this.groupBox_regist_category.Controls.Add(this.textBox_regist_cost);
            this.groupBox_regist_category.Controls.Add(this.textBox_regist_category);
            this.groupBox_regist_category.Controls.Add(this.lbl_regist_cost);
            this.groupBox_regist_category.Controls.Add(this.lbl_regist_category);
            this.groupBox_regist_category.Location = new System.Drawing.Point(22, 281);
            this.groupBox_regist_category.Name = "groupBox_regist_category";
            this.groupBox_regist_category.Size = new System.Drawing.Size(585, 274);
            this.groupBox_regist_category.TabIndex = 3;
            this.groupBox_regist_category.TabStop = false;
            this.groupBox_regist_category.Text = "Add Categories";
            this.groupBox_regist_category.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_regist_addcategory
            // 
            this.btn_regist_addcategory.BackColor = System.Drawing.Color.Teal;
            this.btn_regist_addcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regist_addcategory.ForeColor = System.Drawing.Color.MintCream;
            this.btn_regist_addcategory.Location = new System.Drawing.Point(180, 203);
            this.btn_regist_addcategory.Name = "btn_regist_addcategory";
            this.btn_regist_addcategory.Size = new System.Drawing.Size(209, 47);
            this.btn_regist_addcategory.TabIndex = 4;
            this.btn_regist_addcategory.Text = "Add Category";
            this.btn_regist_addcategory.UseVisualStyleBackColor = false;
            this.btn_regist_addcategory.Click += new System.EventHandler(this.btn_regist_addcategory_Click);
            // 
            // textBox_regist_cost
            // 
            this.textBox_regist_cost.Location = new System.Drawing.Point(316, 134);
            this.textBox_regist_cost.Name = "textBox_regist_cost";
            this.textBox_regist_cost.Size = new System.Drawing.Size(202, 22);
            this.textBox_regist_cost.TabIndex = 3;
            // 
            // textBox_regist_category
            // 
            this.textBox_regist_category.Location = new System.Drawing.Point(316, 67);
            this.textBox_regist_category.Name = "textBox_regist_category";
            this.textBox_regist_category.Size = new System.Drawing.Size(202, 22);
            this.textBox_regist_category.TabIndex = 2;
            // 
            // lbl_regist_cost
            // 
            this.lbl_regist_cost.AutoSize = true;
            this.lbl_regist_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_cost.Location = new System.Drawing.Point(99, 137);
            this.lbl_regist_cost.Name = "lbl_regist_cost";
            this.lbl_regist_cost.Size = new System.Drawing.Size(74, 29);
            this.lbl_regist_cost.TabIndex = 1;
            this.lbl_regist_cost.Text = "Cost :";
            // 
            // lbl_regist_category
            // 
            this.lbl_regist_category.AutoSize = true;
            this.lbl_regist_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_category.Location = new System.Drawing.Point(99, 72);
            this.lbl_regist_category.Name = "lbl_regist_category";
            this.lbl_regist_category.Size = new System.Drawing.Size(122, 29);
            this.lbl_regist_category.TabIndex = 0;
            this.lbl_regist_category.Text = "Category :";
            this.lbl_regist_category.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_regist_username
            // 
            this.textBox_regist_username.Location = new System.Drawing.Point(250, 43);
            this.textBox_regist_username.Name = "textBox_regist_username";
            this.textBox_regist_username.Size = new System.Drawing.Size(290, 22);
            this.textBox_regist_username.TabIndex = 4;
            // 
            // textBox_regist_password
            // 
            this.textBox_regist_password.Location = new System.Drawing.Point(250, 129);
            this.textBox_regist_password.Name = "textBox_regist_password";
            this.textBox_regist_password.Size = new System.Drawing.Size(290, 22);
            this.textBox_regist_password.TabIndex = 5;
            // 
            // textBox_regist_totalBudget
            // 
            this.textBox_regist_totalBudget.Location = new System.Drawing.Point(250, 214);
            this.textBox_regist_totalBudget.Name = "textBox_regist_totalBudget";
            this.textBox_regist_totalBudget.Size = new System.Drawing.Size(290, 22);
            this.textBox_regist_totalBudget.TabIndex = 6;
            // 
            // btn_regist_regist
            // 
            this.btn_regist_regist.BackColor = System.Drawing.Color.Teal;
            this.btn_regist_regist.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regist_regist.ForeColor = System.Drawing.Color.MintCream;
            this.btn_regist_regist.Location = new System.Drawing.Point(22, 576);
            this.btn_regist_regist.Name = "btn_regist_regist";
            this.btn_regist_regist.Size = new System.Drawing.Size(585, 62);
            this.btn_regist_regist.TabIndex = 7;
            this.btn_regist_regist.Text = "Regist";
            this.btn_regist_regist.UseVisualStyleBackColor = false;
            this.btn_regist_regist.Click += new System.EventHandler(this.btn_regist_regist_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(635, 657);
            this.Controls.Add(this.btn_regist_regist);
            this.Controls.Add(this.textBox_regist_totalBudget);
            this.Controls.Add(this.textBox_regist_password);
            this.Controls.Add(this.textBox_regist_username);
            this.Controls.Add(this.groupBox_regist_category);
            this.Controls.Add(this.lbl_regist_budget);
            this.Controls.Add(this.lbl_regist_password);
            this.Controls.Add(this.lbl_regist_username);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Registration";
            this.Text = "Registration";
            this.groupBox_regist_category.ResumeLayout(false);
            this.groupBox_regist_category.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_regist_username;
        private System.Windows.Forms.Label lbl_regist_password;
        private System.Windows.Forms.Label lbl_regist_budget;
        private System.Windows.Forms.GroupBox groupBox_regist_category;
        private System.Windows.Forms.TextBox textBox_regist_cost;
        private System.Windows.Forms.TextBox textBox_regist_category;
        private System.Windows.Forms.Label lbl_regist_cost;
        private System.Windows.Forms.Label lbl_regist_category;
        private System.Windows.Forms.Button btn_regist_addcategory;
        private System.Windows.Forms.TextBox textBox_regist_username;
        private System.Windows.Forms.TextBox textBox_regist_password;
        private System.Windows.Forms.TextBox textBox_regist_totalBudget;
        private System.Windows.Forms.Button btn_regist_regist;
    }
}