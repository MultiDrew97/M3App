using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SPPBC.M3Tools.Attributes;

using static System.IO.Path;
using static M3App.Properties.Resources;

namespace M3App
{
	internal partial class M3App
	{
		private static readonly MultiOutputWriter _log = new(Console.Out);
		private static readonly MultiOutputWriter _err = new(Console.Error);

		[STAThread]
		private static void Main(string[] args)
		{
#if DEBUG
			//PrepDebugValues();
#endif
			Console.SetOut(_log);
			Console.SetError(_err);

			try
			{
				PrepCustomOutputs();

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
				Console.WriteLine("Performing cleanup...");
				Cleanup();
			}
		}

		private static void Cleanup()
		{
			Console.WriteLine("Closing outputs...");
			Console.Out.Close();
			Console.Error.Close();
		}

		private static void PrepCustomOutputs()
		{
			Console.WriteLine("Verifying custom location is valid...");
			if (!Directory.Exists(Utils.LOG_LOCATION) && !Directory.CreateDirectory(Utils.LOG_LOCATION).Exists)
			{
				Console.Error.WriteLine($"Unable to find/create log location: {Utils.LOG_LOCATION}. Skipping custom log creation...");
				return;
			}

			_log.AddWriter(new StreamWriter(Combine(Utils.LOG_LOCATION, CONSOLE_OUTPUT_FILE), false, Encoding.UTF8) { AutoFlush = true });
			_err.AddWriter(new StreamWriter(Combine(Utils.LOG_LOCATION, CONSOLE_ERROR_FILE), false, Encoding.UTF8) { AutoFlush = true });

			Utils.CycleLogs();
			Console.WriteLine("Custom log creation complete");
		}

		private static void PrepDebugValues()
		{
			foreach (Type @class in Assembly.GetExecutingAssembly().GetTypes())
			{
				foreach (PropertyInfo prop in @class.GetProperties())
				{
					DebugCustomValueAttribute attr = prop.GetCustomAttribute<DebugCustomValueAttribute>();
					if (attr is null)
						continue;

					Debug.WriteLine($"Class: {@class.Name}, Prop: {prop.Name}, Custom Value: {attr.Value}", "M3App");
				}
			}
		}
	}

	internal class MultiOutputWriter(params TextWriter[] writers) : TextWriter
	{
		// TODO: Update this to print the date and time when writing to console for tracking
		private readonly string LOG_FORMAT = "{0}";

		// Ensures the encoding is UTF8
		public override Encoding Encoding => Encoding.UTF8;

		public void AddWriter(TextWriter w) => writers = [.. writers, w];

		public void AddWriters(params TextWriter[] ws) => writers = [.. writers, .. ws];

		public void RemoveWriter(TextWriter writer) => writers = writers.Where(w => w != writer).ToArray();

		// TODO: Make it so that it automatically outputs with the date and time info of the output as well
		public override void Write(string value)
		{
			foreach (TextWriter writer in writers)
				writer.Write(string.Format(LOG_FORMAT, value));
		}

		public override void WriteLine(string value)
		{
			foreach (TextWriter writer in writers)
				writer.WriteLine(string.Format(LOG_FORMAT, value));
		}

		public override async Task WriteAsync(string value)
		{
			await Task.WhenAll(writers.Select(writer =>
			writer.WriteAsync(string.Format(LOG_FORMAT, value))));
		}

		public override async Task WriteLineAsync(string value)
		{
			await Task.WhenAll(writers.Select(writer =>
			writer.WriteLineAsync(string.Format(LOG_FORMAT, value))));
		}

		public override void Close()
		{
			base.Close();
			foreach (TextWriter writer in writers)
				writer.Close();
		}
	}
}
