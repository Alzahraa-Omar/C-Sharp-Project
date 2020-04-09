namespace C_Project
{
    partial class AddCategory
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
            this.textBox_addCategory_categoryCost = new System.Windows.Forms.TextBox();
            this.lbl_addCost = new System.Windows.Forms.Label();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.textBox_addedCategory_categoryName = new System.Windows.Forms.TextBox();
            this.lbl_addCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_addCategory_categoryCost
            // 
            this.textBox_addCategory_categoryCost.Location = new System.Drawing.Point(203, 122);
            this.textBox_addCategory_categoryCost.Name = "textBox_addCategory_categoryCost";
            this.textBox_addCategory_categoryCost.Size = new System.Drawing.Size(192, 22);
            this.textBox_addCategory_categoryCost.TabIndex = 17;
            this.textBox_addCategory_categoryCost.TextChanged += new System.EventHandler(this.textBox_edit_addCost_TextChanged);
            // 
            // lbl_addCost
            // 
            this.lbl_addCost.AutoSize = true;
            this.lbl_addCost.Location = new System.Drawing.Point(52, 125);
            this.lbl_addCost.Name = "lbl_addCost";
            this.lbl_addCost.Size = new System.Drawing.Size(65, 17);
            this.lbl_addCost.TabIndex = 16;
            this.lbl_addCost.Text = "Add Cost";
            this.lbl_addCost.Click += new System.EventHandler(this.lbl_edit_addCost_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.Teal;
            this.btn_addCategory.ForeColor = System.Drawing.Color.MintCream;
            this.btn_addCategory.Location = new System.Drawing.Point(408, 179);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(130, 54);
            this.btn_addCategory.TabIndex = 15;
            this.btn_addCategory.Text = "Add Category";
            this.btn_addCategory.UseVisualStyleBackColor = false;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_edit_addCategory_Click);
            // 
            // textBox_addedCategory_categoryName
            // 
            this.textBox_addedCategory_categoryName.Location = new System.Drawing.Point(203, 81);
            this.textBox_addedCategory_categoryName.Name = "textBox_addedCategory_categoryName";
            this.textBox_addedCategory_categoryName.Size = new System.Drawing.Size(192, 22);
            this.textBox_addedCategory_categoryName.TabIndex = 14;
            this.textBox_addedCategory_categoryName.TextChanged += new System.EventHandler(this.textBox_edit_addedCategory_TextChanged);
            // 
            // lbl_addCategory
            // 
            this.lbl_addCategory.AutoSize = true;
            this.lbl_addCategory.Location = new System.Drawing.Point(52, 81);
            this.lbl_addCategory.Name = "lbl_addCategory";
            this.lbl_addCategory.Size = new System.Drawing.Size(94, 17);
            this.lbl_addCategory.TabIndex = 13;
            this.lbl_addCategory.Text = "Add Category";
            this.lbl_addCategory.Click += new System.EventHandler(this.lbl_edit_addCategory_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 266);
            this.Controls.Add(this.textBox_addCategory_categoryCost);
            this.Controls.Add(this.lbl_addCost);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.textBox_addedCategory_categoryName);
            this.Controls.Add(this.lbl_addCategory);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_addCategory_categoryCost;
        private System.Windows.Forms.Label lbl_addCost;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.TextBox textBox_addedCategory_categoryName;
        private System.Windows.Forms.Label lbl_addCategory;
    }
}