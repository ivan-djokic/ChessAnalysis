// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

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
			// input: c0 "[players]" "[result]" "[opening]" "[defense]"
			return new CommentParser(input).Parse();
		}

		protected override Comment Parse()
		{
			return new Comment(Arguments[ParseConsts.COMMENT_PLAYERS_INDEX],
				Arguments[ParseConsts.COMMENT_RESULT_INDEX],
				Arguments[ParseConsts.COMMENT_OPENING_INDEX],
				Arguments[ParseConsts.COMMENT_DEFENSE_INDEX]);
		}
	}
}
