using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm
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

        public TaskDisplay(String text,String date) 
        {
            InitializeComponent();

            title = text;
            dueDate = date;
 
           // setData();
        }

        public void setData()
        {
            taskName.Text = title;
            dateDisplayBox.Text = dueDate;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //When the task is checked, delete it from the tasks list
        private void taskName_CheckedChanged(object sender, EventArgs e)
        {

            /*using (SQLiteConnection connection  = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                string deleteQuery = "Delete from Task Where TaskID = ?";


            }*/
            if (taskName.Checked)
            {
                taskName.Font = new Font(taskName.Font, FontStyle.Strikeout);
            }
            else
            {
                taskName.Font = new Font(taskName.Font, FontStyle.Regular);
            }
           
        }
    }
}
