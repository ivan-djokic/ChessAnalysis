using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public enum NextPlayer
    {
        Black,
        White
    }

    public class Position
    {
        public Position(string input)
        {
            // input: [FEN] [nextPlayer] [castling] [enPasant] [halfMoves] [round] bm [BM]

            var arguments = new Parser(Components.Position).Split(input);

            BestMove = arguments[Constants.POSITION_BEST_MOVE_INDEX];
            Castling = arguments[Constants.POSITION_CASTLING_INDEX];
            EnPassant = arguments[Constants.POSITION_EN_PASSANT_INDEX];
            Fen = arguments[Constants.POSITION_FEN_INDEX];
            HalfMoves = arguments[Constants.POSITION_HALF_MOVES_INDEX].AsNumber(Components.HalfMoves);
            Round = arguments[Constants.POSITION_ROUND_INDEX].AsNumber(Components.Round);
            NextPlayer = ParseNextPlayer(arguments[Constants.POSITION_NEXT_PLAYER_INDEX]);
        }

        public string BestMove { get; set; }

        public string Castling { get; set; }

        public string EnPassant { get; set; }

        public string Fen { get; set; }

        public int HalfMoves { get; set; }

        public NextPlayer NextPlayer { get; set; }

        public int Round { get; set; }

        public bool IsWhitePlayed()
        {
            return NextPlayer == NextPlayer.Black;
        }

        private static NextPlayer ParseNextPlayer(string input)
        {
            if (input.Length != 1)
            {
                throw new InvalidComponentsNumberException(Components.NextPlayer);
            }

            return input[0] switch
            {
                Constants.PLAYER_BLACK => NextPlayer.Black,
                Constants.PLAYER_WHITE => NextPlayer.White,
                _ => throw new UnallowedCharactersException(Components.NextPlayer)
            };
        }
    }
}
