using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.IO.Path;
using static M3App.Properties.Resources;

namespace M3App
{
	internal partial class M3App
	{
		private static StreamWriter _log;
		private static StreamWriter _error;

		private static StreamWriter Log
		{
			get
			{
				_log ??= new StreamWriter(Combine(Utils.LOG_LOCATION, CONSOLE_OUTPUT_FILE), false, Encoding.UTF8);
				return _log;
			}
		}

		private static StreamWriter Error
		{
			get
			{
				_error ??= new StreamWriter(Combine(Utils.LOG_LOCATION, CONSOLE_ERROR_FILE), false, Encoding.UTF8);
				return _error;
			}
		}

		[STAThread]
		private static void Main(string[] args)
		{
			try
			{
				PrepLogs();
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				Application.Run(new M3AppContext());
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
				_ = Utils.ShowErrorMessage("Application Error", string.Format(UNHANDLED_EXCEPTION.Replace(@"\n", "\n").Replace(@"\t", "\t"), ex.Message));
			}
			finally
			{
				Cleanup();
			}
		}

		private static void Cleanup()
		{
			Log.Close();
			Error.Close();
		}

		private static void PrepLogs()
		{
			if (!Directory.Exists(Utils.LOG_LOCATION))
				_ = Directory.CreateDirectory(Utils.LOG_LOCATION);

			Utils.CycleLogs();

			Console.SetOut(new MultiOutputWriter(Console.Out, Log));
			Console.SetError(new MultiOutputWriter(Console.Error, Error));

			Console.WriteLine("Logs have been created");
		}
	}

	internal class MultiOutputWriter(params TextWriter[] writers) : TextWriter
	{
		// TODO: Update this to print the date and time when writing to console for tracking
		private readonly string LOG_FORMAT = $"{{0}}";

		// Ensures the encoding is UTF8
		public override Encoding Encoding => Encoding.UTF8;

		// TODO: Make it so that it automatically outputs with the date and time info of the output as well
		public override void Write(string value) =>
			writers.Select(writer =>
			{
				writer.Write(string.Format(LOG_FORMAT, value));
				return true;
			});

		public override void WriteLine(string value) =>
			writers.Select(writer =>
			{
				writer.WriteLine(string.Format(LOG_FORMAT, value));
				return true;
			});

		public override async Task WriteAsync(string value) =>
			await Task.WhenAll(writers.Select(writer =>
			writer.WriteAsync(string.Format(LOG_FORMAT, value))));

		public override async Task WriteLineAsync(string value) =>
			await Task.WhenAll(writers.Select(writer =>
			writer.WriteLineAsync(string.Format(LOG_FORMAT, value))));
	}
}
