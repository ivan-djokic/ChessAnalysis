// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public class PawnStartPointFinder : StartPointFinderBase
	{
		private readonly bool m_isWhitePiece;

		public PawnStartPointFinder(char[][] fen, char piece)
			: base(fen, piece)
		{
			m_isWhitePiece = !char.IsLower(piece);
		}

		public override Point GetStartPoint(int endColumn, int endRow, char? start)
		{
			// If start is specified and this is impossible move, exception must be thrown
			var (Column, _) = TryDeconstructStartPoint(start);

			if (Column.HasValue)
			{
				// There was capture, so column is changed
				return GetStartPoint(Column.Value, endRow, 1);
			}

			// Ordinary pawn move
			return GetStartPoint(endColumn, endRow, CanJumpTwoFields(endRow) ? 2 : 1);
		}

		private bool CanJumpTwoFields(int endRow)
		{
			if (m_isWhitePiece)
			{
				return endRow == ParseConsts.ALLOWED_PAWN_TWO_FIELDS_JUMP_WHITE;
			}

			return endRow == ParseConsts.ALLOWED_PAWN_TWO_FIELDS_JUMP_BLACK;
		}

		private Point GetStartPoint(int endColumn, int endRow, int attempts)
		{
			if (m_isWhitePiece)
			{
				return TryGetVerticalPieceStartPoint(endColumn, endRow, 1, Constants.BOARD_SIZE - 1, attempts);
			}

			return TryGetVerticalPieceStartPoint(endColumn, endRow, -1, 0, attempts);
		}
	}
}
