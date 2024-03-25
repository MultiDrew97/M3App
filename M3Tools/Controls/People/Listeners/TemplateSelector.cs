using System;
using System.ComponentModel;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{

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

        [ReadOnly(true)]
        public string TemplateName
        {
            get
            {
                return cbx_TemplateSelection.SelectedText;
            }
        }

        [ReadOnly(true)]
        public string TemplateValue
        {
            get
            {
                return Conversions.ToString(cbx_TemplateSelection.SelectedValue);
            }
        }
        public string TemplateSubject
        {
            get
            {
                return (SelectedTemplate?.Subject) ?? "";
            }
        }

        public TemplateSelector()
        {
            InitializeComponent();
        }


        public void Reload()
        {
            cbx_TemplateSelection.SelectedIndex = -1;
        }

        private void TemplateSelectionChanged(object sender, EventArgs e)
        {
            if (cbx_TemplateSelection.SelectedIndex < 0)
            {
                cbx_TemplateSelection.Text = "Select Template...";
                return;
            }

            // wb_TemplateDisplay.Navigate("about:blank")
            wb_TemplateDisplay.DocumentText = Conversions.ToString(cbx_TemplateSelection.SelectedValue);
        }

        private void TemplateListUpdated(object sender, ListChangedEventArgs e)
        {
            if (!(e.ListChangedType == ListChangedType.ItemAdded))
            {
                return;
            }

        }

        public void AddTemplate(Types.Template template)
        {
            bsTemplates.Add(template);
        }

        public void AddRange(Types.TemplateList templates)
        {
            foreach (var template in templates)
                AddTemplate(template);
        }
    }
}