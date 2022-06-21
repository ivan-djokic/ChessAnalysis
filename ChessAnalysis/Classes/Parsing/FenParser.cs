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
            return Arguments.Select(row => ParseRow(row)).ToArray();
        }

        private char[] ParseRow(string input)
        {
            var result = new char[ArgumentsCount];
            var count = 0;

            foreach (var item in input)
            {
                if (count >= ArgumentsCount)
                {
                    throw new InvalidComponentsNumberException(Component);
                }

                if (char.ToUpper(item).IsBoardPiece())
                {
                    result[count++] = item;
                    continue;
                }

                // Skip empty fields
                count += item.AsNumber(Component);
            }

            if (count != ArgumentsCount)
            {
                throw new InvalidComponentsNumberException(Component);
            }

            return result;
        }
    }
}
