using System.Collections;
using System.ComponentModel;
using System.ServiceProcess;

namespace M3AppServices
{
	[RunInstaller(true)]
	public partial class ProjectInstaller : System.Configuration.Install.Installer
	{
		private readonly ServiceBase[] _services = new ServiceBase[]
			{
				new UpdateService()
			};

		public ProjectInstaller() => InitializeComponent();
		protected override void OnBeforeInstall(IDictionary savedState) => base.OnBeforeInstall(savedState);

		public override void Install(IDictionary stateSaver)
		{
			base.Install(stateSaver);

			ServiceBase.Run(_services);
		}

		protected override void OnAfterInstall(IDictionary savedState) => base.OnAfterInstall(savedState);

		protected override void OnBeforeUninstall(IDictionary savedState) => base.OnBeforeUninstall(savedState);

		public override void Uninstall(IDictionary savedState)
		{
			base.Uninstall(savedState);

			ServiceBase.Run(_services);
		}

		protected override void OnAfterUninstall(IDictionary savedState) => base.OnAfterUninstall(savedState);

		protected override void OnBeforeRollback(IDictionary savedState) => base.OnBeforeRollback(savedState);

		public override void Rollback(IDictionary savedState) => base.Rollback(savedState);

		protected override void OnAfterRollback(IDictionary savedState) => base.OnAfterRollback(savedState);

		protected override void OnCommitting(IDictionary savedState) => base.OnCommitting(savedState);

		public override void Commit(IDictionary savedState) => base.Commit(savedState);

		protected override void OnCommitted(IDictionary savedState) => base.OnCommitted(savedState);
	}
}
