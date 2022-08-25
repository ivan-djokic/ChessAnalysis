// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public class BishopStartPointFinder : StartPointFinderBase
	{
		public BishopStartPointFinder(char[][] fen, char piece)
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

			// Start is not specified, so we need to find bishop start possiton in all 4 directions
			try
			{
				// To the top left corner
				return TryGetDiagonalPieceStartPoint(endColumn, endRow, -1, -1, -1, -1);
			}
			catch
			{
			}

			try
			{
				// To the top right corner
				return TryGetDiagonalPieceStartPoint(endColumn, endRow, 1, -1, Constants.BOARD_SIZE, -1);
			}
			catch
			{
			}

			try
			{
				// To the bottom left corner
				return TryGetDiagonalPieceStartPoint(endColumn, endRow, -1, 1, -1, Constants.BOARD_SIZE);
			}
			catch
			{
			}

			// To the bottom right corner
			return TryGetDiagonalPieceStartPoint(endColumn, endRow, 1, 1, Constants.BOARD_SIZE, Constants.BOARD_SIZE);
		}

		private Point? TryGetStartPoint(int endColumn, int endRow, char? start)
		{
			// Start point for bishop is needed if pawn was promoted to bishop
			// and the same-color bishop is already in the game

			// If start is specified and this is impossible move, exception must be thrown
			var (Column, Row) = TryDeconstructStartPoint(start);

			if (Column.HasValue)
			{
				var offset = Math.Abs(Column.Value - endColumn);

				// Top direction
				if (IsPieceField(Column.Value, endRow - offset))
				{
					return new Point(Column.Value, endRow - offset);
				}

				// Bottom direction
				if (IsPieceField(Column.Value, endRow + offset))
				{
					return new Point(Column.Value, endRow + offset);
				}

				throw new IncorrectFormatException(Components.BestMove);
			}

			if (Row.HasValue)
			{
				var offset = Math.Abs(Row.Value - endRow);

				// Left direction
				if (IsPieceField(endColumn - offset, Row.Value))
				{
					return new Point(endColumn - offset, Row.Value);
				}

				// Right direction
				if (IsPieceField(endColumn + offset, Row.Value))
				{
					return new Point(endColumn + offset, Row.Value);
				}

				throw new IncorrectFormatException(Components.BestMove);
			}

			return null;
		}
	}
}
