using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class EnPassantParser : ParserBase<string>
    {
        private EnPassantParser(string input)
            : base(input)
        {
        }

        protected override int ArgumentsCount
        {
            get => ParseConsts.ARGS_COUNT_EN_PASSANT;
        }

        protected override Components Component
        {
            get => Components.EnPassant;
        }

        public static string Parse(string input)
        {
            return new EnPassantParser(input).Parse();
        }

        protected override string Parse()
        {
            if (m_input == ParseConsts.ARG_NULL)
            {
                return string.Empty;
            }

            if (m_input.Length != ArgumentsCount)
            {
                throw new InvalidComponentsNumberException(Component);
            }

            if (!m_input[0].IsBoardColumn() || !ParseConsts.ALLOWED_EN_PASSANT_ROWS.Contains(m_input[1]))
            {
                throw new UnallowedCharactersException(Component);
            }

            return m_input;
        }
    }
}
