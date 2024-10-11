using System;
using System.Diagnostics;

namespace SPPBC.M3Tools.Dialogs
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CreateAccountDialog : System.Windows.Forms.Form
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
            btn_Cancel = new System.Windows.Forms.Button();
            btn_Cancel.Click += new EventHandler(OK_Button_Click);
            btn_Create = new System.Windows.Forms.Button();
            btn_Create.Click += new EventHandler(Cancel_Button_Click);
            cpf_Confirm = new ConfirmPasswordField();
            cpf_Confirm.ConfirmLostFocus += new EventHandler(Cpf_Confirm_ConfirmLostFocus);
            cpf_Confirm.ConfirmTextChanged += new EventHandler(Cpf_Confirm_ConfirmTextChanged);
            pf_Password = new PasswordField();
            pf_Password.PasswordLostFocus += new EventHandler(Pf_Password_PasswordLostFocus);
            pf_Password.PasswordTextChanged += new EventHandler(Pf_Password_PasswordTextChanged);
            uf_Username = new UsernameField();
            uf_Username.UsernameLostFocus += new EventHandler(Uf_Username_UsernameLostFocus);
            uf_Username.UsernameTextChanged += new EventHandler(Uf_Username_TextChanged);
            db_Users = new API.UserDatabase(components);
            ep_FieldError = new System.Windows.Forms.ErrorProvider(components);
            TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep_FieldError).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(btn_Cancel, 0, 0);
            TableLayoutPanel1.Controls.Add(btn_Create, 1, 0);
            TableLayoutPanel1.Location = new System.Drawing.Point(261, 274);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            TableLayoutPanel1.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_Cancel.Location = new System.Drawing.Point(3, 3);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new System.Drawing.Size(67, 23);
            btn_Cancel.TabIndex = 0;
            btn_Cancel.Text = "Cancel";
            // 
            // btn_Create
            // 
            btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Create.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_Create.Location = new System.Drawing.Point(76, 3);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new System.Drawing.Size(67, 23);
            btn_Create.TabIndex = 1;
            btn_Create.Text = "Create";
            // 
            // cpf_Confirm
            // 
            cpf_Confirm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            cpf_Confirm.AutoSize = true;
            cpf_Confirm.BackColor = System.Drawing.SystemColors.Control;
            cpf_Confirm.Location = new System.Drawing.Point(60, 165);
            cpf_Confirm.Name = "cpf_Confirm";
            cpf_Confirm.Size = new System.Drawing.Size(288, 72);
            cpf_Confirm.TabIndex = 2;
            // 
            // pf_Password
            // 
            pf_Password.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            pf_Password.AutoSize = true;
            pf_Password.BackColor = System.Drawing.SystemColors.Control;
            pf_Password.Location = new System.Drawing.Point(60, 87);
            pf_Password.Name = "pf_Password";
            pf_Password.Size = new System.Drawing.Size(288, 72);
            pf_Password.TabIndex = 1;
            // 
            // uf_Username
            // 
            uf_Username.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            uf_Username.AutoSize = true;
            uf_Username.BackColor = System.Drawing.SystemColors.Control;
            uf_Username.Location = new System.Drawing.Point(60, 17);
            uf_Username.Name = "uf_Username";
            uf_Username.Size = new System.Drawing.Size(288, 52);
            uf_Username.TabIndex = 0;
            // 
            // ep_FieldError
            // 
            ep_FieldError.ContainerControl = this;
            // 
            // CreateAccountDialog
            // 
            AcceptButton = btn_Create;
            AutoScaleDimensions = new System.Drawing.SizeF(6.0f, 13.0f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new System.Drawing.Size(419, 315);
            Controls.Add(cpf_Confirm);
            Controls.Add(pf_Password);
            Controls.Add(uf_Username);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateAccountDialog";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Create Account";
            TableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ep_FieldError).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.Button btn_Create;
        internal UsernameField uf_Username;
        internal PasswordField pf_Password;
        internal ConfirmPasswordField cpf_Confirm;
        internal API.UserDatabase db_Users;
        internal System.Windows.Forms.ErrorProvider ep_FieldError;
    }
}