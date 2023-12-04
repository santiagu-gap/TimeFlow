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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskPopUp));
            this.selectedDate = new System.Windows.Forms.TextBox();
            this.taskDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveTaskButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.taskSubject = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedDate
            // 
            this.selectedDate.Enabled = false;
            this.selectedDate.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedDate.Location = new System.Drawing.Point(140, 401);
            this.selectedDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectedDate.Name = "selectedDate";
            this.selectedDate.Size = new System.Drawing.Size(464, 27);
            this.selectedDate.TabIndex = 0;
            // 
            // taskDescription
            // 
            this.taskDescription.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescription.Location = new System.Drawing.Point(140, 140);
            this.taskDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taskDescription.Multiline = true;
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(464, 179);
            this.taskDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 404);
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
            this.label2.Location = new System.Drawing.Point(32, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // saveTaskButton
            // 
            this.saveTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.saveTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTaskButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTaskButton.ForeColor = System.Drawing.Color.White;
            this.saveTaskButton.Location = new System.Drawing.Point(511, 466);
            this.saveTaskButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveTaskButton.Name = "saveTaskButton";
            this.saveTaskButton.Size = new System.Drawing.Size(92, 34);
            this.saveTaskButton.TabIndex = 4;
            this.saveTaskButton.Text = "SAVE";
            this.saveTaskButton.UseVisualStyleBackColor = false;
            this.saveTaskButton.Click += new System.EventHandler(this.saveTaskButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Task Name";
            // 
            // taskSubject
            // 
            this.taskSubject.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskSubject.Location = new System.Drawing.Point(140, 83);
            this.taskSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taskSubject.Name = "taskSubject";
            this.taskSubject.Size = new System.Drawing.Size(464, 27);
            this.taskSubject.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 43);
            this.panel1.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(614, 14);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(15, 16);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitButton.TabIndex = 13;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "New Task";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.cancelButton.Location = new System.Drawing.Point(414, 466);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 34);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category";
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.Font = new System.Drawing.Font("Candara Light", 12F);
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(140, 347);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(464, 27);
            this.categoryBox.TabIndex = 10;
            // 
            // AddTaskPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(643, 510);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taskSubject);
            this.Controls.Add(this.saveTaskButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.selectedDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTaskPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.AddTaskPopUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox exitButton;
    }
}