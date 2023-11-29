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
                        String sql = "INSERT INTO Task(TaskName, TaskDescription, TaskDate) VALUES (?, ?, ?)";

                        SQLiteCommand cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.AddWithValue("TaskName", taskSubject.Text);
                        cmd.Parameters.AddWithValue("TaskDescription", taskDescription.Text);
                        cmd.Parameters.AddWithValue("TaskDate", selectedDate.Text);

                        cmd.ExecuteNonQuery();


                        string taskName = taskSubject.Text;
                        UserControlDay uc = new UserControlDay();

                        uc.UpdateTaskLabel(taskName);


                        transaction.Commit(); // Commit the transaction
                        MessageBox.Show("Saved!");


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
    }
}
