using ChessAnalysis.Properties;

namespace ChessAnalysis.Classes
{
    public class IncorrectFormatException : ExeptionBase
    {
        public IncorrectFormatException(Components component)
            : base(Resources.IncorrectFormat, component)
        {
        }
    }
}
