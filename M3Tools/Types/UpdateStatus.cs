namespace SPPBC.M3Tools.Types
{
	/// <summary>
	/// Whether an update is available or not
	/// </summary>
	public readonly struct UpdateStatus
	{
		/// <summary>
		/// No update is available
		/// </summary>
		public static readonly string NotAvailable = "n";

		/// <summary>
		/// An Update is available
		/// </summary>
		public static readonly string Available = "y";
	}
}
