using ChessAnalysis.Properties;

namespace ChessAnalysis.Classes
{
	public class NotUniqueIdException : ExeptionBase
	{
		public NotUniqueIdException(string id)
			: base(string.Format(Resources.DataSourceContainsId, id), Components.Id)
		{
		}
	}
}
