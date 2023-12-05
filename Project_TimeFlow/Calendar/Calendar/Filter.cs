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
    public partial class Filter : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";
        private Dictionary<string, int> categoryIdMap = new Dictionary<string, int>();
        private int userId = logInPage.userID;

        public Filter()
        {
            InitializeComponent();
            LoadCheckStates();
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                // Assuming there's a common column named "UserId" in both "Categories" and "User" tables
                String sql = "SELECT CategoryId, CategoryName, IsChecked FROM Categories WHERE UserId = @UserId";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming that "CategoryName" and "IsChecked" are columns in the "Categories" table
                            int categoryId = Convert.ToInt32(reader["CategoryId"]);
                            string categoryName = reader["CategoryName"].ToString();
                            int isChecked = Convert.ToInt32(reader["IsChecked"]);

                            // Add the category name to the checkedListBox and set the Checked state
                            categoriesList.Items.Add(categoryName, isChecked == 1);

                            categoryIdMap[categoryName + userId] = categoryId;
                        }
                    }
                }
            }
            categoriesList.ItemCheck += CategoriesList_ItemCheck;
            PriorityBox.ItemCheck += PriorityBox_ItemCheck;

            PriorityBox.Items.Add("Unlabeled");
            PriorityBox.Items.Add("Important - Urgent");
            PriorityBox.Items.Add("Important - Not Urgent");
            PriorityBox.Items.Add("Not Important - Urgent");
            PriorityBox.Items.Add("Not Important - Not Urgent");

            if (PriorityBox.Items.Count > 0)
            {
                PriorityBox.ItemCheck -= PriorityBox_ItemCheck; // Unsubscribe temporarily to avoid event triggering
                LoadCheckStates();
                PriorityBox.ItemCheck += PriorityBox_ItemCheck; // Subscribe back to the event
            }
            ApplyRoundedCorners(this, 30);
        }

        private void CategoriesList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the category name from the clicked item
            string categoryName = categoriesList.Items[e.Index].ToString();

            // Update the "IsChecked" field in the database based on the Checked state
            UpdateIsChecked(categoryName, e.NewValue == CheckState.Checked ? 1 : 0);
        }
        private void UpdateIsChecked(string categoryName, int isChecked)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                // Assuming there's a common column named "UserId" in both "Categories" and "User" tables
                String sql = "UPDATE Categories SET IsChecked = @IsChecked WHERE CategoryName = @CategoryName AND UserId = @UserId";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@IsChecked", isChecked);
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            // Get the new category name from the TextBox
            string newCategoryNameString = newCategoryName.Text.Trim();

            // Check if the new category name is not empty
            if (!string.IsNullOrEmpty(newCategoryNameString))
            {
                // Check if the category already exists in the list
                if (categoriesList.Items.Contains(newCategoryNameString))
                {
                    MessageBox.Show("Category already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if the category already exists
                }

                // Insert the new category into the "Categories" table in the database
                using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
                {
                    connection.Open();

                    // Assuming "CategoryName" and "UserId" are columns in the "Categories" table
                    String sql = "INSERT INTO Categories (CategoryName, UserId) VALUES (@CategoryName, @UserId)";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", newCategoryNameString);
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "SELECT last_insert_rowid()";
                        int newCategoryId = Convert.ToInt32(cmd.ExecuteScalar());

                        categoryIdMap[newCategoryNameString + userId] = newCategoryId;
                    }
                }

                // Add the new category to the checkedListBox
                categoriesList.Items.Add(newCategoryNameString);
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

                    // Assuming "CategoryName" and "UserId" are columns in the "Categories" table
                    String sql = "DELETE FROM Categories WHERE CategoryId = @CategoryId";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        int categoryId = categoryIdMap[categoryName + userId];

                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                        cmd.ExecuteNonQuery();
                    }
                }

                categoryIdMap.Remove(categoryName + userId);
            }
        }

        private void PriorityBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Update the corresponding boolean variable based on the clicked item
            switch (PriorityBox.Items[e.Index].ToString())
            {
                case "Unlabeled":
                    UserControlDay.UnlabeledPriority = (e.NewValue == CheckState.Checked);
                    break;
                case "Important - Urgent":
                    UserControlDay.Priority1 = (e.NewValue == CheckState.Checked);
                    break;
                case "Important - Not Urgent":
                    UserControlDay.Priority2 = (e.NewValue == CheckState.Checked);
                    break;
                case "Not Important - Urgent":
                    UserControlDay.Priority3 = (e.NewValue == CheckState.Checked);
                    break;
                case "Not Important - Not Urgent":
                    UserControlDay.Priority4 = (e.NewValue == CheckState.Checked);
                    break;
            }
        }

        private void LoadCheckStates()
        {
            if (PriorityBox.Items.Count > 0)
            {
                // Unsubscribe temporarily to avoid event triggering
                PriorityBox.ItemCheck -= PriorityBox_ItemCheck;

                SetCheckState(UserControlDay.UnlabeledPriority, 0);
                SetCheckState(UserControlDay.Priority1, 1);
                SetCheckState(UserControlDay.Priority2, 2);
                SetCheckState(UserControlDay.Priority3, 3);
                SetCheckState(UserControlDay.Priority4, 4);

                // Subscribe back to the event
                PriorityBox.ItemCheck += PriorityBox_ItemCheck;
            }
        }

        private void SetCheckState(bool state, int index)
        {
            if (index < PriorityBox.Items.Count)
            {
                PriorityBox.SetItemChecked(index, state);
            }
        }

        private void Filter_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
