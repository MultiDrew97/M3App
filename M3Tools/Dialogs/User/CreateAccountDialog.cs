using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SPPBC.M3Tools.Exceptions;

namespace SPPBC.M3Tools.Dialogs
{
    public partial class CreateAccountDialog
    {

        private readonly Regex __passwordPattern = new Regex(My.Resources.Resources.PasswordRegex);
        private readonly string __usernameEmptyError = "A username is required";
        private readonly string __passwordPatternError = @"Password must contain:\n At least 1 capital letter\n At least 1 lowercase letter\n At least 1 number\n at least 1 special character";
        private readonly string __passwordMisMatchError = "Passwords must match to proceed";

        public CreateAccountDialog()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            CheckValues();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CheckValues()
        {
            try
            {
                if (ValidUsername() & ValidPassword() & PasswordMatch())
                {
                    TryCreateAccount();
                }
            }
            catch (PasswordMismatchException ex)
            {
                cpf_Confirm.Clear();
                cpf_Confirm.Focus();
            }
            catch (PasswordException ex)
            {
                pf_Password.Clear();
                pf_Password.Focus();
            }
            catch (CreationException ex)
            {
                uf_Username.Focus();
            }
        }

        private bool ValidUsername()
        {
            return !string.IsNullOrWhiteSpace(uf_Username.Username);
        }

        private bool ValidPassword()
        {
            if (!__passwordPattern.IsMatch(pf_Password.Password))
            {
                // Throw New PasswordException("Invalid Password")
                return false;
            }

            return true;
        }

        private bool PasswordMatch()
        {
            if (!pf_Password.Password.Equals(cpf_Confirm.Text))
            {
                // Throw New PasswordMisMatchException("Password Mismatch")
                return false;
            }

            return true;
        }

        private void TryCreateAccount()
        {
            try
            {
            }
            // db_Users.CreateUser(uf_Username.Username, pf_Password.Password)
            catch (CreationException ex)
            {
                throw new CreationException("Creation Failed", ex);
            }
        }

        private void Uf_Username_UsernameLostFocus(object sender, EventArgs e)
        {
            if (!ValidUsername())
            {
                ep_FieldError.SetError(uf_Username, __usernameEmptyError);
            }
            else
            {
                ep_FieldError.SetError(uf_Username, "");
            }
        }

        private void Pf_Password_PasswordLostFocus(object sender, EventArgs e)
        {
            if (!ValidPassword())
            {
                ep_FieldError.SetError(pf_Password, __passwordPatternError);
            }
            else
            {
                ep_FieldError.SetError(pf_Password, "");
            }
        }

        private void Cpf_Confirm_ConfirmLostFocus(object sender, EventArgs e)
        {
            if (!PasswordMatch())
            {
                ep_FieldError.SetError(cpf_Confirm, __passwordMisMatchError);
            }
            else
            {
                ep_FieldError.SetError(cpf_Confirm, "");
            }
        }

        private void Uf_Username_TextChanged(object sender, EventArgs e)
        {
            if (!ValidUsername())
            {
                ep_FieldError.SetError(uf_Username, __usernameEmptyError);
            }
            else
            {
                ep_FieldError.SetError(uf_Username, "");
            }
        }

        private void Pf_Password_PasswordTextChanged(object sender, EventArgs e)
        {
            if (!ValidPassword())
            {
                ep_FieldError.SetError(pf_Password, __passwordPatternError);
            }
            else
            {
                ep_FieldError.SetError(pf_Password, "");
            }
        }

        private void Cpf_Confirm_ConfirmTextChanged(object sender, EventArgs e)
        {
            if (!PasswordMatch())
            {
                ep_FieldError.SetError(cpf_Confirm, __passwordMisMatchError);
            }
            else
            {
                ep_FieldError.SetError(cpf_Confirm, "");
            }
        }
    }
}