using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Calendar
{
    public partial class TaskDisplay : UserControl
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";

        public string title;
        public string dueDate;
        public string taskID;

        public TaskDisplay()
        {
            InitializeComponent();
        }

        public TaskDisplay(String text, String date)
        {
            InitializeComponent();

            title = text;
            dueDate = date;
        }

        public TaskDisplay(String text, String date, String ID)
        {
            InitializeComponent();

            title = text;
            dueDate = date;
            taskIDLabel.Text = ID;
            //make the label invisible
            taskIDLabel.Visible = false;
        }

        public void setData()
        {
            taskName.Text = title;
            dateDisplayBox.Text = dueDate;

        }

        private void taskName_CheckedChanged(object sender, EventArgs e)
        {
            string idToRemove = taskIDLabel.Text;
           // isRemoved = true;

            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                string deleteQuery = "Delete from Task Where TaskID = ?";

                SQLiteCommand cmd = connection.CreateCommand();
                cmd.CommandText = deleteQuery;

                cmd.Parameters.AddWithValue("TaskID", idToRemove);
                cmd.ExecuteNonQuery();

                connection.Close();
            }

            /*AddTaskControl control = new AddTaskControl();
            control.deleteTask(idToRemove);*/
        }
    }
}
