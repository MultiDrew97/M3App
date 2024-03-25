using System;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    public partial class CustomEmail
    {
        private readonly string[] placeholders = new[] { "Subject...", "Email Body..." };
        private struct Shortcuts
        {
            public static string Bold = "Bold";
            public static string Underline = "Underline";
            public static string Italics = "Italics";
        }

        public string Subject
        {
            get
            {
                return txt_Subject.Text;
            }
            set
            {
                txt_Subject.Text = value;
            }
        }

        public string Body
        {
            get
            {
                return txt_Body.Text;
            }
            set
            {
                txt_Body.Text = value;
            }
        }

        public string RichTextBody
        {
            get
            {
                return rtb_Body.Rtf;
            }
        }

        public CustomEmail()
        {
            InitializeComponent();
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            if (fd_Font.ShowDialog() == DialogResult.OK)
            {
                rtb_Body.Font = fd_Font.Font;
                btn_Bold.Checked = fd_Font.Font.Bold;
                btn_Italics.Checked = fd_Font.Font.Italic;
                btn_Underline.Checked = fd_Font.Font.Underline;
            }
        }

        private void BoldText(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction", "Text formatting is still under construction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            int fontStyle = GetCurrentFontStyle();

            if (!rtb_Body.SelectionFont.Bold)
            {
                fontStyle += (int)System.Drawing.FontStyle.Bold;
            }
            else
            {
                fontStyle -= (int)System.Drawing.FontStyle.Bold;
            }

            rtb_Body.SelectionFont = new System.Drawing.Font(rtb_Body.Font, (System.Drawing.FontStyle)fontStyle);
        }

        private void BoldShortcut(object sender, EventArgs e)
        {
            string name = ((ToolStripMenuItem)sender).Name;

            switch (name ?? "")
            {
                case var @case when @case == (Shortcuts.Bold ?? ""):
                    {
                        btn_Bold.Checked = !btn_Bold.Checked;
                        break;
                    }
                case var case1 when case1 == (Shortcuts.Underline ?? ""):
                    {
                        btn_Underline.Checked = !btn_Underline.Checked;
                        break;
                    }
                case var case2 when case2 == (Shortcuts.Italics ?? ""):
                    {
                        btn_Italics.Checked = !btn_Italics.Checked;
                        break;
                    }
            }
        }

        private void UnderlineText(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction", "Text formatting is still under construction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            int fontStyle = GetCurrentFontStyle();

            if (!rtb_Body.SelectionFont.Underline)
            {
                fontStyle += (int)System.Drawing.FontStyle.Underline;
            }
            else
            {
                fontStyle -= (int)System.Drawing.FontStyle.Underline;
            }

            rtb_Body.SelectionFont = new System.Drawing.Font(rtb_Body.Font, (System.Drawing.FontStyle)fontStyle);

        }

        private void ItalicizeText(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction", "Text formatting is still under construction", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            int fontStyle = GetCurrentFontStyle();

            if (!rtb_Body.SelectionFont.Italic)
            {
                fontStyle += (int)System.Drawing.FontStyle.Italic;
            }
            else
            {
                fontStyle -= (int)System.Drawing.FontStyle.Italic;
            }

            rtb_Body.SelectionFont = new System.Drawing.Font(rtb_Body.Font, (System.Drawing.FontStyle)fontStyle);
        }

        private int GetCurrentFontStyle()
        {
            // Dim fontStyle As Integer

            return (rtb_Body.SelectionFont.Bold ? (int)System.Drawing.FontStyle.Bold : 0) + (rtb_Body.SelectionFont.Underline ? (int)System.Drawing.FontStyle.Underline : 0) + (rtb_Body.SelectionFont.Italic ? (int)System.Drawing.FontStyle.Italic : 0);

            // If rtb_Body.SelectionFont.Underline And rtb_Body.SelectionFont.Italic And rtb_Body.SelectionFont.Bold Then
            // fontStyle = Drawing.FontStyle.Italic + Drawing.FontStyle.Underline + Drawing.FontStyle.Bold
            // ElseIf rtb_Body.SelectionFont.Underline And rtb_Body.SelectionFont.Italic Then
            // fontStyle = Drawing.FontStyle.Underline + Drawing.FontStyle.Italic
            // ElseIf rtb_Body.SelectionFont.Underline And rtb_Body.SelectionFont.Bold Then
            // fontStyle = Drawing.FontStyle.Underline + Drawing.FontStyle.Bold
            // ElseIf rtb_Body.SelectionFont.Italic And rtb_Body.SelectionFont.Bold Then
            // fontStyle = Drawing.FontStyle.Italic + Drawing.FontStyle.Bold
            // ElseIf rtb_Body.SelectionFont.Underline Then
            // fontStyle = Drawing.FontStyle.Underline
            // ElseIf rtb_Body.SelectionFont.Italic Then
            // fontStyle = Drawing.FontStyle.Italic
            // ElseIf rtb_Body.SelectionFont.Bold Then
            // fontStyle = Drawing.FontStyle.Bold
            // Else
            // fontStyle = 0
            // End If

            // Return fontStyle
        }

        // Private Sub BodyChanged(sender As Object, e As EventArgs) Handles txt_Body.TextChanged
        // If txt_Body.Text <> "" Or txt_Body.Text = placeholder Then
        // Return
        // End If

        // 'rtb_Body.SelectionFont = New Drawing.Font(rtb_Body.Font, Drawing.FontStyle.Regular)

        // ResetFontButtons()
        // txt_Body.Text = placeholder
        // End Sub

        // Private Sub ResetFontButtons()
        // btn_Bold.Checked = False
        // btn_Italics.Checked = False
        // btn_Underline.Checked = False
        // End Sub

        private void Loading(object sender, EventArgs e)
        {
            rtb_Body.SelectionFont = fd_Font.Font;
            btn_Bold.Checked = fd_Font.Font.Bold;
            btn_Italics.Checked = fd_Font.Font.Italic;
            btn_Underline.Checked = fd_Font.Font.Underline;
            txt_Subject.Text = placeholders[0];
            txt_Body.Text = placeholders[1];
        }

        private void TextGotFocus(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            string value = txtBox.Name == "txt_Subject" ? placeholders[0] : placeholders[1];

            if ((txtBox.Text ?? "") != (value ?? ""))
            {
                return;
            }

            txtBox.Text = "";
            txtBox.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void TextLostFocus(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            string value = txtBox.Name == "txt_Subject" ? placeholders[0] : placeholders[1];

            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                return;
            }

            txtBox.Text = value;
            txtBox.ForeColor = System.Drawing.SystemColors.ControlDark;
        }
    }
}