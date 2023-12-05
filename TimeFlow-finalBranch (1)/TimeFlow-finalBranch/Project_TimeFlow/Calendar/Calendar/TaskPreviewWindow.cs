using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("exitIconHover");
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("exitIcon");
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
