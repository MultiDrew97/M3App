using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3App
{
	internal partial class M3App
	{
		[STAThread]
		private static void Main(string[] args)
		{
			using System.IO.StreamWriter consoleFile = new(System.IO.Path.Combine(Application.StartupPath, Properties.Resources.CONSOLE_OUTPUT_FILE), true, Encoding.UTF8);
			using System.IO.StreamWriter errorFile = new(System.IO.Path.Combine(Application.StartupPath, Properties.Resources.CONSOLE_ERROR_FILE), true, Encoding.UTF8);

			Console.SetOut(new MultiOutputWriter(Console.Out, consoleFile));
			Console.SetError(new MultiOutputWriter(Console.Error, errorFile));

			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				Application.Run(new M3AppContext());
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
				_ = MessageBox.Show(string.Format(Properties.Resources.FAILED_TO_OPEN.Replace(@"\n", "\n").Replace(@"\t", "\t"), ex.Message), "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
			}
		}
	}

	internal class MultiOutputWriter : System.IO.TextWriter
	{
		private readonly System.IO.TextWriter[] writers;

		public override Encoding Encoding => Encoding.UTF8;

		public MultiOutputWriter(params System.IO.TextWriter[] writers)
		{
			this.writers = writers;
		}

		// TODO: Make it so that it automatically outputs with the date and time info of the output as well
		public override void Write(string value)
		{
			foreach (System.IO.TextWriter writer in writers)
			{
				writer.Write(value);
			}
		}

		public override void WriteLine(string value)
		{
			foreach (System.IO.TextWriter writer in writers)
			{
				writer.WriteLine(value);
			}
		}

		public override Task WriteAsync(string value)
		{
			return Task.Run(() =>
			{
				foreach (System.IO.TextWriter writer in writers)
				{
					_ = writer.WriteAsync(value);
				}
			});
		}

		public override Task WriteLineAsync(string value)
		{
			return Task.Run(() =>
			{
				foreach (System.IO.TextWriter writer in writers)
				{
					_ = writer.WriteLineAsync(value);
				}
			});
		}
	}
}
