﻿namespace C_Project
{
    partial class Edit
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
            this.lbl_edit_username = new System.Windows.Forms.Label();
            this.comboBox_edit_categories = new System.Windows.Forms.ComboBox();
            this.lbl_edit_removeCategory = new System.Windows.Forms.Label();
            this.btn_edit_removeCategory = new System.Windows.Forms.Button();
            this.textBox_edit_resetBudget = new System.Windows.Forms.TextBox();
            this.lbl_edit_resetBudget = new System.Windows.Forms.Label();
            this.btn_edit_resetBudget = new System.Windows.Forms.Button();
            this.btn_edit_save = new System.Windows.Forms.Button();
            this.btn_edit_addNewCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_edit_username
            // 
            this.lbl_edit_username.AutoSize = true;
            this.lbl_edit_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit_username.Location = new System.Drawing.Point(61, 56);
            this.lbl_edit_username.Name = "lbl_edit_username";
            this.lbl_edit_username.Size = new System.Drawing.Size(192, 38);
            this.lbl_edit_username.TabIndex = 0;
            this.lbl_edit_username.Text = "User Name";
            // 
            // comboBox_edit_categories
            // 
            this.comboBox_edit_categories.FormattingEnabled = true;
            this.comboBox_edit_categories.Location = new System.Drawing.Point(215, 274);
            this.comboBox_edit_categories.Name = "comboBox_edit_categories";
            this.comboBox_edit_categories.Size = new System.Drawing.Size(192, 24);
            this.comboBox_edit_categories.TabIndex = 1;
            // 
            // lbl_edit_removeCategory
            // 
            this.lbl_edit_removeCategory.AutoSize = true;
            this.lbl_edit_removeCategory.Location = new System.Drawing.Point(61, 277);
            this.lbl_edit_removeCategory.Name = "lbl_edit_removeCategory";
            this.lbl_edit_removeCategory.Size = new System.Drawing.Size(121, 17);
            this.lbl_edit_removeCategory.TabIndex = 2;
            this.lbl_edit_removeCategory.Text = "Remove Category";
            // 
            // btn_edit_removeCategory
            // 
            this.btn_edit_removeCategory.BackColor = System.Drawing.Color.Teal;
            this.btn_edit_removeCategory.ForeColor = System.Drawing.Color.MintCream;
            this.btn_edit_removeCategory.Location = new System.Drawing.Point(435, 268);
            this.btn_edit_removeCategory.Name = "btn_edit_removeCategory";
            this.btn_edit_removeCategory.Size = new System.Drawing.Size(130, 30);
            this.btn_edit_removeCategory.TabIndex = 5;
            this.btn_edit_removeCategory.Text = "Remove Category";
            this.btn_edit_removeCategory.UseVisualStyleBackColor = false;
            // 
            // textBox_edit_resetBudget
            // 
            this.textBox_edit_resetBudget.Location = new System.Drawing.Point(215, 183);
            this.textBox_edit_resetBudget.Name = "textBox_edit_resetBudget";
            this.textBox_edit_resetBudget.Size = new System.Drawing.Size(192, 22);
            this.textBox_edit_resetBudget.TabIndex = 7;
            // 
            // lbl_edit_resetBudget
            // 
            this.lbl_edit_resetBudget.AutoSize = true;
            this.lbl_edit_resetBudget.Location = new System.Drawing.Point(65, 188);
            this.lbl_edit_resetBudget.Name = "lbl_edit_resetBudget";
            this.lbl_edit_resetBudget.Size = new System.Drawing.Size(94, 17);
            this.lbl_edit_resetBudget.TabIndex = 8;
            this.lbl_edit_resetBudget.Text = "Reset Budget";
            // 
            // btn_edit_resetBudget
            // 
            this.btn_edit_resetBudget.BackColor = System.Drawing.Color.Teal;
            this.btn_edit_resetBudget.ForeColor = System.Drawing.Color.MintCream;
            this.btn_edit_resetBudget.Location = new System.Drawing.Point(435, 178);
            this.btn_edit_resetBudget.Name = "btn_edit_resetBudget";
            this.btn_edit_resetBudget.Size = new System.Drawing.Size(130, 28);
            this.btn_edit_resetBudget.TabIndex = 9;
            this.btn_edit_resetBudget.Text = "Reset Budget";
            this.btn_edit_resetBudget.UseVisualStyleBackColor = false;
            // 
            // btn_edit_save
            // 
            this.btn_edit_save.BackColor = System.Drawing.Color.Teal;
            this.btn_edit_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_save.ForeColor = System.Drawing.Color.MintCream;
            this.btn_edit_save.Location = new System.Drawing.Point(142, 476);
            this.btn_edit_save.Name = "btn_edit_save";
            this.btn_edit_save.Size = new System.Drawing.Size(326, 38);
            this.btn_edit_save.TabIndex = 10;
            this.btn_edit_save.Text = "Save";
            this.btn_edit_save.UseVisualStyleBackColor = false;
            // 
            // btn_edit_addNewCategory
            // 
            this.btn_edit_addNewCategory.Location = new System.Drawing.Point(226, 361);
            this.btn_edit_addNewCategory.Name = "btn_edit_addNewCategory";
            this.btn_edit_addNewCategory.Size = new System.Drawing.Size(145, 49);
            this.btn_edit_addNewCategory.TabIndex = 11;
            this.btn_edit_addNewCategory.Text = "Add New Category";
            this.btn_edit_addNewCategory.UseVisualStyleBackColor = true;
            this.btn_edit_addNewCategory.Click += new System.EventHandler(this.btn_edit_addNewCategory_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(590, 552);
            this.Controls.Add(this.btn_edit_addNewCategory);
            this.Controls.Add(this.btn_edit_save);
            this.Controls.Add(this.btn_edit_resetBudget);
            this.Controls.Add(this.lbl_edit_resetBudget);
            this.Controls.Add(this.textBox_edit_resetBudget);
            this.Controls.Add(this.btn_edit_removeCategory);
            this.Controls.Add(this.lbl_edit_removeCategory);
            this.Controls.Add(this.comboBox_edit_categories);
            this.Controls.Add(this.lbl_edit_username);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_edit_username;
        private System.Windows.Forms.ComboBox comboBox_edit_categories;
        private System.Windows.Forms.Label lbl_edit_removeCategory;
        private System.Windows.Forms.Button btn_edit_removeCategory;
        private System.Windows.Forms.TextBox textBox_edit_resetBudget;
        private System.Windows.Forms.Label lbl_edit_resetBudget;
        private System.Windows.Forms.Button btn_edit_resetBudget;
        private System.Windows.Forms.Button btn_edit_save;
        private System.Windows.Forms.Button btn_edit_addNewCategory;
    }
}