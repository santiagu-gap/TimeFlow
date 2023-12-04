using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class TaskPage : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";

        public TaskPage()
        {
            InitializeComponent();
            taskDateTimePicker.MinDate = DateTime.Now;
            dataOnLoad();
        }
        DataTable toDoList = new DataTable();
        bool IsEditing = false;

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            DateTime dateSelected = taskDateTimePicker.Value;
            string deadline = dateSelected.Year + "/" + dateSelected.Month + "/" + dateSelected.Day;

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

                        cmd.Parameters.AddWithValue("TaskName", taskTitleTextbox.Text);
                        cmd.Parameters.AddWithValue("TaskDescription", taskDescriptionTextBox.Text);
                        cmd.Parameters.AddWithValue("TaskDate", dateSelected.ToLongDateString());
                        

                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions appropriately
                        MessageBox.Show($"Error: {ex.Message}");
                        transaction.Rollback(); // Rollback the transaction if an error occurs
                    }
                    finally
                    {
                        connection.Close(); // Ensure the connection is closed even if an exception occurs
                    }

                }

            }
            try
            {
                TaskDisplay taskBox = new TaskDisplay(taskTitleTextbox.Text, deadline);
                taskBox.setData();
                taskListFlowPanel.Controls.Add(taskBox);
                taskDateTimePicker.MinDate = DateTime.Now;


            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show($"Error: {ex.Message}");
            }



            //after saved, clear textboxes
            taskTitleTextbox.Text = "";
            taskDescriptionTextBox.Text = "";


        }

        public void dataOnLoad()
        {
            //TaskDisplay taskBox = new TaskDisplay();
            DateTime shortTime = new DateTime();

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                try
                {


                    connection.Open();

                    String sqlQuery = "Select TaskID,TaskName, TaskDescription, TaskDate FROM Task where UserId = ?";
                    

                    using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", logInPage.userID);
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

        }




    }

}


