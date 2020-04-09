namespace C_Project
{
    partial class Form1
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
            this.lbl_tadabeer = new System.Windows.Forms.Label();
            this.lbl_caption = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tadabeer
            // 
            this.lbl_tadabeer.AutoSize = true;
            this.lbl_tadabeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tadabeer.Location = new System.Drawing.Point(77, 26);
            this.lbl_tadabeer.Name = "lbl_tadabeer";
            this.lbl_tadabeer.Size = new System.Drawing.Size(477, 91);
            this.lbl_tadabeer.TabIndex = 0;
            this.lbl_tadabeer.Text = "TADABEER";
            // 
            // lbl_caption
            // 
            this.lbl_caption.AutoSize = true;
            this.lbl_caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caption.Location = new System.Drawing.Point(86, 187);
            this.lbl_caption.Name = "lbl_caption";
            this.lbl_caption.Size = new System.Drawing.Size(469, 36);
            this.lbl_caption.TabIndex = 1;
            this.lbl_caption.Text = "A Better Measure For A Better Life";
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.Teal;
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_signup.Location = new System.Drawing.Point(72, 349);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(204, 113);
            this.btn_signup.TabIndex = 2;
            this.btn_signup.Text = "SIGN UP";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Teal;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_login.Location = new System.Drawing.Point(383, 349);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(204, 113);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(668, 537);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.lbl_caption);
            this.Controls.Add(this.lbl_tadabeer);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Form1";
            this.Text = "TADABEER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tadabeer;
        private System.Windows.Forms.Label lbl_caption;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_login;
    }
}

