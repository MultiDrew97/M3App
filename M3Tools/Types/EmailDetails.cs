using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SPPBC.M3Tools.Types.GTools
{
    public interface IEmailDetails
    {
        /// <summary>
		/// 		''' The contents of the email
		/// 		''' </summary>
		/// 		''' <returns></returns>
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

        public EmailContent(string subject = "", string body = "", EmailType @type = default)
        {
            Subject = subject;
            Body = body;
            BodyType = type == default(int) ? EmailType.HTML : type;
        }
    }

    public enum EmailType
    {
        HTML,
        PLAIN
    }
}