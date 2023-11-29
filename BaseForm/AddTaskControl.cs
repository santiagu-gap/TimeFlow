using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseForm
{
    public partial class AddTaskControl : UserControl
    {
        public AddTaskControl()
        {
            InitializeComponent();
        }
        DataTable toDoList = new DataTable();
        bool IsEditing = false;
        private void AddTaskControl_Load(object sender, EventArgs e)
        {
            //Create columns 
            toDoList.Columns.Add("Title");
            toDoList.Columns.Add("Description");

            //Point our datagridview to our datasource
            toDoListView.DataSource = toDoList;

        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            //if currently editing, the data already exits so just update
            if (IsEditing)
            {
                toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = taskTitleTextbox.Text;
                toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = taskDescriptionTextBox.Text;
            }
            else
            {
                toDoList.Rows.Add(taskTitleTextbox.Text, taskDescriptionTextBox.Text);
            }

            //after saved, clear textboxes
            taskTitleTextbox.Text = "";
            taskDescriptionTextBox.Text = "";
        }

        private void editTaskButton_Click(object sender, EventArgs e)
        {
            //check if the task is currently being editing
            IsEditing = true;

            //Fill text fields with data from table

            //get the current row clicked by the user and put it in the text fields
            taskTitleTextbox.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            taskDescriptionTextBox.Text = toDoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                toDoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
