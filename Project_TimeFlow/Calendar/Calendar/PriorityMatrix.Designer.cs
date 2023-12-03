namespace Calendar
{
    partial class PriorityMatrix
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
            this.TasksMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tasksNode = new System.Windows.Forms.ToolStripMenuItem();
            this.PriorityView1 = new System.Windows.Forms.ListView();
            this.PriorityView2 = new System.Windows.Forms.ListView();
            this.PriorityView3 = new System.Windows.Forms.ListView();
            this.PriorityView4 = new System.Windows.Forms.ListView();
            this.ImportantLabel = new System.Windows.Forms.Label();
            this.NotImportantLabel = new System.Windows.Forms.Label();
            this.UrgentLabel = new System.Windows.Forms.Label();
            this.NotUrgentLabel = new System.Windows.Forms.Label();
            this.TasksMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TasksMenuStrip
            // 
            this.TasksMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksNode});
            this.TasksMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TasksMenuStrip.Name = "TasksMenuStrip";
            this.TasksMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.TasksMenuStrip.TabIndex = 0;
            this.TasksMenuStrip.Text = "menuStrip1";
            // 
            // tasksNode
            // 
            this.tasksNode.Name = "tasksNode";
            this.tasksNode.Size = new System.Drawing.Size(46, 20);
            this.tasksNode.Text = "Tasks";
            // 
            // PriorityView1
            // 
            this.PriorityView1.HideSelection = false;
            this.PriorityView1.Location = new System.Drawing.Point(122, 99);
            this.PriorityView1.Name = "PriorityView1";
            this.PriorityView1.Size = new System.Drawing.Size(218, 145);
            this.PriorityView1.TabIndex = 1;
            this.PriorityView1.UseCompatibleStateImageBehavior = false;
            this.PriorityView1.View = System.Windows.Forms.View.List;
            // 
            // PriorityView2
            // 
            this.PriorityView2.HideSelection = false;
            this.PriorityView2.Location = new System.Drawing.Point(425, 99);
            this.PriorityView2.Name = "PriorityView2";
            this.PriorityView2.Size = new System.Drawing.Size(218, 145);
            this.PriorityView2.TabIndex = 2;
            this.PriorityView2.UseCompatibleStateImageBehavior = false;
            this.PriorityView2.View = System.Windows.Forms.View.List;
            // 
            // PriorityView3
            // 
            this.PriorityView3.HideSelection = false;
            this.PriorityView3.Location = new System.Drawing.Point(122, 278);
            this.PriorityView3.Name = "PriorityView3";
            this.PriorityView3.Size = new System.Drawing.Size(218, 145);
            this.PriorityView3.TabIndex = 3;
            this.PriorityView3.UseCompatibleStateImageBehavior = false;
            this.PriorityView3.View = System.Windows.Forms.View.List;
            // 
            // PriorityView4
            // 
            this.PriorityView4.HideSelection = false;
            this.PriorityView4.Location = new System.Drawing.Point(425, 278);
            this.PriorityView4.Name = "PriorityView4";
            this.PriorityView4.Size = new System.Drawing.Size(218, 145);
            this.PriorityView4.TabIndex = 4;
            this.PriorityView4.UseCompatibleStateImageBehavior = false;
            this.PriorityView4.View = System.Windows.Forms.View.List;
            // 
            // ImportantLabel
            // 
            this.ImportantLabel.AutoSize = true;
            this.ImportantLabel.Location = new System.Drawing.Point(65, 163);
            this.ImportantLabel.Name = "ImportantLabel";
            this.ImportantLabel.Size = new System.Drawing.Size(51, 13);
            this.ImportantLabel.TabIndex = 5;
            this.ImportantLabel.Text = "Important";
            // 
            // NotImportantLabel
            // 
            this.NotImportantLabel.AutoSize = true;
            this.NotImportantLabel.Location = new System.Drawing.Point(45, 349);
            this.NotImportantLabel.Name = "NotImportantLabel";
            this.NotImportantLabel.Size = new System.Drawing.Size(71, 13);
            this.NotImportantLabel.TabIndex = 6;
            this.NotImportantLabel.Text = "Not Important";
            // 
            // UrgentLabel
            // 
            this.UrgentLabel.AutoSize = true;
            this.UrgentLabel.Location = new System.Drawing.Point(204, 73);
            this.UrgentLabel.Name = "UrgentLabel";
            this.UrgentLabel.Size = new System.Drawing.Size(39, 13);
            this.UrgentLabel.TabIndex = 7;
            this.UrgentLabel.Text = "Urgent";
            // 
            // NotUrgentLabel
            // 
            this.NotUrgentLabel.AutoSize = true;
            this.NotUrgentLabel.Location = new System.Drawing.Point(500, 73);
            this.NotUrgentLabel.Name = "NotUrgentLabel";
            this.NotUrgentLabel.Size = new System.Drawing.Size(59, 13);
            this.NotUrgentLabel.TabIndex = 8;
            this.NotUrgentLabel.Text = "Not Urgent";
            // 
            // PriorityMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotUrgentLabel);
            this.Controls.Add(this.UrgentLabel);
            this.Controls.Add(this.NotImportantLabel);
            this.Controls.Add(this.ImportantLabel);
            this.Controls.Add(this.PriorityView4);
            this.Controls.Add(this.PriorityView3);
            this.Controls.Add(this.PriorityView2);
            this.Controls.Add(this.PriorityView1);
            this.Controls.Add(this.TasksMenuStrip);
            this.MainMenuStrip = this.TasksMenuStrip;
            this.Name = "PriorityMatrix";
            this.Text = "Priority Matrix";
            this.TasksMenuStrip.ResumeLayout(false);
            this.TasksMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TasksMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tasksNode;
        private System.Windows.Forms.ListView PriorityView1;
        private System.Windows.Forms.ListView PriorityView2;
        private System.Windows.Forms.ListView PriorityView3;
        private System.Windows.Forms.ListView PriorityView4;
        private System.Windows.Forms.Label ImportantLabel;
        private System.Windows.Forms.Label NotImportantLabel;
        private System.Windows.Forms.Label UrgentLabel;
        private System.Windows.Forms.Label NotUrgentLabel;
    }
}