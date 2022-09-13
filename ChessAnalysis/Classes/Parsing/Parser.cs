// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Models;
using ChessAnalysis.Utils;

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
			get => ParseConsts.ARGS_COUNT_DATA;
		}

		protected override Components Component
		{
			get => Components.Data;
		}

		protected override string Delimiter
		{
			get => ParseConsts.ARGS_DELIMITER_SEMICOLON;
		}

		private string[] ShortArguments
		{
			get => new[]
			{
				$"{m_input} {ParseConsts.ARG_BEST_MOVE} {ParseConsts.ARG_NULL}"
			};
		}

		public static string[] GetArguments(string input)
		{
			var parser = new Parser(input);

			try
			{
				return parser.Arguments;
			}
			catch
			{
				if (!Options.Instance.ShortComment)
				{
					throw;
				}
			}

			return parser.ShortArguments;
		}

		public static Data Parse(string input)
		{
			// input: [POSITION]; id "[ID]"; c0 [COMMENT]
			return new Parser(input).Parse();
		}

		protected override Data Parse()
		{
			try
			{
				return new Data(m_input,
					PositionParser.Parse(Arguments[ParseConsts.DATA_POSITION_INDEX]),
					IdParser.Parse(Arguments[ParseConsts.DATA_ID_INDEX]),
					GetComment());
			}
			catch
			{
				if (!Options.Instance.ShortFen)
				{
					throw;
				}
			}

			return GetShortData();
		}

		private Comment GetComment()
		{
			try
			{
				return CommentParser.Parse(Arguments[ParseConsts.DATA_COMMENT_INDEX]);
			}
			catch
			{
				if (!Options.Instance.ShortComment)
				{
					throw;
				}
			}

			return ShortCommentParser.Parse(Arguments[ParseConsts.DATA_COMMENT_INDEX]);
		}

		private Data GetShortData()
		{
			return new Data(m_input,
				PositionParser.Parse(ShortArguments[ParseConsts.DATA_POSITION_INDEX]),
				Guid.NewGuid().Short(),
				new Comment());
		}
	}
}
