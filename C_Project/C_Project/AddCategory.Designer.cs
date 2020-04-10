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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_addCategory_categoryCost
            // 
            this.textBox_addCategory_categoryCost.Location = new System.Drawing.Point(152, 99);
            this.textBox_addCategory_categoryCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_addCategory_categoryCost.Name = "textBox_addCategory_categoryCost";
            this.textBox_addCategory_categoryCost.Size = new System.Drawing.Size(145, 20);
            this.textBox_addCategory_categoryCost.TabIndex = 17;
            this.textBox_addCategory_categoryCost.TextChanged += new System.EventHandler(this.textBox_edit_addCost_TextChanged);
            this.textBox_addCategory_categoryCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_addCategory_categoryCost_KeyPress);
            // 
            // lbl_addCost
            // 
            this.lbl_addCost.AutoSize = true;
            this.lbl_addCost.Location = new System.Drawing.Point(39, 102);
            this.lbl_addCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_addCost.Name = "lbl_addCost";
            this.lbl_addCost.Size = new System.Drawing.Size(50, 13);
            this.lbl_addCost.TabIndex = 16;
            this.lbl_addCost.Text = "Add Cost";
            this.lbl_addCost.Click += new System.EventHandler(this.lbl_edit_addCost_Click);
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.Teal;
            this.btn_addCategory.ForeColor = System.Drawing.Color.MintCream;
            this.btn_addCategory.Location = new System.Drawing.Point(306, 145);
            this.btn_addCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(98, 44);
            this.btn_addCategory.TabIndex = 15;
            this.btn_addCategory.Text = "Add Category";
            this.btn_addCategory.UseVisualStyleBackColor = false;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_edit_addCategory_Click);
            // 
            // textBox_addedCategory_categoryName
            // 
            this.textBox_addedCategory_categoryName.Location = new System.Drawing.Point(152, 66);
            this.textBox_addedCategory_categoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_addedCategory_categoryName.Name = "textBox_addedCategory_categoryName";
            this.textBox_addedCategory_categoryName.Size = new System.Drawing.Size(145, 20);
            this.textBox_addedCategory_categoryName.TabIndex = 14;
            this.textBox_addedCategory_categoryName.TextChanged += new System.EventHandler(this.textBox_edit_addedCategory_TextChanged);
            // 
            // lbl_addCategory
            // 
            this.lbl_addCategory.AutoSize = true;
            this.lbl_addCategory.Location = new System.Drawing.Point(39, 66);
            this.lbl_addCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_addCategory.Name = "lbl_addCategory";
            this.lbl_addCategory.Size = new System.Drawing.Size(71, 13);
            this.lbl_addCategory.TabIndex = 13;
            this.lbl_addCategory.Text = "Add Category";
            this.lbl_addCategory.Click += new System.EventHandler(this.lbl_edit_addCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(323, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_addCategory_categoryCost);
            this.Controls.Add(this.lbl_addCost);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.textBox_addedCategory_categoryName);
            this.Controls.Add(this.lbl_addCategory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label1;
    }
}