// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public class BestMovePointsHelper
	{
		private readonly string m_enPassant;
		private readonly char[][] m_fen;

		public BestMovePointsHelper(char[][] fen, bool isNextPlayerWhite, string enPassant)
		{
			m_fen = fen;
			m_enPassant = enPassant;
			IsNextPlayerWhite = isNextPlayerWhite;
		}

		public bool IsEnPassant(char column, char row)
		{
			return m_enPassant == $"{column}{row}";
		}

		public bool IsNextPlayerWhite { get; }

		public (Point Start, Point End) GetCastlingPoints(bool kingSide)
		{
			var row = IsNextPlayerWhite ? Constants.BOARD_SIZE - 1 : 0;
			var endColumn = kingSide ? ParseConsts.CASTLING_COLUMN_KING : ParseConsts.CASTLING_COLUMN_QUEEN;

			return (new Point(ParseConsts.KING_START_COLUMN, row), new Point(endColumn, row));
		}

		public char GetEndPointPiece(char endColumn, char endRow)
		{
			var endPoint = GetEndPoint(endColumn, endRow);
			return m_fen[endPoint.Y][endPoint.X];
		}

		public (Point Start, Point End) GetPoints(char piece, char endColumn, char endRow, char? start = null)
		{
			var endPoint = GetEndPoint(endRow, endColumn);
			return (GetFinder(piece).GetStartPoint(endPoint.X, endPoint.Y, start), endPoint);
		}

		private static Point GetEndPoint(char column, char row)
		{
			return new Point(column.AsBoardColumn(Components.BestMove), row.AsNumber(Components.BestMove).AsBoardRow());
		}

		private StartPointFinderBase GetFinder(char piece)
		{
			if (!IsNextPlayerWhite)
			{
				// In case of white, piece is already uppercase, so there is no need to format it
				piece = char.ToLower(piece);
			}

			return char.ToUpper(piece) switch
			{
				Constants.PIECE_BISHOP => new BishopStartPointFinder(m_fen, piece),
				Constants.PIECE_KING => new KingStartPointFinder(m_fen, piece),
				Constants.PIECE_KNIGHT => new KnightStartPointFinder(m_fen, piece),
				Constants.PIECE_PAWN => new PawnStartPointFinder(m_fen, piece),
				Constants.PIECE_QUEEN => new QueenStartPointFinder(m_fen, piece),
				_ => new RookStartPointFinder(m_fen, piece)
			};
		}
	}
}
