using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTaskForm
{
    public partial class HomeForm : TeamProject.Form2
    {
        public HomeForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // base.getAddButton().BackColor = 
            base.getAddButton().BackColor = Color.DarkGray; // Change the background color
            base.getAddButton().FlatAppearance.MouseDownBackColor = Color.DarkGray; // Change the color when the button is pressed
            base.getAddButton().FlatAppearance.MouseOverBackColor = Color.DarkGray;
        }
    }
}
