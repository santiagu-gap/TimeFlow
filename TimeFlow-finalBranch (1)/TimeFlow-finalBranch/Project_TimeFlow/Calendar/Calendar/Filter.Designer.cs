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
            this.deleteCategoryButton = new System.Windows.Forms.Label();
            this.newCategoryName = new System.Windows.Forms.TextBox();
            this.addCategoryButton = new System.Windows.Forms.Label();
            this.categoriesList = new System.Windows.Forms.CheckedListBox();
            this.CategoryListLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.PriorityBox = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.BackColor = System.Drawing.SystemColors.Window;
            this.deleteCategoryButton.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategoryButton.Location = new System.Drawing.Point(288, 254);
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(30, 30);
            this.deleteCategoryButton.TabIndex = 14;
            this.deleteCategoryButton.Text = "-";
            this.deleteCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // newCategoryName
            // 
            this.newCategoryName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCategoryName.Location = new System.Drawing.Point(108, 257);
            this.newCategoryName.Name = "newCategoryName";
            this.newCategoryName.Size = new System.Drawing.Size(175, 26);
            this.newCategoryName.TabIndex = 13;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.SystemColors.Window;
            this.addCategoryButton.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryButton.Location = new System.Drawing.Point(328, 254);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(30, 30);
            this.addCategoryButton.TabIndex = 12;
            this.addCategoryButton.Text = "+";
            this.addCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // categoriesList
            // 
            this.categoriesList.BackColor = System.Drawing.Color.White;
            this.categoriesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoriesList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesList.FormattingEnabled = true;
            this.categoriesList.Location = new System.Drawing.Point(16, 91);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoriesList.Size = new System.Drawing.Size(404, 160);
            this.categoriesList.TabIndex = 11;
            // 
            // CategoryListLabel
            // 
            this.CategoryListLabel.AutoSize = true;
            this.CategoryListLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryListLabel.Location = new System.Drawing.Point(12, 67);
            this.CategoryListLabel.Name = "CategoryListLabel";
            this.CategoryListLabel.Size = new System.Drawing.Size(112, 21);
            this.CategoryListLabel.TabIndex = 10;
            this.CategoryListLabel.Text = "Category List";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityLabel.Location = new System.Drawing.Point(12, 302);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(60, 21);
            this.PriorityLabel.TabIndex = 15;
            this.PriorityLabel.Text = "Priority";
            // 
            // PriorityBox
            // 
            this.PriorityBox.BackColor = System.Drawing.Color.White;
            this.PriorityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriorityBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityBox.FormattingEnabled = true;
            this.PriorityBox.Location = new System.Drawing.Point(16, 326);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PriorityBox.Size = new System.Drawing.Size(404, 80);
            this.PriorityBox.TabIndex = 16;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(337, 426);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 32);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 51);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "New Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Filtering";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(450, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.newCategoryName);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.CategoryListLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Filter_FormClosing);
            this.Load += new System.EventHandler(this.Filter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteCategoryButton;
        private System.Windows.Forms.TextBox newCategoryName;
        private System.Windows.Forms.Label addCategoryButton;
        private System.Windows.Forms.CheckedListBox categoriesList;
        private System.Windows.Forms.Label CategoryListLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.CheckedListBox PriorityBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}