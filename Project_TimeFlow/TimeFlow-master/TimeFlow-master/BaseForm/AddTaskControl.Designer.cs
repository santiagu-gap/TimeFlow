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
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.taskDescriptionLabel = new System.Windows.Forms.Label();
            this.taskTitleTextbox = new System.Windows.Forms.TextBox();
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.taskListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.toDoListView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.taskListFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
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
            this.panel2.Controls.Add(this.editTaskButton);
            this.panel2.Controls.Add(this.addTaskButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.taskDescriptionTextBox);
            this.panel2.Controls.Add(this.taskDescriptionLabel);
            this.panel2.Controls.Add(this.taskTitleTextbox);
            this.panel2.Controls.Add(this.taskTitleLabel);
            this.panel2.Location = new System.Drawing.Point(1261, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 437);
            this.panel2.TabIndex = 4;
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
            this.taskListFlowPanel.Controls.Add(this.flowLayoutPanel1);
            this.taskListFlowPanel.Controls.Add(this.flowLayoutPanel2);
            this.taskListFlowPanel.Location = new System.Drawing.Point(417, 126);
            this.taskListFlowPanel.Name = "taskListFlowPanel";
            this.taskListFlowPanel.Size = new System.Drawing.Size(692, 805);
            this.taskListFlowPanel.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(689, 119);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 128);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(689, 130);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(10, 287);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(140, 95);
            this.addTaskButton.TabIndex = 8;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Location = new System.Drawing.Point(422, 287);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(144, 95);
            this.editTaskButton.TabIndex = 9;
            this.editTaskButton.Text = "Edit Task";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(210, 288);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 94);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete Task";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // toDoListView
            // 
            this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.toDoListView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toDoListView.Location = new System.Drawing.Point(1190, 589);
            this.toDoListView.Name = "toDoListView";
            this.toDoListView.RowHeadersWidth = 82;
            this.toDoListView.RowTemplate.Height = 33;
            this.toDoListView.Size = new System.Drawing.Size(713, 342);
            this.toDoListView.TabIndex = 6;
            // 
            // AddTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toDoListView);
            this.Controls.Add(this.taskListFlowPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLabel);
            this.Name = "AddTaskControl";
            this.Size = new System.Drawing.Size(1977, 1046);
            this.Load += new System.EventHandler(this.AddTaskControl_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.taskListFlowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView toDoListView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
