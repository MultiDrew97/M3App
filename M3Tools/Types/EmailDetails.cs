using System.Collections.ObjectModel;

namespace SPPBC.M3Tools.Types.GTools
{
	/// <summary>
	///	
	/// </summary>
	public class EmailDetails
	{
		/// <summary>
		/// The subject of the email
		/// </summary>
		public string Subject;

		/// <summary>
		/// The body of the email
		/// </summary>
		public string Body;

		/// <summary>
		/// The list of any drive links that may have been selected to be sent
		/// </summary>
		/// <returns></returns>
		public FileCollection DriveLinks;

		/// <summary>
		/// The list of any local files that were selected to be sent
		/// </summary>
		/// <returns></returns>
		public Collection<string> LocalFiles;

		/// <summary>
		/// The list of recipients of the email
		/// </summary>
		/// <returns></returns>
		public DbEntryCollection<Listener> Recipients;

		/// <summary>
		/// The list of links to be added to the email body
		/// </summary>
		/// <returns></returns>
		public Collection<string> SendingLinks;

		/// <summary>
		/// 
		/// </summary>
		public EmailDetails()
		{
			//EmailContents = new EmailContent();
			Subject = string.Empty;
			Body = string.Empty;
			DriveLinks = [];
			LocalFiles = [];
			Recipients = new ListenerCollection();
			SendingLinks = [];
		}
	}

	/// <summary>
	/// The content of the email being sent
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// <param name="subject"></param>
	/// <param name="body"></param>
	public class EmailContent(string subject = "", string body = "")
	{
		/// <summary>
		/// The subject of the email
		/// </summary>
		/// <returns></returns>
		public string Subject = subject;

		/// <summary>
		/// The body content of the email
		/// </summary>
		/// <returns></returns>
		public string Body = body;
	}
}
