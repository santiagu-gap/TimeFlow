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
    public partial class Form1 : Form
    {
        bool sidebarExpand;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //sidebarFlowPanel.MaximumSize = new Size(348, int.MaxValue);
            int screenHeight = Screen.FromControl(this).WorkingArea.Height;
            sidebarFlowPanel.Height = screenHeight;
            //containerPanel.Height = screenHeight;
            containerPanel.Size = new Size(Screen.FromControl(this).WorkingArea.Width, Screen.FromControl(this).WorkingArea.Height);

            sidebarFlowPanel.Size = new Size(sidebarFlowPanel.MinimumSize.Width, sidebarFlowPanel.Height);

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebarFlowPanel.Width -= 10;

                if (sidebarFlowPanel.Width == sidebarFlowPanel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarFlowPanel.Width += 10;
                if (sidebarFlowPanel.Width == sidebarFlowPanel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        public void createInstance(UserControl module)
        {
            Form parentForm = this.FindForm();
            //var controls = containerPanel.Controls.OfType<UserControl>().ToList();
            foreach (Control control in parentForm.Controls.OfType<UserControl>().ToList())
            {
                control.Dispose();
            }
            parentForm.Controls.Add(module);
            module.Dock = DockStyle.Fill;

        }

        public void deleteInstance(UserControl module)
        {
            Form parentForm = this.FindForm();

            parentForm.Controls.Remove(module);
        }

        private void iconPictureBox_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

        }

        private void taskButton_Click(object sender, EventArgs e)
        {
            createInstance(new AddTaskControl());
            taskButton.BackColor = Color.DarkGray;
            taskButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            taskButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            deleteInstance(new AddTaskControl());

        }
    }
}
