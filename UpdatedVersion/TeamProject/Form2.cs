using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class Form2 : Form
    {
        bool sidebarExpand;
        public Form2()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
           /*HomeForm addTask = new HomeForm();
            addTask.Show();*/
            //this.Close();
            
        }

        public Button getAddButton ()
        {
            return addTaskButton;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarFlowPanel.Width -= 10;

                if(sidebarFlowPanel.Width == sidebarFlowPanel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarFlowPanel.Width += 10;
                if(sidebarFlowPanel.Width == sidebarFlowPanel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuIconPicture_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int screenHeight = Screen.FromControl(this).WorkingArea.Height;
            sidebarFlowPanel.Size  = new Size(sidebarFlowPanel.Width, screenHeight);

        }
    }
}
