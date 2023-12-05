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
            this.taskName.Location = new System.Drawing.Point(19, 10);
            this.taskName.Margin = new System.Windows.Forms.Padding(2);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(668, 46);
            this.taskName.TabIndex = 1;
            this.taskName.UseVisualStyleBackColor = true;
            this.taskName.CheckedChanged += new System.EventHandler(this.taskName_CheckedChanged);
            // 
            // dateDisplayBox
            // 
            this.dateDisplayBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplayBox.Location = new System.Drawing.Point(742, 16);
            this.dateDisplayBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateDisplayBox.Name = "dateDisplayBox";
            this.dateDisplayBox.Size = new System.Drawing.Size(93, 32);
            this.dateDisplayBox.TabIndex = 4;
            this.dateDisplayBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(248, 0);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(0, 19);
            this.dueDateLabel.TabIndex = 5;
            // 
            // TaskDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.dateDisplayBox);
            this.Controls.Add(this.taskName);
            this.Name = "TaskDisplay";
            this.Size = new System.Drawing.Size(852, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion


        private System.Windows.Forms.CheckBox taskName;
        private System.Windows.Forms.Label dateDisplayBox;
        private System.Windows.Forms.Label dueDateLabel;
    }
}