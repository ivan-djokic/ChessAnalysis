// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Models;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public class PositionParser : ParserBase<Position>
	{
		private PositionParser(string input)
			: base(input)
		{
		}

		protected override int ArgumentsCount
		{
			get => ParseConsts.ARGS_COUNT_POSITION;
		}

		protected override Components Component
		{
			get => Components.Position;
		}

		protected override string Delimiter
		{
			get => ParseConsts.ARGS_DELIMITER_SPACE;
		}

		public static string[] GetArguments(string input)
		{
			return new PositionParser(input).Arguments;
		}

		public static Position Parse(string input)
		{
			// input: [FEN] [nextPlayer] [castling] [enPasant] [halfMoves] [round] bm [BM]
			return new PositionParser(input).Parse();
		}

		protected override Position Parse()
		{
			var nextPlayer = NextPlayerParser.Parse(Arguments[ParseConsts.POSITION_NEXT_PLAYER_INDEX]);

			return new Position(
				FenParser.Parse(Arguments[ParseConsts.POSITION_FEN_INDEX]),
				nextPlayer,
				CastlingParser.Parse(Arguments[ParseConsts.POSITION_CASTLING_INDEX]),
				EnPassantParser.Parse(Arguments[ParseConsts.POSITION_EN_PASSANT_INDEX], nextPlayer == NextPlayer.Black),
				Arguments[ParseConsts.POSITION_HALF_MOVES_INDEX].AsNumber(Components.HalfMoves),
				Arguments[ParseConsts.POSITION_ROUND_INDEX].AsNumber(Components.Round),
				BestMoveParser.Parse(Arguments[ParseConsts.POSITION_BEST_MOVE_INDEX], nextPlayer == NextPlayer.Black));
		}
	}
}
