namespace BaseForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.calendarButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.taskButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.sidebarFlowPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // sidebarFlowPanel
            // 
            this.sidebarFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebarFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidebarFlowPanel.Controls.Add(this.flowLayoutPanel2);
            this.sidebarFlowPanel.Controls.Add(this.panel1);
            this.sidebarFlowPanel.Controls.Add(this.panel2);
            this.sidebarFlowPanel.Controls.Add(this.flowLayoutPanel1);
            this.sidebarFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidebarFlowPanel.MaximumSize = new System.Drawing.Size(232, 1024);
            this.sidebarFlowPanel.MinimumSize = new System.Drawing.Size(83, 634);
            this.sidebarFlowPanel.Name = "sidebarFlowPanel";
            this.sidebarFlowPanel.Size = new System.Drawing.Size(202, 692);
            this.sidebarFlowPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.calendarButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 255);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 86);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // calendarButton
            // 
            this.calendarButton.FlatAppearance.BorderSize = 0;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendarButton.Location = new System.Drawing.Point(2, 2);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(2);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(228, 84);
            this.calendarButton.TabIndex = 0;
            this.calendarButton.Text = "         Calendar";
            this.calendarButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.taskButton);
            this.panel2.Location = new System.Drawing.Point(2, 168);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 83);
            this.panel2.TabIndex = 3;
            // 
            // taskButton
            // 
            this.taskButton.FlatAppearance.BorderSize = 0;
            this.taskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskButton.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskButton.Image = global::BaseForm.Properties.Resources.viewTaskIcon;
            this.taskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskButton.Location = new System.Drawing.Point(0, 0);
            this.taskButton.Margin = new System.Windows.Forms.Padding(2);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(230, 87);
            this.taskButton.TabIndex = 2;
            this.taskButton.Text = "    Task";
            this.taskButton.UseVisualStyleBackColor = true;
            this.taskButton.Click += new System.EventHandler(this.taskButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(2, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 80);
            this.panel1.TabIndex = 1;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = global::BaseForm.Properties.Resources.homeIcon;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, -3);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(230, 89);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "      Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.Controls.Add(this.iconPictureBox);
            this.flowLayoutPanel2.Controls.Add(this.menuLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(230, 78);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // menuLabel
            // 
            this.menuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuLabel.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuLabel.Location = new System.Drawing.Point(77, 24);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(78, 30);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox.Image = global::BaseForm.Properties.Resources.menuIcon;
            this.iconPictureBox.Location = new System.Drawing.Point(2, 2);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(71, 74);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.Click += new System.EventHandler(this.iconPictureBox_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.sidebarFlowPanel);
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(241, 680);
            this.containerPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 682);
            this.Controls.Add(this.containerPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebarFlowPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel sidebarFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Panel containerPanel;



        #endregion

        // private BaseForm.BaseForm baseModel1;

    }
}

