using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{
	/// <summary>
	/// 
	/// </summary>
    public partial class TemplateSelector
    {
        // TODO: Create template management system for this later

        private Types.Template SelectedTemplate
        {
            get
            {
                return (Types.Template)cbx_TemplateSelection.SelectedItem;
            }
        }

		/// <summary>
		/// The name of the currently selected template
		/// </summary>
        [ReadOnly(true)]
        public string TemplateName
        {
            get
            {
                return cbx_TemplateSelection.SelectedText;
            }
        }

		/// <summary>
		/// The value of the currently selected template
		/// </summary>
        [ReadOnly(true)]
        public string TemplateValue
        {
            get
            {
                return Conversions.ToString(cbx_TemplateSelection.SelectedValue);
            }
        }

		/// <summary>
		/// The subject for the currently selected template
		/// </summary>
        public string TemplateSubject
        {
            get
            {
                return (SelectedTemplate?.Subject) ?? "";
            }
        }

		/// <summary>
		/// 
		/// </summary>
        public TemplateSelector()
        {
            InitializeComponent();
        }


		/// <summary>
		/// Reloads the control
		/// </summary>
        public void Reload()
        {
            cbx_TemplateSelection.SelectedIndex = -1;
        }

        private void TemplateSelectionChanged(object sender, EventArgs e)
        {
            if (cbx_TemplateSelection.SelectedIndex < 0)
            {
                cbx_TemplateSelection.Text = "Select Template...";
				wb_TemplateDisplay.Navigate("about:blank");
                return;
            }

            wb_TemplateDisplay.DocumentText = TemplateValue;
        }

		/// <summary>
		/// Add a template to the list
		/// </summary>
		/// <param name="template"></param>
        public void AddTemplate(Types.Template template)
        {
            bsTemplates.Add(template);
        }

		/// <summary>
		/// Add a range of templates to the list
		/// </summary>
		/// <param name="templates"></param>
        public void AddRange(Types.TemplateList templates)
        {
            foreach (var template in templates)
                AddTemplate(template);
        }
    }
}
