using ChessAnalysis.Models;

namespace ChessAnalysis.Classes
{
    public class CommentParser : ParserBase<Comment>
    {
        private CommentParser(string input)
            : base(input)
        {
        }

        protected override int ArgumentsCount
        {
            get => ParserConsts.ARGS_COUNT_COMMENT;
        }

        protected override Components Component
        {
            get => Components.Comment;
        }

        protected override string Delimiter
        {
            get => ParserConsts.ARGS_DELIMITER_QUOTES;
        }

        protected override string KeyWord
        {
            get => ParserConsts.ARG_COMMENT;
        }

        public static Comment Parse(string input)
        {
            // input: c0 "[players]" "[timestamp]" "[opening]" "[defense]"
            return new CommentParser(input).Parse();
        }

        protected override Comment Parse()
        {
            return new Comment
            {
                Defense = ParseQuotesInput(Arguments[ParserConsts.COMMENT_DEFENSE_INDEX]),
                Opening = ParseQuotesInput(Arguments[ParserConsts.COMMENT_OPENING_INDEX]),
                Players = ParseQuotesInput(Arguments[ParserConsts.COMMENT_PLAYERS_INDEX]),
                Timestamp = ParseQuotesInput(Arguments[ParserConsts.COMMENT_TIMESTAMP_INDEX])
            };
        }
    }
}
