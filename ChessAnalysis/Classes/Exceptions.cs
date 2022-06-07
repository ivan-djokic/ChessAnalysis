using ChessAnalysis.Properties;

namespace ChessAnalysis.Classes
{
    public enum Components
    {
        BestMove,
        Castling,
        Comment,
        Data,
        EnPassant,
        Fen,
        HalfMoves,
        Id,
        NextPlayer,
        Position,
        Round
    }

    public abstract class ExeptionBase : Exception
    {
        protected ExeptionBase(string message, Components component)
           : base(string.Format(message, component))
        {
            Component = component;
        }

        public Components Component { get; }
    }

    public class NotUniqueIdException : ExeptionBase
    {
        public NotUniqueIdException(string id)
            : base(string.Format(Strings.DataSourceContainsId, id), Components.Id)
        {
        }
    }

    public class IncorrectFormatException : ExeptionBase
    {
        public IncorrectFormatException(Components component)
            : base(Strings.IncorrectFormat, component)
        {
        }
    }

    public class InvalidComponentsNumberException : ExeptionBase
    {
        public InvalidComponentsNumberException(Components component)
            : base(Strings.InvalidComponentsNumber, component)
        {
        }
    }

    public class UnallowedCharactersException : ExeptionBase
    {
        public UnallowedCharactersException(Components component)
            : base(Strings.UnallowedCharactersDetected, component)
        {
        }
    }
}
