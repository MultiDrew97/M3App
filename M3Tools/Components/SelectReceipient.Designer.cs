using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SPPBC.M3Tools
{
    public partial class SelectReceipient : System.ComponentModel.Component
    {

        [DebuggerNonUserCode()]
        public SelectReceipient(System.ComponentModel.IContainer container) : this()
        {

            // Required for Windows.Forms Class Composition Designer support
            if (container is not null)
            {
                container.Add(this);
            }

        }

        [DebuggerNonUserCode()]
        public SelectReceipient() : base()
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
            _db_Listeners = new Database.ListenerDatabase(components);
            // 
            // db_Listeners
            // 
            _db_Listeners.BaseUrl = "Media Ministry";
            _db_Listeners.Password = "M3AppPassword2499";
            _db_Listeners.Username = "M3App";

        }

        private Database.ListenerDatabase _db_Listeners;

        internal virtual Database.ListenerDatabase db_Listeners
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _db_Listeners;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _db_Listeners = value;
            }
        }
    }
}