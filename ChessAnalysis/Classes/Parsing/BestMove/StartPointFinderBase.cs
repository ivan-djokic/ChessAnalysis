// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public abstract class StartPointFinderBase
	{
		protected readonly char[][] m_fen;
		protected readonly char m_piece;

		public StartPointFinderBase(char[][] fen, char piece)
		{
			m_fen = fen;
			m_piece = piece;
		}

		public abstract Point GetStartPoint(int endColumn, int endRow, char? start);

		protected bool IsPieceField(int column, int row, bool validate = false)
		{
			// Acccess to fen in try block to avoid checking boundary conditions
			try
			{
				if (m_fen[row][column] == m_piece)
				{
					return true;
				}
			}
			catch
			{
				// Cannot validate because index was out of the bounds
				validate = false;
			}

			if (validate && m_fen[row][column] != Constants.EMPTY_CHAR)
			{
				// Something is on the way to specified piece
				throw new IncorrectFormatException(Components.BestMove);
			}

			return false;
		}

		protected static (int? Column, int? Row) TryDeconstructStartPoint(char? start)
		{
			if (!start.HasValue)
			{
				return (null, null);
			}

			try
			{
				return (start.Value.AsBoardColumn(Components.BestMove), null);
			}
			catch
			{
				return (null, start.Value.AsNumber(Components.BestMove).AsBoardRow());
			}
		}

		protected Point TryGetDiagonalPieceStartPoint(int column, int row, int columnDirection, int rowDirection, int columnLimit, int rowLimit)
		{
			var i = column + columnDirection;
			var j = row + rowDirection;

			while (i != columnLimit && j != rowLimit)
			{
				if (IsPieceField(i, j, true))
				{
					return new Point(i, j);
				}

				i += columnDirection;
				j += rowDirection;
			}

			throw new IncorrectFormatException(Components.BestMove);
		}

		protected Point TryGetHorisontalPieceStartPoint(int column, int row, int direction, int limit)
		{
			var i = column + direction;

			while (i != limit)
			{
				if (IsPieceField(i, row, true))
				{
					return new Point(i, row);
				}

				i += direction;
			}

			// Piece not found
			throw new IncorrectFormatException(Components.BestMove);
		}

		protected Point TryGetVerticalPieceStartPoint(int column, int row, int direction, int limit, int attempts = 7)
		{
			var i = row + direction;

			while (i != limit && attempts > 0)
			{
				if (IsPieceField(column, i, true))
				{
					return new Point(column, i);
				}

				i += direction;
				attempts--;
			}

			// Piece not found
			throw new IncorrectFormatException(Components.BestMove);
		}
	}
}
