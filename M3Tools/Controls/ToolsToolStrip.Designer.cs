using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SPPBC.M3Tools
{
    public partial class ToolsToolStrip : System.Windows.Forms.ToolStrip
    {

        [DebuggerNonUserCode()]
        public ToolsToolStrip(System.ComponentModel.IContainer container) : this()
        {

            // Required for Windows.Forms Class Composition Designer support
            if (container is not null)
            {
                container.Add(this);
            }

        }

        [DebuggerNonUserCode()]
        public ToolsToolStrip() : base()
        {

            // This call is required by the Component Designer.
            InitializeComponent();
            LayoutCompleted += ToolsToolStrip_LayoutCompleted;

        }

        // Component overrides dispose to clean up the component list.
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

        // Required by the Component Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Component Designer
        // It can be modified using the Component Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            _tsb_New = new System.Windows.Forms.ToolStripButton();
            _tsb_New.Click += new EventHandler(AddEntry);
            _tsb_Import = new System.Windows.Forms.ToolStripButton();
            _tsb_Import.Click += new EventHandler(ImportEntries);
            _ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            _tst_Filter = new System.Windows.Forms.ToolStripTextBox();
            _tst_Filter.TextChanged += new EventHandler(FilterUpdated);
            _tsb_Emails = new System.Windows.Forms.ToolStripButton();
            _tsb_Emails.Click += new EventHandler(SendEmails);
            _tsl_Count = new System.Windows.Forms.ToolStripLabel();
            _ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            SuspendLayout();
            // 
            // tsb_New
            // 
            _tsb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            _tsb_New.Image = My.Resources.Resources.NewDocumentOption;
            _tsb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            _tsb_New.Name = "_tsb_New";
            _tsb_New.Size = new System.Drawing.Size(23, 22);
            _tsb_New.Text = "New";
            _tsb_New.ToolTipText = "Add {0}";
            // 
            // tsb_Import
            // 
            _tsb_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            _tsb_Import.Image = My.Resources.Resources.import;
            _tsb_Import.ImageTransparentColor = System.Drawing.Color.Magenta;
            _tsb_Import.Name = "_tsb_Import";
            _tsb_Import.Size = new System.Drawing.Size(23, 22);
            _tsb_Import.Text = "Import";
            _tsb_Import.ToolTipText = "Import {0}";
            // 
            // ToolStripSeparator1
            // 
            _ToolStripSeparator1.Name = "_ToolStripSeparator1";
            _ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tst_Filter
            // 
            _tst_Filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            _tst_Filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            _tst_Filter.Font = new System.Drawing.Font("Segoe UI", 9.0f);
            _tst_Filter.Name = "_tst_Filter";
            _tst_Filter.Size = new System.Drawing.Size(100, 23);
            _tst_Filter.ToolTipText = "Filter {0}";
            // 
            // tsb_Emails
            // 
            _tsb_Emails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            _tsb_Emails.Image = My.Resources.Resources.send_email;
            _tsb_Emails.ImageTransparentColor = System.Drawing.Color.Magenta;
            _tsb_Emails.Name = "_tsb_Emails";
            _tsb_Emails.Size = new System.Drawing.Size(23, 22);
            _tsb_Emails.Text = "Send Emails";
            // 
            // tsl_Count
            // 
            _tsl_Count.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            _tsl_Count.Name = "_tsl_Count";
            _tsl_Count.Size = new System.Drawing.Size(0, 0);
            // 
            // ToolStripSeparator2
            // 
            _ToolStripSeparator2.Name = "_ToolStripSeparator2";
            _ToolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // ToolsToolStrip
            // 
            GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            Items.AddRange(new System.Windows.Forms.ToolStripItem[] { _tsb_New, _tsb_Import, _tsb_Emails, _ToolStripSeparator1, _tst_Filter, _ToolStripSeparator2, _tsl_Count });
            RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            Stretch = true;
            ResumeLayout(false);

        }

        private System.Windows.Forms.ToolStripButton _tsb_New;

        internal virtual System.Windows.Forms.ToolStripButton tsb_New
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tsb_New;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tsb_New != null)
                {
                    _tsb_New.Click -= AddEntry;
                }

                _tsb_New = value;
                if (_tsb_New != null)
                {
                    _tsb_New.Click += AddEntry;
                }
            }
        }
        private System.Windows.Forms.ToolStripButton _tsb_Import;

        internal virtual System.Windows.Forms.ToolStripButton tsb_Import
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tsb_Import;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tsb_Import != null)
                {
                    _tsb_Import.Click -= ImportEntries;
                }

                _tsb_Import = value;
                if (_tsb_Import != null)
                {
                    _tsb_Import.Click += ImportEntries;
                }
            }
        }
        private System.Windows.Forms.ToolStripSeparator _ToolStripSeparator1;

        internal virtual System.Windows.Forms.ToolStripSeparator ToolStripSeparator1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripSeparator1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripSeparator1 = value;
            }
        }
        private System.Windows.Forms.ToolStripTextBox _tst_Filter;

        internal virtual System.Windows.Forms.ToolStripTextBox tst_Filter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tst_Filter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tst_Filter != null)
                {
                    _tst_Filter.TextChanged -= FilterUpdated;
                }

                _tst_Filter = value;
                if (_tst_Filter != null)
                {
                    _tst_Filter.TextChanged += FilterUpdated;
                }
            }
        }
        private System.Windows.Forms.ToolStripButton _tsb_Emails;

        internal virtual System.Windows.Forms.ToolStripButton tsb_Emails
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tsb_Emails;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tsb_Emails != null)
                {
                    _tsb_Emails.Click -= SendEmails;
                }

                _tsb_Emails = value;
                if (_tsb_Emails != null)
                {
                    _tsb_Emails.Click += SendEmails;
                }
            }
        }
        private System.Windows.Forms.ToolStripLabel _tsl_Count;

        internal virtual System.Windows.Forms.ToolStripLabel tsl_Count
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tsl_Count;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _tsl_Count = value;
            }
        }
        private System.Windows.Forms.ToolStripSeparator _ToolStripSeparator2;

        internal virtual System.Windows.Forms.ToolStripSeparator ToolStripSeparator2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolStripSeparator2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripSeparator2 = value;
            }
        }
    }
}