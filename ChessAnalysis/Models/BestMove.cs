namespace ChessAnalysis.Models
{
	public class BestMove
	{
		private readonly string m_input;

		public BestMove(string input, char piece, Point field)
		{
			Field = field;
			m_input = input;
			Piece = piece;
		}

		public Point Field { get; }

		public char Piece { get; set; }

		public override string ToString()
		{
			return m_input;
		}
	}
}
