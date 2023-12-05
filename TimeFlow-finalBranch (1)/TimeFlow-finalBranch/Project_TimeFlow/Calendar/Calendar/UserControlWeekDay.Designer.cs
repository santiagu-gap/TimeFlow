namespace Calendar
{
    partial class UserControlWeekDay
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
            this.dayNumberLabel = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Label();
            this.taskLabel1 = new System.Windows.Forms.Label();
            this.taskLabel2 = new System.Windows.Forms.Label();
            this.taskLabel3 = new System.Windows.Forms.Label();
            this.taskLabel6 = new System.Windows.Forms.Label();
            this.taskLabel5 = new System.Windows.Forms.Label();
            this.taskLabel4 = new System.Windows.Forms.Label();
            this.taskLabel9 = new System.Windows.Forms.Label();
            this.taskLabel8 = new System.Windows.Forms.Label();
            this.taskLabel7 = new System.Windows.Forms.Label();
            this.taskLabel12 = new System.Windows.Forms.Label();
            this.taskLabel11 = new System.Windows.Forms.Label();
            this.taskLabel10 = new System.Windows.Forms.Label();
            this.taskLabel14 = new System.Windows.Forms.Label();
            this.taskLabel13 = new System.Windows.Forms.Label();
            this.autoAddTaskTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // dayNumberLabel
            // 
            this.dayNumberLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayNumberLabel.Location = new System.Drawing.Point(15, 15);
            this.dayNumberLabel.Name = "dayNumberLabel";
            this.dayNumberLabel.Size = new System.Drawing.Size(45, 35);
            this.dayNumberLabel.TabIndex = 2;
            this.dayNumberLabel.Text = "00";
            this.dayNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTaskButton
            // 
            this.addTaskButton.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.Location = new System.Drawing.Point(177, 6);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(52, 47);
            this.addTaskButton.TabIndex = 5;
            this.addTaskButton.Text = "+";
            this.addTaskButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            this.addTaskButton.MouseEnter += new System.EventHandler(this.addTaskButton_MouseEnter);
            this.addTaskButton.MouseLeave += new System.EventHandler(this.addTaskButton_MouseLeave);
            // 
            // taskLabel1
            // 
            this.taskLabel1.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel1.Location = new System.Drawing.Point(20, 66);
            this.taskLabel1.Name = "taskLabel1";
            this.taskLabel1.Size = new System.Drawing.Size(198, 21);
            this.taskLabel1.TabIndex = 6;
            this.taskLabel1.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel1.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel1.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel2
            // 
            this.taskLabel2.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel2.Location = new System.Drawing.Point(20, 120);
            this.taskLabel2.Name = "taskLabel2";
            this.taskLabel2.Size = new System.Drawing.Size(198, 21);
            this.taskLabel2.TabIndex = 7;
            this.taskLabel2.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel2.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel2.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel3
            // 
            this.taskLabel3.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel3.Location = new System.Drawing.Point(20, 175);
            this.taskLabel3.Name = "taskLabel3";
            this.taskLabel3.Size = new System.Drawing.Size(198, 21);
            this.taskLabel3.TabIndex = 8;
            this.taskLabel3.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel3.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel3.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel6
            // 
            this.taskLabel6.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel6.Location = new System.Drawing.Point(20, 337);
            this.taskLabel6.Name = "taskLabel6";
            this.taskLabel6.Size = new System.Drawing.Size(198, 21);
            this.taskLabel6.TabIndex = 11;
            this.taskLabel6.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel6.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel6.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel5
            // 
            this.taskLabel5.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel5.Location = new System.Drawing.Point(20, 282);
            this.taskLabel5.Name = "taskLabel5";
            this.taskLabel5.Size = new System.Drawing.Size(198, 21);
            this.taskLabel5.TabIndex = 10;
            this.taskLabel5.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel5.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel5.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel4
            // 
            this.taskLabel4.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel4.Location = new System.Drawing.Point(20, 228);
            this.taskLabel4.Name = "taskLabel4";
            this.taskLabel4.Size = new System.Drawing.Size(198, 21);
            this.taskLabel4.TabIndex = 9;
            this.taskLabel4.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel4.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel4.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel9
            // 
            this.taskLabel9.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel9.Location = new System.Drawing.Point(20, 503);
            this.taskLabel9.Name = "taskLabel9";
            this.taskLabel9.Size = new System.Drawing.Size(198, 21);
            this.taskLabel9.TabIndex = 14;
            this.taskLabel9.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel9.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel9.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel8
            // 
            this.taskLabel8.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel8.Location = new System.Drawing.Point(20, 448);
            this.taskLabel8.Name = "taskLabel8";
            this.taskLabel8.Size = new System.Drawing.Size(198, 21);
            this.taskLabel8.TabIndex = 13;
            this.taskLabel8.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel8.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel8.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel7
            // 
            this.taskLabel7.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel7.Location = new System.Drawing.Point(20, 394);
            this.taskLabel7.Name = "taskLabel7";
            this.taskLabel7.Size = new System.Drawing.Size(198, 21);
            this.taskLabel7.TabIndex = 12;
            this.taskLabel7.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel7.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel7.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel12
            // 
            this.taskLabel12.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel12.Location = new System.Drawing.Point(20, 668);
            this.taskLabel12.Name = "taskLabel12";
            this.taskLabel12.Size = new System.Drawing.Size(198, 21);
            this.taskLabel12.TabIndex = 17;
            this.taskLabel12.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel12.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel12.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel11
            // 
            this.taskLabel11.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel11.Location = new System.Drawing.Point(20, 613);
            this.taskLabel11.Name = "taskLabel11";
            this.taskLabel11.Size = new System.Drawing.Size(198, 21);
            this.taskLabel11.TabIndex = 16;
            this.taskLabel11.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel11.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel11.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel10
            // 
            this.taskLabel10.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel10.Location = new System.Drawing.Point(20, 559);
            this.taskLabel10.Name = "taskLabel10";
            this.taskLabel10.Size = new System.Drawing.Size(198, 21);
            this.taskLabel10.TabIndex = 15;
            this.taskLabel10.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel10.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel10.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel14
            // 
            this.taskLabel14.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel14.Location = new System.Drawing.Point(20, 779);
            this.taskLabel14.Name = "taskLabel14";
            this.taskLabel14.Size = new System.Drawing.Size(198, 21);
            this.taskLabel14.TabIndex = 19;
            this.taskLabel14.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel14.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel14.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // taskLabel13
            // 
            this.taskLabel13.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel13.Location = new System.Drawing.Point(20, 725);
            this.taskLabel13.Name = "taskLabel13";
            this.taskLabel13.Size = new System.Drawing.Size(198, 21);
            this.taskLabel13.TabIndex = 18;
            this.taskLabel13.Click += new System.EventHandler(this.taskLabel_Click);
            this.taskLabel13.MouseEnter += new System.EventHandler(this.task_MouseEnter);
            this.taskLabel13.MouseLeave += new System.EventHandler(this.task_MouseLeave);
            // 
            // autoAddTaskTimer
            // 
            this.autoAddTaskTimer.Interval = 500;
            this.autoAddTaskTimer.Tick += new System.EventHandler(this.autoAddTaskTimer_Tick);
            // 
            // UserControlWeekDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.taskLabel14);
            this.Controls.Add(this.taskLabel13);
            this.Controls.Add(this.taskLabel12);
            this.Controls.Add(this.taskLabel11);
            this.Controls.Add(this.taskLabel10);
            this.Controls.Add(this.taskLabel9);
            this.Controls.Add(this.taskLabel8);
            this.Controls.Add(this.taskLabel7);
            this.Controls.Add(this.taskLabel6);
            this.Controls.Add(this.taskLabel5);
            this.Controls.Add(this.taskLabel4);
            this.Controls.Add(this.taskLabel3);
            this.Controls.Add(this.taskLabel2);
            this.Controls.Add(this.taskLabel1);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.dayNumberLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlWeekDay";
            this.Size = new System.Drawing.Size(236, 848);
            this.Load += new System.EventHandler(this.UserControlWeekDay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dayNumberLabel;
        private System.Windows.Forms.Label addTaskButton;
        private System.Windows.Forms.Label taskLabel1;
        private System.Windows.Forms.Label taskLabel2;
        private System.Windows.Forms.Label taskLabel3;
        private System.Windows.Forms.Label taskLabel6;
        private System.Windows.Forms.Label taskLabel5;
        private System.Windows.Forms.Label taskLabel4;
        private System.Windows.Forms.Label taskLabel9;
        private System.Windows.Forms.Label taskLabel8;
        private System.Windows.Forms.Label taskLabel7;
        private System.Windows.Forms.Label taskLabel12;
        private System.Windows.Forms.Label taskLabel11;
        private System.Windows.Forms.Label taskLabel10;
        private System.Windows.Forms.Label taskLabel14;
        private System.Windows.Forms.Label taskLabel13;
        private System.Windows.Forms.Timer autoAddTaskTimer;
    }
}
