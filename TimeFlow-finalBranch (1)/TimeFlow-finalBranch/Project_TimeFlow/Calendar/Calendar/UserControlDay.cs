﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlDay : UserControl
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";

        public static string staticDay;
        public static string taskSelected;
        public bool addingNewTask = false;
        public string date;
        int addingNewTaskTrigger = 0;
        public bool taskOneLoaded = false;
        public bool taskTwoLoaded = false;
        public bool taskThreeLoaded = false;
        int tasksOutputted = 1;
        public static string lastAccessedDay;
        public static bool UnlabeledPriority = true;
        public static bool Priority1 = true;
        public static bool Priority2 = true;
        public static bool Priority3 = true;
        public static bool Priority4 = true;
        public UserControlDay()
        {
            InitializeComponent();
        }

        public void days(int dayNumber, bool currDay)
        {
            if (!currDay)
            {
                dayNumberLabel.Text = dayNumber.ToString();
            }
            else if (currDay)
            {
                dayNumberLabel.Text = dayNumber.ToString();
                dayNumberLabel.Font = new Font(dayNumberLabel.Font, FontStyle.Bold);
                dayNumberLabel.ForeColor = Color.White;
                dayNumberLabel.BackColor = Color.FromArgb(145, 170, 252);
                ApplyRoundedCorners(dayNumberLabel, 10);
            }
            
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {
            //UserControlMonthViewTaskOutput task = new UserControlMonthViewTaskOutput();
            //tasksFlowPanel.Controls.Add(task);
            ApplyRoundedCorners(this, 20);
            ApplyRoundedCorners(this.taskLabel1, 10);
            ApplyRoundedCorners(this.taskLabel2, 10);
            ApplyRoundedCorners(this.taskLabel3, 10);
            ApplyRoundedCorners(addTaskButton, 10);
            displayTasks();
        }

        private void ApplyRoundedCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            control.Region = new Region(path);
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            staticDay = dayNumberLabel.Text;
            Calendar.monthViewBool = true;
            Calendar.weekViewBool = false;
            Calendar.dayViewBool = false;
            autoAddTaskTimer.Start();
            //lastAccessedDay = date;
            AddTaskPopUp popUp = new AddTaskPopUp();
            popUp.Show();
        }

        public void displayTasks()
        {
            tasksOutputted = 1;
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                String sql = "SELECT * FROM Task WHERE TaskDate = ? AND UserId = ? AND (CategoryId IS NULL OR CategoryId IN (SELECT CategoryId FROM Categories WHERE IsChecked = 1))";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("TaskDate", Calendar.staticMonth + "/" + dayNumberLabel.Text + "/" + Calendar.staticYear);
                    cmd.Parameters.AddWithValue("UserId", logInPage.userID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read() && tasksOutputted <= 3)
                            {
                                int priority = Convert.ToInt32(reader["Priority"]);

                                // Check Priority and boolean flags
                                bool displayTask = false;
                                if (priority == 0) // Unlabeled
                                {
                                    displayTask = UnlabeledPriority;
                                }
                                else // Labeled with Priority
                                {
                                    switch (priority)
                                    {
                                        case 1:
                                            displayTask = Priority1;
                                            break;
                                        case 2:
                                            displayTask = Priority2;
                                            break;
                                        case 3:
                                            displayTask = Priority3;
                                            break;
                                        case 4:
                                            displayTask = Priority4;
                                            break;
                                    }
                                }

                                if (displayTask)
                                {
                                    string taskLabel = "taskLabel" + tasksOutputted;

                                    Control control = Controls.Find(taskLabel, true).FirstOrDefault();

                                    if (control != null && control is System.Windows.Forms.Label label)
                                    {
                                        label.Text = reader["TaskName"].ToString();
                                        label.BackColor = Color.FromArgb(100, 145, 170, 252);
                                        ApplyRoundedCorners(label, 10);
                                    }
                                    tasksOutputted++;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void taskLabel_Click(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Label clickedLabel)
            {
                // Get the label's number from its name
                if (int.TryParse(clickedLabel.Name.Replace("taskLabel", ""), out int labelNumber))
                {
                    staticDay = dayNumberLabel.Text;
                    taskSelected = clickedLabel.Text;
                    TaskPreviewWindow taskPreviewWindow = new TaskPreviewWindow();
                    taskPreviewWindow.Show();
                }
            }
        }

        private void task_MouseEnter(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Label clickedLabel)
            {
                if (!clickedLabel.Text.Equals(""))
                {
                    clickedLabel.BackColor = Color.FromArgb(150, 145, 170, 252);
                }

            }

        }

        private void task_MouseLeave(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Label clickedLabel)
            {
                if (!clickedLabel.Text.Equals(""))
                {
                    clickedLabel.BackColor = Color.FromArgb(100, 145, 170, 252);
                }
            }
        }

        private void addTaskButton_MouseEnter(object sender, EventArgs e)
        {
            addTaskButton.BackColor = Color.WhiteSmoke;
        }

        private void addTaskButton_MouseLeave(object sender, EventArgs e)
        {
            addTaskButton.BackColor = Color.White;
        }

        private void autoAddTaskTimer_Tick(object sender, EventArgs e)
        {
            displayTasks();
        }
    }
}
