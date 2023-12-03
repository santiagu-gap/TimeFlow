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
using System.Text.RegularExpressions;

namespace Calendar
{
    public partial class logInPage : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";
        private static bool isFrench = false;
        usernameRequirements a = new usernameRequirements();
        static string username;
        static string password;
        public static int userID;
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

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            var signUpUsername = signUpUsernameTextBox.Text;
            var signUpPassword = signUpPasswordTextBox.Text;
            bool isValid = true;

            if (!Regex.IsMatch(signUpUsername, @"[^\w\d]") && signUpUsername.Length >= 4 && !signUpUsername.Contains(" "))
            {
                // Username is valid
            }
            else
            {
                isValid = false;
                signUpErrorLabel.Text = "Invalid username.";
            }

            if (!Regex.IsMatch(signUpPassword, "[A-Z]") || signUpPassword.Length < 6 || signUpPassword.Contains(" ") || !Regex.IsMatch(signUpPassword, "[!@#$%^&*(),.?\":{}|<>]"))
            {
                isValid = false;
                signUpErrorLabel.Text = "Invalid password.";
            }

            if (isValid)
            {
                SaveUser(signUpUsername, signUpPassword);
                MessageBox.Show("Account has been created!", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username and/or password. Please make sure to input valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            username = logInUsernameTextBox.Text;
            password = logInPasswordTextBox.Text;
            
            if (VerifyUser(username, password))
            {
                loadForm(new PracticeForm());
            }
            else
            {
                errorLabel.Text = "Invalid username and/or password";
                MessageBox.Show("Invalid username and/or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        public bool VerifyUser(string user, string pswrd)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                string sql = "SELECT UserId FROM User WHERE Username = @Username AND Password = @Password";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", user);
                    cmd.Parameters.AddWithValue("@Password", pswrd);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Store UserId in a static variable
                                userID = reader.GetInt32(reader.GetOrdinal("UserId"));
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }


        private void SaveUser(string user, string pswrd)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
            {
                connection.Open();

                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        String sql = "INSERT INTO User(Username, Password) VALUES (?, ?)";

                        SQLiteCommand cmd = connection.CreateCommand();
                        cmd.CommandText = sql;

                        cmd.Parameters.AddWithValue("Username", user);
                        cmd.Parameters.AddWithValue("Password", pswrd);

                        cmd.ExecuteNonQuery();

                        transaction.Commit(); // Commit the transaction
                    }
                    catch (Exception ex)
                    {
                        // Log the error
                        Console.WriteLine($"Error in SaveUser: {ex.Message}");

                        // Rollback the transaction if an error occurs
                        transaction.Rollback();
                    }
                }
            }
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

        
    }
}
