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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaseForm
{
    public partial class AddTaskControl : UserControl
    {
        //"C:\Users\Admin\source\repos\TeamProject\Database\tasksDB.db"
        String sqlConnection = @"DataSource=..\..\..\Database\tasksDB.db;Version=3;";
        string relativePath = @"..\..\..\Database\tasksDB.db";

        public AddTaskControl()
        {
            InitializeComponent();
        }
        DataTable toDoList = new DataTable();
        bool IsEditing = false;
        private void AddTaskControl_Load(object sender, EventArgs e)
        {
            //Create columns 
            toDoList.Columns.Add("Title");
            toDoList.Columns.Add("Description");

            //Point our datagridview to our datasource
            //The user can choose a date in the present or in the future but not in the past
            taskDateTimePicker.MinDate = DateTime.Now;
             dataOnLoad();


        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            //retrieve the value of the date chosen by the user
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

        private void editTaskButton_Click(object sender, EventArgs e)
        {
            //check if the task is currently being editing
            IsEditing = true;

            //Fill text fields with data from table

            //get the current row clicked by the user and put it in the text fields
            /*taskTitleTextbox.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            taskDescriptionTextBox.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();*/
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            /*try
            {
                toDoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
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

        }
    }
}
