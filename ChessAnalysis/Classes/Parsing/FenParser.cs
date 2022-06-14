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

            for (var i = 0; i < Arguments.Length; i++)
            {
                result[i] = ParseRow(Arguments[i]);
            }

            return result;
        }

        private char[] ParseRow(string row)
        {
            var result = new char[ArgumentsCount];
            var x = 0;

            foreach (var item in row)
            {
                if (x >= ArgumentsCount)
                {
                    throw new InvalidComponentsNumberException(Component);
                }

                if (char.ToUpper(item).IsBoardPiece())
                {
                    result[x++] = item;
                    continue;
                }

                // Skip empty fields
                x += item.AsNumber(Component);
            }

            if (x < Constants.BOARD_SIZE)
            {
                throw new InvalidComponentsNumberException(Component);
            }

            return result;
        }
    }
}
