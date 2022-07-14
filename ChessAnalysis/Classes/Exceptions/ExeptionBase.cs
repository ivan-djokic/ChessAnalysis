// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

namespace ChessAnalysis.Classes
{
	public abstract class ExeptionBase : Exception
	{
		protected ExeptionBase(string message, Components component)
			: base(string.Format(message, component))
		{
			Component = component;
		}

		public Components Component { get; }
	}
}
