using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class PracticeForm : Form
    {
        bool sidebarExpand;
        bool calendarSelected = false;
        bool homeSelected = false;
        bool tasksSelected = false;
        public PracticeForm()
        {
            InitializeComponent();
        }

        private void PracticeForm_Load(object sender, EventArgs e)
        {
            //ApplyRoundedCorners(sidebarFlowPanel, 60);
            //sidebarFlowPanel.MaximumSize = new Size(348, int.MaxValue);
            int screenHeight = Screen.FromControl(this).WorkingArea.Height;
            sidebarFlowPanel.Height = screenHeight;
            //containerPanel.Height = screenHeight;
            containerPanel.Size = new Size(Screen.FromControl(this).WorkingArea.Width, Screen.FromControl(this).WorkingArea.Height);

            sidebarFlowPanel.Size = new Size(sidebarFlowPanel.MinimumSize.Width, sidebarFlowPanel.Height);

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
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
            //createInstance(new AddTaskControl());
            //taskButton.BackColor = Color.DarkGray;
            //taskButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            //taskButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            //deleteInstance(new AddTaskControl());

        }

        public void loadForm(object Form)
        {
            
            if (this.formContainer.Controls.Count > 0)
            {
                this.formContainer.Controls.Clear();
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            this.formContainer.Controls.Add(f);
            this.formContainer.Tag = f;
            
            f.Show();
        }

        

        private void mouseEnterEvent(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            // Handle mouse enter events as before
            if (pictureBox != null && homeSelected == false && pictureBox.Equals(homeIcon))
            {
                homeIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("homeHover");
                homeLabel.ForeColor = Color.FromArgb(196,216,255);
            }

            if (pictureBox != null && pictureBox.Equals(menuIcon))
            {
                menuIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("menuHover");
            }

            if (pictureBox != null && tasksSelected == false && pictureBox.Equals(taskIcon))
            {
                taskIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("taskHover");
                tasksLabel.ForeColor = Color.FromArgb(196, 216, 255);
            }

            if (pictureBox != null && calendarSelected == false && pictureBox.Equals(calendarIcon))
            {
                calendarIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("calendarHover");
                calendarLabel.ForeColor = Color.FromArgb(196, 216, 255);
            }
        }


        private void mouseLeaveEvent(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox != null && homeSelected == false && pictureBox.Equals(homeIcon))
            {
                homeIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("homeBlue");
                homeLabel.ForeColor = Color.FromArgb(179, 197, 249);
            }


            if (pictureBox != null && pictureBox.Equals(menuIcon))
            {
                menuIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("menuBlue");
            }


            if (pictureBox != null && tasksSelected == false && pictureBox.Equals(taskIcon))
            {
                taskIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("taskBlue");
                tasksLabel.ForeColor = Color.FromArgb(179, 197, 249);
            }
                

            if (pictureBox != null && calendarSelected == false && pictureBox.Equals(calendarIcon))
            {
                calendarIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("calendarBlue");
                calendarLabel.ForeColor = Color.FromArgb(179, 197, 249);
            }
                

        }

        private void resetIcons()
        {
            homeIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("homeBlue");
            taskIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("taskBlue");
            calendarIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("calendarBlue");
            calendarLabel.ForeColor = Color.FromArgb(179, 197, 249);
            tasksLabel.ForeColor = Color.FromArgb(179, 197, 249);
            homeLabel.ForeColor = Color.FromArgb(179, 197, 249);
        }
        private void calendarButton_Click(object sender, EventArgs e)
        {
            loadForm(new Calendar());
            tasksSelected = false;
            homeSelected = false;
            calendarSelected = true;
            // Change the image directly within the click event
            resetIcons();
            calendarIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("calendarWhite");
            calendarLabel.ForeColor = Color.White;
        }

        private void taskIcon_Click(object sender, EventArgs e)
        {
            tasksSelected = true;
            homeSelected = false;
            calendarSelected = false;

            resetIcons();
            taskIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("taskWhite");
            tasksLabel.ForeColor = Color.White;
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            tasksSelected = false;
            homeSelected = true;
            calendarSelected = false;

            resetIcons();
            homeIcon.Image = (Image)Properties.Resources.ResourceManager.GetObject("homeWhite");
            homeLabel.ForeColor = Color.White;
        }

        private void ApplyRoundedCorners(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            control.Region = new Region(path);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PriorityMatrix matrix = new PriorityMatrix();
            matrix.Show();
        }

        private void NotificationButton_Click(object sender, EventArgs e)
        {
            NotificationsForm notif = new NotificationsForm();
            notif.Show();
        }
    }
}
