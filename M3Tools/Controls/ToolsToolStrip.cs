using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

	public enum ToolButtons
	{
		ADD,
		IMPORT,
		EMAIL,
		FILTER,
		COUNT
	}

    [DefaultEvent("FilterChanged")]
    public partial class ToolsToolStrip : ToolStrip
    {
        public event EventHandler ImportEntries;
        public event EventHandler AddEntry;
        public event EventHandler SendEmails;
        public event EventHandler<string> FilterChanged;

        public string Count
        {
            set
            {
                tsl_Count.Text = value;
            }
        }

        [DefaultValue("")]
        public string ListType { get; set; }

        private string Filter
        {
            get
            {
                return tst_Filter.Text;
            }
            set
            {
                tst_Filter.Text = value;
            }
        }

        private void Import(object sender, EventArgs e)
        {
            ImportEntries?.Invoke(sender, e);
        }

        private void Add(object sender, EventArgs e)
        {
            AddEntry?.Invoke(sender, e);
        }

        private void Emails(object sender, EventArgs e)
        {
            SendEmails?.Invoke(sender, e);
        }

        private void Filtered(object sender, EventArgs e)
        {
            FilterChanged?.Invoke(sender, Filter);
        }

        private void UpdateLabelText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ListType))
            {
                return;
            }

            tsb_New.ToolTipText = string.Format(tsb_New.ToolTipText, ListType);
            tsb_Import.ToolTipText = string.Format(tsb_Import.ToolTipText, ListType);
            tst_Filter.ToolTipText = string.Format(tst_Filter.ToolTipText, ListType);
        }

		/// <summary>
		/// Toggle any of the buttons in the strip to not be visible by name
		/// </summary>
		/// <param name="button">The button to toggle visibility on</param>
		/// <exception cref="ArgumentNullException"></exception>
		/// <exception cref="ArgumentException"></exception>
		public void ToggleButton(ToolButtons button)
		{
			switch (button)
			{
				case ToolButtons.EMAIL:
					tsb_Emails.Available = !tsb_Emails.Available;
					break;
				case ToolButtons.ADD:
					tsb_New.Available = !tsb_New.Available;
					break;
				case ToolButtons.IMPORT:								   
					tsb_Import.Available = !tsb_Import.Available;		   
					break;												   
				case ToolButtons.FILTER:								   
					tst_Filter.Available = !tst_Filter.Available;		   
					// TODO: Also hide last seperator when hiding this one;
					break;
				case ToolButtons.COUNT:
					tsl_Count.Available = !tsl_Count.Available;
					// TODO: Also hide last seperator when hiding this one;
					break;
				default:
					throw new ArgumentException($"Name '${button}' not known");
			}
		}
	}
}
