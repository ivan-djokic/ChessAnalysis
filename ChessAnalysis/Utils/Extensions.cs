using ChessAnalysis.Classes;

namespace ChessAnalysis.Utils
{
    public static class Extensions
    {
        public static int? AsFormatedDigit(this char input)
        {
            if (!char.IsDigit(input) || input == '0' || input == '9')
            {
                return null;
            }

            return input - '0';
        }

        public static int AsNumber(this string input, Components component)
        {
            try
            {
                return int.Parse(input);
            }
            catch
            {
                throw new UnallowedCharactersException(component);
            }
        }

        public static string AsString(this int input)
        {
            return ((char)input).ToString();
        }

        public static bool IsEven(this int input)
        {
            return input % 2 == 0;
        }

        public static int LetterOrdinal(this char input)
        {
            if (!char.IsLetter(input))
            {
                return -1;
            }

            return input - 'a';
        }

        public static string RemoveFirst(this string input, int count = 1)
        {
            return input.Substring(count);
        }

        public static string RemoveLast(this string input, int count = 1)
        {
            return input.Remove(input.Length - count);
        }
    }
}
