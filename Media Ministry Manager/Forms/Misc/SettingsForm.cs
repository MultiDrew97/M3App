using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace M3App
{

    // TODO: Incorporate Gmail and GDrive tools in this page
    public partial class SettingsForm
    {
        private const string currentUser = "Current User: {0}";
        private CancellationTokenSource cts;
        private readonly string bold = "Bolded? {0}";
        private readonly string fontSize = "Font Size: {0}pt";
        private readonly string textFont = "Font: {0}";
        private DialogResult result;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Frm_Settings_Load(object sender, EventArgs e)
        {
            // Load settings from settings file to display to user
            Font = Settings.Default.CurrentFont;
            bw_Settings.RunWorkerAsync("l");
            bw_CheckServices.RunWorkerAsync();
        }

        private void Btn_Default_Click(object sender, EventArgs e)
        {
            bw_Settings.RunWorkerAsync("d");
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            bw_Settings.RunWorkerAsync("s");
        }

        private void Btn_SelectFont_Click(object sender, EventArgs e)
        {
            result = fd_FontSelector.ShowDialog();

            if (result == DialogResult.OK)
            {
                ChangeFont();
            }
            else
            {
                fd_FontSelector.Font = Settings.Default.CurrentFont;
            }
        }

        private void ChangeFont()
        {
            lbl_CurrentFont.Text = string.Format(textFont, fd_FontSelector.Font.Name);
            lbl_FontSize.Text = string.Format(fontSize, fd_FontSelector.Font.Size);
            lbl_Bold.Text = string.Format(bold, Interaction.IIf(fd_FontSelector.Font.Bold, "Yes", "No"));
        }

        private void Bw_Settings_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            switch (Conversions.ToString(e.Argument) ?? "")
            {
                case "l":
                    {
                        // Load the settings of the application
                        Invoke(new Action(() =>
            {
                fd_FontSelector.Font = Settings.Default.CurrentFont;
                ChangeFont();
            }));
                        break;
                    }
                case "s":
                    {
                        // Save the settings that have been changed by the user
                        Settings.Default.CurrentFont = fd_FontSelector.Font;
                        Settings.Default.Save();
                        break;
                    }
                case "d":
                    {
                        // Restore the defaults of the application
                        Settings.Default.CurrentFont = Settings.Default.DefaultFont;
                        Invoke(new Action(() =>
            {
                fd_FontSelector.Font = Settings.Default.CurrentFont;
                ChangeFont();
            }));
                        Settings.Default.Save();
                        break;
                    }
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Helpers.Utils.CloseOpenForms();
        }

        private void Btn_GoogleDrive_Click(object sender, EventArgs e)
        {
            if (btn_GoogleDrive.Text == "Unlink Google Drive")
            {
                try
                {
                    Directory.Delete(Application.StartupPath + @"\Drive Token", true);
                    btn_GoogleDrive.Text = "Link Google Drive";
                    lbl_CurrentDrive.Text = string.Format(currentUser, "Unlinked");
                }
                catch (DirectoryNotFoundException ex)
                {
                }

                catch (UnauthorizedAccessException ex)
                {
                }

                catch (PathTooLongException ex)
                {

                }
            }
            else if (btn_GoogleDrive.Text == "Cancel")
            {
                if (cts is not null)
                {
                    cts.Cancel();
                    bw_Service.CancelAsync();
                    btn_GoogleDrive.Text = "Link Google Drive";
                }
            }
            else if (btn_GoogleDrive.Text == "Link Google Drive")
            {
                btn_GoogleDrive.Text = "Cancel";
                bw_Service.RunWorkerAsync("d");
            }
        }

        private void Btn_Gmail_Click(object sender, EventArgs e)
        {
            if (btn_Gmail.Text == "Unlink Gmail")
            {
                try
                {
                    Directory.Delete(Application.StartupPath + @"\Gmail Token", true);
                    btn_Gmail.Text = "Link Gmail";
                    lbl_CurrentGmail.Text = string.Format(currentUser, "Unlinked");
                }
                catch (DirectoryNotFoundException ex)
                {
                }

                catch (UnauthorizedAccessException ex)
                {
                }

                catch (PathTooLongException ex)
                {

                }
            }
            else if (btn_Gmail.Text == "Cancel")
            {
                if (cts is not null)
                {
                    cts.Cancel();
                    bw_Service.CancelAsync();
                    btn_Gmail.Text = "Link Gmail";
                }
            }
            else if (btn_Gmail.Text == "Link Gmail")
            {
                btn_Gmail.Text = "Cancel";
                bw_Service.RunWorkerAsync("m");
            }
        }

        private void Bw_Service_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            cts = new CancellationTokenSource();
            // Dim service As Service
            switch (Conversions.ToString(e.Argument) ?? "")
            {
                case "d":
                    {
                        try
                        {
                            // service = New DriveUploader(cts.Token)
                            // lbl_CurrentDrive.Text = String.Format(currentUser, CType(service.Info, User).EmailAddress)
                            Invoke(new Action(() => btn_GoogleDrive.Text = "Unlink Google Drive"));
                        }
                        catch (OperationCanceledException ex)
                        {
                            Console.WriteLine("Canceled Exception");
                        }
                        catch (AggregateException ex)
                        {
                            Console.WriteLine("Aggregate Exception");
                        }

                        break;
                    }

                case "m":
                    {
                        try
                        {
                            // service = New Sender(cts.Token)
                            // lbl_CurrentGmail.Text = String.Format(currentUser, CType(service.Info, Profile).EmailAddress)
                            Invoke(new Action(() => btn_Gmail.Text = "Unlink Gmail"));
                        }
                        catch (OperationCanceledException ex)
                        {
                            Console.WriteLine("Canceled Exception");
                        }
                        catch (AggregateException ex)
                        {
                            Console.WriteLine("Aggregate Exception");
                        }

                        break;
                    }
            }
        }

        private void Bw_CheckServices_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Invoke(new Action(() =>
    {
        // Retrieve the Google Drive Info being used by the user
        if (Directory.Exists(Application.StartupPath + @"\Drive Token"))
        {
        }
        // Using uploader As New DriveUploader()
        // Dim user As User = CType(uploader.Info, User)

        // If user IsNot Nothing Then
        // lbl_CurrentDrive.Text = String.Format(currentUser, user.EmailAddress)
        // btn_GoogleDrive.Text = "Unlink Google Drive"
        // Else
        // lbl_CurrentDrive.Text = String.Format(currentUser, "Unlinked")
        // btn_GoogleDrive.Text = "Link Google Drive"
        // End If
        // End Using
        else
        {
            lbl_CurrentDrive.Text = string.Format(currentUser, "Unlinked");
            btn_GoogleDrive.Text = "Link Google Drive";
        }

        // Retrieve the Google Drive Info being used by the user
        if (Directory.Exists(Application.StartupPath + @"\Gmail Token"))
        {
        }
        // Using emailer As New Sender()
        // Dim profile As Profile = CType(emailer.Info, Profile)

        // If profile IsNot Nothing Then
        // lbl_CurrentGmail.Text = String.Format(currentUser, profile.EmailAddress)
        // btn_Gmail.Text = "Unlink Gmail"
        // Else
        // lbl_CurrentGmail.Text = String.Format(currentUser, "Unlinked")
        // btn_Gmail.Text = "Link Gmail"
        // End If
        // End Using
        else
        {
            lbl_CurrentGmail.Text = string.Format(currentUser, "Unlinked");
            btn_Gmail.Text = "Link Gmail";
        }
    }));
        }

        private void Frm_Settings_Closed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name.Equals("MainForm", StringComparison.OrdinalIgnoreCase))
                    {
                        form.Show();
                        break;
                    }
                }
            }
        }
    }
}
