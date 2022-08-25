// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

namespace ChessAnalysis.Classes
{
	public class KingStartPointFinder : StartPointFinderBase
	{
		public KingStartPointFinder(char[][] fen, char piece)
			: base(fen, piece)
		{
		}

		public override Point GetStartPoint(int endColumn, int endRow, char? _)
		{
			// Find king start possiton in all max 8 possible positions
			// from top to bottom and from left to right

			// Top left corrner
			if (IsPieceField(endColumn - 1, endRow - 1))
			{
				return new Point(endColumn - 1, endRow - 1);
			}

			// Top corrner
			if (IsPieceField(endColumn, endRow - 1))
			{
				return new Point(endColumn, endRow - 1);
			}

			// Top right corrner
			if (IsPieceField(endColumn + 1, endRow - 1))
			{
				return new Point(endColumn + 1, endRow - 1);
			}

			// Left corrner
			if (IsPieceField(endColumn - 1, endRow))
			{
				return new Point(endColumn - 1, endRow);
			}

			// Right corrner
			if (IsPieceField(endColumn + 1, endRow))
			{
				return new Point(endColumn + 1, endRow);
			}

			// Bottom left corrner
			if (IsPieceField(endColumn - 1, endRow + 1))
			{
				return new Point(endColumn - 1, endRow + 1);
			}

			// Bottom corrner
			if (IsPieceField(endColumn, endRow + 1))
			{
				return new Point(endColumn, endRow + 1);
			}

			// Bottom right corrner
			if (IsPieceField(endColumn + 1, endRow + 1))
			{
				return new Point(endColumn + 1, endRow + 1);
			}

			throw new IncorrectFormatException(Components.BestMove);
		}
	}
}
