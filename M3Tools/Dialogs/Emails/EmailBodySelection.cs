using System;
using System.Windows.Forms;
using SPPBC.M3Tools.Types;

namespace SPPBC.M3Tools.Dialogs
{
	/// <summary>
	/// A control for selecting from templates for email body
	/// </summary>
    public partial class EmailBodySelection
    {
        private string Subject
        {
            get
            {
                return TabControl1.SelectedIndex switch
                {
                    var @template when @template == TabControl1.TabPages.IndexOf(tp_Templates) => ts_Templates.TemplateSubject,
                    var @custom when @custom == TabControl1.TabPages.IndexOf(tp_Custom) => CustomEmail1.Subject,
                    _ => null,
                };
            }
        }

        private string Body
        {
            get
            {
				return TabControl1.SelectedIndex switch
				{
					var @template when @template == TabControl1.TabPages.IndexOf(tp_Templates) => ts_Templates.TemplateValue,
					var @custom when @custom == TabControl1.TabPages.IndexOf(tp_Custom) => CustomEmail1.Html,
					_ => null,
				};
			}
        }

        private Types.GTools.EmailType BodyType
        {
            get
            {
				return TabControl1.SelectedIndex switch
				{
					var @template when @template == TabControl1.TabPages.IndexOf(tp_Templates) => Types.GTools.EmailType.HTML,
					var @custom when @custom == TabControl1.TabPages.IndexOf(tp_Custom) => Types.GTools.EmailType.PLAIN,
					_ => default,
				};
			}
        }

		/// <summary>
		/// The content of the email being sent
		/// </summary>
        public Types.GTools.EmailContent Content
        {
            get => new(Subject, Body, BodyType);
        }

		/// <summary>
		/// The tempates to display
		/// </summary>
        public Types.TemplateList Templates
        {
            set => ts_Templates.AddRange(value);
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public EmailBodySelection(TemplateList templates)
        {
            InitializeComponent();
			Templates = templates;
        }


        private void ConfirmSelection(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelSelection(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Reload(object sender, EventArgs e)
        {
            ts_Templates.Reload();
        }
    }
}
