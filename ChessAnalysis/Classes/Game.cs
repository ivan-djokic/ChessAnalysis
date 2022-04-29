using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class Game
    {
        public Game(string input)
        {
            // input: c0 "players" "timestamp" "opening" "defense"

            var parser = new Parser(Components.Comment);
            var arguments = parser.Split(input);

            Defense = parser.ParseQuotesInput(arguments[Constants.GAME_DEFENSE_INDEX]);
            Opening = parser.ParseQuotesInput(arguments[Constants.GAME_OPENING_INDEX]);
            Players = parser.ParseQuotesInput(arguments[Constants.GAME_PLAYERS_INDEX]);
            Timestamp = parser.ParseQuotesInput(arguments[Constants.GAME_TIMESTAMP_INDEX]);
        }

        public string Defense { get; set; }

        public string Opening { get; set; }

        public string Players { get; set; }

        public string Timestamp { get; set; }
    }
}
