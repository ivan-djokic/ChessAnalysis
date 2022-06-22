using ChessAnalysis.Properties;

namespace ChessAnalysis.Classes
{
    public class InvalidComponentsNumberException : ExeptionBase
    {
        public InvalidComponentsNumberException(Components component)
            : base(Resources.InvalidComponentsNumber, component)
        {
        }
    }
}
