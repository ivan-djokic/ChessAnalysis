// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Properties;

namespace ChessAnalysis.Classes
{
	public class InvalidComponentsNumberException : ExeptionBase
	{
		public InvalidComponentsNumberException(Components component)
			: base(Resources.InvalidComponentsNumber, component)
		{
		}
	}
}
