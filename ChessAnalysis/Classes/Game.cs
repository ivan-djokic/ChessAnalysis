using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class Game
    {
        public Game(string input)
        {
            // input: c0 "players" "timestamp" "opening" "defense"

            var arguments = input.Split(Constants.ARG_DELIMITER_WITHOUT_QUOTES);

            if (arguments.Length != Constants.ARG_GAME_ARGS_COUNT)
            {
                throw new InvalidComponentsNumberException(Components.Comment);
            }

            Defense = ProcessString(arguments[Constants.GAME_DEFENSE_INDEX]);
            Opening = ProcessString(arguments[Constants.GAME_OPENING_INDEX]);
            Players = ProcessString(arguments[Constants.GAME_PLAYERS_INDEX]);
            Timestamp = ProcessString(arguments[Constants.GAME_TIMESTAMP_INDEX]);
        }

        public string Defense { get; set; }

        public string Opening { get; set; }

        public string Players { get; set; }

        public string Timestamp { get; set; }

        private static string ProcessString(string input)
        {
            if (!input.EndsWith(Constants.QUOTES))
            {
                throw new UnallowedCharactersException(Components.Comment);
            }

            return input.RemoveLast();
        }
    }
}
