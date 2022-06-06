using ChessAnalysis.Models;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class NextPlayerParser : ParserBase<NextPlayer>
    {
        private NextPlayerParser(string input)
            : base(input)
        {
        }

        protected override int ArgumentsCount
        {
            get => ParseConsts.ARGS_COUNT_NEXT_PLAYER;
        }

        protected override Components Component
        {
            get => Components.NextPlayer;
        }

        public static NextPlayer Parse(string input)
        {
            return new NextPlayerParser(input).Parse();
        }

        protected override NextPlayer Parse()
        {
            if (m_input.Length != ArgumentsCount)
            {
                throw new InvalidComponentsNumberException(Component);
            }

            return m_input[0] switch
            {
                Constants.PLAYER_BLACK => NextPlayer.Black,
                Constants.PLAYER_WHITE => NextPlayer.White,
                _ => throw new UnallowedCharactersException(Component)
            };
        }
    }
}
