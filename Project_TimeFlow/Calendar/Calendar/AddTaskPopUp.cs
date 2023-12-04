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
using System.Drawing.Drawing2D;
//using MySql.Data.MySqlClient;

namespace Calendar
{
    public partial class AddTaskPopUp : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";

        public AddTaskPopUp()
        {
            InitializeComponent();
        }

        private void AddTaskPopUp_Load(object sender, EventArgs e)
        {

            if (Calendar.monthViewBool)
            {
                selectedDate.Text = Calendar.staticMonth + "/" +  UserControlDay.staticDay + "/" + Calendar.staticYear;
            }

            else if (Calendar.weekViewBool) 
            {
                selectedDate.Text = Calendar.staticMonth + "/" + UserControlWeekDay.staticDay + "/" + Calendar.staticYear;
            }

            else if (Calendar.dayViewBool)
            {
                selectedDate.Text = Calendar.staticMonth + "/" + UserControlDayView.staticDay + "/" + Calendar.staticYear;
            }

            ApplyRoundedCorners(this, 20);
            
        }

        private void saveTaskButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        String sql = "INSERT INTO Task(TaskName, TaskDescription, TaskDate, UserId) VALUES (?, ?, ?, ?)";

                        SQLiteCommand cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.AddWithValue("TaskName", taskSubject.Text);
                        cmd.Parameters.AddWithValue("TaskDescription", taskDescription.Text);
                        cmd.Parameters.AddWithValue("TaskDate", selectedDate.Text);
                        cmd.Parameters.AddWithValue("UserId", logInPage.userID);

                        cmd.ExecuteNonQuery();


                        string taskName = taskSubject.Text;
                        UserControlDay uc = new UserControlDay();

                        //uc.UpdateTaskLabel(taskName);


                        transaction.Commit(); // Commit the transaction
                        MessageBox.Show("Saved!");

                        this.Close();


                        //label1.Text = UserControlDay.lastAccessedDay.ToString();

                        
                        //UserControlDay day = new UserControlDay(UserControlDay.lastAccessedDay);
                        //day.Refresh();

                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions appropriately
                        MessageBox.Show($"Error: {ex.Message}");
                        transaction.Rollback(); // Rollback the transaction if an error occurs
                    }
                }
            }
            
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("exitIconHover");
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("exitIcon");
        }
    }
}
