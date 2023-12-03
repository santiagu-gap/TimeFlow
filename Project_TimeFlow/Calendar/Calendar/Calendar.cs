using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Calendar : Form
    {
        // Creating global vairables to track which month/year were currently on
        int month, year;
        bool monthMode = true;
        bool weekMode = false;
        bool dayMode = false;
        DateTime weekStartDate;
        DateTime currentDate;
        // Static variable to pass to another form
        public static string staticMonth, staticYear;

        public static bool monthViewBool = false;
        public static bool weekViewBool = false;
        public static bool dayViewBool = false;

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            
            // Loading the global variables
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            currentDate = DateTime.Now;

            // Ensuring the week view always starts on the first Sunday of a week
            weekStartDate = DateTime.Now;
            while (weekStartDate.DayOfWeek != DayOfWeek.Sunday)
            {
                weekStartDate = weekStartDate.AddDays(-1);
            }

            // Default calendar view is Month view
            displayMonthDays();
            ApplyRoundedCorners(nextButton, 25);
            ApplyRoundedCorners(previousButton, 25);
            this.WindowState = FormWindowState.Maximized;
        }

        public void displayMonthDays()
        {
            loadLabels();

            daysContainer.Controls.Clear();
            // Creating DateTime object to access functions regarding dates
            DateTime now = DateTime.Now;  

            // Loading displayLabel
            var monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearDisplay.Text = monthName + " " + year;

            staticMonth = monthName;
            staticYear = year.ToString();

            // Retrieving the first days of the apprioriate month when switching amonsgt months
            DateTime startOfMonth = new DateTime(year, month, 1); // The 1 represents the first day

            // Get the count of days of the month (This will load the appropriete amont of days in a month
            int days = DateTime.DaysInMonth(year, month);

            // Converting start of the month to an interger
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            // This for loop will detect the days of the month NOT to load/show on the GUI
            for(int i = 1; i < dayOfTheWeek; i++) 
            {
                UserControlBlankDay blankDay = new UserControlBlankDay();
                daysContainer.Controls.Add(blankDay);

            }

            // Now create a usercontrol for days
            for (int i = 1 ; i <=days; i++) 
            {
                DateTime currentDay = new DateTime(year, month, i);
                //string dateString = currentDay.ToString("MMMM DD YYY");
                UserControlDay day = new UserControlDay();
                bool isCurrentDay = currentDay.Date == DateTime.Today;
                day.days(i, isCurrentDay);
                daysContainer.Controls.Add(day);
            }
        }

        private void displayWeekDays()
        {
            loadLabels();
            // Clear day container before loading new week
            daysContainer.Controls.Clear();

            staticMonth = weekStartDate.ToString("MMMM");
            staticYear = weekStartDate.Year.ToString();

            // Display the week start date
            monthYearDisplay.Text = weekStartDate.ToString("MMMM yyyy");

            // Create user controls for the days of the week
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = weekStartDate.AddDays(i);
                int currDay = currentDay.Day;
                UserControlWeekDay weekDay = new UserControlWeekDay();
                bool isCurrentDay = currentDay.Date == DateTime.Today;
                weekDay.days(currDay, isCurrentDay);
                daysContainer.Controls.Add(weekDay);
            }
        }

        private void displayDayMode()
        {
            clearLabels();
            // Clear day container before loading new week
            daysContainer.Controls.Clear();

            staticMonth = currentDate.ToString("MMMM");
            staticYear = currentDate.Year.ToString();

            // Display the week start date
            monthYearDisplay.Text = currentDate.ToString("MMMM dd yyyy");

            // Create user control for the single day of the week
            DateTime currentDay = currentDate;
            int currDay = currentDay.Day;
            UserControlDayView weekDay = new UserControlDayView();
            bool isCurrentDay = currentDay.Date == DateTime.Today;
            weekDay.days(currDay, isCurrentDay);
            daysContainer.Controls.Add(weekDay);
        }


        private void nextButton_Click(object sender, EventArgs e)
        {

            if (monthMode)
            {
                // Clear day container to load new month properly
                daysContainer.Controls.Clear();

                // Increment month as we click next
                if (month == 12)
                {
                    month = 0;
                    year++;
                }
                month++;

                displayMonthDays();
            }

            else if (weekMode)
            {
                // Move to the next week
                weekStartDate = weekStartDate.AddDays(7);

                // Display the updated week
                displayWeekDays();
            }

            else if (dayMode)
            {
                currentDate = currentDate.AddDays(1);
                displayDayMode();
            }
            
        }

        private void previousButton_Click(object sender, EventArgs e)
        {

            if (monthMode)
            {
                // Clear day container to load new month properly
                daysContainer.Controls.Clear();

                // Decrement month as we click previous
                if (month == 1)
                {
                    month = 13;
                    year--;
                }
                month--;

                displayMonthDays();
            }

            else if (weekMode)
            {
                // Move to the previous week
                weekStartDate = weekStartDate.AddDays(-7);

                // Display the updated week
                displayWeekDays();
            }

            else if (dayMode)
            {
                currentDate = currentDate.AddDays(-1);
                displayDayMode();
            }

        }

        private void dayModeButton_Click(object sender, EventArgs e)
        {
            monthMode = false;
            weekMode = false;
            dayMode = true;
            displayDayMode();
        }

        private void weekModeButton_Click(object sender, EventArgs e)
        {
            dayMode = false;
            monthMode = false;
            weekMode = true;
            displayWeekDays();
        }

        private void monthModeButton_Click(object sender, EventArgs e)
        {
            dayMode = false;
            weekMode = false;
            monthMode = true;
            displayMonthDays();
        }

        private void clearLabels()
        {
            sundayLabel.Text = "";
            mondayLabel.Text = "";
            tuesdayLabel.Text = "";
            wednesdayLabel.Text = "";
            thursdayLabel.Text = "";
            fridayLabel.Text = "";
            saturdayLabel.Text = "";
        }

        private void nextButton_MouseLeave(object sender, EventArgs e)
        {
            nextButton.BackColor = Color.White;
        }

        private void nextButton_MouseEnter(object sender, EventArgs e)
        {
            nextButton.BackColor = Color.LightGray;
        }

        private void previousButton_MouseLeave(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.White;
        }

        private void previousButton_MouseEnter(object sender, EventArgs e)
        {
            previousButton.BackColor = Color.LightGray;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.Show();
        }

        private void loadLabels()
        {
            sundayLabel.Text = "Sunday";
            mondayLabel.Text = "Monday";
            tuesdayLabel.Text = "Tuesday";
            wednesdayLabel.Text = "Wednesday";
            thursdayLabel.Text = "Thursday";
            fridayLabel.Text = "Friday";
            saturdayLabel.Text = "Saturday";
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

    }
}