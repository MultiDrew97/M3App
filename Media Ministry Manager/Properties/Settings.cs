using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;

using SPPBC.M3Tools.Types.Extensions;

namespace M3App.Properties
{
	/// <summary>
	/// 
	/// </summary>
	//  This class allows you to handle specific events on the settings class:
	//  The SettingChanging event is raised before a setting's value is changed.
	//  The PropertyChanged event is raised after a setting's value is changed.
	//  The SettingsLoaded event is raised after the setting values are loaded.
	//  The SettingsSaving event is raised before the setting values are saved.
	[SettingsProvider(typeof(M3AppSettingsProvider))]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		[ApplicationScopedSetting]
		[DefaultSettingValue("true")]
		public bool UpdateOnStart { get; set; } = true;

		[ApplicationScopedSetting]
		[DefaultSettingValue("http://localhost:3000")]
		public string BaseUrl => Environment.GetEnvironmentVariable(Resources.API_BASE_URL, Utils.API_VAR_TARGET).Decrypt();

		[ApplicationScopedSetting]
		[DefaultSettingValue("password")]
		public string ApiPassword => Environment.GetEnvironmentVariable(Resources.API_PASSWORD, Utils.API_VAR_TARGET).Decrypt();

		[ApplicationScopedSetting]
		[DefaultSettingValue("username")]
		public string ApiUsername => Environment.GetEnvironmentVariable(Resources.API_USERNAME, Utils.API_VAR_TARGET).Decrypt();

		public Settings() => Console.WriteLine("Initializing Settings..");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void OnSettingsSaving(object sender, CancelEventArgs e) => base.OnSettingsSaving(sender, e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void OnSettingChanging(object sender, SettingChangingEventArgs e) => base.OnSettingChanging(sender, e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void OnPropertyChanged(object sender, PropertyChangedEventArgs e) => base.OnPropertyChanged(sender, e);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected override void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e) => base.OnSettingsLoaded(sender, e);

		internal static void EncryptAppConfig()
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("appSettings");
			if (!appSettings.SectionInformation.IsProtected)
			{
				appSettings.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
				config.Save(ConfigurationSaveMode.Full);
				Console.WriteLine("appSettings section has been encrypted.");
			}
		}

		internal static void DecryptAppConfig()
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

			AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("appSettings");
			if (appSettings.SectionInformation.IsProtected)
			{
				appSettings.SectionInformation.UnprotectSection();
				config.Save(ConfigurationSaveMode.Full);
				Console.WriteLine("appSettings section has been decrypted.");
			}
		}
	}

	internal sealed class M3AppSettingsProvider : SettingsProvider, IApplicationSettingsProvider
	{
		private const string SettingsFileName = "M3App.settings";

		private string SettingsFilePath
		{
			get
			{
				Debug.WriteLine(ApplicationName);
				if (!Directory.Exists(Utils.UserLocation))
				{
					_ = Directory.CreateDirectory(Utils.UserLocation);
				}

				return Path.Combine(Utils.UserLocation, SettingsFileName);
			}
		}

		public override string ApplicationName { get; set; } = Application.ProductName;

		public override void Initialize(string name, NameValueCollection config)
		{
			if (string.IsNullOrEmpty(name))
			{
				name = "M3AppSettingsProvider";
			}

			base.Initialize(name, config);
		}

		public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties)
		{
			Console.WriteLine(properties);
			SettingsPropertyValueCollection values = [];
			XmlDocument xml = new();

			if (File.Exists(SettingsFilePath))
			{
				xml.Load(SettingsFilePath);
			}
			else
			{
				_ = xml.AppendChild(xml.CreateElement("Settings"));
			}

			foreach (SettingsProperty property in properties)
			{
				SettingsPropertyValue value = new(property);
				XmlNode node = xml.SelectSingleNode($"//Setting[@Name='{property.Name}']");

				value.SerializedValue = node != null && node.Attributes["Value"] != null ? node.Attributes["Value"].Value : property.DefaultValue;

				values.Add(value);
			}

			return values;
		}

		public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values)
		{
			Console.WriteLine("Saving Settings Values...");
			XmlDocument xml = new();

			if (File.Exists(SettingsFilePath))
			{
				xml.Load(SettingsFilePath);
			}
			else
			{
				_ = xml.AppendChild(xml.CreateElement("Settings"));
			}

			foreach (SettingsPropertyValue value in values)
			{
				if (!value.IsDirty)
					continue;

				XmlNode node = xml.SelectSingleNode($"//Setting[@Name='{value.Name}']");

				if (node == null)
				{
					node = xml.CreateElement("Setting");
					XmlAttribute nameAttr = xml.CreateAttribute("Name");
					nameAttr.Value = value.Name;
					_ = node.Attributes.Append(nameAttr);
					_ = xml.DocumentElement.AppendChild(node);
				}

				XmlAttribute valueAttr = node.Attributes["Value"];
				if (valueAttr == null)
				{
					valueAttr = xml.CreateAttribute("Value");
					_ = node.Attributes.Append(valueAttr);
				}

				valueAttr.Value = value.SerializedValue?.ToString();
			}

			xml.Save(SettingsFilePath);
		}

		SettingsPropertyValue IApplicationSettingsProvider.GetPreviousVersion(SettingsContext context, SettingsProperty property) => throw new NotImplementedException();
		void IApplicationSettingsProvider.Reset(SettingsContext context) => throw new NotImplementedException();
		void IApplicationSettingsProvider.Upgrade(SettingsContext context, SettingsPropertyCollection properties) => throw new NotImplementedException();
	}
}
