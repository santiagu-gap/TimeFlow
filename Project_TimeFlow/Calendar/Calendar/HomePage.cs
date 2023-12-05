using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Calendar;

namespace Calendar
{
    public partial class HomePage : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";
        string[] quoteArray = {
        "Education is the most powerful weapon you can use to change the world",
        "The expert in anything was once a beginner",
        "The way to get started is to quit talking and begin doing",
        "Motivation is what gets you started. Habit is what keeps you going",
        "Success is the sum of small efforts, repeated",
        "The future belongs to those who believe in the beauty of their dreams",
        "Learn from yesterday. Live for today. Hope for tomorrow",
        "Today a reader, tomorrow a leader",
        "All progress takes place outside of your comfort zone"

        };
        public HomePage()
        {
            InitializeComponent();
            labelTransparent();
            dateDisplay.Text = DateTime.Today.ToLongDateString();
            timeDisplay.Text = DateTime.Now.ToLongTimeString();

            dataOnLoad();
            quoteRandom();
            dayProgression.Maximum = 24 * 60;
            dayProgression.Value = GetCurrentProgress();
            dayProgression.ForeColor = Color.CadetBlue;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeDisplay.Text = DateTime.Now.ToLongTimeString();
        }

        public void dataOnLoad()
        {
            if (taskDisplayContainer.Controls.Count > 0)
            {
                taskDisplayContainer.Controls.Clear();
            }
            //TaskDisplay taskBox = new TaskDisplay();
            DateTime shortTime = new DateTime();
            DateTime todaysDate = DateTime.Today;

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                try
                {
                    connection.Open();

                    String sqlQuery = "Select TaskID,TaskName,TaskDescription, TaskDate FROM Task";

                    using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                try
                                {
                                    string taskName = reader["TaskName"].ToString();
                                    string dueDate = reader["TaskDate"].ToString();
                                    /*                                    string ID = reader["TaskID"].ToString();
                                    */
                                    shortTime = DateTime.Parse(dueDate);

                                    if (todaysDate.ToShortDateString() == shortTime.ToShortDateString())
                                    {
                                        TaskDisplay taskBox = new TaskDisplay(taskName, shortTime.ToShortDateString());
                                        taskBox.setData();
                                        taskDisplayContainer.Controls.Add(taskBox);
                                    }


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"An error occurred: {ex.Message} {ex.StackTrace}");
                                }


                            }

                            reader.Close();
                        }
                        command.Dispose();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

            }

        }
        public void quoteRandom()
        {
            Random random = new Random();
            int number = random.Next(0, quoteArray.Length);
            quoteGenerator.Text = quoteArray[number];
        }

        /*
         * private void StartProgressBar()
        {
            progressionBar.Interval = 1000;
            progressionBar.Tick += progressionBar_Tick;
            progressionBar.Start();

        }
         */
        private int GetCurrentProgress()
        {
            DateTime now = DateTime.Now;
            int progress = now.Hour * 60 + now.Minute;
            return progress;
        }

        private void progressionBar_Tick(object sender, EventArgs e)
        {
            dayProgression.Value = GetCurrentProgress();
        }

        private void vanierLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vanierLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://vaniercollege.omnivox.ca/intr/");
        }

        private void pomodoroLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pomodoroLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://studywithme.io/aesthetic-pomodoro-timer/");
        }

        private void quizletLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quizletLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://quizlet.com/");
        }

        private void labelTransparent()
        {
            //welcomeLabel.Parent = bannerPicture;
            //dateDisplay.Parent = bannerPicture;
            //timeDisplay.Parent = bannerPicture;
            welcomeLabel.BackColor = Color.Transparent;
            dateDisplay.BackColor = Color.Transparent;
            timeDisplay.BackColor = Color.Transparent;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text += logInPage.username;
        }
    }
}
