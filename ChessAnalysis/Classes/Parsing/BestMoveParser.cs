// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Models;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public class BestMoveParser : ParserBase<BestMove>
	{
		private readonly bool m_isWhitePlayed;

		private BestMoveParser(string input, bool isWhitePlayed)
			: base(input)
		{
			m_isWhitePlayed = isWhitePlayed;
		}

		protected override Components Component
		{
			get => Components.BestMove;
		}

		public static BestMove Parse(string input, bool isWhitePlayed)
		{
			return new BestMoveParser(input, isWhitePlayed).Parse();
		}

		protected override BestMove Parse()
		{
			if (m_input == ParseConsts.ARG_NULL)
			{
				return new BestMove(string.Empty, Constants.EMPTY_CHAR, new Point(-1, -1));
			}

			return ParseCastlingMove() ?? ParseRegularMove();
		}

		private BestMove CreateCastlingMove(int column)
		{
			return new BestMove(m_input, GetPiece(Constants.PIECE_KING), new Point(column, m_isWhitePlayed ? Constants.BOARD_SIZE - 1 : 0));
		}

		private Point GetField(char column, char row)
		{
			return new Point(column.AsBoardColumn(Component), row.AsNumber(Component).AsBoardRow());
		}

		private char GetPiece(char input, bool allowPawn = false)
		{
			if (!input.IsBoardPiece() || !allowPawn && input == Constants.PIECE_PAWN)
			{
				throw new UnallowedCharactersException(Component);
			}

			return m_isWhitePlayed ? input : char.ToLower(input);
		}

		private bool IsPromotion()
		{
			if (!m_input.Contains(ParseConsts.BEST_MOVE_PROMOTION))
			{
				return false;
			}

			ValidateArgumentsCount(4, 4);

			if (m_input[1] != ParseConsts.ALLOWED_BEST_MOVE_PROMOTION_ROWS[Convert.ToInt32(m_isWhitePlayed)]
				|| m_input[^1] == Constants.PIECE_PAWN || m_input[^1] == Constants.PIECE_KING)
			{
				throw new UnallowedCharactersException(Component);
			}

			return true;
		}

		private BestMove? ParseCastlingMove()
		{
			return m_input switch
			{
				ParseConsts.CASTLING_KING => CreateCastlingMove(6),
				ParseConsts.CASTLING_QUEEN => CreateCastlingMove(2),
				_ => null
			};
		}

		private BestMove ParseRegularMove()
		{
			// input: [column] [row] = [piece] || {[<pawnColumn>] || ([<piece>] [<prevColumn || prevRow>]) [<capture>] [column] [row]} [<check || mate>]
			ValidateArgumentsCount(2, 6);

			var input = m_input;

			if (ParseConsts.BEST_MOVE_CHECK_OR_MATE.Contains(m_input[^1]))
			{
				m_input = m_input.RemoveLast();
			}

			// input: [column] [row] = [piece] || {[<pawnColumn>] || ([<piece>] [<prevColumn || prevRow>]) [<capture>] [column] [row]}
			if (IsPromotion())
			{
				// input: [column] [row] = [piece]
				return new BestMove(input, GetPiece(m_input[^1]), GetField(m_input[0], m_input[1]));
			}

			// input: [<pawnColumn>] || ([<piece>] [<prevColumn || prevRow>]) [<capture>] [column] [row]
			ValidateArgumentsCount(2, 5, false);

			// Pawn has not mark, so piece is pawn by default
			var result = new BestMove(input, GetPiece(Constants.PIECE_PAWN, true), GetField(m_input[^2], m_input[^1]));
			m_input = m_input.RemoveLast(2);

			// input: [<pawnColumn>] || ([<piece>] [<prevColumn || prevRow>]) [<capture>]
			if (string.IsNullOrEmpty(m_input))
			{
				return result;
			}

			// input: [pawnColumn] || ([<piece>] [<prevColumn || prevRow>]) [<capture>]
			var capture = m_input.EndsWith(ParseConsts.BEST_MOVE_CAPTURE);

			if (capture)
			{
				m_input = m_input.RemoveLast();
			}

			// input: [pawnColumn] || ([<piece>] [<prevColumn || prevRow>])
			ValidateArgumentsCount(1, 2, false);

			if (m_input[0].IsBoardColumn())
			{
				// input: [pawnColumn]
				ValidateArgumentsCount(1, 1);

				if (!capture)
				{
					throw new UnallowedCharactersException(Component);
				}

				return result;
			}

			// input: [piece] [<prevColumn || prevRow>]
			result.Piece = GetPiece(m_input[0]);
			m_input = m_input[1..];

			// input: [<prevColumn || prevRow>]
			if (!string.IsNullOrEmpty(m_input) && !m_input[0].IsBoardColumn() && !m_input[0].IsBoardRow())
			{
				throw new UnallowedCharactersException(Component);
			}

			return result;
		}

		private void ValidateArgumentsCount(int minCount, int maxCount, bool countException = true)
		{
			if (m_input.Length < minCount || m_input.Length > maxCount)
			{
				throw countException ? new InvalidComponentsNumberException(Component) : new UnallowedCharactersException(Component);
			}
		}
	}
}
