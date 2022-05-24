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
            var board = FenParser.Parse(Arguments[ParseConsts.POSITION_FEN_INDEX]);
            var nextPlayer = NextPlayerParser.Parse(Arguments[ParseConsts.POSITION_NEXT_PLAYER_INDEX]);
            var enPassant = EnPassantParser.Parse(Arguments[ParseConsts.POSITION_EN_PASSANT_INDEX]);
            (var blackCastling, var whiteCastling) = CastlingParser.Parse(Arguments[ParseConsts.POSITION_CASTLING_INDEX]);
            var halfMoves = Arguments[ParseConsts.POSITION_HALF_MOVES_INDEX].AsNumber(Components.HalfMoves);
            var round = Arguments[ParseConsts.POSITION_ROUND_INDEX].AsNumber(Components.Round);
            var bestMove = BestMoveParser.Parse(Arguments[ParseConsts.POSITION_BEST_MOVE_INDEX], nextPlayer == NextPlayer.Black);

            return new Position(board, nextPlayer, blackCastling, whiteCastling, enPassant, halfMoves, round, bestMove);
        }
    }
}
