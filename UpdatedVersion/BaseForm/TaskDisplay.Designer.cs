namespace BaseForm
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
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.dateDisplayBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(3, 3);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(686, 113);
            this.taskName.TabIndex = 0;
            this.taskName.UseVisualStyleBackColor = true;
            this.taskName.CheckedChanged += new System.EventHandler(this.taskName_CheckedChanged);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Candara", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(525, 3);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(121, 33);
            this.dueDateLabel.TabIndex = 1;
            this.dueDateLabel.Text = "Due Date";
            this.dueDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateDisplayBox
            // 
            this.dateDisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplayBox.Location = new System.Drawing.Point(488, 46);
            this.dateDisplayBox.Name = "dateDisplayBox";
            this.dateDisplayBox.Size = new System.Drawing.Size(186, 62);
            this.dateDisplayBox.TabIndex = 3;
            // 
            // TaskDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateDisplayBox);
            this.Controls.Add(this.dueDateLabel);
            this.Controls.Add(this.taskName);
            this.Name = "TaskDisplay";
            this.Size = new System.Drawing.Size(689, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox taskName;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label dateDisplayBox;
    }
}
