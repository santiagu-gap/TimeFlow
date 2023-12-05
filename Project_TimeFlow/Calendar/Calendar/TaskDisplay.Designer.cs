namespace Calendar
{
    partial class TaskDisplay
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


        #region Component Designer generated code


        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskName = new System.Windows.Forms.CheckBox();
            this.dateDisplayBox = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(25, 12);
            this.taskName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(891, 56);
            this.taskName.TabIndex = 1;
            this.taskName.UseVisualStyleBackColor = true;
            // 
            // dateDisplayBox
            // 
            this.dateDisplayBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplayBox.Location = new System.Drawing.Point(990, 20);
            this.dateDisplayBox.Name = "dateDisplayBox";
            this.dateDisplayBox.Size = new System.Drawing.Size(124, 39);
            this.dateDisplayBox.TabIndex = 4;
            this.dateDisplayBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(330, 0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(0, 21);
            this.dueDateLabel.TabIndex = 5;
            // 
            // TaskDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.dateDisplayBox);
            this.Controls.Add(this.taskName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskDisplay";
            this.Size = new System.Drawing.Size(1136, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion


        private System.Windows.Forms.CheckBox taskName;
        private System.Windows.Forms.Label dateDisplayBox;
        private System.Windows.Forms.Label dueDateLabel;
    }
}