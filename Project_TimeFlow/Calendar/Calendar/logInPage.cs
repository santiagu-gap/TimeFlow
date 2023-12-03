using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Calendar
{
    public partial class logInPage : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";
        private static bool isFrench = false;
        usernameRequirements a = new usernameRequirements();
        public logInPage()
        {
            InitializeComponent();
            ApplyRoundedCorners(logInButton, 25);
            ApplyRoundedCorners(createAccountButton, 25);
            ApplyRoundedCorners(logInUsernameTextBox, 5);
            ApplyRoundedCorners(logInPasswordTextBox, 5);
            ApplyRoundedCorners(signUpUsernameTextBox, 5);
            ApplyRoundedCorners(signUpPasswordTextBox, 5);
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
        public void loadForm(object Form)
        {

            if (this.masterPanel.Controls.Count > 0)
            {
                this.masterPanel.Controls.Clear();
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            this.masterPanel.Controls.Add(f);
            this.masterPanel.Tag = f;

            f.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            loadForm(new PracticeForm());
        }
        

        private void languageButton_Click(object sender, EventArgs e)
        {
            if (languageButton.Text == "English")
            {
                welcomeBackLabel.Text = "Welcome Back!";
                logInButton.Text = "Log In";
                signUpLabel.Text = "Not Signed Up?";
                createAccountButton.Text = "Create Account";
                languageButton.Text = "Français";
            }

            else if (languageButton.Text == "Français")
            {
                welcomeBackLabel.Text = "Bienvenue!";
                logInButton.Text = "Se connecter";
                signUpLabel.Text = "Pas Encore Inscrit?";
                createAccountButton.Text = "Créer un compte";
                languageButton.Text = "English";
            }
            
        }

        private void saveUser_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        String sql = "INSERT INTO Task(TaskName, TaskDescription, TaskDate) VALUES (?, ?, ?)";

                        SQLiteCommand cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.AddWithValue("TaskName", taskSubject.Text);
                        cmd.Parameters.AddWithValue("TaskDescription", taskDescription.Text);
                        cmd.Parameters.AddWithValue("TaskDate", selectedDate.Text);

                        cmd.ExecuteNonQuery();


                        string taskName = taskSubject.Text;
                        UserControlDay uc = new UserControlDay();

                        uc.UpdateTaskLabel(taskName);


                        transaction.Commit(); // Commit the transaction
                        MessageBox.Show("Saved!");


                        //label1.Text = UserControlDay.lastAccessedDay.ToString();


                        //UserControlDay day = new UserControlDay(UserControlDay.lastAccessedDay);
                        //day.Refresh();

                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions appropriately
                        MessageBox.Show($"Error: {ex.Message}");
                        transaction.Rollback(); // Rollback the transaction if an error occurs
                    }
                }
            }

        }

    }
}
