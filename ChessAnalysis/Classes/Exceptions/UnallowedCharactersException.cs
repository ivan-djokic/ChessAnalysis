using ChessAnalysis.Properties;

namespace ChessAnalysis.Classes
{
	public class UnallowedCharactersException : ExeptionBase
	{
		public UnallowedCharactersException(Components component)
			: base(Resources.UnallowedCharactersDetected, component)
		{
		}
	}
}
