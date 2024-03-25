using System.Collections.Generic;

namespace SPPBC.M3Tools.Types
{
    public class Template
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Subject { get; set; }

        public Template(string name = "", string text = "", string subject = "")
        {
            Name = name;
            Text = text;
            Subject = subject;
        }

        public static bool operator ==(Template left, Template right)
        {
            return (left.Name ?? "") == (right.Name ?? "");
        }

        public static bool operator !=(Template left, Template right)
        {
            return !(left == right);
        }
    }

    public class TemplateList : List<Template>
    {
    }
}