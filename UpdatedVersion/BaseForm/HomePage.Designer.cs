namespace BaseForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.timeDisplay = new System.Windows.Forms.Label();
            this.dateDisplay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.studyLinksLabel = new System.Windows.Forms.Label();
            this.pomodoroLink = new System.Windows.Forms.LinkLabel();
            this.quizletLink = new System.Windows.Forms.LinkLabel();
            this.vanierLink = new System.Windows.Forms.LinkLabel();
            this.quoteGenerator = new System.Windows.Forms.Label();
            this.listTitle = new System.Windows.Forms.Label();
            this.taskDisplayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.dayProgression = new System.Windows.Forms.ProgressBar();
            this.progressionBar = new System.Windows.Forms.Timer(this.components);
            this.progressionLabel = new System.Windows.Forms.Label();
            this.bannerPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bannerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeLabel.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(744, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(949, 229);
            this.welcomeLabel.TabIndex = 12;
            this.welcomeLabel.Text = "Welcome Home";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timeDisplay
            // 
            this.timeDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeDisplay.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeDisplay.Location = new System.Drawing.Point(1850, 0);
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(454, 143);
            this.timeDisplay.TabIndex = 11;
            this.timeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateDisplay
            // 
            this.dateDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateDisplay.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDisplay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateDisplay.Location = new System.Drawing.Point(3, 0);
            this.dateDisplay.Name = "dateDisplay";
            this.dateDisplay.Size = new System.Drawing.Size(525, 171);
            this.dateDisplay.TabIndex = 10;
            this.dateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // studyLinksLabel
            // 
            this.studyLinksLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyLinksLabel.Location = new System.Drawing.Point(17, 1108);
            this.studyLinksLabel.Name = "studyLinksLabel";
            this.studyLinksLabel.Size = new System.Drawing.Size(345, 64);
            this.studyLinksLabel.TabIndex = 19;
            this.studyLinksLabel.Text = "Useful Links";
            // 
            // pomodoroLink
            // 
            this.pomodoroLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoroLink.Location = new System.Drawing.Point(19, 1286);
            this.pomodoroLink.Name = "pomodoroLink";
            this.pomodoroLink.Size = new System.Drawing.Size(263, 39);
            this.pomodoroLink.TabIndex = 18;
            this.pomodoroLink.TabStop = true;
            this.pomodoroLink.Text = "Pomodoro Timer";
            this.pomodoroLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pomodoroLink_LinkClicked);
            // 
            // quizletLink
            // 
            this.quizletLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizletLink.Location = new System.Drawing.Point(21, 1369);
            this.quizletLink.Name = "quizletLink";
            this.quizletLink.Size = new System.Drawing.Size(116, 39);
            this.quizletLink.TabIndex = 17;
            this.quizletLink.TabStop = true;
            this.quizletLink.Text = "Quizlet";
            this.quizletLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.quizletLink_LinkClicked);
            // 
            // vanierLink
            // 
            this.vanierLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vanierLink.Location = new System.Drawing.Point(18, 1203);
            this.vanierLink.Name = "vanierLink";
            this.vanierLink.Size = new System.Drawing.Size(264, 39);
            this.vanierLink.TabIndex = 16;
            this.vanierLink.TabStop = true;
            this.vanierLink.Text = "Vanier Omnivox";
            this.vanierLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.vanierLink_LinkClicked);
            // 
            // quoteGenerator
            // 
            this.quoteGenerator.Font = new System.Drawing.Font("Candara", 25.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteGenerator.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.quoteGenerator.Location = new System.Drawing.Point(1821, 432);
            this.quoteGenerator.Name = "quoteGenerator";
            this.quoteGenerator.Size = new System.Drawing.Size(434, 601);
            this.quoteGenerator.TabIndex = 15;
            this.quoteGenerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listTitle
            // 
            this.listTitle.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTitle.Location = new System.Drawing.Point(718, 342);
            this.listTitle.Name = "listTitle";
            this.listTitle.Size = new System.Drawing.Size(339, 68);
            this.listTitle.TabIndex = 14;
            this.listTitle.Text = "Today\'s Tasks";
            // 
            // taskDisplayContainer
            // 
            this.taskDisplayContainer.AutoScroll = true;
            this.taskDisplayContainer.Location = new System.Drawing.Point(742, 432);
            this.taskDisplayContainer.Name = "taskDisplayContainer";
            this.taskDisplayContainer.Size = new System.Drawing.Size(853, 992);
            this.taskDisplayContainer.TabIndex = 13;
            // 
            // dayProgression
            // 
            this.dayProgression.Location = new System.Drawing.Point(27, 626);
            this.dayProgression.Name = "dayProgression";
            this.dayProgression.Size = new System.Drawing.Size(352, 64);
            this.dayProgression.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.dayProgression.TabIndex = 21;
            this.dayProgression.Click += new System.EventHandler(this.dayProgression_Click);
            // 
            // progressionBar
            // 
            this.progressionBar.Tick += new System.EventHandler(this.progressionBar_Tick);
            // 
            // progressionLabel
            // 
            this.progressionLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressionLabel.Location = new System.Drawing.Point(19, 524);
            this.progressionLabel.Name = "progressionLabel";
            this.progressionLabel.Size = new System.Drawing.Size(394, 75);
            this.progressionLabel.TabIndex = 22;
            this.progressionLabel.Text = "Day Progression";
            // 
            // bannerPicture
            // 
            this.bannerPicture.BackgroundImage = global::BaseForm.Properties.Resources.image2;
            this.bannerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bannerPicture.Location = new System.Drawing.Point(0, 0);
            this.bannerPicture.Name = "bannerPicture";
            this.bannerPicture.Size = new System.Drawing.Size(2307, 282);
            this.bannerPicture.TabIndex = 23;
            this.bannerPicture.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.progressionLabel);
            this.Controls.Add(this.dayProgression);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.timeDisplay);
            this.Controls.Add(this.dateDisplay);
            this.Controls.Add(this.studyLinksLabel);
            this.Controls.Add(this.pomodoroLink);
            this.Controls.Add(this.quizletLink);
            this.Controls.Add(this.vanierLink);
            this.Controls.Add(this.quoteGenerator);
            this.Controls.Add(this.listTitle);
            this.Controls.Add(this.taskDisplayContainer);
            this.Controls.Add(this.bannerPicture);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(2307, 1446);
            ((System.ComponentModel.ISupportInitialize)(this.bannerPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label timeDisplay;
        private System.Windows.Forms.Label dateDisplay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label studyLinksLabel;
        private System.Windows.Forms.LinkLabel pomodoroLink;
        private System.Windows.Forms.LinkLabel quizletLink;
        private System.Windows.Forms.LinkLabel vanierLink;
        private System.Windows.Forms.Label quoteGenerator;
        private System.Windows.Forms.Label listTitle;
        private System.Windows.Forms.FlowLayoutPanel taskDisplayContainer;
        private System.Windows.Forms.ProgressBar dayProgression;
        private System.Windows.Forms.Timer progressionBar;
        private System.Windows.Forms.Label progressionLabel;
        private System.Windows.Forms.PictureBox bannerPicture;
    }
}
