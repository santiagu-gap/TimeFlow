﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class UserControlWeekDay : UserControl
    {
        public static string staticDay;
        public UserControlWeekDay()
        {
            InitializeComponent();
        }

        public void days(int dayNumber, bool currDay)
        {
            if (!currDay)
            {
                dayNumberLabel.Text = dayNumber.ToString();
            }
            else if (currDay)
            {
                dayNumberLabel.Text = dayNumber.ToString();
                dayNumberLabel.Font = new Font(dayNumberLabel.Font, FontStyle.Bold);
                dayNumberLabel.ForeColor = Color.White;
                dayNumberLabel.BackColor = Color.FromArgb(145, 170, 252);
                ApplyRoundedCorners(dayNumberLabel, 10);
            }
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

        private void UserControlWeekDay_Load(object sender, EventArgs e)
        {
            ApplyRoundedCorners(this, 20);
            ApplyRoundedCorners(addTaskButton, 10);
        }
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            staticDay = dayNumberLabel.Text;
            Calendar.monthViewBool = false;
            Calendar.weekViewBool = true;
            Calendar.dayViewBool = false;
            AddTaskPopUp popUp = new AddTaskPopUp();
            popUp.Show();
        }
        private void addTaskButton_MouseEnter(object sender, EventArgs e)
        {
            addTaskButton.BackColor = Color.WhiteSmoke;
        }

        private void addTaskButton_MouseLeave(object sender, EventArgs e)
        {
            addTaskButton.BackColor = Color.White;
        }
    }
}
