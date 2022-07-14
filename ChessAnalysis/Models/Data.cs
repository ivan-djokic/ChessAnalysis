// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

namespace ChessAnalysis.Models
{
	public class Data
	{
		private string m_input;

		public Data(string input, Position position, string id, Comment comment)
		{
			Comment = comment;
			Id = id;
			m_input = input;
			Position = position;
		}

		public Comment Comment { get; }

		public string Id { get; }

		public Position Position { get; }

		public override string ToString()
		{
			return m_input;
		}
	}
}
