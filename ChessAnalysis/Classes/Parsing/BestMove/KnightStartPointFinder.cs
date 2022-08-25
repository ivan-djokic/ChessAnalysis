// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

namespace ChessAnalysis.Classes
{
	public class KnightStartPointFinder : StartPointFinderBase
	{
		public KnightStartPointFinder(char[][] fen, char piece)
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

			// Start is not specified, so we need to find knight start possiton in
			// all max 8 possible positions from top to bottom and from left to right

			// Top left corrner
			if (IsPieceField(endColumn - 1, endRow - 2))
			{
				return new Point(endColumn - 1, endRow - 2);
			}

			// Top corrner
			if (IsPieceField(endColumn + 1, endRow - 2))
			{
				return new Point(endColumn + 1, endRow - 2);
			}

			// Top middle left corrner
			if (IsPieceField(endColumn - 2, endRow - 1))
			{
				return new Point(endColumn - 2, endRow - 1);
			}

			// Top middle right corrner
			if (IsPieceField(endColumn + 2, endRow - 1))
			{
				return new Point(endColumn + 2, endRow - 1);
			}

			// Bottom middle left corrner
			if (IsPieceField(endColumn - 2, endRow + 1))
			{
				return new Point(endColumn - 2, endRow + 1);
			}

			// Bottom middle right corrner
			if (IsPieceField(endColumn + 2, endRow + 1))
			{
				return new Point(endColumn + 2, endRow + 1);
			}

			// Bottom left corrner
			if (IsPieceField(endColumn - 1, endRow + 2))
			{
				return new Point(endColumn - 1, endRow + 2);
			}

			// Bottom right corrner
			if (IsPieceField(endColumn + 1, endRow + 2))
			{
				return new Point(endColumn + 1, endRow + 2);
			}

			throw new IncorrectFormatException(Components.BestMove);
		}

		private static int GetOffset(int start, int end)
		{
			var difference = Math.Abs(start - end);

			if (difference != 1 && difference != 2)
			{
				throw new IncorrectFormatException(Components.BestMove);
			}

			// If difference between start and end value, e.g. column, is 1
			// then difference between start and end row is 2 (and reverse)
			return difference == 1 ? 2 : 1;
		}

		private Point? TryGetStartPoint(int endColumn, int endRow, char? start)
		{
			// If start is specified and this is impossible move, exception must be thrown
			var (Column, Row) = TryDeconstructStartPoint(start);

			if (Column.HasValue)
			{
				var offset = GetOffset(Column.Value, endColumn);

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
				var offset = GetOffset(Row.Value, endRow);

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
