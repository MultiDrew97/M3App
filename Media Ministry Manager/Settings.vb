' This class allows you to handle specific events on the settings class:
' The SettingChanging event is raised before a setting's value is changed.
' The PropertyChanged event is raised after a setting's value is changed.
' The SettingsLoaded event is raised after the setting values are loaded.
' The SettingsSaving event is raised before the setting values are saved.
Partial Friend NotInheritable Class MySettings
	Private ReadOnly __saveLocation As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SPPBC", Username, "Settings")
	Private ReadOnly xmlReader As Xml.XmlReader
	Private ReadOnly xmlWriter As Xml.XmlWriter
	Public Overrides Sub Save()
		Using xmlWriter = Xml.XmlWriter.Create(IO.Path.Combine(__saveLocation, Me.Username, "Settings.xml"))
			xmlWriter.WriteStartDocument()
			xmlWriter.WriteStartElement("Settings")
			xmlWriter.WriteElementString("Username", Me.Username)
			xmlWriter.WriteElementString("Password", Me.Password)
			xmlWriter.WriteElementString("Remember", Me.KeepLoggedIn.ToString)
			xmlWriter.WriteEndElement()
			xmlWriter.WriteEndDocument()
		End Using
		Console.WriteLine("Saved")
		MyBase.Save()
	End Sub

	Public Sub Load()
		Using xmlReader = Xml.XmlReader.Create(IO.Path.Combine(__saveLocation, Me.Username, "Settings.xml"))
			While xmlReader.Read()
				Console.WriteLine(xmlReader.Name)
			End While
		End Using
	End Sub
End Class