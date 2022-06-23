﻿using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public abstract class ParserBase<T>
	{
		private string[] m_arguments = Array.Empty<string>();
		protected string m_input;

		protected ParserBase(string input)
		{
			m_input = input.Trim();
		}

		protected virtual int ArgumentsCount { get; }

		protected string[] Arguments 
		{ 
			get
			{
				if (!m_arguments.Any())
				{
					m_arguments = GetArguments();
				}

				return m_arguments;
			}
		}

		protected abstract Components Component { get; }

		protected virtual string Delimiter
		{
			get => string.Empty;
		}

		protected virtual string KeyWord 
		{
			get => string.Empty;
		}

		protected abstract T Parse();

		private string[] GetArguments()
		{
			if (!m_input.StartsWith(KeyWord))
			{
				throw new IncorrectFormatException(Component);
			}

			var arguments = m_input.Split(Delimiter);

			if (arguments.Length != ArgumentsCount)
			{
				throw new InvalidComponentsNumberException(Component);
			}

			if (Delimiter == ParseConsts.ARGS_DELIMITER_QUOTES)
			{
				for (var i = 1; i < ArgumentsCount; i++)
				{
					if (!arguments[i].EndsWith(ParseConsts.QUOTES))
					{
						throw new UnallowedCharactersException(Component);
					}

					arguments[i] = arguments[i].RemoveLast();
				}
			}

			return arguments;
		}
	}
}
