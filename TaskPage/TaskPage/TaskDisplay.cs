using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPage
{
    public partial class TaskDisplay : UserControl
    {
        String sqlConnection = @"DataSource=..\..\..\Database\tasksDB.db;Version=3;";
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

        public void setData()
        {
            taskName.Text = title;
            dateDisplayBox.Text = dueDate;

        }

        private void taskName_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
