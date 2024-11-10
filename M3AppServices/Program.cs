using System;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;

namespace M3AppServices
{
	internal static class Program
	{
		private static readonly ServiceInstaller _installer = new ServiceInstaller() { a };
		private static readonly System.Collections.IDictionary _serviceState;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		private static void Main(params string[] args)
		{
			switch (true)
			{
				case var _ when ValidateInstallArgs(args):
					Console.WriteLine("Installing Services...");
					InstallServices();
					break;
				case var _ when ValidateUninstallArgs(args):
					Console.WriteLine("Uninstalling Services...");
					UninstallServices();
					break;
				default:
					Console.WriteLine("Unknown argument(s):\n");
					Console.WriteLine(args);
					throw new ArgumentException("Unknown arguments received", "args");
			}
		}

		private static bool ValidateInstallArgs(string[] args) => !args.Contains("/u") && (args.Contains("/i") || args.Contains("-i") || args.Contains("--install"));

		private static bool ValidateUninstallArgs(string[] args) => !args.Contains("/i") && (args.Contains("/u") || args.Contains("-u") || args.Contains("--uninstall"));

		private static void InstallServices()
		{
#if DEBUG
			Console.WriteLine("Services have been installed");

			ServiceInstaller temp = new ServiceInstaller();
			temp.Install(_serviceState);
#else
			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[]
			{
				new UpdateService()
			};
			ServiceBase.Run(ServicesToRun);
#endif
		}

		private static void UninstallServices()
		{
			ServiceInstaller temp = new ServiceInstaller();
			temp.Uninstall(_serviceState);
			_ = Process.Start(new ProcessStartInfo()
			{
				CreateNoWindow = true,
				UseShellExecute = true
			});
		}
	}
}
