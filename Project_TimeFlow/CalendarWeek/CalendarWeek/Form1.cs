using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarWeek
{
    public partial class Form1 : Form
    {
        // Creating global variables to track the current week's start date
        DateTime weekStartDate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the week start date to the current date
            weekStartDate = DateTime.Now;

            // Display the initial week
            displayDays();
        }

        private void displayDays()
        {
            // Clear day container before loading new week
            daysContainer.Controls.Clear();

            // Display the week start date
            monthYearDisplay.Text = weekStartDate.ToString("MMMM yyyy");

            // Create user controls for the days of the week
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = weekStartDate.AddDays(i);
                int currDay = currentDay.Day;
                UserControlWeekDay weekDay = new UserControlWeekDay();
                weekDay.days(currDay);
                daysContainer.Controls.Add(weekDay);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // Move to the next week
            weekStartDate = weekStartDate.AddDays(7);

            // Display the updated week
            displayDays();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            // Move to the previous week
            weekStartDate = weekStartDate.AddDays(-7);

            // Display the updated week
            displayDays();
        }
    }
}
