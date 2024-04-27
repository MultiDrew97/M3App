using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SPPBC.M3Tools.Types.GTools
{
	/// <summary>
	/// Contains the info for an email being sent out
	/// </summary>
    public interface IEmailDetails
    {
        /// <summary>
		/// The contents of the email
		/// </summary>
		/// <returns></returns>
        EmailContent EmailContents { get; set; }

        /// <summary>
		/// 		''' The list of any drive links that may have been selected to be sent
		/// 		''' </summary>
		/// 		''' <returns></returns>
        FileCollection DriveLinks { get; set; }

        /// <summary>
		/// 		''' The list of any local files that were selected to be sent
		/// 		''' </summary>
		/// 		''' <returns></returns>
        Collection<string> LocalFiles { get; set; }

        /// <summary>
		/// 		''' The list of reciepients of the email
		/// 		''' </summary>
		/// 		''' <returns></returns>
        DBEntryCollection<Listener> Recipients { get; set; }

        /// <summary>
		/// 		''' The list of links to be added to the email body
		/// 		''' </summary>
		/// 		''' <returns></returns>
        List<string> SendingLinks { get; set; }

        // Public Sub New()
        // EmailContents = New EmailContent("", "", "html")
        // DriveLinks = New GTools.Types.FileCollection() 'List(Of String)
        // LocalFiles = New Collection(Of String)
        // Recipients = New ListenerCollection
        // SendingLinks = New List(Of String)
        // End Sub
    }

	/// <summary>
	/// The content of the email being sent
	/// </summary>
    public class EmailContent
    {
        /// <summary>
		/// 		''' The subject of the email
		/// 		''' </summary>
		/// 		''' <returns></returns>
        public string Subject { get; set; }

        /// <summary>
		/// 		''' The body content of the email
		/// 		''' </summary>
		/// 		''' <returns></returns>
        public string Body { get; set; }

        /// <summary>
		/// 		''' The text type of the email body. Typically 'html' or 'plain'
		/// 		''' </summary>
		/// 		''' <returns></returns>
        public EmailType BodyType { get; set; }

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		/// <param name="subject"></param>
		/// <param name="body"></param>
		/// <param name="type"></param>
        public EmailContent(string subject = "", string body = "", EmailType @type = default)
        {
            Subject = subject;
            Body = body;
            BodyType = type == default(int) ? EmailType.HTML : type;
        }
    }

	/// <summary>
	/// The type of email body being sent
	/// </summary>
    public enum EmailType
    {
		/// <summary>
		/// The email will contain an HTML body
		/// </summary>
        HTML,
		/// <summary>
		/// The email will contain a Plain Text body
		/// </summary>
        PLAIN
    }
}
