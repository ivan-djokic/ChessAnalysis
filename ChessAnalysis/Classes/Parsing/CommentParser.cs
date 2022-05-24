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
            get => ParseConsts.ARGS_COUNT_COMMENT;
        }

        protected override Components Component
        {
            get => Components.Comment;
        }

        protected override string Delimiter
        {
            get => ParseConsts.ARGS_DELIMITER_QUOTES;
        }

        protected override string KeyWord
        {
            get => ParseConsts.ARG_COMMENT;
        }

        public static Comment Parse(string input)
        {
            // input: c0 "[players]" "[timestamp]" "[opening]" "[defense]"
            return new CommentParser(input).Parse();
        }

        protected override Comment Parse()
        {
            var players = ParseQuotesInput(Arguments[ParseConsts.COMMENT_PLAYERS_INDEX]);
            var timestamp = ParseQuotesInput(Arguments[ParseConsts.COMMENT_TIMESTAMP_INDEX]);
            var opening = ParseQuotesInput(Arguments[ParseConsts.COMMENT_OPENING_INDEX]);
            var defense = ParseQuotesInput(Arguments[ParseConsts.COMMENT_DEFENSE_INDEX]);

            return new Comment(players, timestamp, opening, defense);
        }
    }
}
