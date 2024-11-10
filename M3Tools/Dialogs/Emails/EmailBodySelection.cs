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
				return tc_EmailType.SelectedIndex switch
				{
					var @template when @template == tc_EmailType.TabPages.IndexOf(tp_Templates) => ts_Template.TemplateSubject,
					var @custom when @custom == tc_EmailType.TabPages.IndexOf(tp_Custom) => ce_Custom.Subject,
					_ => null,
				};
			}
		}

		private string Body
		{
			get
			{
				return tc_EmailType.SelectedIndex switch
				{
					var @template when @template == tc_EmailType.TabPages.IndexOf(tp_Templates) => ts_Template.TemplateValue,
					var @custom when @custom == tc_EmailType.TabPages.IndexOf(tp_Custom) => ce_Custom.Body,
					_ => null,
				};
			}
		}

		/// <summary>
		/// The content of the email being sent
		/// </summary>
		public Types.GTools.EmailContent Content => new(Subject, Body);

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public EmailBodySelection(TemplateList templates)
		{
			InitializeComponent();
			ts_Template.AddRange(templates);

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

		private void Reload(object sender, EventArgs e) => ts_Template.Reload();
	}
}
