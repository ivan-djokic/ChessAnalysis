namespace ChessAnalysis.Classes
{
    public class IdParser : ParserBase<string>
    {
        private IdParser(string input)
            : base(input)
        {
        }

        protected override int ArgumentsCount
        {
            get => ParserConsts.ARGS_COUNT_ID;
        }

        protected override Components Component
        {
            get => Components.Id;
        }

        protected override string Delimiter
        {
            get => ParserConsts.ARGS_DELIMITER_QUOTES;
        }

        protected override string KeyWord
        {
            get => ParserConsts.ARG_ID;
        }

        public static string Parse(string input)
        {
            return new IdParser(input).Parse();
        }

        protected override string Parse()
        {
            var result = ParseQuotesInput(Arguments[ParserConsts.ID_INDEX]);

            if (string.IsNullOrEmpty(result))
            {
                throw new InvalidComponentsNumberException(Component);
            }

            return result;
        }
    }
}
