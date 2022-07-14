// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

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
