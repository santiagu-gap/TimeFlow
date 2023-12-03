namespace Calendar
{
    partial class Calendar
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
            this.daysContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.sundayLabel = new System.Windows.Forms.Label();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.thursdayLabel = new System.Windows.Forms.Label();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.monthYearDisplay = new System.Windows.Forms.Label();
            this.dayModeButton = new System.Windows.Forms.Button();
            this.weekModeButton = new System.Windows.Forms.Button();
            this.monthModeButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysContainer
            // 
            this.daysContainer.Location = new System.Drawing.Point(10, 109);
            this.daysContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.daysContainer.Name = "daysContainer";
            this.daysContainer.Size = new System.Drawing.Size(1707, 873);
            this.daysContainer.TabIndex = 0;
            // 
            // sundayLabel
            // 
            this.sundayLabel.AutoSize = true;
            this.sundayLabel.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundayLabel.Location = new System.Drawing.Point(95, 71);
            this.sundayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sundayLabel.Name = "sundayLabel";
            this.sundayLabel.Size = new System.Drawing.Size(66, 23);
            this.sundayLabel.TabIndex = 0;
            this.sundayLabel.Text = "Sunday";
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mondayLabel.Location = new System.Drawing.Point(335, 71);
            this.mondayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(74, 23);
            this.mondayLabel.TabIndex = 2;
            this.mondayLabel.Text = "Monday";
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesdayLabel.Location = new System.Drawing.Point(799, 71);
            this.wednesdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(100, 23);
            this.wednesdayLabel.TabIndex = 4;
            this.wednesdayLabel.Text = "Wednesday";
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesdayLabel.Location = new System.Drawing.Point(574, 71);
            this.tuesdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(73, 23);
            this.tuesdayLabel.TabIndex = 3;
            this.tuesdayLabel.Text = "Tuesday";
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridayLabel.Location = new System.Drawing.Point(1305, 71);
            this.fridayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(56, 23);
            this.fridayLabel.TabIndex = 6;
            this.fridayLabel.Text = "Friday";
            // 
            // thursdayLabel
            // 
            this.thursdayLabel.AutoSize = true;
            this.thursdayLabel.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursdayLabel.Location = new System.Drawing.Point(1052, 71);
            this.thursdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thursdayLabel.Name = "thursdayLabel";
            this.thursdayLabel.Size = new System.Drawing.Size(80, 23);
            this.thursdayLabel.TabIndex = 5;
            this.thursdayLabel.Text = "Thursday";
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturdayLabel.Location = new System.Drawing.Point(1535, 71);
            this.saturdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(78, 23);
            this.saturdayLabel.TabIndex = 7;
            this.saturdayLabel.Text = "Saturday";
            // 
            // monthYearDisplay
            // 
            this.monthYearDisplay.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthYearDisplay.Location = new System.Drawing.Point(718, 15);
            this.monthYearDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthYearDisplay.Name = "monthYearDisplay";
            this.monthYearDisplay.Size = new System.Drawing.Size(260, 33);
            this.monthYearDisplay.TabIndex = 8;
            this.monthYearDisplay.Text = "  ";
            this.monthYearDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dayModeButton
            // 
            this.dayModeButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayModeButton.Location = new System.Drawing.Point(1457, 10);
            this.dayModeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dayModeButton.Name = "dayModeButton";
            this.dayModeButton.Size = new System.Drawing.Size(77, 25);
            this.dayModeButton.TabIndex = 9;
            this.dayModeButton.Text = "Day";
            this.dayModeButton.UseVisualStyleBackColor = true;
            this.dayModeButton.Click += new System.EventHandler(this.dayModeButton_Click);
            // 
            // weekModeButton
            // 
            this.weekModeButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekModeButton.Location = new System.Drawing.Point(1538, 10);
            this.weekModeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weekModeButton.Name = "weekModeButton";
            this.weekModeButton.Size = new System.Drawing.Size(77, 25);
            this.weekModeButton.TabIndex = 10;
            this.weekModeButton.Text = "Week";
            this.weekModeButton.UseVisualStyleBackColor = true;
            this.weekModeButton.Click += new System.EventHandler(this.weekModeButton_Click);
            // 
            // monthModeButton
            // 
            this.monthModeButton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthModeButton.Location = new System.Drawing.Point(1620, 10);
            this.monthModeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthModeButton.Name = "monthModeButton";
            this.monthModeButton.Size = new System.Drawing.Size(77, 25);
            this.monthModeButton.TabIndex = 11;
            this.monthModeButton.Text = "Month";
            this.monthModeButton.UseVisualStyleBackColor = true;
            this.monthModeButton.Click += new System.EventHandler(this.monthModeButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.White;
            this.nextButton.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(990, 10);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(39, 37);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = ">";
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            this.nextButton.MouseEnter += new System.EventHandler(this.nextButton_MouseEnter);
            this.nextButton.MouseLeave += new System.EventHandler(this.nextButton_MouseLeave);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.White;
            this.previousButton.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Location = new System.Drawing.Point(666, 10);
            this.previousButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(39, 37);
            this.previousButton.TabIndex = 13;
            this.previousButton.Text = "<";
            this.previousButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            this.previousButton.MouseEnter += new System.EventHandler(this.previousButton_MouseEnter);
            this.previousButton.MouseLeave += new System.EventHandler(this.previousButton_MouseLeave);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(10, 10);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 14;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 862);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.monthModeButton);
            this.Controls.Add(this.weekModeButton);
            this.Controls.Add(this.dayModeButton);
            this.Controls.Add(this.monthYearDisplay);
            this.Controls.Add(this.saturdayLabel);
            this.Controls.Add(this.fridayLabel);
            this.Controls.Add(this.thursdayLabel);
            this.Controls.Add(this.wednesdayLabel);
            this.Controls.Add(this.tuesdayLabel);
            this.Controls.Add(this.mondayLabel);
            this.Controls.Add(this.sundayLabel);
            this.Controls.Add(this.daysContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daysContainer;
        private System.Windows.Forms.Label sundayLabel;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label thursdayLabel;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.Label monthYearDisplay;
        private System.Windows.Forms.Button dayModeButton;
        private System.Windows.Forms.Button weekModeButton;
        private System.Windows.Forms.Button monthModeButton;
        private System.Windows.Forms.Label nextButton;
        private System.Windows.Forms.Label previousButton;
        private System.Windows.Forms.Button FilterButton;
    }
}

