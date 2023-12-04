namespace Calendar
{
    partial class NotificationsForm
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
            this.taskListFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // taskListFlowPanel
            // 
            this.taskListFlowPanel.AutoScroll = true;
            this.taskListFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.taskListFlowPanel.Location = new System.Drawing.Point(295, 54);
            this.taskListFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.taskListFlowPanel.Name = "taskListFlowPanel";
            this.taskListFlowPanel.Size = new System.Drawing.Size(383, 587);
            this.taskListFlowPanel.TabIndex = 6;
            this.taskListFlowPanel.WrapContents = false;
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 695);
            this.Controls.Add(this.taskListFlowPanel);
            this.Name = "NotificationsForm";
            this.Text = "Notifications";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel taskListFlowPanel;
    }
}