namespace BaseForm
{
    partial class BaseModel
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
            this.sidebarFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.calendarButton = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.taskButton = new System.Windows.Forms.Button();
            this.sidebarFlowPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarFlowPanel
            // 
            this.sidebarFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidebarFlowPanel.Controls.Add(this.flowLayoutPanel2);
            this.sidebarFlowPanel.Controls.Add(this.panel1);
            this.sidebarFlowPanel.Controls.Add(this.panel2);
            this.sidebarFlowPanel.Controls.Add(this.flowLayoutPanel1);
            this.sidebarFlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarFlowPanel.MaximumSize = new System.Drawing.Size(348, 991);
            this.sidebarFlowPanel.MinimumSize = new System.Drawing.Size(124, 991);
            this.sidebarFlowPanel.Name = "sidebarFlowPanel";
            this.sidebarFlowPanel.Size = new System.Drawing.Size(348, 991);
            this.sidebarFlowPanel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.Controls.Add(this.iconPictureBox);
            this.flowLayoutPanel2.Controls.Add(this.menuLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(345, 122);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // menuLabel
            // 
            this.menuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuLabel.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuLabel.Location = new System.Drawing.Point(116, 37);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(117, 47);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Location = new System.Drawing.Point(3, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 125);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.taskButton);
            this.panel2.Location = new System.Drawing.Point(3, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 130);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.calendarButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 398);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 134);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // calendarButton
            // 
            this.calendarButton.FlatAppearance.BorderSize = 0;
            this.calendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendarButton.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calendarButton.Location = new System.Drawing.Point(3, 3);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(342, 131);
            this.calendarButton.TabIndex = 0;
            this.calendarButton.Text = "         Calendar";
            this.calendarButton.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox.Image = global::BaseForm.Properties.Resources.menuIcon;
            this.iconPictureBox.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(107, 115);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.Click += new System.EventHandler(this.iconPictureBox_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = global::BaseForm.Properties.Resources.homeIcon;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, -4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(345, 139);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "      Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
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
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(345, 136);
            this.taskButton.TabIndex = 2;
            this.taskButton.Text = "    Task";
            this.taskButton.UseVisualStyleBackColor = true;
            this.taskButton.Click += new System.EventHandler(this.taskButton_Click);
            // 
            // BaseModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebarFlowPanel);
            this.Name = "BaseModel";
            this.Size = new System.Drawing.Size(1680, 991);
            this.Load += new System.EventHandler(this.BaseModel_Load);
            this.sidebarFlowPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebarFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}
