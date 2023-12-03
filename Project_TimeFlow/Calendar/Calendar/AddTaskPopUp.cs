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

            LoadCategories();
        }

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

        private void saveTaskButton_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Assuming you have a way to obtain the CategoryId from the selected item in categoryBox
                        int selectedCategoryId = (categoryBox.SelectedItem as dynamic)?.CategoryId ?? -1;

                        // Modify the SQL statement to include CategoryId
                        String sql = "INSERT INTO Task(TaskName, TaskDescription, TaskDate, UserId, CategoryId) VALUES (?, ?, ?, ?, ?)";

                        SQLiteCommand cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.AddWithValue("TaskName", taskSubject.Text);
                        cmd.Parameters.AddWithValue("TaskDescription", taskDescription.Text);
                        cmd.Parameters.AddWithValue("TaskDate", selectedDate.Text);
                        cmd.Parameters.AddWithValue("UserId", logInPage.userID);
                        cmd.Parameters.AddWithValue("CategoryId", selectedCategoryId);  // Add CategoryId parameter

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

    }
}
