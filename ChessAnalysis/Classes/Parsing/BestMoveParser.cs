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
            if (m_input == ParserConsts.ARG_NULL)
            {
                return new BestMove();
            }

            if (m_input.Length < ParserConsts.ARGS_COUNT_MIN_BEST_MOVE || m_input.Length > ParserConsts.ARGS_COUNT_MAX_BEST_MOVE)
            {
                throw new InvalidComponentsNumberException(Component);
            }

            var result = ParseCastlingMove();

            if (result != null)
            {
                return result;
            }

            return ProcessRegularMove();
        }

        private Point GetField()
        {
            if (m_input.Length < 2)
            {
                throw new InvalidComponentsNumberException(Component);
            }

            var x = m_input[m_input.Length - 2];
            var y = m_input[m_input.Length - 1].AsFormatedDigit();

            if (!y.HasValue || !IsValidColumn(x))
            {
                throw new IncorrectFormatException(Component);
            }

            return new Point(x.LetterOrdinal(), Constants.BOARD_SIZE - y.Value);
        }

        private static bool IsNonPawnPiece(char input)
        {
            return input == 'B' || input == 'K' || input == 'N' || input == 'Q' || input == 'R';
        }

        private static bool IsValidColumn(char input)
        {
            return input >= 'a' && input <= 'h';
        }

        private BestMove ParseCastling(int column)
        {
            if (m_isWhitePlayed)
            {
                return new BestMove
                {
                    Field = new Point(column, Constants.BOARD_SIZE - 1),
                    Piece = 'K',
                    Value = m_input
                };
            }

            return new BestMove
            {
                Field = new Point(6, 0),
                Piece = 'k',
                Value = m_input
            };
        }

        private BestMove? ParseCastlingMove()
        {
            // expected input: O-O || O-O-O

            return m_input.Count(c => c == 'O') switch
            {
                0 => null,
                2 => ParseCastling(6),
                3 => ParseCastling(2),
                _ => throw new InvalidComponentsNumberException(Component),
            };
        }

        private BestMove ProcessRegularMove()
        {
            // TODO: add to constants
            var result = new BestMove
            {
                Piece = m_isWhitePlayed ? 'P' : 'p',
                Value = m_input
            };

            // input: <[piece]> <[prevColumn || prevRow]> <[capture]> [column] [row] <[check || mate]>

            if (m_input.EndsWith('+') || m_input.EndsWith('#'))
            {
                m_input = m_input.RemoveLast();
            }

            // input: <[piece]> <[prevColumn || prevRow]> <[capture]> [column] [row]

            result.Field = GetField();

            m_input = m_input.RemoveLast(2);

            // input: <[piece]> <[prevColumn || prevRow]> <[capture]>

            if (string.IsNullOrEmpty(m_input))
            {
                return result;
            }

            // input: <[piece]> <[prevColumn || prevRow]> <[capture]>

            if (m_input.EndsWith('x'))
            {
                m_input = m_input.RemoveLast();
            }

            // input: <[piece]> <[prevColumn || prevRow]>

            if (string.IsNullOrEmpty(m_input))
            {
                throw new InvalidComponentsNumberException(Component);
            }

            if (!char.IsLetter(m_input[0]))
            {
                throw new IncorrectFormatException(Component);
            }

            // input: [piece] || <[prevColumn || prevRow]>


            // TODO: check this, maybe there is prevRow
            if (char.IsLower(m_input[0]))
            {
                // input: [prevColumn]

                if (!IsValidColumn(m_input[0]))
                {
                    throw new UnallowedCharactersException(Component);
                }

                return result;
            }

            if (!IsNonPawnPiece(m_input[0]))
            {
                throw new IncorrectFormatException(Component);
            }

            // input: [piece] <[prevColumn || prevRow]>

            result.Piece = m_isWhitePlayed ? m_input[0] : char.ToLower(m_input[0]);

            if (m_input.Length > 1)
            {
                ValidatePreviousCoord(m_input[1]);
            }
            
            return result;
        }

        private void ValidatePreviousCoord(char input)
        {
            // input: [prevColumn || prevRow]

            if (char.IsDigit(input))
            {
                // input: [prevRow]

                if (!input.AsFormatedDigit().HasValue)
                {
                    throw new UnallowedCharactersException(Component);
                }

                return;
            }

            // input: [prevColumn]

            if (!IsValidColumn(input))
            {
                throw new UnallowedCharactersException(Component);
            }
        }
    }
}
