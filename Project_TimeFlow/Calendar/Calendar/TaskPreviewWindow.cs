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
    public partial class TaskPreviewWindow : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";
        public TaskPreviewWindow()
        {
            InitializeComponent();
        }

        private void TaskPreviewWindow_Load(object sender, EventArgs e)
        {
            dateBox.Text = Calendar.staticMonth + "/" + UserControlDay.staticDay + "/" + Calendar.staticYear;

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                String sql = "SELECT Task.*, Categories.CategoryName " +
                             "FROM Task LEFT JOIN Categories ON Task.CategoryId = Categories.CategoryId " +
                             "WHERE Task.TaskName = ? AND Task.TaskDate = ?";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("TaskName", UserControlDay.taskSelected);
                    cmd.Parameters.AddWithValue("TaskDate", dateBox.Text);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                taskDescriptionTextBox.Text = reader["TaskDescription"].ToString();
                                taskSubject.Text = reader["TaskName"].ToString();

                                // Check if "CategoryName" is null and set the categoryBox.Text accordingly
                                categoryBox.Text = reader["CategoryName"] != DBNull.Value
                                    ? reader["CategoryName"].ToString()
                                    : "none";
                            }
                        }
                    }
                }
            }
        }

    }
}
