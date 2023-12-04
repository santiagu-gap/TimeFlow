namespace BaseForm
{
    partial class AddTaskControl
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.taskDateLabel = new System.Windows.Forms.Label();
            this.taskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.taskDescriptionLabel = new System.Windows.Forms.Label();
            this.taskTitleTextbox = new System.Windows.Forms.TextBox();
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.taskListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Candara", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(613, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(316, 101);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "To Do List";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1334, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 84);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Task";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.taskDateLabel);
            this.panel2.Controls.Add(this.taskDateTimePicker);
            this.panel2.Controls.Add(this.editTaskButton);
            this.panel2.Controls.Add(this.addTaskButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.taskDescriptionTextBox);
            this.panel2.Controls.Add(this.taskDescriptionLabel);
            this.panel2.Controls.Add(this.taskTitleTextbox);
            this.panel2.Controls.Add(this.taskTitleLabel);
            this.panel2.Location = new System.Drawing.Point(1261, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 515);
            this.panel2.TabIndex = 4;
            // 
            // taskDateLabel
            // 
            this.taskDateLabel.AutoSize = true;
            this.taskDateLabel.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDateLabel.Location = new System.Drawing.Point(3, 284);
            this.taskDateLabel.Name = "taskDateLabel";
            this.taskDateLabel.Size = new System.Drawing.Size(215, 39);
            this.taskDateLabel.TabIndex = 12;
            this.taskDateLabel.Text = "Task Deadline: ";
            // 
            // taskDateTimePicker
            // 
            this.taskDateTimePicker.Location = new System.Drawing.Point(10, 336);
            this.taskDateTimePicker.Name = "taskDateTimePicker";
            this.taskDateTimePicker.Size = new System.Drawing.Size(350, 31);
            this.taskDateTimePicker.TabIndex = 50;
            // 
            // editTaskButton
            // 
            this.editTaskButton.Location = new System.Drawing.Point(422, 397);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(144, 95);
            this.editTaskButton.TabIndex = 9;
            this.editTaskButton.Text = "Edit Task";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(10, 397);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(140, 95);
            this.addTaskButton.TabIndex = 8;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(210, 398);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 94);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete Task";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(10, 208);
            this.taskDescriptionTextBox.Multiline = true;
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(556, 57);
            this.taskDescriptionTextBox.TabIndex = 7;
            // 
            // taskDescriptionLabel
            // 
            this.taskDescriptionLabel.AutoSize = true;
            this.taskDescriptionLabel.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescriptionLabel.Location = new System.Drawing.Point(3, 155);
            this.taskDescriptionLabel.Name = "taskDescriptionLabel";
            this.taskDescriptionLabel.Size = new System.Drawing.Size(242, 39);
            this.taskDescriptionLabel.TabIndex = 6;
            this.taskDescriptionLabel.Text = "Task Description:";
            // 
            // taskTitleTextbox
            // 
            this.taskTitleTextbox.Location = new System.Drawing.Point(10, 72);
            this.taskTitleTextbox.Multiline = true;
            this.taskTitleTextbox.Name = "taskTitleTextbox";
            this.taskTitleTextbox.Size = new System.Drawing.Size(556, 57);
            this.taskTitleTextbox.TabIndex = 6;
            // 
            // taskTitleLabel
            // 
            this.taskTitleLabel.AutoSize = true;
            this.taskTitleLabel.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitleLabel.Location = new System.Drawing.Point(3, 30);
            this.taskTitleLabel.Name = "taskTitleLabel";
            this.taskTitleLabel.Size = new System.Drawing.Size(147, 39);
            this.taskTitleLabel.TabIndex = 5;
            this.taskTitleLabel.Text = "Task Title:";
            // 
            // taskListFlowPanel
            // 
            this.taskListFlowPanel.AutoScroll = true;
            this.taskListFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.taskListFlowPanel.Location = new System.Drawing.Point(387, 126);
            this.taskListFlowPanel.Name = "taskListFlowPanel";
            this.taskListFlowPanel.Size = new System.Drawing.Size(723, 823);
            this.taskListFlowPanel.TabIndex = 5;
            this.taskListFlowPanel.WrapContents = false;
            // 
            // AddTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskListFlowPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddTaskControl";
            this.Size = new System.Drawing.Size(1977, 1046);
            this.Load += new System.EventHandler(this.AddTaskControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox taskDescriptionTextBox;
        private System.Windows.Forms.Label taskDescriptionLabel;
        private System.Windows.Forms.TextBox taskTitleTextbox;
        private System.Windows.Forms.Label taskTitleLabel;
        private System.Windows.Forms.FlowLayoutPanel taskListFlowPanel;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button deleteButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker taskDateTimePicker;
        private System.Windows.Forms.Label taskDateLabel;
    }
}
