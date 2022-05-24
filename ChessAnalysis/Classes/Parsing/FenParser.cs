using ChessAnalysis.Models;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class FenParser : ParserBase<char[][]>
    {
        private FenParser(string input)
            : base(input)
        {
        }

        protected override int ArgumentsCount
        {
            get => Constants.BOARD_SIZE;
        }

        protected override Components Component
        {
            get => Components.Fen;
        }

        protected override string Delimiter
        {
            get => ParseConsts.ARGS_DELIMITER_SLASH;
        }

        public static char[][] Parse(string input)
        {
            return new FenParser(input).Parse();
        }

        protected override char[][] Parse()
        {
            var result = new char[ArgumentsCount][];

            for (var y = 0; y < Arguments.Length; y++)
            {
                result[y] = ParseRow(Arguments[y]);
            }

            return result;
        }

        private char[] ParseRow(string row)
        {
            var result = new char[ArgumentsCount];
            var x = 0;

            for (var i = 0; i < row.Length; i++)
            {
                if (x >= ArgumentsCount)
                {
                    throw new InvalidComponentsNumberException(Component);
                }

                if (char.ToUpper(row[i]).IsBoardPiece())
                {
                    result[x++] = row[i];
                    continue;
                }

                // Skip empty fields
                x += row[i].AsNumber(Component);
            }

            if (x < Constants.BOARD_SIZE)
            {
                throw new InvalidComponentsNumberException(Component);
            }

            return result;
        }
    }
}
