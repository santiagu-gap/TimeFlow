namespace Calendar
{
    partial class PracticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeForm));
            this.formContainer = new System.Windows.Forms.Panel();
            this.sidebarFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.taskButton = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.taskPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sidebarFlowPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.homePanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.taskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.calendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // formContainer
            // 
            this.formContainer.BackColor = System.Drawing.SystemColors.Control;
            this.formContainer.Location = new System.Drawing.Point(225, -1);
            this.formContainer.Name = "formContainer";
            this.formContainer.Size = new System.Drawing.Size(2315, 1263);
            this.formContainer.TabIndex = 1;
            // 
            // sidebarFlowPanel
            // 
            this.sidebarFlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidebarFlowPanel.BackColor = System.Drawing.Color.LightGray;
            this.sidebarFlowPanel.Controls.Add(this.flowLayoutPanel2);
            this.sidebarFlowPanel.Controls.Add(this.homePanel);
            this.sidebarFlowPanel.Controls.Add(this.taskPanel);
            this.sidebarFlowPanel.Controls.Add(this.calendarPanel);
            this.sidebarFlowPanel.Location = new System.Drawing.Point(2, 2);
            this.sidebarFlowPanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidebarFlowPanel.MaximumSize = new System.Drawing.Size(217, 1259);
            this.sidebarFlowPanel.MinimumSize = new System.Drawing.Size(70, 200);
            this.sidebarFlowPanel.Name = "sidebarFlowPanel";
            this.sidebarFlowPanel.Size = new System.Drawing.Size(217, 1259);
            this.sidebarFlowPanel.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.Controls.Add(this.iconPictureBox);
            this.flowLayoutPanel2.Controls.Add(this.menuLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(215, 64);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconPictureBox.Image")));
            this.iconPictureBox.Location = new System.Drawing.Point(2, 2);
            this.iconPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(60, 60);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.Click += new System.EventHandler(this.iconPictureBox_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuLabel.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuLabel.Location = new System.Drawing.Point(66, 17);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(78, 30);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.homeButton);
            this.homePanel.Controls.Add(this.pictureBox1);
            this.homePanel.Location = new System.Drawing.Point(2, 70);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(215, 64);
            this.homePanel.TabIndex = 1;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(66, -3);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(149, 64);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // taskButton
            // 
            this.taskButton.FlatAppearance.BorderSize = 0;
            this.taskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskButton.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskButton.Location = new System.Drawing.Point(61, 0);
            this.taskButton.Margin = new System.Windows.Forms.Padding(2);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(154, 64);
            this.taskButton.TabIndex = 2;
            this.taskButton.Text = "Task";
            this.taskButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskButton.UseVisualStyleBackColor = true;
            // 
            // calendarButton
            // 
            this.calendarButton.FlatAppearance.BorderSize = 0;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendarButton.Location = new System.Drawing.Point(62, 2);
            this.calendarButton.Margin = new System.Windows.Forms.Padding(2);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(151, 60);
            this.calendarButton.TabIndex = 0;
            this.calendarButton.Text = "Calendar";
            this.calendarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.sidebarFlowPanel);
            this.containerPanel.Location = new System.Drawing.Point(1, -1);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(221, 1263);
            this.containerPanel.TabIndex = 0;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // taskPanel
            // 
            this.taskPanel.Controls.Add(this.pictureBox2);
            this.taskPanel.Controls.Add(this.taskButton);
            this.taskPanel.Location = new System.Drawing.Point(2, 138);
            this.taskPanel.Margin = new System.Windows.Forms.Padding(2);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(215, 64);
            this.taskPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // calendarPanel
            // 
            this.calendarPanel.Controls.Add(this.calendarButton);
            this.calendarPanel.Controls.Add(this.pictureBox3);
            this.calendarPanel.Location = new System.Drawing.Point(3, 207);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(215, 64);
            this.calendarPanel.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2539, 1262);
            this.Controls.Add(this.formContainer);
            this.Controls.Add(this.containerPanel);
            this.Name = "PracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PracticeForm";
            this.Load += new System.EventHandler(this.PracticeForm_Load);
            this.sidebarFlowPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.taskPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.calendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel formContainer;
        private System.Windows.Forms.FlowLayoutPanel sidebarFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel taskPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}