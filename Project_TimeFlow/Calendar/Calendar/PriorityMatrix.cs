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
    public partial class PriorityMatrix : Form
    {

        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";
        public PriorityMatrix()
        {
            InitializeComponent();
            LoadTasksForCurrentUser();
            LoadTasksIntoListViews();
        }
        private void LoadTasksForCurrentUser()
        {
            ToolStripMenuItem tasksNode = TasksMenuStrip.Items.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Name == "tasksNode");

            if (tasksNode != null)
            {
                tasksNode.DropDownItems.Clear(); // Clear existing items

                using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
                {
                    connection.Open();

                    String sql = "SELECT * FROM Task WHERE UserId = ?";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("UserId", logInPage.userID);

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int taskId = Convert.ToInt32(reader["TaskId"]);
                                string taskName = reader["TaskName"].ToString();

                                ToolStripMenuItem taskMenuItem = new ToolStripMenuItem(taskName);
                                taskMenuItem.BackColor = Color.FromArgb(100, 145, 170, 252);

                                // Add the 4 child nodes
                                for (int priority = 1; priority <= 4; priority++)
                                {
                                    ToolStripMenuItem priorityNode = new ToolStripMenuItem(GetPriorityLabel(priority));
                                    priorityNode.Tag = new Tuple<int, int>(taskId, priority); // Store taskId and priority as a tuple
                                    priorityNode.Click += UpdateTaskPriority;

                                    taskMenuItem.DropDownItems.Add(priorityNode);
                                }

                                tasksNode.DropDownItems.Add(taskMenuItem);
                            }
                        }
                    }
                }
            }
        }

        private string GetPriorityLabel(int priority)
        {
            switch (priority)
            {
                case 1: return "Important - Urgent";
                case 2: return "Important - Not Urgent";
                case 3: return "Not Important - Urgent";
                case 4: return "Not Important - Not Urgent";
                default: return "Unknown Priority";
            }
        }

        private void UpdateTaskPriority(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            Tuple<int, int> data = (Tuple<int, int>)menuItem.Tag;

            int taskId = data.Item1;
            int priority = data.Item2;

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                String updateSql = "UPDATE Task SET Priority = @Priority WHERE TaskId = @TaskId";

                using (SQLiteCommand updateCmd = new SQLiteCommand(updateSql, connection))
                {
                    updateCmd.Parameters.AddWithValue("@TaskId", taskId);
                    updateCmd.Parameters.AddWithValue("@Priority", priority);

                    updateCmd.ExecuteNonQuery();
                }
            }

            LoadTasksIntoListViews();
        }

        private void LoadTasksIntoListViews()
        {

            ListView[] priorityBoxes = { PriorityView1, PriorityView2, PriorityView3, PriorityView4 };
            

            foreach (ListView listView in priorityBoxes)
            {
                listView.Items.Clear(); // Clear all items in the ListView
                
            }

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                String sql = "SELECT * FROM Task WHERE UserId = ?";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("UserId", logInPage.userID);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int priority = Convert.ToInt32(reader["Priority"]);

                            // Skip tasks with priority 0
                            if (priority > 0 && priority <= priorityBoxes.Length)
                            {
                                string taskName = reader["TaskName"].ToString();
                                priorityBoxes[priority - 1].Items.Add(taskName);
                            }
                        }
                    }
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

        private void PriorityMatrix_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners(PriorityView1, 10);
            ApplyRoundedCorners(PriorityView2, 10);
            ApplyRoundedCorners(PriorityView4, 10);
            ApplyRoundedCorners(PriorityView3, 10);
        }
    }
}