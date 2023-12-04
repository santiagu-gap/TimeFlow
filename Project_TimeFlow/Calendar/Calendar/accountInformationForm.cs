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
    public partial class accountInformationForm : Form
    {
        public accountInformationForm()
        {
            InitializeComponent();
        }

        private void accountInformationForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = logInPage.username;
            var passwordLength = logInPage.password.Length;
            for(int i = 0; i < passwordLength; i++)
            {
                passwordLabel.Text += "*";
            }

            ApplyRoundedCorners(masterPanel, 20);
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

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            changePassword a = new changePassword();
            a.Show();
        }
    }
}
