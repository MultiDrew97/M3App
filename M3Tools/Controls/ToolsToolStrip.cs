using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SPPBC.M3Tools
{

    [DefaultEvent("FilterChanged")]
    public partial class ToolsToolStrip : ToolStrip
    {
        public event EventHandler Import;
        public event EventHandler Add;
        public event EventHandler Email;
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

        private void ImportEntries(object sender, EventArgs e)
        {
            Import?.Invoke(sender, e);
        }

        private void AddEntry(object sender, EventArgs e)
        {
            Add?.Invoke(sender, e);
        }

        private void SendEmails(object sender, EventArgs e)
        {
            Email?.Invoke(sender, e);
        }

        private void FilterUpdated(object sender, EventArgs e)
        {
            FilterChanged?.Invoke(sender, Filter);
        }

        private void ToolsToolStrip_LayoutCompleted(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ListType))
            {
                return;
            }

            tsb_New.ToolTipText = string.Format(tsb_New.ToolTipText, ListType);
            tsb_Import.ToolTipText = string.Format(tsb_Import.ToolTipText, ListType);
            tst_Filter.ToolTipText = string.Format(tst_Filter.ToolTipText, ListType);
        }
    }
}