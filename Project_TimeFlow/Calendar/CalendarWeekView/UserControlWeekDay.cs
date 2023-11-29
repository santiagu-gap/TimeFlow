using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarWeekView
{
    public partial class UserControlWeekDay : UserControl
    {
        public UserControlWeekDay()
        {
            InitializeComponent();
        }

        public void days(int dayNumber)
        {
            dayNumberLabel.Text = dayNumber + "";
        }
    }
}
