using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForm;

namespace BaseForm
{
    public partial class BaseModel : UserControl
    {
        bool sidebarExpand;
        
        public BaseModel()
        {
            InitializeComponent();
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

        private void iconPictureBox_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void BaseModel_Load(object sender, EventArgs e)
        {
            //make sure that the user control matches the form size
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //make sure that the height goes all the way down
            int screenHeight = Screen.FromControl(this).WorkingArea.Height;
            sidebarFlowPanel.MaximumSize = new Size(sidebarFlowPanel.MaximumSize.Width, screenHeight);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            deleteInstance(new AddTaskControl());
            createInstance(new BaseModel());

        }
 
        private void taskButton_Click(object sender, EventArgs e)
        {
            //make it open the addtaskUsercontrol
            //deleteInstance(new BaseModel());
            createInstance(new AddTaskControl());
            taskButton.BackColor = Color.DarkGray;
            taskButton.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            taskButton.FlatAppearance.MouseOverBackColor = Color.DarkGray;


        }

        public Button getAddButton()
        {
            return taskButton;
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
    }
}
