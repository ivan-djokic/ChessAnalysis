using ChessAnalysis.Properties;

namespace ChessAnalysis.Classes
{
    public enum Components
    {
        BM, // Best Move
        Comment,
        FEN,
        HalfMoves,
        Id,
        Input,
        NextPlayer,
        Position,
        Round
    }

    public class IncorrectFormatException : Exception
    {
        public IncorrectFormatException()
            : base(Strings.IncorrectFormat)
        {
        }
    }

    public class InvalidComponentsNumberException : Exception
    {
        public InvalidComponentsNumberException(Components field)
            : base(string.Format(Strings.InvalidComponentsNumber, field))
        {
        }
    }

    public class UnallowedCharactersException : Exception
    {
        public UnallowedCharactersException(Components field)
            : base(string.Format(Strings.UnallowedCharactersDetected, field))
        {
        }
    }
}
