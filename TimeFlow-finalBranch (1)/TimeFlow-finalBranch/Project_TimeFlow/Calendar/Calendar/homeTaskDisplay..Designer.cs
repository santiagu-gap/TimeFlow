namespace Calendar
{
    partial class homeTaskDisplay
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
            this.taskIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(22, 20);
            this.taskName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(594, 88);
            this.taskName.TabIndex = 2;
            this.taskName.UseVisualStyleBackColor = true;
            this.taskName.CheckedChanged += new System.EventHandler(this.taskName_CheckedChanged);
            // 
            // dateDisplayBox
            // 
            this.dateDisplayBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplayBox.Location = new System.Drawing.Point(632, 33);
            this.dateDisplayBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateDisplayBox.Name = "dateDisplayBox";
            this.dateDisplayBox.Size = new System.Drawing.Size(186, 61);
            this.dateDisplayBox.TabIndex = 5;
            this.dateDisplayBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskIDLabel
            // 
            this.taskIDLabel.AutoSize = true;
            this.taskIDLabel.Location = new System.Drawing.Point(56, 45);
            this.taskIDLabel.Name = "taskIDLabel";
            this.taskIDLabel.Size = new System.Drawing.Size(0, 25);
            this.taskIDLabel.TabIndex = 6;
            // 
            // homeTaskDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskIDLabel);
            this.Controls.Add(this.dateDisplayBox);
            this.Controls.Add(this.taskName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "homeTaskDisplay";
            this.Size = new System.Drawing.Size(855, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox taskName;
        private System.Windows.Forms.Label dateDisplayBox;
        private System.Windows.Forms.Label taskIDLabel;
    }
}
