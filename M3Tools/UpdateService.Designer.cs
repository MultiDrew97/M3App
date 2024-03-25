using System.Diagnostics;
using System.ServiceProcess;

namespace SPPBC.M3Tools
{

    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UpdateService : ServiceBase
    {

        // UserService overrides dispose to clean up the component list.
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
        // It can be modified using the Component Designer.  Do not modify it
        // using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            wb_Updater = new System.Windows.Forms.WebBrowser();
            // 
            // wb_Updater
            // 
            wb_Updater.Location = new System.Drawing.Point(332, 324);
            wb_Updater.MinimumSize = new System.Drawing.Size(20, 20);
            wb_Updater.Name = "wb_Updater";
            wb_Updater.Size = new System.Drawing.Size(45, 36);
            wb_Updater.TabIndex = 6;
            wb_Updater.Visible = false;
            // 
            // UpdateService
            // 
            ServiceName = "UpdateService";

        }

        internal System.Windows.Forms.WebBrowser wb_Updater;
    }
}