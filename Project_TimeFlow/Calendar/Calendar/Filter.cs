using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Filter : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";

        public Filter()
        {
            InitializeComponent();
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                String sql = "SELECT CategoryName, isChecked FROM Categories";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string categoryName = reader["CategoryName"].ToString();
                            int isChecked = Convert.ToInt32(reader["isChecked"]);

                            // Add the category name to the checkedListBox
                            int index = categoriesList.Items.Add(categoryName);

                            // Set the checked state based on the value of isChecked
                            categoriesList.SetItemChecked(index, isChecked == 1);
                        }
                    }
                }
            }

            // Attach the ItemCheck event handler
            categoriesList.ItemCheck += CategoriesList_ItemCheck;
        }

        private void CategoriesList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // When an item's check state is changing, update the database immediately
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                string categoryName = categoriesList.Items[e.Index].ToString();
                int isChecked = e.NewValue == CheckState.Checked ? 1 : 0;

                // Update the isChecked field in the database
                String sql = "UPDATE Categories SET isChecked = @isChecked WHERE CategoryName = @CategoryName";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@isChecked", isChecked);
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void Filter_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Detach the ItemCheck event handler to avoid unnecessary updates during closing
            categoriesList.ItemCheck -= CategoriesList_ItemCheck;
            UserControlDay.displayTasks();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            // Get the new category name from the TextBox
            string newCategoryNameString = newCategoryName.Text.Trim();

            // Check if the new category name is not empty
            if (!string.IsNullOrEmpty(newCategoryNameString))
            {
                // Add the new category to the checkedListBox
                categoriesList.Items.Add(newCategoryNameString);

                // Insert the new category into the "Categories" table in the database
                using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
                {
                    connection.Open();

                    // Assuming "CategoryName" is a column in the "Categories" table
                    String sql = "INSERT INTO Categories (CategoryName) VALUES (@CategoryName)";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", newCategoryNameString);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            // Loop through the selected items and remove them
            for (int i = categoriesList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int selectedIndex = categoriesList.SelectedIndices[i];
                string categoryName = categoriesList.Items[selectedIndex].ToString();

                // Remove the category from the checkedListBox
                categoriesList.Items.RemoveAt(selectedIndex);

                // Remove the category from the "Categories" table in the database
                using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
                {
                    connection.Open();

                    // Assuming "CategoryName" is a column in the "Categories" table
                    String sql = "DELETE FROM Categories WHERE CategoryName = @CategoryName";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}