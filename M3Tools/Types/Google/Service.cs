
namespace SPPBC.M3Tools.Types.GTools
{
	/// <summary>
	/// An interface that defines aspects of a Google API instance
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IGoogleService<T>
	{
		/// <summary>
		/// Gets the current user's account information
		/// </summary>
		//public T UserAccount { get; }

		public T GetUser();
	}
}
