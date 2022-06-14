using ChessAnalysis.Models;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class BestMoveParser : ParserBase<BestMove>
    {
        private readonly bool m_isWhitePlayed;

        private BestMoveParser(string input, bool isWhitePlayed)
            : base(input)
        {
            m_isWhitePlayed = isWhitePlayed;
        }

        protected override Components Component
        {
            get => Components.BestMove;
        }

        public static BestMove Parse(string input, bool isWhitePlayed)
        {
            return new BestMoveParser(input, isWhitePlayed).Parse();
        }

        protected override BestMove Parse()
        {
            if (m_input == ParseConsts.ARG_NULL)
            {
                return new BestMove(string.Empty, Constants.EMPTY_CHAR, new Point(-1, -1));
            }

            return ParseCastlingMove() ?? ProcessRegularMove();
        }

        private BestMove CreateCastlingMove(int column)
        {
            if (m_isWhitePlayed)
            {
                return new BestMove(m_input, 'K', new Point(column, Constants.BOARD_SIZE - 1));
            }

            return new BestMove(m_input, 'k', new Point(column, 0));
        }

        private Point GetField()
        {
            return new Point(m_input[^2].AsBoardColumn(Component), m_input[^1].AsNumber(Component).AsBoardRow());
        }

        private char GetPiece(char input)
        {
            return m_isWhitePlayed ? input : char.ToLower(input);
        }

        private BestMove? ParseCastlingMove()
        {
            // expected input: O-O || O-O-O
            var parts = m_input.Split("O-");

            switch (parts.Length)
            {
                case 1:
                    return null;

                case 2:
                    if (!string.IsNullOrEmpty(parts[0]) || parts[1] != "O")
                    {
                        throw new UnallowedCharactersException(Component);
                    }

                    return CreateCastlingMove(6);

                case 3:
                    if (!string.IsNullOrEmpty(parts[0]) || !string.IsNullOrEmpty(parts[1]) || parts[2] != "O")
                    {
                        throw new UnallowedCharactersException(Component);
                    }

                    return CreateCastlingMove(2);

                default:
                    throw new InvalidComponentsNumberException(Component);
            }
        }

        private BestMove ProcessRegularMove()
        {
            // input: <[prevColumn] || ([piece]> <[prevColumn || prevRow]>)> <[capture]> [column] [row] <[check || mate]>
            ValidateArgumentsCount(2, 6);

            var input = m_input;

            if (m_input.EndsWith('+') || m_input.EndsWith('#'))
            {
                m_input = m_input.RemoveLast();
            }

            // input: <[prevColumn] || ([piece]> <[prevColumn || prevRow]>)> <[capture]> [column] [row]
            ValidateArgumentsCount(2, 5, false);

            var result = new BestMove(input, GetPiece(Constants.PAWN), GetField());
            m_input = m_input.RemoveLast(2);

            // input: <[prevColumn] || ([piece]> <[prevColumn || prevRow]>)> <[capture]>

            if (string.IsNullOrEmpty(m_input))
            {
                return result;
            }

            // input: [prevColumn] || ([piece]> <[prevColumn || prevRow]>) <[capture]>

            var capture = m_input.EndsWith('x');

            if (capture)
            {
                m_input = m_input.RemoveLast();
            }

            // input: [prevColumn] || ([piece]> <[prevColumn || prevRow]>)
            ValidateArgumentsCount(1, 2, false);

            if (m_input[0].IsBoardColumn())
            {
                // input: [prevColumn]
                ValidateArgumentsCount(1, 1);

                if (!capture)
                {
                    throw new UnallowedCharactersException(Component);
                }

                return result;
            }

            // input: [piece] <[prevColumn || prevRow]>

            if (!m_input[0].IsBoardPiece() || m_input[0] == Constants.PAWN)
            {
                throw new UnallowedCharactersException(Component);
            }

            result.Piece = GetPiece(m_input[0]);
            m_input = m_input[1..];

            // input: <[prevColumn || prevRow]>

            if (!string.IsNullOrEmpty(m_input) && !(m_input[0].IsBoardRow() || m_input[0].IsBoardColumn()))
            {
                throw new UnallowedCharactersException(Component);
            }

            return result;
        }

        private void ValidateArgumentsCount(int minCount, int maxCount, bool countException = true)
        {
            if (m_input.Length < minCount || m_input.Length > maxCount)
            {
                throw countException ? 
                    new InvalidComponentsNumberException(Component) : new UnallowedCharactersException(Component);
            }
        }
    }
}
