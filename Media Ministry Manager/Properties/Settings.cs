using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Xml;

namespace M3App.Properties
{
	internal sealed class M3AppSettingsProvider : SettingsProvider, IApplicationSettingsProvider
	{
		private const string SettingsFileName = "M3App.settings";

		private string SettingsFilePath
		{
			get
			{
				Console.WriteLine("App Name: {0}", ApplicationName);
				string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), ApplicationName);

				if (!Directory.Exists(dir))
				{
					_ = Directory.CreateDirectory(dir);
				}

				return Path.Combine(dir, SettingsFileName);
			}
		}

		public override string ApplicationName { get; set; } = "M3App";

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

			if (!File.Exists(SettingsFilePath))
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
		[DefaultSettingValue("https://sppbc.herbivore.site")]
		public string BaseUrl => Environment.GetEnvironmentVariable("api_base_url");
		/*#if DEBUG
						"http://localhost:3000";
		#else
					"https://sppbc.herbivore.site";
		#endif*/

		[ApplicationScopedSetting]
		[DefaultSettingValue("Wz^8Ne3f3jnkX#456BTd^$#mJqBE!G")]
		public string ApiPassword => Environment.GetEnvironmentVariable("api_password");
		/*#if DEBUG
						"password";
		#else
					"Wz^8Ne3f3jnkX#456BTd^$#mJqBE!G";
		#endif*/

		[ApplicationScopedSetting]
		[DefaultSettingValue("Preachy2034")]
		public string ApiUsername => Environment.GetEnvironmentVariable("api_username");
		/*#if DEBUG
						"username";
		#else
					"Preachy2034";
		#endif*/

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

		/*[UserScopedSetting]
		[DefaultSettingValue("Microsoft Sans Serif, 15.75pt, style=Bold")]
		[SettingsManageability(SettingsManageability.Roaming)]
		public System.Drawing.Font CurrentFont
		{
			get => (System.Drawing.Font)this["CurrentFont"];
			set => this["CurrentFont"] = value;
		}

		[ApplicationScopedSetting]
		[DefaultSettingValue("Microsoft Sans Serif, 15.75pt, style=Bold")]
		public System.Drawing.Font DefaultFont => (System.Drawing.Font)this["DefaultFont"];

		[UserScopedSetting]
		[SettingsManageability(SettingsManageability.Roaming)]
		public SPPBC.M3Tools.Types.User User
		{
			get => (SPPBC.M3Tools.Types.User)this["User"];
			set => this["User"] = value;
		}

		[UserScopedSetting]
		[DefaultSettingValue("")]
		[SettingsManageability(SettingsManageability.Roaming)]
		public string Username
		{
			get => (string)this["Username"];
			set => this["Username"] = value;
		}

		[UserScopedSetting]
		[DefaultSettingValue("")]
		[SettingsManageability(SettingsManageability.Roaming)]
		public string Password
		{
			get => (string)this["Password"];
			set => this["Password"] = value;
		}

		[UserScopedSetting]
		[DefaultSettingValue("False")]
		[SettingsManageability(SettingsManageability.Roaming)]
		public bool KeepLoggedIn
		{
			get => (bool)this["KeepLoggedIn"];
			set => this["KeepLoggedIn"] = value;
		}

		[UserScopedSetting]
		[DefaultSettingValue("True")]
		[SettingsManageability(SettingsManageability.Roaming)]
		public bool UpgradeRequired
		{
			get => (bool)this["UpradeRequired"];
			set => this["UpgradeRequired"] = value;
		}*/
	}
}
