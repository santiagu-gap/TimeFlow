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
            if (Calendar.monthViewBool)
            {
                dateBox.Text = Calendar.staticMonth + "/" + UserControlDay.staticDay + "/" + Calendar.staticYear;
            }

            if (Calendar.weekViewBool)
            {
                dateBox.Text = Calendar.staticMonth + "/" + UserControlWeekDay.staticDay + "/" + Calendar.staticYear;
            }

            if (Calendar.dayViewBool)
            {
                dateBox.Text = Calendar.staticMonth + "/" + UserControlDayView.staticDay + "/" + Calendar.staticYear;
            }

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                String sql = "SELECT * FROM Task WHERE TaskName = ? AND TaskDate = ?";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    if (Calendar.monthViewBool)
                    {
                        cmd.Parameters.AddWithValue("TaskName",UserControlDay.taskSelected);
                    }

                    if (Calendar.weekViewBool)
                    {
                        cmd.Parameters.AddWithValue("TaskName", UserControlWeekDay.taskSelected);
                    }

                    if (Calendar.dayViewBool)
                    {
                        cmd.Parameters.AddWithValue("TaskName", UserControlDayView.taskSelected);
                    }

                    cmd.Parameters.AddWithValue("TaskDate", dateBox.Text);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                taskDescriptionTextBox.Text = reader["TaskDescription"].ToString();
                                taskSubject.Text = reader["TaskName"].ToString();
                            }
                             
                        }
                    }
                }
            }
            ApplyRoundedCorners(this, 20);
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
