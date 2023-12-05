using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlMonthViewTaskOutput : UserControl
    {
        public static string day;
        public UserControlMonthViewTaskOutput()
        {
            InitializeComponent();
        }

        private void UserControlMonthViewTaskOutput_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TaskPreviewWindow taskPreviewWindow = new TaskPreviewWindow();   

            taskPreviewWindow.Show();
        }
    }
}
