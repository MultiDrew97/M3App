using System;
using System.Windows.Forms;
using Google.Apis.Drive.v3.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace SPPBC.M3Tools
{

    public partial class PermissionsDialog
    {
		/// <summary>
		/// The set of permissions
		/// </summary>
        public Permission Permission { get; set; } = new Permission();

        private readonly string[] __roles = new[] { "Owner", "Organizer", "File Organizer", "Writer", "Commenter", "Reader" };
        private readonly string[] __types = new[] { "User", "Group", "Domain", "Anyone" };

		/// <summary>
		/// 
		/// </summary>
        public PermissionsDialog()
        {
            InitializeComponent();
        }

        private void SetPermission(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PermissionsDialogLoaded(object sender, EventArgs e)
        {
            bsRoles.DataSource = __roles;
            bsTypes.DataSource = __types;
            cbx_Role.SelectedItem = "Reader";
            cbx_Type.SelectedItem = "Anyone";
        }

        private void RoleChanged(object sender, EventArgs e)
        {
            Permission.Role = Conversions.ToString(cbx_Role.SelectedItem).Replace(" ", "");
        }

        private void TypeChanged(object sender, EventArgs e)
        {
            Permission.Type = Conversions.ToString(cbx_Type.SelectedItem).Replace(" ", "");
        }
    }
}
