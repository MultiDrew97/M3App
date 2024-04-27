using System.Collections.Generic;

namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// A class containing the informaion for email templates
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
        public static bool operator ==(Template left, Template right)
        {
            return (left.Name ?? "") == (right.Name ?? "");
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
        public static bool operator !=(Template left, Template right)
        {
            return !(left == right);
        }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return this == obj as Template || base.Equals(obj);
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}

	/// <summary>
	/// A list of templates
	/// </summary>
    public class TemplateList : List<Template>
    {
    }
}
