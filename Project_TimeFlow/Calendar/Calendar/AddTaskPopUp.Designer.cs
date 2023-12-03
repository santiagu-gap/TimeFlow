namespace Calendar
{
    partial class AddTaskPopUp
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
            this.selectedDate = new System.Windows.Forms.TextBox();
            this.taskDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveTaskButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.taskSubject = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selectedDate
            // 
            this.selectedDate.Enabled = false;
            this.selectedDate.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedDate.Location = new System.Drawing.Point(156, 80);
            this.selectedDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectedDate.Name = "selectedDate";
            this.selectedDate.Size = new System.Drawing.Size(316, 27);
            this.selectedDate.TabIndex = 0;
            // 
            // taskDescription
            // 
            this.taskDescription.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescription.Location = new System.Drawing.Point(156, 295);
            this.taskDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taskDescription.Multiline = true;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(316, 65);
            this.taskDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // saveTaskButton
            // 
            this.saveTaskButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTaskButton.Location = new System.Drawing.Point(406, 386);
            this.saveTaskButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveTaskButton.Name = "saveTaskButton";
            this.saveTaskButton.Size = new System.Drawing.Size(65, 27);
            this.saveTaskButton.TabIndex = 4;
            this.saveTaskButton.Text = "Save";
            this.saveTaskButton.UseVisualStyleBackColor = true;
            this.saveTaskButton.Click += new System.EventHandler(this.saveTaskButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Task";
            // 
            // taskSubject
            // 
            this.taskSubject.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskSubject.Location = new System.Drawing.Point(156, 149);
            this.taskSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taskSubject.Name = "taskSubject";
            this.taskSubject.Size = new System.Drawing.Size(316, 27);
            this.taskSubject.TabIndex = 5;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(164, 191);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(71, 19);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Category";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(156, 222);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(316, 21);
            this.categoryBox.TabIndex = 8;
            // 
            // AddTaskPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 445);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskSubject);
            this.Controls.Add(this.saveTaskButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.selectedDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTaskPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.AddTaskPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectedDate;
        private System.Windows.Forms.TextBox taskDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveTaskButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taskSubject;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox categoryBox;
    }
}