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
    public partial class UserControlWeekDay : UserControl
    {
        public UserControlWeekDay()
        {
            InitializeComponent();
        }

        private void UserControlWeekDay_Load(object sender, EventArgs e)
        {

        }

        public void days(int dayNumber)
        {
            dayNumberLabel.Text = dayNumber + "";
        }
    }
}
