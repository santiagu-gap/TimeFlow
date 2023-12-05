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
    public partial class homeTaskDisplay : UserControl
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";

        public string title;
        public string dueDate;
        public string taskID;

        public homeTaskDisplay()
        {
            InitializeComponent();
        }

        public homeTaskDisplay(String text, String date)
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

    }
}
