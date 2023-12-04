using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calendar
{
    public partial class changePassword : Form
    {
        String sqlConnection = "Data Source=..\\..\\..\\..\\Database\\tasksDB.db;Version=3;";
        public changePassword()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveTaskButton_Click(object sender, EventArgs e)
        {
            var isValid = true;
            var newPass = newPassword.Text;
            var currentInput = currentPassword.Text;

            if (currentInput.Equals(logInPage.password))
            {
                if (!Regex.IsMatch(newPass, "[A-Z]") || newPass.Length < 6 || newPass.Contains(" ") || !Regex.IsMatch(newPass, "[!@#$%^&*(),.?\":{}|<>]"))
                {
                    isValid = false;
                }

                if (isValid)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(sqlConnection))
                    {
                        connection.Open();

                        string sql = "UPDATE User SET password = @NewPassword WHERE userId = @UserId";
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@NewPassword", newPass); // Assuming you have a hash function
                            cmd.Parameters.AddWithValue("@UserId", logInPage.userID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                logInPage.password = newPass;
                            }
                            else
                            {
                                MessageBox.Show("Failed to update password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("New password does not match password requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Current password does not match input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
