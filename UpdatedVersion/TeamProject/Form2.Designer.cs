namespace TeamProject
{
    partial class Form2
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
            this.sidebarFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuLabel = new System.Windows.Forms.Label();
            this.menuIconPicture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebarFlowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuIconPicture)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarFlowPanel
            // 
            this.sidebarFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidebarFlowPanel.Controls.Add(this.panel1);
            this.sidebarFlowPanel.Controls.Add(this.flowLayoutPanel2);
            this.sidebarFlowPanel.Controls.Add(this.panel2);
            this.sidebarFlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarFlowPanel.MaximumSize = new System.Drawing.Size(453, 819);
            this.sidebarFlowPanel.MinimumSize = new System.Drawing.Size(157, 819);
            this.sidebarFlowPanel.Name = "sidebarFlowPanel";
            this.sidebarFlowPanel.Size = new System.Drawing.Size(157, 819);
            this.sidebarFlowPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuLabel);
            this.panel1.Controls.Add(this.menuIconPicture);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 133);
            this.panel1.TabIndex = 1;
            // 
            // menuLabel
            // 
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuLabel.Location = new System.Drawing.Point(171, 53);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(137, 47);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // menuIconPicture
            // 
            this.menuIconPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuIconPicture.Image = global::TeamProject.Properties.Resources.menuIcon;
            this.menuIconPicture.Location = new System.Drawing.Point(3, 9);
            this.menuIconPicture.Name = "menuIconPicture";
            this.menuIconPicture.Size = new System.Drawing.Size(120, 121);
            this.menuIconPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuIconPicture.TabIndex = 0;
            this.menuIconPicture.TabStop = false;
            this.menuIconPicture.Click += new System.EventHandler(this.menuIconPicture_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.homeButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 142);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(450, 133);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeButton.Image = global::TeamProject.Properties.Resources.homeIcon;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(444, 130);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "  Home";
            this.homeButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addTaskButton);
            this.panel2.Location = new System.Drawing.Point(3, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 126);
            this.panel2.TabIndex = 0;
            // 
            // addTaskButton
            // 
            this.addTaskButton.FlatAppearance.BorderSize = 0;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTaskButton.Image = global::TeamProject.Properties.Resources.addTaskIcon;
            this.addTaskButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTaskButton.Location = new System.Drawing.Point(-3, 0);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(450, 135);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "  Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2059, 827);
            this.Controls.Add(this.sidebarFlowPanel);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.sidebarFlowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuIconPicture)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebarFlowPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.PictureBox menuIconPicture;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}