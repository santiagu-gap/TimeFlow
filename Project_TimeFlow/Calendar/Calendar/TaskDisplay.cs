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

        public TaskDisplay(String text, String date, string ID)
        {
            InitializeComponent();

            title = text;
            dueDate = date;
            taskID = ID;
        }

        public void setData()
        {
            taskName.Text = title;
            dateDisplayBox.Text = dueDate;
        }


        private void taskName_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            List<int> selectedTasks = TaskPage.selectedTasks;

            if (checkBox != null)
            {
                int taskId;

                // Assuming the Tag property of each checkbox contains the associated task ID
                if (int.TryParse(taskID, out taskId))
                {
                    if (checkBox.Checked)
                    {
                        // Add task ID to the list when the checkbox is checked
                        if (!selectedTasks.Contains(taskId))
                        {
                            selectedTasks.Add(taskId);
                        }
                    }
                    else
                    {
                        // Remove task ID from the list when the checkbox is unchecked
                        selectedTasks.Remove(taskId);
                    }

                    // Print the selected task IDs (you can modify this part based on your needs)
                    Console.WriteLine("Selected Task IDs: " + string.Join(", ", selectedTasks));
                }
            }
        }
    }
}
