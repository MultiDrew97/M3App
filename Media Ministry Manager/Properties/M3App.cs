using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using M3App.My;

namespace M3App
{
	internal partial class M3App
	{
		[STAThread]
		static void Main(string[] args)
		{
			using System.IO.StreamWriter consoleFile = new(System.IO.Path.Combine(Application.StartupPath, Properties.Resources.CONSOLE_OUTPUT_FILE), true, Encoding.UTF8);
			using System.IO.StreamWriter errorFile = new(System.IO.Path.Combine(Application.StartupPath, Properties.Resources.CONSOLE_ERROR_FILE), true, Encoding.UTF8);
			Console.SetOut(new MultiOutputWriter(Console.Out, consoleFile));
			Console.SetError(new MultiOutputWriter(Console.Error, errorFile));

			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				Application.Run(new M3ApplicationContext(args));
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format(Properties.Resources.FAILED_TO_OPEN, ex.Message), "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			foreach (var writer in writers)
			{
				writer.Write(value);
			}
		}

		public override void WriteLine(string value)
		{
			foreach (var writer in writers)
			{
				writer.WriteLine(value);
			}
		}
	}
}
