using BaseForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class NotificationsForm : Form
    {

        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";

        public NotificationsForm()
        {
            InitializeComponent();
            dataOnLoad();
        }

        public void dataOnLoad()
        {
            DateTime today = DateTime.Today;
            DateTime oneDayLater = today.AddDays(1);
            DateTime threeDaysLater = today.AddDays(3);

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                try
                {
                    connection.Open();

                    String sqlQuery = "SELECT TaskID, TaskName, TaskDescription, TaskDate FROM Task WHERE UserId = ? ORDER BY TaskDate ASC";

                    using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                    {

                        command.Parameters.AddWithValue("UserId", logInPage.userID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    string taskName = reader["TaskName"].ToString();
                                    string dueDate = reader["TaskDate"].ToString();
                                    DateTime shortTime = DateTime.Parse(dueDate);

                                    if (shortTime >= oneDayLater && shortTime <= threeDaysLater)
                                    {

                                        TaskDisplay taskBox = new TaskDisplay(taskName, shortTime.ToShortDateString());
                                        taskBox.setData();
                                        taskListFlowPanel.Controls.Add(taskBox);
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






        /* public void dataOnLoad()
         {
             //TaskDisplay taskBox = new TaskDisplay();
             DateTime shortTime = new DateTime();

             using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
             {
                 try
                 {
                     connection.Open();

                     String sqlQuery = "Select TaskID,TaskName, TaskDescription, TaskDate FROM Task";

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
                                     string ID = reader["TaskID"].ToString();
                                     shortTime = DateTime.Parse(dueDate);


                                     TaskDisplay taskBox = new TaskDisplay(taskName, shortTime.ToShortDateString());
                                     taskBox.setData();
                                     taskListFlowPanel.Controls.Add(taskBox);

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

         }*/

    }
}
