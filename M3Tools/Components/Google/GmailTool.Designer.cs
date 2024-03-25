﻿using System.Diagnostics;

namespace SPPBC.M3Tools.GTools
{
    public partial class GmailTool : Types.GTools.API
    {

        [DebuggerNonUserCode()]
        public GmailTool(System.ComponentModel.IContainer container) : this()
        {

            // Required for Windows.Forms Class Composition Designer support
            if (container is not null)
            {
                container.Add(this);
            }

        }

        [DebuggerNonUserCode()]
        public GmailTool() : base()
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
        }

    }
}