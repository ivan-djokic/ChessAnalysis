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
            get => ParserConsts.ARGS_COUNT_POSITION;
        }

        protected override Components Component
        {
            get => Components.Position;
        }

        protected override string Delimiter
        {
            get => ParserConsts.ARGS_DELIMITER_SPACE;
        }

        public static Position Parse(string input)
        {
            // input: [FEN] [nextPlayer] [castling] [enPasant] [halfMoves] [round] bm [BM]
            return new PositionParser(input).Parse();
        }

        protected override Position Parse()
        {
            var result = new Position
            {
                Fen = Arguments[ParserConsts.POSITION_FEN_INDEX],
                HalfMoves = Arguments[ParserConsts.POSITION_HALF_MOVES_INDEX].AsNumber(Components.HalfMoves),
                Round = Arguments[ParserConsts.POSITION_ROUND_INDEX].AsNumber(Components.Round)
            };

            if (Arguments[ParserConsts.POSITION_EN_PASSANT_INDEX] != ParserConsts.ARG_NULL)
            {
                result.EnPassant = Arguments[ParserConsts.POSITION_EN_PASSANT_INDEX];
            }

            result.NextPlayer = NextPlayerParser.Parse(Arguments[ParserConsts.POSITION_NEXT_PLAYER_INDEX]);
            result.BestMove = BestMoveParser.Parse(Arguments[ParserConsts.POSITION_BEST_MOVE_INDEX], result.NextPlayer == NextPlayer.Black);
            (result.CastlingBlack, result.CastlingWhite) = CastlingParser.Parse(Arguments[ParserConsts.POSITION_CASTLING_INDEX]);

            return result;
        }
    }
}
