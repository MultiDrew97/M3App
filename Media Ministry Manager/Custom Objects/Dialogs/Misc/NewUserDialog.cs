using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using SPPBC.M3Tools.Exceptions;

namespace M3App
{

    public partial class NewUserDialog
    {

        public string Password
        {
            get
            {
                return txt_Password.Text;
            }
            set
            {
                txt_Password.Text = value;
            }
        }

        protected string Confirm
        {
            get
            {
                return txt_ConfirmPassword.Text;
            }
            set
            {
                txt_ConfirmPassword.Text = value;
            }
        }

        public NewUserDialog()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PasswordCheck())
                {
                    throw new PasswordMismatchException(); // $"Password: {Password}{vbNewLine}Confirm{Confirm}")
                }
            }

            // If AdminInfoDialog.ShowDialog = DialogResult.OK Then

            // _connection.UserID = AdminInfoDialog.Username
            // _connection.Password = AdminInfoDialog.Password

            // Using db As New Database(_connection)
            // 'TODO: Reimplement later after learning how to assign roles
            // 'db.CreateUser(txt_Username.Text, txt_Password.Text)
            // End Using

            // AdminInfoDialog.Clear()

            // DialogResult = DialogResult.OK
            // Me.Close()
            // End If
            catch (SqlException exception)
            {
                Console.WriteLine("Could not create user: " + exception.Message);
            }
            catch (PasswordMismatchException passException)
            {
                tss_UserFeedback.Text = "Passwords did not match try again";
                tss_UserFeedback.ForeColor = Color.Red;
                Console.WriteLine("Passwords didn't match: " + passException.Message);
            }
        }

        private bool PasswordCheck()
        {
            return txt_Password.Text.Equals(txt_ConfirmPassword.Text);
        }

    }
}