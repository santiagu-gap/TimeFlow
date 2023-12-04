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
    public partial class BaseForm : Form
    {
        bool sidebarExpand;
        public BaseForm()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void menuLabel_Click(object sender, EventArgs e)
        {

        }

        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            //Set minimum & maximum size

            //if the sidebar is already expanded and the user clicks,
            //then it decreases meaning that the side bar will be minimized.
                if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
                else
            {   //if the user clicks the icon and the sidebar is false
                //(at minimum size) then increase to expand the sidebar.
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void menuIcon_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {

        }
    }
}
