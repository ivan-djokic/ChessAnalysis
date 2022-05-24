using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public abstract class ParserBase<T>
    {
        private string[] m_arguments;
        protected string m_input;

        protected ParserBase(string input)
        {
            m_input = input.Trim();
        }

        protected virtual int ArgumentsCount { get; }

        protected string[] Arguments 
        { 
            get
            {
                if (m_arguments == null)
                {
                    m_arguments = GetArguments();
                }

                return m_arguments;
            }
        }

        protected abstract Components Component { get; }

        protected virtual string Delimiter { get; }

        protected virtual string KeyWord 
        {
            get => string.Empty;
        }

        protected abstract T Parse();

        protected string ParseQuotesInput(string input)
        {
            if (!input.EndsWith(ParseConsts.QUOTES))
            {
                throw new UnallowedCharactersException(Component);
            }

            return input.RemoveLast();
        }

        private string[] GetArguments()
        {
            if (!m_input.StartsWith(KeyWord))
            {
                throw new IncorrectFormatException(Component);
            }

            var arguments = m_input.Split(Delimiter);

            if (arguments.Length != ArgumentsCount)
            {
                throw new InvalidComponentsNumberException(Component);
            }

            return arguments;
        }
    }
}
