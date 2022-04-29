using ChessAnalysis.Classes;

namespace ChessAnalysis.Utils
{
    public class Parser
    {
        private readonly Components m_component;

        public Parser(Components component)
        {
            m_component = component;
        }

        public string ParseQuotesInput(string input)
        {
            if (!input.EndsWith(Constants.QUOTES))
            {
                throw new UnallowedCharactersException(m_component);
            }

            return input.RemoveLast();
        }

        public string[] Split(string input)
        {
            return m_component switch
            {
                Components.Comment => Split(input, Constants.ARGS_DELIMITER_QUOTES, Constants.ARGS_COUNT_GAME, Constants.ARG_COMMENT),
                Components.Id => Split(input, Constants.ARGS_DELIMITER_QUOTES, Constants.ARGS_COUNT_ID, Constants.ARG_ID),
                Components.InputData => Split(input, Constants.ARGS_DELIMITER_SEMICOLON, Constants.ARGS_COUNT_INPUT_DATA),
                Components.Position => Split(input, Constants.ARGS_DELIMITER_SPACE, Constants.ARGS_COUNT_POSITION),
                _ => Array.Empty<string>()
            };
        }

        private string[] Split(string input, string delimiter, int expectedCount, string validator = "")
        {
            if (!string.IsNullOrEmpty(validator) && !input.StartsWith(validator))
            {
                throw new IncorrectFormatException(m_component);
            }

            var arguments = input.Split(delimiter);

            if (arguments.Length == expectedCount)
            {
                return arguments;
            }

            throw new InvalidComponentsNumberException(m_component);
        }
    }
}
