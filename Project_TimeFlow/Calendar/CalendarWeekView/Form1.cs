using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarWeekView
{
    public partial class Form1 : Form
    {
        int month, year, week;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            // Creating DateTime object to access functions regarding dates
            DateTime now = DateTime.Now;

            // Loading the global variables
            month = now.Month;
            year = now.Year;

            // Loading displayLabel
            var monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearDisplay.Text = monthName + " " + year;

            // Retrieving the first days of the apprioriate month when switching amonsgt months
            DateTime startOfMonth = new DateTime(year, month, 1); // The 1 represents the first day

            // Get the count of days of the month (This will load the appropriete amont of days in a month
            int days = DateTime.DaysInMonth(year, month);

            // Converting start of the month to an interger
            int dayOfTheWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d")) + 1;

            // Create usercontrol for a blank day entity (This means a day that will not show in the GUI) - We called "UserControlBlankDay"

            // This for loop will detect the days of the month NOT to load/show on the GUI
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlWeekBlankDay blankDay = new UserControlWeekBlankDay();
                daysContainer.Controls.Add(blankDay);

            }

            // Now create a usercontrol for days
            
            for (int i = 1; i <= days; i++)
            {
                UserControlWeekDay day = new UserControlWeekDay();
                day.days(i);
                daysContainer.Controls.Add(day);
            }
            
        }
    }
}
