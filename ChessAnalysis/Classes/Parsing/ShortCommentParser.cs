// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Models;

namespace ChessAnalysis.Classes
{
	public class ShortCommentParser : ParserBase<Comment>
	{
		private ShortCommentParser(string input)
			: base(input)
		{
		}

		protected override int ArgumentsCount
		{
			get => ParseConsts.ARGS_COUNT_COMMENT_SHORT;
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
			// input: c0 "<[players]>, <[result]>, <[opening]>, <[defense]>"
			return new ShortCommentParser(input).Parse();
		}

		protected override Comment Parse()
		{
			var arguments = PostProcessArguments();

			return new Comment(arguments[ParseConsts.COMMENT_PLAYERS_INDEX],
				arguments[ParseConsts.COMMENT_RESULT_INDEX],
				arguments[ParseConsts.COMMENT_OPENING_INDEX],
				arguments[ParseConsts.COMMENT_DEFENSE_INDEX]);
		}

		private string[] PostProcessArguments()
		{
			var arguments = new string[5];
			arguments[0] = KeyWord;

			var i = 1;

			foreach (var arg in Arguments.Last().Split(ParseConsts.ARGS_DELIMITER_COMA))
			{
				if (i > arguments.Length - 1)
				{
					// More than 4 arguments
					break;
				}	

				arguments[i++] = arg;
			}

			return arguments;
		}
	}
}
