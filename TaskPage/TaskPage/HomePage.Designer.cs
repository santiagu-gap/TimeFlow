namespace TaskPage
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
            this.timeDisplay = new System.Windows.Forms.Label();
            this.dateDisplay = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.taskDisplayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.listTitle = new System.Windows.Forms.Label();
            this.dayProgression = new System.Windows.Forms.ProgressBar();
            this.progressionLabel = new System.Windows.Forms.Label();
            this.studyLinksLabel = new System.Windows.Forms.Label();
            this.pomodoroLink = new System.Windows.Forms.LinkLabel();
            this.quizletLink = new System.Windows.Forms.LinkLabel();
            this.vanierLink = new System.Windows.Forms.LinkLabel();
            this.quoteGenerator = new System.Windows.Forms.Label();
            this.bannerPicture = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressionBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bannerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // timeDisplay
            // 
            this.timeDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeDisplay.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeDisplay.Location = new System.Drawing.Point(925, 0);
            this.timeDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(227, 74);
            this.timeDisplay.TabIndex = 12;
            this.timeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateDisplay
            // 
            this.dateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateDisplay.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateDisplay.Location = new System.Drawing.Point(2, 0);
            this.dateDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.Size = new System.Drawing.Size(227, 74);
            this.dateDisplay.TabIndex = 13;
            this.dateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeLabel.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(354, 0);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(474, 119);
            this.welcomeLabel.TabIndex = 14;
            this.welcomeLabel.Text = "Welcome Home";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taskDisplayContainer
            // 
            this.taskDisplayContainer.AutoScroll = true;
            this.taskDisplayContainer.Location = new System.Drawing.Point(371, 225);
            this.taskDisplayContainer.Margin = new System.Windows.Forms.Padding(2);
            this.taskDisplayContainer.Name = "taskDisplayContainer";
            this.taskDisplayContainer.Size = new System.Drawing.Size(426, 516);
            this.taskDisplayContainer.TabIndex = 15;
            // 
            // listTitle
            // 
            this.listTitle.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTitle.Location = new System.Drawing.Point(359, 178);
            this.listTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listTitle.Name = "listTitle";
            this.listTitle.Size = new System.Drawing.Size(170, 35);
            this.listTitle.TabIndex = 16;
            this.listTitle.Text = "Today\'s Tasks";
            // 
            // dayProgression
            // 
            this.dayProgression.Location = new System.Drawing.Point(14, 326);
            this.dayProgression.Margin = new System.Windows.Forms.Padding(2);
            this.dayProgression.Name = "dayProgression";
            this.dayProgression.Size = new System.Drawing.Size(176, 33);
            this.dayProgression.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.dayProgression.TabIndex = 22;
            // 
            // progressionLabel
            // 
            this.progressionLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressionLabel.Location = new System.Drawing.Point(10, 272);
            this.progressionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.progressionLabel.Name = "progressionLabel";
            this.progressionLabel.Size = new System.Drawing.Size(197, 39);
            this.progressionLabel.TabIndex = 23;
            this.progressionLabel.Text = "Day Progression";
            // 
            // studyLinksLabel
            // 
            this.studyLinksLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyLinksLabel.Location = new System.Drawing.Point(9, 544);
            this.studyLinksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studyLinksLabel.Name = "studyLinksLabel";
            this.studyLinksLabel.Size = new System.Drawing.Size(172, 33);
            this.studyLinksLabel.TabIndex = 27;
            this.studyLinksLabel.Text = "Useful Links";
            // 
            // pomodoroLink
            // 
            this.pomodoroLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoroLink.Location = new System.Drawing.Point(11, 637);
            this.pomodoroLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pomodoroLink.Name = "pomodoroLink";
            this.pomodoroLink.Size = new System.Drawing.Size(132, 20);
            this.pomodoroLink.TabIndex = 26;
            this.pomodoroLink.TabStop = true;
            this.pomodoroLink.Text = "Pomodoro Timer";
            this.pomodoroLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pomodoroLink_LinkClicked);
            // 
            // quizletLink
            // 
            this.quizletLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizletLink.Location = new System.Drawing.Point(11, 680);
            this.quizletLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quizletLink.Name = "quizletLink";
            this.quizletLink.Size = new System.Drawing.Size(58, 20);
            this.quizletLink.TabIndex = 25;
            this.quizletLink.TabStop = true;
            this.quizletLink.Text = "Quizlet";
            this.quizletLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quizletLink_LinkClicked);
            // 
            // vanierLink
            // 
            this.vanierLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanierLink.Location = new System.Drawing.Point(10, 594);
            this.vanierLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vanierLink.Name = "vanierLink";
            this.vanierLink.Size = new System.Drawing.Size(132, 20);
            this.vanierLink.TabIndex = 24;
            this.vanierLink.TabStop = true;
            this.vanierLink.Text = "Vanier Omnivox";
            this.vanierLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.vanierLink_LinkClicked);
            // 
            // quoteGenerator
            // 
            this.quoteGenerator.Font = new System.Drawing.Font("Candara", 25.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteGenerator.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.quoteGenerator.Location = new System.Drawing.Point(910, 225);
            this.quoteGenerator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quoteGenerator.Name = "quoteGenerator";
            this.quoteGenerator.Size = new System.Drawing.Size(217, 313);
            this.quoteGenerator.TabIndex = 28;
            this.quoteGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bannerPicture
            // 
            this.bannerPicture.BackgroundImage = global::TaskPage.Properties.Resources.image2;
            this.bannerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bannerPicture.Location = new System.Drawing.Point(1, -2);
            this.bannerPicture.Name = "bannerPicture";
            this.bannerPicture.Size = new System.Drawing.Size(1154, 147);
            this.bannerPicture.TabIndex = 0;
            this.bannerPicture.TabStop = false;
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
            this.ClientSize = new System.Drawing.Size(1138, 713);
            this.Controls.Add(this.quoteGenerator);
            this.Controls.Add(this.studyLinksLabel);
            this.Controls.Add(this.pomodoroLink);
            this.Controls.Add(this.quizletLink);
            this.Controls.Add(this.vanierLink);
            this.Controls.Add(this.progressionLabel);
            this.Controls.Add(this.dayProgression);
            this.Controls.Add(this.listTitle);
            this.Controls.Add(this.taskDisplayContainer);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.dateDisplay);
            this.Controls.Add(this.timeDisplay);
            this.Controls.Add(this.bannerPicture);
            this.Name = "HomePage";
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.bannerPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bannerPicture;
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Label dateDisplay;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.FlowLayoutPanel taskDisplayContainer;
        private System.Windows.Forms.Label listTitle;
        private System.Windows.Forms.ProgressBar dayProgression;
        private System.Windows.Forms.Label progressionLabel;
        private System.Windows.Forms.Label studyLinksLabel;
        private System.Windows.Forms.LinkLabel pomodoroLink;
        private System.Windows.Forms.LinkLabel quizletLink;
        private System.Windows.Forms.LinkLabel vanierLink;
        private System.Windows.Forms.Label quoteGenerator;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer progressionBar;
    }
}

