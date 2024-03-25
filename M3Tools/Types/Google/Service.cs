
namespace SPPBC.M3Tools.Types.GTools
{
    public interface IGoogleService<T>
    {
        /// <summary>
		/// 		''' Gets the account information for the current user.
		/// 		''' </summary>
		/// 		''' <returns>The account info for the current user</returns>
        T UserAccount { get; }
    }
}