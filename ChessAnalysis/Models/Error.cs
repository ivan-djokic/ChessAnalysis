namespace ChessAnalysis.Models
{
    public class Error
    {
        public Error(string input, string error)
        {
            Line = input;
            Message = error;
        }

        public string Line { get; set; }

        public string Message { get; set; }
    }
}
