namespace Calendar
{
    partial class TaskPage
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.taskListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addTaskPanel = new System.Windows.Forms.Panel();
            this.taskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.taskTitleTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addTaskPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(211, 65);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "To Do List";
            // 
            // taskListFlowPanel
            // 
            this.taskListFlowPanel.AutoScroll = true;
            this.taskListFlowPanel.BackColor = System.Drawing.Color.White;
            this.taskListFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.taskListFlowPanel.ForeColor = System.Drawing.Color.Black;
            this.taskListFlowPanel.Location = new System.Drawing.Point(-3, 68);
            this.taskListFlowPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskListFlowPanel.Name = "taskListFlowPanel";
            this.taskListFlowPanel.Size = new System.Drawing.Size(1146, 927);
            this.taskListFlowPanel.TabIndex = 6;
            this.taskListFlowPanel.WrapContents = false;
            // 
            // addTaskPanel
            // 
            this.addTaskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.addTaskPanel.Controls.Add(this.categoryBox);
            this.addTaskPanel.Controls.Add(this.taskDateTimePicker);
            this.addTaskPanel.Controls.Add(this.label4);
            this.addTaskPanel.Controls.Add(this.editTaskButton);
            this.addTaskPanel.Controls.Add(this.label3);
            this.addTaskPanel.Controls.Add(this.addTaskButton);
            this.addTaskPanel.Controls.Add(this.taskTitleTextbox);
            this.addTaskPanel.Controls.Add(this.deleteButton);
            this.addTaskPanel.Controls.Add(this.label2);
            this.addTaskPanel.Controls.Add(this.taskDescriptionTextBox);
            this.addTaskPanel.Controls.Add(this.label5);
            this.addTaskPanel.Location = new System.Drawing.Point(1142, 54);
            this.addTaskPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTaskPanel.Name = "addTaskPanel";
            this.addTaskPanel.Size = new System.Drawing.Size(594, 939);
            this.addTaskPanel.TabIndex = 7;
            // 
            // taskDateTimePicker
            // 
            this.taskDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.taskDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.White;
            this.taskDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.taskDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.taskDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDateTimePicker.Location = new System.Drawing.Point(150, 786);
            this.taskDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDateTimePicker.Name = "taskDateTimePicker";
            this.taskDateTimePicker.Size = new System.Drawing.Size(381, 32);
            this.taskDateTimePicker.TabIndex = 50;
            // 
            // editTaskButton
            // 
            this.editTaskButton.BackColor = System.Drawing.Color.White;
            this.editTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTaskButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTaskButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.editTaskButton.Location = new System.Drawing.Point(408, 843);
            this.editTaskButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(123, 60);
            this.editTaskButton.TabIndex = 9;
            this.editTaskButton.Text = "Edit Task";
            this.editTaskButton.UseVisualStyleBackColor = false;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.White;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.addTaskButton.Location = new System.Drawing.Point(40, 843);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(123, 60);
            this.addTaskButton.TabIndex = 8;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.deleteButton.Location = new System.Drawing.Point(233, 843);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(123, 60);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete Task";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1160, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Task";
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(150, 725);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(379, 31);
            this.categoryBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 726);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Task Name";
            // 
            // taskTitleTextbox
            // 
            this.taskTitleTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitleTextbox.Location = new System.Drawing.Point(150, 53);
            this.taskTitleTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskTitleTextbox.Name = "taskTitleTextbox";
            this.taskTitleTextbox.Size = new System.Drawing.Size(383, 32);
            this.taskTitleTextbox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 795);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date";
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(150, 123);
            this.taskDescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDescriptionTextBox.Multiline = true;
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(383, 584);
            this.taskDescriptionTextBox.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1706, 68);
            this.panel1.TabIndex = 19;
            // 
            // TaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 984);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addTaskPanel);
            this.Controls.Add(this.taskListFlowPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskPage";
            this.Text = "TaskPage";
            this.Load += new System.EventHandler(this.TaskPage_Load);
            this.addTaskPanel.ResumeLayout(false);
            this.addTaskPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel taskListFlowPanel;
        private System.Windows.Forms.Panel addTaskPanel;
        private System.Windows.Forms.DateTimePicker taskDateTimePicker;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taskTitleTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskDescriptionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}