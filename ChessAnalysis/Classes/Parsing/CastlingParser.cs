// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Models;

namespace ChessAnalysis.Classes
{
	public class CastlingParser : ParserBase<(Castling Black, Castling White)>
	{
		private CastlingParser(string input)
			: base(input)
		{
		}

		protected override int ArgumentsCount
		{
			get => ParseConsts.ARGS_COUNT_CASTLING;
		}

		protected override Components Component
		{
			get => Components.Castling;
		}

		public static (Castling Black, Castling White) Parse(string input)
		{
			return new CastlingParser(input).Parse();
		}

		protected override (Castling Black, Castling White) Parse()
		{
			if (m_input.Length < ArgumentsCount)
			{
				throw new InvalidComponentsNumberException(Component);
			}

			var black = Castling.None;
			var white = Castling.None;

			if (m_input == ParseConsts.ARG_NULL)
			{
				return (black, white);
			}

			foreach (var item in m_input)
			{
				switch (item)
				{
					case 'k':
						black = ExecuteOrOperation(black, Castling.King, Castling.Queen);
						break;

					case 'q':
						black = ExecuteOrOperation(black, Castling.Queen);
						break;

					case 'K':
						white = ExecuteOrOperation(white, Castling.King, Castling.Queen);
						break;

					case 'Q':
						white = ExecuteOrOperation(white, Castling.Queen);
						break;

					default:
						throw new UnallowedCharactersException(Component);
				}
			}

			return (black, white);
		}

		private static bool Contains(Castling input, Castling value)
		{
			return (input & value) == value;
		}

		private Castling ExecuteOrOperation(Castling input, Castling value, Castling? prevValue = null)
		{
			// Remove Castling.None value
			input &= ~Castling.None;

			if (Contains(input, value) || prevValue.HasValue && Contains(input, prevValue.Value))
			{
				// Duplicate characters or incorent order
				throw new IncorrectFormatException(Component);
			}

			return input | value;
		}
	}
}
