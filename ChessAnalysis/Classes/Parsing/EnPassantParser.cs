using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class EnPassantParser : ParserBase<string>
    {
        private readonly bool m_isWhitePlayed;

        private EnPassantParser(string input, bool isWhitePlayed)
            : base(input)
        {
            m_isWhitePlayed = isWhitePlayed;
        }

        protected override int ArgumentsCount
        {
            get => ParseConsts.ARGS_COUNT_EN_PASSANT;
        }

        protected override Components Component
        {
            get => Components.EnPassant;
        }

        public static string Parse(string input, bool isWhitePlayed)
        {
            return new EnPassantParser(input, isWhitePlayed).Parse();
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

            if (!m_input[0].IsBoardColumn() || m_input[1] != ParseConsts.ALLOWED_EN_PASSANT_ROWS[Convert.ToInt32(m_isWhitePlayed)])
            {
                throw new UnallowedCharactersException(Component);
            }

            return m_input;
        }
    }
}
