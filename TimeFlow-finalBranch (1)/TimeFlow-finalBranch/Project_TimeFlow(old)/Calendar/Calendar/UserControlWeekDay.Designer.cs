namespace Calendar
{
    partial class UserControlWeekDay
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
            this.dayNumberLabel = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayNumberLabel
            // 
            this.dayNumberLabel.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNumberLabel.Location = new System.Drawing.Point(15, 15);
            this.dayNumberLabel.Name = "dayNumberLabel";
            this.dayNumberLabel.Size = new System.Drawing.Size(45, 35);
            this.dayNumberLabel.TabIndex = 2;
            this.dayNumberLabel.Text = "00";
            this.dayNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTaskButton
            // 
            this.addTaskButton.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.Location = new System.Drawing.Point(257, 6);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(52, 47);
            this.addTaskButton.TabIndex = 5;
            this.addTaskButton.Text = "+";
            this.addTaskButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            this.addTaskButton.MouseEnter += new System.EventHandler(this.addTaskButton_MouseEnter);
            this.addTaskButton.MouseLeave += new System.EventHandler(this.addTaskButton_MouseLeave);
            // 
            // UserControlWeekDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.dayNumberLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlWeekDay";
            this.Size = new System.Drawing.Size(316, 1060);
            this.Load += new System.EventHandler(this.UserControlWeekDay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dayNumberLabel;
        private System.Windows.Forms.Label addTaskButton;
    }
}
