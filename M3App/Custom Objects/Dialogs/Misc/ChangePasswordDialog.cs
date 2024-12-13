using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Exceptions;

namespace M3App
{

    public partial class ChangePasswordDialog
    {
        public ChangePasswordDialog()
        {
            InitializeComponent();
        }
        private void UpdatePassword(object sender, EventArgs e)
        {
            try
            {
                if (!PasswordCheck())
                {
                    throw new FormatException($@"Password: {txt_Password.Text} \n Confirm: {txt_ConfirmPassword.Text}");
                }
            }


            // If AdminInfoDialog.ShowDialog = DialogResult.OK Then
            // _connection.UserID = AdminInfoDialog.Username
            // _connection.Password = AdminInfoDialog.Password

            // Using db As New Database(_connection)
            // db.ChangePassword(txt_Username.Text, txt_Password.Text)
            // End Using

            // AdminInfoDialog.Clear()

            // DialogResult = DialogResult.OK
            // Me.Close()
            // End If
            catch (SqlException ex)
            {
                Console.WriteLine("Failed to update user password: " + ex.Message);
            }
            catch (PasswordMismatchException passEx)
            {
                tss_UserFeedback.Text = "Passwords did not match try again";
                tss_UserFeedback.ForeColor = Color.Red;
                Console.WriteLine("Passwords did not match: " + passEx.Message);
            }
        }

        private bool PasswordCheck()
        {
            return txt_Password.Text.Equals(txt_ConfirmPassword.Text);
        }

        private void CancelPasswordChange(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ChangePasswordLoaded(object sender, EventArgs e)
        {

        }
    }
}