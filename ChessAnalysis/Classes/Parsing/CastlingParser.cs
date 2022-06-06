using ChessAnalysis.Models;

namespace ChessAnalysis.Classes
{
    public class CastlingParser : ParserBase<(Castling Black, Castling White)>
    {
        private CastlingParser(string input)
            : base(input)
        {
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
                        black = ExecuteOrOperation(black, Castling.King);
                        break;

                    case 'q':
                        black = ExecuteOrOperation(black, Castling.Queen);
                        break;

                    case 'K':
                        white = ExecuteOrOperation(white, Castling.King);
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

        private Castling ExecuteOrOperation(Castling input, Castling value)
        {
            if ((input & value) != Castling.None)
            {
                // Duplicate characters
                throw new UnallowedCharactersException(Component);
            }

            return input |= value;
        }
    }
}
