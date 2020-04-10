namespace C_Project
{
    partial class Login
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
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btn_login_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.Location = new System.Drawing.Point(20, 63);
            this.lbl_login_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(147, 29);
            this.lbl_login_username.TabIndex = 0;
            this.lbl_login_username.Text = "User Name :";
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_password.Location = new System.Drawing.Point(20, 167);
            this.lbl_login_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(120, 26);
            this.lbl_login_password.TabIndex = 1;
            this.lbl_login_password.Text = "Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(176, 73);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(203, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(176, 175);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(203, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // btn_login_enter
            // 
            this.btn_login_enter.BackColor = System.Drawing.Color.Teal;
            this.btn_login_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_enter.ForeColor = System.Drawing.Color.MintCream;
            this.btn_login_enter.Location = new System.Drawing.Point(112, 266);
            this.btn_login_enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login_enter.Name = "btn_login_enter";
            this.btn_login_enter.Size = new System.Drawing.Size(175, 64);
            this.btn_login_enter.TabIndex = 4;
            this.btn_login_enter.Text = "Enter";
            this.btn_login_enter.UseVisualStyleBackColor = false;
            this.btn_login_enter.Click += new System.EventHandler(this.btn_login_enter_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(417, 397);
            this.Controls.Add(this.btn_login_enter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.lbl_login_username);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btn_login_enter;
    }
}