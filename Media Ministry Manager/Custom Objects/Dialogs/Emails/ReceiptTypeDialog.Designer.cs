using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace M3App
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ReceiptTypeDialog : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            btn_Ok = new Button();
            btn_Ok.Click += new EventHandler(Btn_Ok_Click);
            btn_Cancel = new Button();
            btn_Cancel.Click += new EventHandler(Btn_Cancel_Click);
            txt_Other = new TextBox();
            lbl_Other = new Label();
            gbx_RecieptOptions = new GroupBox();
            rdo_Tithes = new RadioButton();
            rdo_Tithes.CheckedChanged += new EventHandler(TithesCheckedChanged);
            rdo_Other = new RadioButton();
            rdo_Other.CheckedChanged += new EventHandler(Rdo_Other_CheckedChanged);
            rdo_LoveOffering = new RadioButton();
            rdo_LoveOffering.CheckedChanged += new EventHandler(LoveOfferingCheckedChanged);
            rdo_Offering = new RadioButton();
            rdo_Offering.CheckedChanged += new EventHandler(OfferingCheckedChanged);
            nud_Amount = new NumericUpDown();
            lbl_Amount = new Label();
            gbx_RecieptOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Amount).BeginInit();
            SuspendLayout();
            // 
            // btn_Ok
            // 
            btn_Ok.Anchor = AnchorStyles.Bottom;
            btn_Ok.AutoSize = true;
            btn_Ok.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Ok.DataBindings.Add(new Binding("Font", global::M3App.Settings.Default, "CurrentFont", true, DataSourceUpdateMode.OnPropertyChanged));
            btn_Ok.Font = global::M3App.Settings.Default.CurrentFont;
            btn_Ok.Location = new Point(239, 266);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(51, 35);
            btn_Ok.TabIndex = 0;
            btn_Ok.Text = "Ok";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = AnchorStyles.Bottom;
            btn_Cancel.AutoSize = true;
            btn_Cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Cancel.DataBindings.Add(new Binding("Font", global::M3App.Settings.Default, "CurrentFont", true, DataSourceUpdateMode.OnPropertyChanged));
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Cancel.Font = global::M3App.Settings.Default.CurrentFont;
            btn_Cancel.Location = new Point(111, 266);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(95, 35);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "Cancel";
            // 
            // txt_Other
            // 
            txt_Other.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Other.DataBindings.Add(new Binding("Font", global::M3App.Settings.Default, "CurrentFont", true, DataSourceUpdateMode.OnPropertyChanged));
            txt_Other.Font = global::M3App.Settings.Default.CurrentFont;
            txt_Other.Location = new Point(61, 257);
            txt_Other.Name = "txt_Other";
            txt_Other.Size = new Size(310, 31);
            txt_Other.TabIndex = 1;
            txt_Other.Visible = false;
            // 
            // lbl_Other
            // 
            lbl_Other.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_Other.AutoSize = true;
            lbl_Other.DataBindings.Add(new Binding("Font", global::M3App.Settings.Default, "CurrentFont", true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_Other.Font = global::M3App.Settings.Default.CurrentFont;
            lbl_Other.Location = new Point(56, 229);
            lbl_Other.Name = "lbl_Other";
            lbl_Other.Size = new Size(70, 25);
            lbl_Other.TabIndex = 2;
            lbl_Other.Text = "Other";
            lbl_Other.Visible = false;
            // 
            // gbx_RecieptOptions
            // 
            gbx_RecieptOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbx_RecieptOptions.Controls.Add(rdo_Tithes);
            gbx_RecieptOptions.Controls.Add(rdo_Other);
            gbx_RecieptOptions.Controls.Add(rdo_LoveOffering);
            gbx_RecieptOptions.Controls.Add(rdo_Offering);
            gbx_RecieptOptions.DataBindings.Add(new Binding("Font", global::M3App.Settings.Default, "CurrentFont", true, DataSourceUpdateMode.OnPropertyChanged));
            gbx_RecieptOptions.Font = global::M3App.Settings.Default.CurrentFont;
            gbx_RecieptOptions.Location = new Point(70, 12);
            gbx_RecieptOptions.Name = "gbx_RecieptOptions";
            gbx_RecieptOptions.Size = new Size(301, 164);
            gbx_RecieptOptions.TabIndex = 28;
            gbx_RecieptOptions.TabStop = false;
            gbx_RecieptOptions.Text = "Type";
            // 
            // rdo_Tithes
            // 
            rdo_Tithes.AutoSize = true;
            rdo_Tithes.Checked = true;
            rdo_Tithes.Location = new Point(69, 19);
            rdo_Tithes.Name = "rdo_Tithes";
            rdo_Tithes.Size = new Size(95, 29);
            rdo_Tithes.TabIndex = 0;
            rdo_Tithes.TabStop = true;
            rdo_Tithes.Text = "Tithes";
            rdo_Tithes.UseVisualStyleBackColor = true;
            // 
            // rdo_Other
            // 
            rdo_Other.AutoSize = true;
            rdo_Other.Location = new Point(69, 124);
            rdo_Other.Name = "rdo_Other";
            rdo_Other.Size = new Size(88, 29);
            rdo_Other.TabIndex = 0;
            rdo_Other.Text = "Other";
            rdo_Other.UseVisualStyleBackColor = true;
            // 
            // rdo_LoveOffering
            // 
            rdo_LoveOffering.AutoSize = true;
            rdo_LoveOffering.Location = new Point(69, 89);
            rdo_LoveOffering.Name = "rdo_LoveOffering";
            rdo_LoveOffering.Size = new Size(172, 29);
            rdo_LoveOffering.TabIndex = 0;
            rdo_LoveOffering.Text = "Love Offering";
            rdo_LoveOffering.UseVisualStyleBackColor = true;
            // 
            // rdo_Offering
            // 
            rdo_Offering.AutoSize = true;
            rdo_Offering.Location = new Point(69, 54);
            rdo_Offering.Name = "rdo_Offering";
            rdo_Offering.Size = new Size(114, 29);
            rdo_Offering.TabIndex = 0;
            rdo_Offering.Text = "Offering";
            rdo_Offering.UseVisualStyleBackColor = true;
            // 
            // nud_Amount
            // 
            nud_Amount.DataBindings.Add(new Binding("Font", global::M3App.Settings.Default, "CurrentFont", true, DataSourceUpdateMode.OnPropertyChanged));
            nud_Amount.DecimalPlaces = 2;
            nud_Amount.Font = global::M3App.Settings.Default.CurrentFont;
            nud_Amount.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nud_Amount.Location = new Point(154, 217);
            nud_Amount.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            nud_Amount.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nud_Amount.Name = "nud_Amount";
            nud_Amount.Size = new Size(120, 31);
            nud_Amount.TabIndex = 29;
            nud_Amount.TextAlign = HorizontalAlignment.Center;
            nud_Amount.ThousandsSeparator = true;
            nud_Amount.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // lbl_Amount
            // 
            lbl_Amount.AutoSize = true;
            lbl_Amount.DataBindings.Add(new Binding("Font", global::M3App.Settings.Default, "CurrentFont", true, DataSourceUpdateMode.OnPropertyChanged));
            lbl_Amount.Font = global::M3App.Settings.Default.CurrentFont;
            lbl_Amount.Location = new Point(149, 189);
            lbl_Amount.Name = "lbl_Amount";
            lbl_Amount.Size = new Size(98, 25);
            lbl_Amount.TabIndex = 30;
            lbl_Amount.Text = "Amount:";
            // 
            // RecieptTypeDialog
            // 
            AcceptButton = btn_Ok;
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(424, 329);
            Controls.Add(lbl_Amount);
            Controls.Add(nud_Amount);
            Controls.Add(gbx_RecieptOptions);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Ok);
            Controls.Add(lbl_Other);
            Controls.Add(txt_Other);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReceiptTypeDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Receipt Type";
            gbx_RecieptOptions.ResumeLayout(false);
            gbx_RecieptOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Amount).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button btn_Ok;
        internal Button btn_Cancel;
        internal TextBox txt_Other;
        internal Label lbl_Other;
        internal GroupBox gbx_RecieptOptions;
        internal RadioButton rdo_Tithes;
        internal RadioButton rdo_Other;
        internal RadioButton rdo_LoveOffering;
        internal RadioButton rdo_Offering;
        internal NumericUpDown nud_Amount;
        internal Label lbl_Amount;
    }
}
