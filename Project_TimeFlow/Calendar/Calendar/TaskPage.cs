using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class TaskPage : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";

        public static List<int> selectedTasks = new List<int>();

        public TaskPage()
        {
            InitializeComponent();
            taskDateTimePicker.MinDate = DateTime.Now;
            dataOnLoad();
            LoadCategories();
        }
        DataTable toDoList = new DataTable();
        bool IsEditing = false;

        private void LoadCategories()
        {

            // Clear existing items and data in categoryBox
            categoryBox.Items.Clear();
            categoryBox.DisplayMember = "CategoryName";
            categoryBox.ValueMember = "CategoryId";

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                // Assuming there's a common column named "UserId" in both "Categories" and "User" tables
                String sql = "SELECT CategoryId, CategoryName FROM Categories WHERE UserId = @UserId";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", logInPage.userID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming that "CategoryName" and "CategoryId" are columns in the "Categories" table
                            int categoryId = Convert.ToInt32(reader["CategoryId"]);
                            string categoryName = reader["CategoryName"].ToString();

                            // Create a new object to store both CategoryId and CategoryName
                            var categoryItem = new { CategoryId = categoryId, CategoryName = categoryName };

                            // Add the category to the categoryBox
                            categoryBox.Items.Add(categoryItem);
                        }
                    }
                }
            }
        }

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

                        int selectedCategoryId = (categoryBox.SelectedItem as dynamic)?.CategoryId ?? -1;

                        String sql = "INSERT INTO Task(TaskName, TaskDescription, TaskDate, UserId, CategoryId) VALUES (?, ?, ?, ?, ?)";

                        SQLiteCommand cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.AddWithValue("TaskName", taskTitleTextbox.Text);
                        cmd.Parameters.AddWithValue("TaskDescription", taskDescriptionTextBox.Text);
                        cmd.Parameters.AddWithValue("TaskDate", dateSelected.ToString("MMMM/d/yyyy").Replace("-", "/"));
                        cmd.Parameters.AddWithValue("UserId", logInPage.userID);
                        cmd.Parameters.AddWithValue("CategoryId", selectedCategoryId);  // Add CategoryId parameter


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
                //TaskDisplay taskBox = new TaskDisplay(taskTitleTextbox.Text, deadline);
                //taskBox.setData();
                //taskListFlowPanel.Controls.Add(taskBox);
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


                                    TaskDisplay taskBox = new TaskDisplay(taskName, shortTime.ToShortDateString(), ID);
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

        private void ApplyRoundedCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            control.Region = new Region(path);
        }

        private void TaskPage_Load(object sender, EventArgs e)
        {
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedTasks.Count > 0)
            {
                using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
                {
                    connection.Open();

                    using (SQLiteTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Create a parameterized SQL query to delete tasks based on TaskID
                            string deleteSql = "DELETE FROM Task WHERE TaskID IN (" +
                                               string.Join(",", selectedTasks) +
                                               ") AND UserId = @UserId";

                            using (SQLiteCommand deleteCommand = new SQLiteCommand(deleteSql, connection, transaction))
                            {
                                deleteCommand.Parameters.AddWithValue("@UserId", logInPage.userID);
                                deleteCommand.ExecuteNonQuery();
                            }

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

                // Clear the selectedTasks list
                selectedTasks.Clear();

                // Optionally, update the UI or perform other actions after deletion
                // For example, you may want to reload the data or update the task list display
                taskListFlowPanel.Controls.Clear(); // Clear existing controls
                dataOnLoad(); // Reload data and update the display
            }
            else
            {
                MessageBox.Show("No tasks selected for deletion.");
            }
        }

    }

}


