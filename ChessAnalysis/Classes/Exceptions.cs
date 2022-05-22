using ChessAnalysis.Properties;

namespace ChessAnalysis.Classes
{
    public enum Components
    {
        BestMove,
        Castling,
        Comment,
        FEN,
        HalfMoves,
        Id,
        Data,
        NextPlayer,
        Position,
        Round
    }

    public class IncorrectFormatException : Exception
    {
        public IncorrectFormatException(Components component)
            : base(string.Format(Strings.IncorrectFormat, component))
        {
        }
    }

    public class InvalidComponentsNumberException : Exception
    {
        public InvalidComponentsNumberException(Components component)
            : base(string.Format(Strings.InvalidComponentsNumber, component))
        {
        }
    }

    public class UnallowedCharactersException : Exception
    {
        public UnallowedCharactersException(Components component)
            : base(string.Format(Strings.UnallowedCharactersDetected, component))
        {
        }
    }
}
