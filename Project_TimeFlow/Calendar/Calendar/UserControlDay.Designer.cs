namespace Calendar
{
    partial class UserControlDay
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
            this.components = new System.ComponentModel.Container();
            this.dayNumberLabel = new System.Windows.Forms.Label();
            this.taskLabel1 = new System.Windows.Forms.Label();
            this.tasksFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tasksPanel = new System.Windows.Forms.Panel();
            this.taskLabel3 = new System.Windows.Forms.Label();
            this.taskLabel2 = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Label();
            this.autoAddTaskTimer = new System.Windows.Forms.Timer(this.components);
            this.tasksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayNumberLabel
            // 
            this.dayNumberLabel.AutoSize = true;
            this.dayNumberLabel.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNumberLabel.Location = new System.Drawing.Point(15, 17);
            this.dayNumberLabel.Name = "dayNumberLabel";
            this.dayNumberLabel.Size = new System.Drawing.Size(38, 28);
            this.dayNumberLabel.TabIndex = 0;
            this.dayNumberLabel.Text = "00";
            // 
            // taskLabel1
            // 
            this.taskLabel1.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel1.Location = new System.Drawing.Point(17, 0);
            this.taskLabel1.Name = "taskLabel1";
            this.taskLabel1.Size = new System.Drawing.Size(198, 21);
            this.taskLabel1.TabIndex = 0;
            this.taskLabel1.Click += new System.EventHandler(this.taskLabel1_Click);
            this.taskLabel1.MouseEnter += new System.EventHandler(this.taskLabel1_MouseEnter);
            this.taskLabel1.MouseLeave += new System.EventHandler(this.taskLabel1_MouseLeave);
            // 
            // tasksFlowPanel
            // 
            this.tasksFlowPanel.Location = new System.Drawing.Point(20, 50);
            this.tasksFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tasksFlowPanel.Name = "tasksFlowPanel";
            this.tasksFlowPanel.Size = new System.Drawing.Size(0, 0);
            this.tasksFlowPanel.TabIndex = 1;
            this.tasksFlowPanel.Click += new System.EventHandler(this.tasksFlowPanel_Click);
            // 
            // tasksPanel
            // 
            this.tasksPanel.Controls.Add(this.taskLabel3);
            this.tasksPanel.Controls.Add(this.taskLabel2);
            this.tasksPanel.Controls.Add(this.taskLabel1);
            this.tasksPanel.Location = new System.Drawing.Point(3, 50);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Size = new System.Drawing.Size(230, 81);
            this.tasksPanel.TabIndex = 3;
            // 
            // taskLabel3
            // 
            this.taskLabel3.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel3.Location = new System.Drawing.Point(17, 61);
            this.taskLabel3.Name = "taskLabel3";
            this.taskLabel3.Size = new System.Drawing.Size(198, 21);
            this.taskLabel3.TabIndex = 2;
            this.taskLabel3.Click += new System.EventHandler(this.taskLabel3_Click);
            this.taskLabel3.MouseEnter += new System.EventHandler(this.taskLabel3_MouseEnter);
            this.taskLabel3.MouseLeave += new System.EventHandler(this.taskLabel3_MouseLeave);
            // 
            // taskLabel2
            // 
            this.taskLabel2.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel2.Location = new System.Drawing.Point(17, 31);
            this.taskLabel2.Name = "taskLabel2";
            this.taskLabel2.Size = new System.Drawing.Size(198, 21);
            this.taskLabel2.TabIndex = 1;
            this.taskLabel2.Click += new System.EventHandler(this.taskLabel2_Click);
            this.taskLabel2.MouseEnter += new System.EventHandler(this.taskLabel2_MouseEnter);
            this.taskLabel2.MouseLeave += new System.EventHandler(this.taskLabel2_MouseLeave);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.Location = new System.Drawing.Point(184, 0);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(52, 47);
            this.addTaskButton.TabIndex = 4;
            this.addTaskButton.Text = "+";
            this.addTaskButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            this.addTaskButton.MouseEnter += new System.EventHandler(this.addTaskButton_MouseEnter);
            this.addTaskButton.MouseLeave += new System.EventHandler(this.addTaskButton_MouseLeave);
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.tasksPanel);
            this.Controls.Add(this.tasksFlowPanel);
            this.Controls.Add(this.dayNumberLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(236, 134);
            this.Load += new System.EventHandler(this.UserControlDay_Load);
            this.tasksPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayNumberLabel;
        private System.Windows.Forms.Label taskLabel1;
        private System.Windows.Forms.FlowLayoutPanel tasksFlowPanel;
        private System.Windows.Forms.Panel tasksPanel;
        private System.Windows.Forms.Label taskLabel3;
        private System.Windows.Forms.Label taskLabel2;
        private System.Windows.Forms.Label addTaskButton;
        private System.Windows.Forms.Timer autoAddTaskTimer;
    }
}
