namespace Calendar
{
    partial class Filter
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
            this.CategoryListLabel = new System.Windows.Forms.Label();
            this.categoriesList = new System.Windows.Forms.CheckedListBox();
            this.addCategoryButton = new System.Windows.Forms.Label();
            this.newCategoryName = new System.Windows.Forms.TextBox();
            this.deleteCategoryButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoryListLabel
            // 
            this.CategoryListLabel.AutoSize = true;
            this.CategoryListLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListLabel.Location = new System.Drawing.Point(18, 19);
            this.CategoryListLabel.Name = "CategoryListLabel";
            this.CategoryListLabel.Size = new System.Drawing.Size(98, 19);
            this.CategoryListLabel.TabIndex = 5;
            this.CategoryListLabel.Text = "Category List";
            // 
            // categoriesList
            // 
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Location = new System.Drawing.Point(22, 52);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(404, 319);
            this.categoriesList.TabIndex = 6;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.SystemColors.Window;
            this.addCategoryButton.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.Location = new System.Drawing.Point(344, 9);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(39, 38);
            this.addCategoryButton.TabIndex = 7;
            this.addCategoryButton.Text = "+";
            this.addCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // newCategoryName
            // 
            this.newCategoryName.Location = new System.Drawing.Point(164, 20);
            this.newCategoryName.Name = "newCategoryName";
            this.newCategoryName.Size = new System.Drawing.Size(175, 20);
            this.newCategoryName.TabIndex = 8;
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.BackColor = System.Drawing.SystemColors.Window;
            this.deleteCategoryButton.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryButton.Location = new System.Drawing.Point(387, 9);
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(39, 38);
            this.deleteCategoryButton.TabIndex = 9;
            this.deleteCategoryButton.Text = "-";
            this.deleteCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 396);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.newCategoryName);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.CategoryListLabel);
            this.Name = "Filter";
            this.Text = "Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Filter_FormClosing);
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CategoryListLabel;
        private System.Windows.Forms.CheckedListBox categoriesList;
        private System.Windows.Forms.Label addCategoryButton;
        private System.Windows.Forms.TextBox newCategoryName;
        private System.Windows.Forms.Label deleteCategoryButton;
    }
}