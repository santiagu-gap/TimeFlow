using System;
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
        public UserControlDay()
        {
            InitializeComponent();
        }

        //public UserControlDay(String date)
        //{
        //    InitializeComponent();
        //    this.date = date;
        //}

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
            //autoAddTaskTimer.Start();
            //lastAccessedDay = date;
            AddTaskPopUp popUp = new AddTaskPopUp();
            popUp.Show();
        }

        public void displayTasks()
        {
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
                            while (reader.Read() && tasksOutputted <= 4)
                            {
                                switch (tasksOutputted)
                                {
                                    case 1:
                                        taskLabel1.Text = reader["TaskName"].ToString();
                                        taskLabel1.BackColor = Color.FromArgb(100, 145, 170, 252);
                                        taskOneLoaded = true;
                                        break;
                                    case 2:
                                        taskLabel2.Text = reader["TaskName"].ToString();
                                        taskLabel2.BackColor = Color.FromArgb(100, 145, 170, 252);
                                        taskTwoLoaded = true;
                                        break;
                                    case 3:
                                        taskLabel3.Text = reader["TaskName"].ToString();
                                        taskLabel3.BackColor = Color.FromArgb(100, 145, 170, 252);
                                        taskThreeLoaded = true;
                                        break;
                                }
                                tasksOutputted++;
                            }
                        }
                    }
                }
            }
        }


        /*        public void displayTasks()
                {
                    using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
                    {
                        connection.Open();

                        String sql = "SELECT * FROM Task WHERE TaskDate = ? AND UserId = ?";

                        using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("TaskDate", Calendar.staticMonth + "/" + dayNumberLabel.Text + "/" + Calendar.staticYear);
                            cmd.Parameters.AddWithValue("UserId", logInPage.userID);

                            using (SQLiteDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read() && tasksOutputted <= 4)
                                    {
                                        switch (tasksOutputted)
                                        {
                                            case 1:
                                                taskLabel1.Text = reader["TaskName"].ToString();
                                                //taskLabel1.BackColor = Color.FromArgb(100, Color.DarkRed);
                                                taskLabel1.BackColor = Color.FromArgb(100,145, 170, 252);
                                                //taskLabel1.Update();
                                                taskOneLoaded = true;
                                                break;
                                            case 2:
                                                taskLabel2.Text = reader["TaskName"].ToString();

                                                //taskLabel2.BackColor = Color.FromArgb(100, Color.Coral);
                                                taskLabel2.BackColor = Color.FromArgb(100,145, 170, 252);
                                                taskTwoLoaded = true;
                                                break;
                                            case 3:
                                                taskLabel3.Text = reader["TaskName"].ToString();
                                                //taskLabel3.BackColor = Color.FromArgb(100, Color.SpringGreen);
                                                taskLabel3.BackColor = Color.FromArgb(100, 145, 170, 252);
                                                taskThreeLoaded = true;
                                                break;

                                        }
                                        tasksOutputted++;
                                    }
                                }
                            }
                        }
                    }
                }
        */
        public void UpdateTaskLabel(string taskName)
        {
                taskLabel1.Text = taskName;
                taskLabel1.BackColor = Color.FromArgb(145, 170, 252);
                taskLabel1.Refresh();
        }

        private void tasksFlowPanel_Click(object sender, EventArgs e)
        {
            staticDay = dayNumberLabel.Text;
        }

        private void taskLabel1_Click(object sender, EventArgs e)
        {
            if (taskOneLoaded)
            {
                staticDay = dayNumberLabel.Text;
                taskSelected = taskLabel1.Text;
                TaskPreviewWindow taskPreviewWindow = new TaskPreviewWindow();  
                taskPreviewWindow.Show();
                
            }
        }
        private void taskLabel2_Click(object sender, EventArgs e)
        {
            if (taskTwoLoaded)
            {
                staticDay = dayNumberLabel.Text;
                taskSelected = taskLabel2.Text;
                TaskPreviewWindow taskPreviewWindow = new TaskPreviewWindow(); 
                taskPreviewWindow.Show();
            }
        }

        private void taskLabel3_Click(object sender, EventArgs e)
        {
            if (taskThreeLoaded)
            {
                staticDay = dayNumberLabel.Text;
                taskSelected = taskLabel3.Text;
                TaskPreviewWindow taskPreviewWindow = new TaskPreviewWindow();
                taskPreviewWindow.Show();
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

        private void taskLabel1_MouseEnter(object sender, EventArgs e)
        {
            if (taskOneLoaded)
                taskLabel1.BackColor = Color.FromArgb(150, 145, 170, 252);
        }

        private void taskLabel1_MouseLeave(object sender, EventArgs e)
        {
            if (taskOneLoaded)
                taskLabel1.BackColor = Color.FromArgb(100, 145, 170, 252);
        }


        private void taskLabel3_MouseEnter(object sender, EventArgs e)
        {
            if (taskThreeLoaded)
                taskLabel3.BackColor = Color.FromArgb(150, 145, 170, 252);
        }

        private void taskLabel3_MouseLeave(object sender, EventArgs e)
        {
            if (taskThreeLoaded)
                taskLabel3.BackColor = Color.FromArgb(100, 145, 170, 252);
        }

        private void taskLabel2_MouseEnter(object sender, EventArgs e)
        {
            if (taskTwoLoaded)
                taskLabel2.BackColor = Color.FromArgb(150, 145, 170, 252);
        }

        private void taskLabel2_MouseLeave(object sender, EventArgs e)
        {
            if (taskTwoLoaded)
                taskLabel2.BackColor = Color.FromArgb(100, 145, 170, 252);
        }

        private void autoAddTaskTimer_Tick(object sender, EventArgs e)
        {
            addingNewTask = true;
            addingNewTaskTrigger = 0;
            displayTasks();
            
        }
    }
}
