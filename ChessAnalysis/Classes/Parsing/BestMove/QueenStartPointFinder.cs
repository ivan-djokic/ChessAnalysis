// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

namespace ChessAnalysis.Classes
{
	public class QueenStartPointFinder : StartPointFinderBase
	{
		public QueenStartPointFinder(char[][] fen, char piece)
			: base(fen, piece)
		{
		}

		public override Point GetStartPoint(int endColumn, int endRow, char? start)
		{
			// Queen is piece that combine bishop and rook behaviors, so to find queen start possiton
			// in all max 8 possible positions combine search methods of these two pieces

			try
			{
				return new RookStartPointFinder(m_fen, m_piece).GetStartPoint(endColumn, endRow, start);
			}
			catch
			{
				return new BishopStartPointFinder(m_fen, m_piece).GetStartPoint(endColumn, endRow, start);
			}
		}
	}
}
