﻿using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SPPBC.M3Tools.Database
{
    public partial class OrdersDatabase : System.ComponentModel.Component
    {

        [DebuggerNonUserCode()]
        public OrdersDatabase(System.ComponentModel.IContainer container) : this()
        {

            // Required for Windows.Forms Class Composition Designer support
            if (container is not null)
            {
                container.Add(this);
            }

        }

        [DebuggerNonUserCode()]
        public OrdersDatabase() : base()
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
            _dbConnection = new Database(components);

        }

        private Database _dbConnection;

        internal Database dbConnection
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dbConnection;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _dbConnection = value;
            }
        }
    }
}