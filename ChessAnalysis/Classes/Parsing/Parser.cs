// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

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

		public static string[] GetArguments(string input)
		{
			return new Parser(input).Arguments;
		}

		public static Data Parse(string input)
		{
			// input: [POSITION]; id "[ID]"; c0 [COMMENT]
			return new Parser(input).Parse();
		}

		protected override Data Parse()
		{
			return new Data(m_input,
				PositionParser.Parse(Arguments[ParseConsts.DATA_POSITION_INDEX]),
				IdParser.Parse(Arguments[ParseConsts.DATA_ID_INDEX]),
				CommentParser.Parse(Arguments[ParseConsts.DATA_COMMENT_INDEX]));
		}
	}
}
