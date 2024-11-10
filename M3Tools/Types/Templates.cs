using System.Collections.Generic;

// TODO: Make it so these come from files in a directory that can be changed by the user
//			This prevents from having to push a new version, just because there was a template change. Will also help in keeping more templates
namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// A class containing the information for email templates
	/// </summary>
	public class Template
	{
		/// <summary>
		/// The name of the template
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The text within the template
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// The subject associated with the template
		/// </summary>
		public string Subject { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="text"></param>
		/// <param name="subject"></param>
		public Template(string name = "", string text = "", string subject = "")
		{
			Name = name;
			Text = text;
			Subject = subject;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator ==(Template left, Template right) => !(left is null ^ right is null) && left.Name == right.Name && left.Subject == right.Subject && left.Text == right.Text;

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator !=(Template left, Template right) => !(left == right);

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode() => base.GetHashCode();
		/// <inheritdoc/>

		public override bool Equals(object obj) => this == (obj as Template);
	}

	/// <summary>
	/// A list of templates
	/// </summary>
	public class TemplateList : List<Template>
	{
	}
}
