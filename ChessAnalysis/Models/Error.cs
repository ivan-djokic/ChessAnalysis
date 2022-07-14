// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

namespace ChessAnalysis.Models
{
	public class Error
	{
		public Error(string input, string error)
		{
			Line = input;
			Message = error;
		}

		public string Line { get; }

		public string Message { get; }
	}
}
