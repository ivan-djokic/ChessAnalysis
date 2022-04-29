using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class InputData
    {
        public InputData(string input)
        {
            // input: [POSITION]; id "[ID]"; c0 [COMMENT]

            var parser = new Parser(Components.InputData);
            var arguments = parser.Split(input);

            Game = new Game(arguments[Constants.INPUT_DATA_GAME_INDEX]);
            Id = ParseId(arguments[Constants.INPUT_DATA_ID_INDEX]);
            Position = new Position(arguments[Constants.INPUT_DATA_POSITION_INDEX]);
        }

        public Game Game { get; set; }

        public string Id { get; set; }

        public Position Position { get; set; }

        private static string ParseId(string input)
        {
            var parser = new Parser(Components.Id);
            
            var result = parser.ParseQuotesInput(parser.Split(input)[Constants.ID_INDEX]);

            if (!string.IsNullOrEmpty(result))
            {
                return result;
            }

            throw new InvalidComponentsNumberException(Components.Id);
        }
    }
}
