using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class BestMove
    {
        public BestMove(string input, bool isWhitePlayed)
        {
            if (input == Constants.ARG_NULL)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(input) || input.Length < Constants.BEST_MOVE_MIN_CHARS 
                || input.Length > Constants.BEST_MOVE_MAX_CHARS)
            {
                throw new InvalidComponentsNumberException(Components.BestMove);
            }

            if (!ProcessCastlingMove(input, isWhitePlayed))
            {
                ProcessRegularMove(input, isWhitePlayed);
            }
        }

        public Point Field { get; private set; } = new Point(-1, -1);

        public char Piece { get; private set; }

        public bool Equals(char piece, int x, int y)
        {
            return Piece == piece && Field.X == x && Field.Y == y;
        }

        private static Point GetField(char column, char row)
        {
            var y = row.AsFormatedDigit();

            if (!y.HasValue || !IsValidColumn(column))
            {
                throw new IncorrectFormatException(Components.BestMove);
            }

            return new Point(column.LetterOrdinal(), Constants.BOARD_SIZE - y.Value);
        }

        private static bool IsNonPawnPiece(char input)
        {
            return input == 'B' || input == 'K' || input == 'N' || input == 'Q' || input == 'R';
        }

        private static bool IsValidColumn(char input)
        {
            return input >= 'a' && input <= 'h';
        }

        private bool ProcessCastlingMove(string input, bool isWhitePlayed)
        {
            // expected input: O-O || O-O-O

            switch (input.Count(c => c == 'O'))
            {
                case 0: 
                    return false;

                case 2:
                    if (isWhitePlayed)
                    {
                        Field = new Point(6, 7);
                        Piece = 'K';

                        return true;
                    }

                    Field = new Point(6, 0);
                    Piece = 'k';

                    return true;

                case 3:
                    if (isWhitePlayed)
                    {
                        Field = new Point(2, 7);
                        Piece = 'K';

                        return true;
                    }

                    Field = new Point(2, 0);
                    Piece = 'k';

                    return true;

                default:
                    throw new InvalidComponentsNumberException(Components.BestMove);
            }
        }

        private void ProcessRegularMove(string input, bool isWhitePlayed)
        {
            // input: <[piece]> <[prevColumn || prevRow]> <[capture]> <[column]> <[row]> <[check || mate]>

            if (input.EndsWith('+') || input.EndsWith('#'))
            {
                input = input.RemoveLast();
            }

            // input: <[piece]> <[prevColumn || prevRow]> <[capture]> <[column]> <[row]>

            if (input.Length < 2)
            {
                throw new InvalidComponentsNumberException(Components.BestMove);
            }

            // input: <[piece]> <[prevColumn || prevRow]> <[capture]> [column] [row]

            Field = GetField(input[input.Length - 2], input[input.Length - 1]);

            input = input.RemoveLast(2);

            // input: <[piece]> <[prevColumn || prevRow]> <[capture]>

            if (string.IsNullOrEmpty(input))
            {
                Piece = isWhitePlayed ? 'P' : 'p';
                return;
            }

            // input: <[piece]> <[prevColumn || prevRow]> <[capture]>

            if (input.EndsWith('x'))
            {
                input = input.RemoveLast();
            }

            // input: <[piece]> <[prevColumn || prevRow]>

            if (string.IsNullOrEmpty(input))
            {
                throw new InvalidComponentsNumberException(Components.BestMove);
            }

            if (!char.IsLetter(input[0]))
            {
                throw new IncorrectFormatException(Components.BestMove);
            }

            // input: <[piece]> <[prevColumn || prevRow]>

            if (char.IsLower(input[0]))
            {
                // input: [prevColumn]

                if (!IsValidColumn(input[0]))
                {
                    throw new UnallowedCharactersException(Components.BestMove);
                }

                Piece = isWhitePlayed ? 'P' : 'p';
                return;
            }

            if (!IsNonPawnPiece(input[0]))
            {
                throw new IncorrectFormatException(Components.BestMove);
            }

            // input: [piece] <[prevColumn || prevRow]>

            Piece = isWhitePlayed ? input[0] : char.ToLower(input[0]);

            if (input.Length == 1)
            {
                return;
            }

            // input: [piece] [prevColumn || prevRow]

            if (char.IsDigit(input[1]))
            {
                // input: [piece] [prevRow]

                if (!input[1].AsFormatedDigit().HasValue)
                {
                    throw new UnallowedCharactersException(Components.BestMove);
                }

                return;
            }

            // input: [piece] [prevColumn]

            if (!IsValidColumn(input[1]))
            {
                throw new UnallowedCharactersException(Components.BestMove);
            }
        }
    }
}
