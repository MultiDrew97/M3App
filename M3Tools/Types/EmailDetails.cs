using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SPPBC.M3Tools.Types.GTools
{
	/// <summary>
	///	
	/// </summary>
    public class EmailDetails
    {
        /// <summary>
		///	The contents of the email
		/// </summary>
		/// <returns></returns>
        public EmailContent EmailContents;

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
		/// The list of reciepients of the email
		/// </summary>
		/// <returns></returns>
		public DbEntryCollection<Listener> Recipients;

		/// <summary>
		/// The list of links to be added to the email body
		/// </summary>
		/// <returns></returns>
		public List<string> SendingLinks;

		/// <summary>
		/// 
		/// </summary>
		public EmailDetails()
		{
			EmailContents = new EmailContent();
			DriveLinks = new FileCollection();
			LocalFiles = new Collection<string>();
			Recipients = new ListenerCollection();
			SendingLinks = new List<string>();
		}
	}

	/// <summary>
	/// The content of the email being sent
	/// </summary>
	public class EmailContent
    {
        /// <summary>
		/// The subject of the email
		/// </summary>
		/// <returns></returns>
        public string Subject { get; set; }

        /// <summary>
		/// The body content of the email
		/// </summary>
		/// <returns></returns>
        public string Body { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="subject"></param>
		/// <param name="body"></param>
        public EmailContent(string subject = "", string body = "")
        {
            Subject = subject;
            Body = body;
        }
    }
}
