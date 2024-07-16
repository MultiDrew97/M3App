using System;
using System.ComponentModel;
using System.Configuration;

namespace M3App.Properties {
    
    /// <summary>
	/// 
	/// </summary>
    //  This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {
		/// <summary>
		/// 
		/// </summary>
		public Settings()
		{
			// To add event handlers for saving and changing settings, uncomment the lines below:
			Console.WriteLine("Creating an instance of the Settings object...");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void OnSettingsSaving(object sender, CancelEventArgs e)
		{
			base.OnSettingsSaving(sender, e);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void OnSettingChanging(object sender, SettingChangingEventArgs e)
		{
			base.OnSettingChanging(sender, e);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(sender, e);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
		{
			base.OnSettingsLoaded(sender, e);
		}
	}
}
