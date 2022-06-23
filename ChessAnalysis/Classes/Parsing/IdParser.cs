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
			get => ParseConsts.ARGS_COUNT_ID;
		}

		protected override Components Component
		{
			get => Components.Id;
		}

		protected override string Delimiter
		{
			get => ParseConsts.ARGS_DELIMITER_QUOTES;
		}

		protected override string KeyWord
		{
			get => ParseConsts.ARG_ID;
		}

		public static string Parse(string input)
		{
			return new IdParser(input).Parse();
		}

		protected override string Parse()
		{
			if (string.IsNullOrWhiteSpace(Arguments[ParseConsts.ID_INDEX]))
			{
				throw new InvalidComponentsNumberException(Component);
			}

			return Arguments[ParseConsts.ID_INDEX];
		}
	}
}
