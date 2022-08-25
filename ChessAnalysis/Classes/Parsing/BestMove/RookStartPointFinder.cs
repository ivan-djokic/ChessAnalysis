// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public class RookStartPointFinder : StartPointFinderBase
	{
		public RookStartPointFinder(char[][] fen, char piece)
			: base(fen, piece)
		{
		}

		public override Point GetStartPoint(int endColumn, int endRow, char? start)
		{
			var result = TryGetStartPoint(endColumn, endRow, start);

			if (result.HasValue)
			{
				return result.Value;
			}

			// Start is not specified, so we need to find rook start possiton in all 4 directions
			try
			{
				// To the left
				return TryGetHorisontalPieceStartPoint(endColumn, endRow, -1, -1);
			}
			catch
			{
			}

			try
			{
				// To the right
				return TryGetHorisontalPieceStartPoint(endColumn, endRow, 1, Constants.BOARD_SIZE);
			}
			catch
			{
			}

			try
			{
				// To the top
				return TryGetVerticalPieceStartPoint(endColumn, endRow, -1, -1);
			}
			catch
			{
			}

			// To the bottom
			return TryGetVerticalPieceStartPoint(endColumn, endRow, 1, Constants.BOARD_SIZE);
		}

		private Point? TryGetStartPoint(int endColumn, int endRow, char? start)
		{
			// If start is specified and this is impossible move, exception must be thrown
			var (Column, Row) = TryDeconstructStartPoint(start);

			if (Column.HasValue)
			{
				// Rook is on the same row
				if (IsPieceField(Column.Value, endRow))
				{
					return new Point(Column.Value, endRow);
				}

				throw new IncorrectFormatException(Components.BestMove);
			}

			if (Row.HasValue)
			{
				// Rook is on the same column
				if (IsPieceField(endColumn, Row.Value))
				{
					return new Point(endColumn, Row.Value);
				}

				throw new IncorrectFormatException(Components.BestMove);
			}

			return null;
		}
	}
}
