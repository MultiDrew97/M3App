using System;
using System.Drawing;
using System.Windows.Forms;

namespace MediaMinistry
{
    public partial class ReceiptTypeDialog
    {
        public enum ReceiptType
        {
            Tithes,
            Love,
            Offering,
            Other
        }

        public double Amount
        {
            get
            {
                return (double)nud_Amount.Value;
            }
        }

        public ReceiptType ReceiptOption { get; set; }

        public string OtherOption
        {
            get
            {
                return txt_Other.Text;
            }
        }

        public ReceiptTypeDialog()
        {
            InitializeComponent();
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (rdo_Other.Checked && string.IsNullOrWhiteSpace(txt_Other.Text))
            {
                MessageBox.Show("You must enter something that says what this receipt is for. Please enter a value or select a preset type.", "Select Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Rdo_Other_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Other.Checked)
            {
                Size = new Size(440, 419);
            }
            else
            {
                Size = new Size(440, 368);
            }

            ReceiptOption = ReceiptType.Other;
            lbl_Other.Visible = rdo_Other.Checked;
            txt_Other.Visible = rdo_Other.Checked;
        }

        private void TithesCheckedChanged(object sender, EventArgs e)
        {
            ReceiptOption = ReceiptType.Tithes;
        }

        private void LoveOfferingCheckedChanged(object sender, EventArgs e)
        {
            ReceiptOption = ReceiptType.Love;
        }

        private void OfferingCheckedChanged(object sender, EventArgs e)
        {
            ReceiptOption = ReceiptType.Offering;
        }
    }
}