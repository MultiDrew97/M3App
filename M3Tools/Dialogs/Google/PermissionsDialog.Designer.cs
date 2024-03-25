using System;
using System.Diagnostics;

namespace SPPBC.M3Tools
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PermissionsDialog : System.Windows.Forms.Form
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
            components = new System.ComponentModel.Container();
            TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            OK_Button = new System.Windows.Forms.Button();
            OK_Button.Click += new EventHandler(SetPermission);
            Cancel_Button = new System.Windows.Forms.Button();
            Cancel_Button.Click += new EventHandler(Cancel);
            cbx_Role = new System.Windows.Forms.ComboBox();
            cbx_Role.SelectedIndexChanged += new EventHandler(RoleChanged);
            bsRoles = new System.Windows.Forms.BindingSource(components);
            lbl_Role = new System.Windows.Forms.Label();
            cbx_Type = new System.Windows.Forms.ComboBox();
            cbx_Type.SelectedIndexChanged += new EventHandler(TypeChanged);
            lbl_Type = new System.Windows.Forms.Label();
            bsTypes = new System.Windows.Forms.BindingSource(components);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTypes).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(OK_Button, 1, 0);
            TableLayoutPanel1.Controls.Add(Cancel_Button, 0, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(277, 274);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            OK_Button.Location = new System.Drawing.Point(76, 3);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new System.Drawing.Size(67, 23);
            OK_Button.TabIndex = 0;
            OK_Button.Text = "OK";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Cancel_Button.Location = new System.Drawing.Point(3, 3);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new System.Drawing.Size(67, 23);
            Cancel_Button.TabIndex = 1;
            Cancel_Button.Text = "Cancel";
            // 
            // cbx_Role
            // 
            cbx_Role.DataSource = bsRoles;
            cbx_Role.FormattingEnabled = true;
            cbx_Role.Location = new System.Drawing.Point(101, 36);
            cbx_Role.Name = "cbx_Role";
            cbx_Role.Size = new System.Drawing.Size(184, 21);
            cbx_Role.TabIndex = 1;
            // 
            // lbl_Role
            // 
            lbl_Role.AutoSize = true;
            lbl_Role.Location = new System.Drawing.Point(101, 17);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new System.Drawing.Size(29, 13);
            lbl_Role.TabIndex = 2;
            lbl_Role.Text = "Role";
            // 
            // cbx_Type
            // 
            cbx_Type.DataSource = bsTypes;
            cbx_Type.FormattingEnabled = true;
            cbx_Type.Location = new System.Drawing.Point(101, 96);
            cbx_Type.Name = "cbx_Type";
            cbx_Type.Size = new System.Drawing.Size(184, 21);
            cbx_Type.TabIndex = 1;
            // 
            // lbl_Type
            // 
            lbl_Type.AutoSize = true;
            lbl_Type.Location = new System.Drawing.Point(101, 77);
            lbl_Type.Name = "lbl_Type";
            lbl_Type.Size = new System.Drawing.Size(31, 13);
            lbl_Type.TabIndex = 2;
            lbl_Type.Text = "Type";
            // 
            // PermissionsDialog
            // 
            AcceptButton = OK_Button;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = Cancel_Button;
            ClientSize = new System.Drawing.Size(435, 315);
            Controls.Add(lbl_Type);
            Controls.Add(lbl_Role);
            Controls.Add(cbx_Type);
            Controls.Add(cbx_Role);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PermissionsDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "PermissionsDialog";
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTypes).EndInit();
            Load += new EventHandler(PermissionsDialogLoaded);
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button OK_Button;
        internal System.Windows.Forms.Button Cancel_Button;
        internal System.Windows.Forms.ComboBox cbx_Role;
        internal System.Windows.Forms.Label lbl_Role;
        internal System.Windows.Forms.ComboBox cbx_Type;
        internal System.Windows.Forms.Label lbl_Type;
        internal System.Windows.Forms.BindingSource bsRoles;
        internal System.Windows.Forms.BindingSource bsTypes;
    }
}