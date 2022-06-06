namespace ChessAnalysis.Models
{
    public class Error
    {
        public Error(string input, string error)
        {
            Input = input;
            Message = error;
        }

        public string Input { get; set; }

        public string Message { get; set; }
    }
}
