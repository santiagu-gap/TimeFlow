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
            this.SuspendLayout();
            // 
            // selectedDate
            // 
            this.selectedDate.Enabled = false;
            this.selectedDate.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedDate.Location = new System.Drawing.Point(208, 99);
            this.selectedDate.Name = "selectedDate";
            this.selectedDate.Size = new System.Drawing.Size(420, 32);
            this.selectedDate.TabIndex = 0;
            // 
            // taskDescription
            // 
            this.taskDescription.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescription.Location = new System.Drawing.Point(208, 261);
            this.taskDescription.Multiline = true;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(420, 79);
            this.taskDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // saveTaskButton
            // 
            this.saveTaskButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTaskButton.Location = new System.Drawing.Point(541, 373);
            this.saveTaskButton.Name = "saveTaskButton";
            this.saveTaskButton.Size = new System.Drawing.Size(87, 33);
            this.saveTaskButton.TabIndex = 4;
            this.saveTaskButton.Text = "Save";
            this.saveTaskButton.UseVisualStyleBackColor = true;
            this.saveTaskButton.Click += new System.EventHandler(this.saveTaskButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Task";
            // 
            // taskSubject
            // 
            this.taskSubject.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskSubject.Location = new System.Drawing.Point(208, 183);
            this.taskSubject.Name = "taskSubject";
            this.taskSubject.Size = new System.Drawing.Size(420, 32);
            this.taskSubject.TabIndex = 5;
            // 
            // AddTaskPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskSubject);
            this.Controls.Add(this.saveTaskButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.selectedDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}