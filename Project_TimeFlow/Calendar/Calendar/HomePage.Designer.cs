namespace Calendar
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.timeDisplay = new System.Windows.Forms.Label();
            this.dateDisplay = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.taskDisplayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.listTitle = new System.Windows.Forms.Label();
            this.dayProgression = new System.Windows.Forms.ProgressBar();
            this.studyLinksLabel = new System.Windows.Forms.Label();
            this.pomodoroLink = new System.Windows.Forms.LinkLabel();
            this.quizletLink = new System.Windows.Forms.LinkLabel();
            this.vanierLink = new System.Windows.Forms.LinkLabel();
            this.quoteGenerator = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressionBar = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timeDisplay
            // 
            this.timeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.timeDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeDisplay.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.ForeColor = System.Drawing.Color.White;
            this.timeDisplay.Location = new System.Drawing.Point(32, 646);
            this.timeDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(444, 89);
            this.timeDisplay.TabIndex = 12;
            this.timeDisplay.Text = "s";
            this.timeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateDisplay
            // 
            this.dateDisplay.BackColor = System.Drawing.Color.Transparent;
            this.dateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateDisplay.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplay.ForeColor = System.Drawing.Color.White;
            this.dateDisplay.Location = new System.Drawing.Point(37, 726);
            this.dateDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.Size = new System.Drawing.Size(716, 74);
            this.dateDisplay.TabIndex = 13;
            this.dateDisplay.Text = "s";
            this.dateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(1, 0);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(1279, 109);
            this.welcomeLabel.TabIndex = 14;
            this.welcomeLabel.Text = "Welcome, ";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // taskDisplayContainer
            // 
            this.taskDisplayContainer.AutoScroll = true;
            this.taskDisplayContainer.BackColor = System.Drawing.Color.Transparent;
            this.taskDisplayContainer.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDisplayContainer.ForeColor = System.Drawing.Color.White;
            this.taskDisplayContainer.Location = new System.Drawing.Point(447, 278);
            this.taskDisplayContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taskDisplayContainer.Name = "taskDisplayContainer";
            this.taskDisplayContainer.Size = new System.Drawing.Size(483, 388);
            this.taskDisplayContainer.TabIndex = 15;
            // 
            // listTitle
            // 
            this.listTitle.BackColor = System.Drawing.Color.Transparent;
            this.listTitle.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTitle.ForeColor = System.Drawing.Color.White;
            this.listTitle.Location = new System.Drawing.Point(518, 219);
            this.listTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listTitle.Name = "listTitle";
            this.listTitle.Size = new System.Drawing.Size(270, 35);
            this.listTitle.TabIndex = 16;
            this.listTitle.Text = "Today\'s Tasks";
            this.listTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayProgression
            // 
            this.dayProgression.ForeColor = System.Drawing.Color.White;
            this.dayProgression.Location = new System.Drawing.Point(43, 801);
            this.dayProgression.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dayProgression.Name = "dayProgression";
            this.dayProgression.Size = new System.Drawing.Size(666, 5);
            this.dayProgression.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.dayProgression.TabIndex = 22;
            // 
            // studyLinksLabel
            // 
            this.studyLinksLabel.BackColor = System.Drawing.Color.Transparent;
            this.studyLinksLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyLinksLabel.ForeColor = System.Drawing.Color.White;
            this.studyLinksLabel.Location = new System.Drawing.Point(1099, 682);
            this.studyLinksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studyLinksLabel.Name = "studyLinksLabel";
            this.studyLinksLabel.Size = new System.Drawing.Size(172, 33);
            this.studyLinksLabel.TabIndex = 27;
            this.studyLinksLabel.Text = "Useful Links";
            this.studyLinksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pomodoroLink
            // 
            this.pomodoroLink.BackColor = System.Drawing.Color.Transparent;
            this.pomodoroLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoroLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.pomodoroLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.pomodoroLink.Location = new System.Drawing.Point(1140, 747);
            this.pomodoroLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pomodoroLink.Name = "pomodoroLink";
            this.pomodoroLink.Size = new System.Drawing.Size(132, 20);
            this.pomodoroLink.TabIndex = 26;
            this.pomodoroLink.TabStop = true;
            this.pomodoroLink.Text = "Pomodoro Timer";
            this.pomodoroLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pomodoroLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pomodoroLink_LinkClicked);
            // 
            // quizletLink
            // 
            this.quizletLink.BackColor = System.Drawing.Color.Transparent;
            this.quizletLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizletLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.quizletLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.quizletLink.Location = new System.Drawing.Point(1213, 768);
            this.quizletLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quizletLink.Name = "quizletLink";
            this.quizletLink.Size = new System.Drawing.Size(58, 20);
            this.quizletLink.TabIndex = 25;
            this.quizletLink.TabStop = true;
            this.quizletLink.Text = "Quizlet";
            this.quizletLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.quizletLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quizletLink_LinkClicked);
            // 
            // vanierLink
            // 
            this.vanierLink.BackColor = System.Drawing.Color.Transparent;
            this.vanierLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanierLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.vanierLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(114)))), ((int)(((byte)(250)))));
            this.vanierLink.Location = new System.Drawing.Point(1138, 724);
            this.vanierLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vanierLink.Name = "vanierLink";
            this.vanierLink.Size = new System.Drawing.Size(132, 20);
            this.vanierLink.TabIndex = 24;
            this.vanierLink.TabStop = true;
            this.vanierLink.Text = "Vanier Omnivox";
            this.vanierLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vanierLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.vanierLink_LinkClicked);
            // 
            // quoteGenerator
            // 
            this.quoteGenerator.BackColor = System.Drawing.Color.Transparent;
            this.quoteGenerator.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteGenerator.ForeColor = System.Drawing.Color.White;
            this.quoteGenerator.Location = new System.Drawing.Point(981, 219);
            this.quoteGenerator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quoteGenerator.Name = "quoteGenerator";
            this.quoteGenerator.Size = new System.Drawing.Size(231, 344);
            this.quoteGenerator.TabIndex = 28;
            this.quoteGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressionBar
            // 
            this.progressionBar.Tick += new System.EventHandler(this.progressionBar_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.timeDisplay);
            this.Controls.Add(this.quoteGenerator);
            this.Controls.Add(this.studyLinksLabel);
            this.Controls.Add(this.pomodoroLink);
            this.Controls.Add(this.quizletLink);
            this.Controls.Add(this.vanierLink);
            this.Controls.Add(this.dayProgression);
            this.Controls.Add(this.listTitle);
            this.Controls.Add(this.taskDisplayContainer);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.dateDisplay);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Label dateDisplay;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.FlowLayoutPanel taskDisplayContainer;
        private System.Windows.Forms.Label listTitle;
        private System.Windows.Forms.ProgressBar dayProgression;
        private System.Windows.Forms.Label studyLinksLabel;
        private System.Windows.Forms.LinkLabel pomodoroLink;
        private System.Windows.Forms.LinkLabel quizletLink;
        private System.Windows.Forms.LinkLabel vanierLink;
        private System.Windows.Forms.Label quoteGenerator;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer progressionBar;
    }
}

