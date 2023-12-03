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
            PopulateCategoryBox();
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
        private void PopulateCategoryBox()
        {
            categoryBox.Items.Clear(); // Clear existing items

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                String sql = "SELECT CategoryName FROM Categories";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string categoryName = reader["CategoryName"].ToString();
                            categoryBox.Items.Add(categoryName);
                        }
                    }
                }
            }
        }

        // Call this method where appropriate, such as in the form's Load event
        private void Form_Load(object sender, EventArgs e)
        {
            PopulateCategoryBox();
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
                        // Get the selected category from the comboBox
                        string selectedCategory = categoryBox.SelectedItem?.ToString();

                        // If a category is selected, retrieve its CategoryID from the Categories table
                        int categoryID = GetCategoryID(selectedCategory);

                        // Insert the task into the Task table
                        String sql = "INSERT INTO Task(TaskName, TaskDescription, TaskDate, Category) VALUES (?, ?, ?, ?)";

                        SQLiteCommand cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.AddWithValue("TaskName", taskSubject.Text);
                        cmd.Parameters.AddWithValue("TaskDescription", taskDescription.Text);
                        cmd.Parameters.AddWithValue("TaskDate", selectedDate.Text);
                        cmd.Parameters.AddWithValue("Category", categoryID);

                        cmd.ExecuteNonQuery();

                        string taskName = taskSubject.Text;
                        UserControlDay uc = new UserControlDay();
                        uc.UpdateTaskLabel(taskName);

                        transaction.Commit(); // Commit the transaction
                        MessageBox.Show("Saved!");
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

        private int GetCategoryID(string categoryName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                String sql = "SELECT CategoryID FROM Categories WHERE CategoryName = @CategoryName";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }

            // If no matching category is found, return a default value or handle it accordingly
            return -1; // You might want to replace this with an appropriate default value or error handling
        }


        /*private void saveTaskButton_Click(object sender, EventArgs e)
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
            
        }*/
    }
}
