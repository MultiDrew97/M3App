using System;
using System.ComponentModel;
using System.Windows.Forms;
using SPPBC.M3Tools.Events.Customers;

namespace M3App
{
	/// <summary>
	/// 
	/// </summary>
    public partial class ManagementForm<T> //where T : SPPBC.M3Tools.Types.IDbEntry
	{
		// private SPPBC.M3Tools.Data.CustomerBindingSource DataSource => (SPPBC.M3Tools.Data.CustomerBindingSource)cdg_Customers.DataSource; 

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
        public ManagementForm()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Called when the display is being closed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void DisplayClosing(object sender, CancelEventArgs e)
		{
			
		}

		/// <summary>
		/// Reloads the display
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void Reload(object sender, EventArgs e)
		{

		}
    }
}
