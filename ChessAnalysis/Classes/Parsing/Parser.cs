using ChessAnalysis.Models;

namespace ChessAnalysis.Classes
{
    public class Parser : ParserBase<Data>
    {
        private Parser(string input)
            : base(input)
        {
        }

        protected override int ArgumentsCount
        {
            get => ParserConsts.ARGS_COUNT_DATA;
        }

        protected override Components Component
        {
            get => Components.Data;
        }

        protected override string Delimiter
        {
            get => ParserConsts.ARGS_DELIMITER_SEMICOLON;
        }

        public static Data Parse(string input)
        {
            // input: [POSITION]; id "[ID]"; c0 [COMMENT]
            return new Parser(input).Parse();
        }

        protected override Data Parse()
        {
            return new Data
            {
                Comment = CommentParser.Parse(Arguments[ParserConsts.DATA_COMMENT_INDEX]),
                Id = IdParser.Parse(Arguments[ParserConsts.DATA_ID_INDEX]),
                Input = m_input,
                Position = PositionParser.Parse(Arguments[ParserConsts.DATA_POSITION_INDEX])
            };
        }
    }
}
