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
            this.textBox_regist_username = new System.Windows.Forms.TextBox();
            this.textBox_regist_password = new System.Windows.Forms.TextBox();
            this.textBox_regist_totalBudget = new System.Windows.Forms.TextBox();
            this.btn_regist_regist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_regist_username
            // 
            this.lbl_regist_username.AutoSize = true;
            this.lbl_regist_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_username.Location = new System.Drawing.Point(26, 162);
            this.lbl_regist_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_regist_username.Name = "lbl_regist_username";
            this.lbl_regist_username.Size = new System.Drawing.Size(115, 24);
            this.lbl_regist_username.TabIndex = 0;
            this.lbl_regist_username.Text = "User Name :";
            this.lbl_regist_username.Click += new System.EventHandler(this.lbl_regist_username_Click);
            // 
            // lbl_regist_password
            // 
            this.lbl_regist_password.AutoSize = true;
            this.lbl_regist_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_password.Location = new System.Drawing.Point(39, 247);
            this.lbl_regist_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_regist_password.Name = "lbl_regist_password";
            this.lbl_regist_password.Size = new System.Drawing.Size(102, 24);
            this.lbl_regist_password.TabIndex = 1;
            this.lbl_regist_password.Text = "Password :";
            // 
            // lbl_regist_budget
            // 
            this.lbl_regist_budget.AutoSize = true;
            this.lbl_regist_budget.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regist_budget.Location = new System.Drawing.Point(52, 325);
            this.lbl_regist_budget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_regist_budget.Name = "lbl_regist_budget";
            this.lbl_regist_budget.Size = new System.Drawing.Size(80, 24);
            this.lbl_regist_budget.TabIndex = 2;
            this.lbl_regist_budget.Text = "Budget :";
            // 
            // textBox_regist_username
            // 
            this.textBox_regist_username.Location = new System.Drawing.Point(174, 166);
            this.textBox_regist_username.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_regist_username.Name = "textBox_regist_username";
            this.textBox_regist_username.Size = new System.Drawing.Size(218, 20);
            this.textBox_regist_username.TabIndex = 4;
            this.textBox_regist_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_regist_username_KeyPress);
            // 
            // textBox_regist_password
            // 
            this.textBox_regist_password.Location = new System.Drawing.Point(174, 251);
            this.textBox_regist_password.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_regist_password.Name = "textBox_regist_password";
            this.textBox_regist_password.Size = new System.Drawing.Size(218, 20);
            this.textBox_regist_password.TabIndex = 5;
            this.textBox_regist_password.UseSystemPasswordChar = true;
            this.textBox_regist_password.TextChanged += new System.EventHandler(this.textBox_regist_password_TextChanged);
            // 
            // textBox_regist_totalBudget
            // 
            this.textBox_regist_totalBudget.Location = new System.Drawing.Point(174, 338);
            this.textBox_regist_totalBudget.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_regist_totalBudget.Name = "textBox_regist_totalBudget";
            this.textBox_regist_totalBudget.Size = new System.Drawing.Size(218, 20);
            this.textBox_regist_totalBudget.TabIndex = 6;
            this.textBox_regist_totalBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_regist_totalBudget_KeyPress);
            // 
            // btn_regist_regist
            // 
            this.btn_regist_regist.BackColor = System.Drawing.Color.Teal;
            this.btn_regist_regist.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regist_regist.ForeColor = System.Drawing.Color.MintCream;
            this.btn_regist_regist.Location = new System.Drawing.Point(11, 435);
            this.btn_regist_regist.Margin = new System.Windows.Forms.Padding(2);
            this.btn_regist_regist.Name = "btn_regist_regist";
            this.btn_regist_regist.Size = new System.Drawing.Size(439, 50);
            this.btn_regist_regist.TabIndex = 7;
            this.btn_regist_regist.Text = "Regist";
            this.btn_regist_regist.UseVisualStyleBackColor = false;
            this.btn_regist_regist.Click += new System.EventHandler(this.btn_regist_regist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(496, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regist_regist);
            this.Controls.Add(this.textBox_regist_totalBudget);
            this.Controls.Add(this.textBox_regist_password);
            this.Controls.Add(this.textBox_regist_username);
            this.Controls.Add(this.lbl_regist_budget);
            this.Controls.Add(this.lbl_regist_password);
            this.Controls.Add(this.lbl_regist_username);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_regist_username;
        private System.Windows.Forms.Label lbl_regist_password;
        private System.Windows.Forms.Label lbl_regist_budget;
        private System.Windows.Forms.TextBox textBox_regist_username;
        private System.Windows.Forms.TextBox textBox_regist_password;
        private System.Windows.Forms.TextBox textBox_regist_totalBudget;
        private System.Windows.Forms.Button btn_regist_regist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}