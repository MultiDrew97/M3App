using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SPPBC.M3Tools
{
    public partial class RecipientSelectionDialog : System.ComponentModel.Component
    {

        [DebuggerNonUserCode()]
        public RecipientSelectionDialog(System.ComponentModel.IContainer container) : this()
        {

            // Required for Windows.Forms Class Composition Designer support
            if (container is not null)
            {
                container.Add(this);
            }

        }

        [DebuggerNonUserCode()]
        public RecipientSelectionDialog() : base()
        {

            // This call is required by the Component Designer.
            InitializeComponent();

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
            components = new System.ComponentModel.Container();
            _bsListeners = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)_bsListeners).BeginInit();
            // 
            // bsListeners
            // 
            _bsListeners.DataSource = typeof(Types.DBEntryCollection<Types.Listener>);
            ((System.ComponentModel.ISupportInitialize)_bsListeners).EndInit();

        }

        private System.Windows.Forms.BindingSource _bsListeners;

        internal virtual System.Windows.Forms.BindingSource bsListeners
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _bsListeners;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _bsListeners = value;
            }
        }
    }
}