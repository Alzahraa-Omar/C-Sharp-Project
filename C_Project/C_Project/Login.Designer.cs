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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_login_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.Location = new System.Drawing.Point(27, 77);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(179, 36);
            this.lbl_login_username.TabIndex = 0;
            this.lbl_login_username.Text = "User Name :";
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_password.Location = new System.Drawing.Point(27, 205);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(154, 32);
            this.lbl_login_password.TabIndex = 1;
            this.lbl_login_password.Text = "Password :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btn_login_enter
            // 
            this.btn_login_enter.BackColor = System.Drawing.Color.Teal;
            this.btn_login_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_enter.ForeColor = System.Drawing.Color.MintCream;
            this.btn_login_enter.Location = new System.Drawing.Point(150, 327);
            this.btn_login_enter.Name = "btn_login_enter";
            this.btn_login_enter.Size = new System.Drawing.Size(233, 79);
            this.btn_login_enter.TabIndex = 4;
            this.btn_login_enter.Text = "Enter";
            this.btn_login_enter.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(556, 489);
            this.Controls.Add(this.btn_login_enter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_login_password);
            this.Controls.Add(this.lbl_login_username);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_login_enter;
    }
}