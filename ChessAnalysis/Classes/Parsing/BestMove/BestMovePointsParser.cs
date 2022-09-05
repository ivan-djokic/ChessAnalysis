// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public class BestMovePointsParser : ParserBase<(Point Start, Point End)>
	{
		private readonly BestMovePointsHelper m_helper;

		private BestMovePointsParser(string input, char[][] fen, bool isNextPlayerWhite)
			: base(input)
		{
			m_helper = new BestMovePointsHelper(fen, isNextPlayerWhite);
		}

		protected override Components Component
		{
			get => Components.BestMove;
		}

		public static (Point Start, Point End) Parse(string input, char[][] fen, bool isNextPlayerWhite)
		{
			return new BestMovePointsParser(input, fen, isNextPlayerWhite).Parse();
		}

		protected override (Point Start, Point End) Parse()
		{
			if (string.IsNullOrEmpty(m_input))
			{
				return (new Point(-1, -1), new Point(-1, -1));
			}

			return ParseCastlingMove() ?? ParseRegularMove();
		}

		private bool IsPromotion()
		{
			if (!m_input.Contains(ParseConsts.BEST_MOVE_PROMOTION))
			{
				return false;
			}

			ValidateArgumentsCount(4, 4);

			if (m_input[1] != ParseConsts.ALLOWED_BEST_MOVE_PROMOTION_ROWS[Convert.ToInt32(m_helper.IsNextPlayerWhite)]
				|| m_input[^1] == Constants.PIECE_PAWN || m_input[^1] == Constants.PIECE_KING)
			{
				throw new UnallowedCharactersException(Component);
			}

			return true;
		}

		private (Point Start, Point End)? ParseCastlingMove()
		{
			return m_input switch
			{
				ParseConsts.CASTLING_KING => m_helper.GetCastlingPoints(true),
				ParseConsts.CASTLING_QUEEN => m_helper.GetCastlingPoints(false),
				_ => null
			};
		}

		private (Point Start, Point End) ParseRegularMove()
		{
			// input: [column] [row] = [piece] || {[<pawnColumn>] || ([<piece>] [<prevColumn || prevRow>]) [<capture>] [column] [row]} [<check || mate>]
			ValidateArgumentsCount(2, 6);

			if (ParseConsts.BEST_MOVE_CHECK_OR_MATE.Contains(m_input[^1]))
			{
				m_input = m_input.RemoveLast();
			}

			// input: [column] [row] = [piece] || {[<pawnColumn>] || ([<piece>] [<prevColumn || prevRow>]) [<capture>] [column] [row]}
			if (IsPromotion())
			{
				// input: [column] [row] = [piece]
				return m_helper.GetPoints(Constants.PIECE_PAWN, m_input[1], m_input[0]);
			}

			// input: [<pawnColumn>] || ([<piece>] [<prevColumn || prevRow>]) [<capture>] [column] [row]
			ValidateArgumentsCount(2, 5, false);

			var row = m_input[^1];
			var column = m_input[^2];

			var endPointPiece = m_helper.GetEndPointPiece(column, row);

			m_input = m_input.RemoveLast(2);

			if (string.IsNullOrEmpty(m_input))
			{
				if (endPointPiece != Constants.EMPTY_CHAR)
				{
					// Pawn regular move can be made only on empty field
					throw new IncorrectFormatException(Component);
				}

				// Pawn has not mark, so piece is pawn by default
				return m_helper.GetPoints(Constants.PIECE_PAWN, row, column);
			}

			// input: [pawnColumn] || ([<piece>] [<prevColumn || prevRow>]) [<capture>]
			var capture = m_input.EndsWith(ParseConsts.BEST_MOVE_CAPTURE);

			if (capture)
			{
				ValidateCapture(endPointPiece);
				m_input = m_input.RemoveLast();
			}
			else if (endPointPiece != Constants.EMPTY_CHAR)
			{
				throw new IncorrectFormatException(Component);
			}

			// input: [pawnColumn] || ([<piece>] [<prevColumn || prevRow>])
			ValidateArgumentsCount(1, 2, false);

			if (m_input[0].IsBoardColumn())
			{
				// input: [pawnColumn]
				ValidateArgumentsCount(1, 1);

				var distance = Math.Abs(m_input[0] - column);

				// Check is pawn captures on neighbour column
				if (!capture || distance != 1)
				{
					throw new UnallowedCharactersException(Component);
				}

				return m_helper.GetPoints(Constants.PIECE_PAWN, row, column, m_input[0]);
			}

			// input: [piece] [<prevColumn || prevRow>]
			if (!m_input[0].IsBoardPiece() || m_input[0] == Constants.PIECE_PAWN)
			{
				throw new UnallowedCharactersException(Component);
			}

			if (m_input.Length > 1)
			{
				// input: [piece] [prevColumn || prevRow]
				return m_helper.GetPoints(m_input[0], row, column, m_input[1]);
			}

			// input: [piece] 
			return m_helper.GetPoints(m_input[0], row, column);
		}

		private void ValidateArgumentsCount(int minCount, int maxCount, bool countException = true)
		{
			if (m_input.Length < minCount || m_input.Length > maxCount)
			{
				throw countException ? new InvalidComponentsNumberException(Component) : new UnallowedCharactersException(Component);
			}
		}

		private void ValidateCapture(char piece)
		{
			if (piece == Constants.EMPTY_CHAR
				|| m_helper.IsNextPlayerWhite && char.IsUpper(piece) 
				|| !m_helper.IsNextPlayerWhite && char.IsLower(piece))
			{
				// Cannot capture empty field or same color piece
				throw new IncorrectFormatException(Component);
			}
		}
	}
}
