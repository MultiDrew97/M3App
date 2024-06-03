using System;
using System.Windows.Forms;

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
                switch (TabControl1.SelectedIndex)
                {
                    case var @case  when @case == TabControl1.TabPages.IndexOf(tp_Templates):
                        {
                            return ts_Templates.TemplateSubject;
                        }
                    case var case1 when case1 == TabControl1.TabPages.IndexOf(tp_Custom):
                        {
                            return CustomEmail1.Subject;
                        }

                    default:
                        {
                            return null;
                        }
                }
            }
        }

        private string Body
        {
            get
            {
                switch (TabControl1.SelectedIndex)
                {
                    case var @case when @case == TabControl1.TabPages.IndexOf(tp_Templates):
                        {
                            return ts_Templates.TemplateValue;
                        }
					case var case1 when case1 == TabControl1.TabPages.IndexOf(tp_Custom):
                        {
                            return CustomEmail1.Body;
                        }

                    default:
                        {
                            return null;
                        }
                }
            }
        }

        private Types.GTools.EmailType BodyType
        {
            get
            {
                switch (TabControl1.SelectedIndex)
                {
                    case var @case when @case == TabControl1.TabPages.IndexOf(tp_Templates):
                        {
                            return Types.GTools.EmailType.HTML;
                        }
                    case var case1 when case1 == TabControl1.TabPages.IndexOf(tp_Custom):
                        {
                            return Types.GTools.EmailType.PLAIN;
                        }

                    default:
                        {
                            return default;
                        }
                }
            }
        }

		/// <summary>
		/// The content of the email being sent
		/// </summary>
        public Types.GTools.EmailContent Content
        {
            get
            {
                return new Types.GTools.EmailContent(Subject, Body, BodyType);
            }
        }

		/// <summary>
		/// The tempates to display
		/// </summary>
        public Types.TemplateList Templates
        {
            set
            {
                ts_Templates.AddRange(value);
            }
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public EmailBodySelection()
        {
            InitializeComponent();
        }


        private void FinishDialog(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelDialog(object sender, EventArgs e)
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
