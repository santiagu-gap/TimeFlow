namespace Calendar
{
    partial class TaskPreviewWindow
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
            this.taskSubject = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taskDescriptionTextBox = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskSubject
            // 
            this.taskSubject.AutoSize = true;
            this.taskSubject.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskSubject.Location = new System.Drawing.Point(8, 9);
            this.taskSubject.Name = "taskSubject";
            this.taskSubject.Size = new System.Drawing.Size(82, 19);
            this.taskSubject.TabIndex = 0;
            this.taskSubject.Text = "Task Name";
            // 
            // dateBox
            // 
            this.dateBox.Enabled = false;
            this.dateBox.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.Location = new System.Drawing.Point(12, 31);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(567, 30);
            this.dateBox.TabIndex = 2;
            this.dateBox.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taskDescriptionTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 219);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Info";
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.taskDescriptionTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.taskDescriptionTextBox.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(5, 24);
            this.taskDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(555, 189);
            this.taskDescriptionTextBox.TabIndex = 0;
            this.taskDescriptionTextBox.Text = "label1";
            // 
            // categoryBox
            // 
            this.categoryBox.Enabled = false;
            this.categoryBox.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.Location = new System.Drawing.Point(16, 95);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(567, 30);
            this.categoryBox.TabIndex = 5;
            this.categoryBox.Text = "Category";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(12, 73);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(71, 19);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Category";
            // 
            // TaskPreviewWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 385);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.taskSubject);
            this.Name = "TaskPreviewWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskPreviewWindow";
            this.Load += new System.EventHandler(this.TaskPreviewWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskSubject;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label taskDescriptionTextBox;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label CategoryLabel;
    }
}