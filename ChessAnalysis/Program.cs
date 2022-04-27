using ChessAnalysis.Forms;

namespace ChessAnalysis
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\IDjokic\source\repos\ChessAnalysis\ChessAnalysis\Resources\Icons\test\test2");

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}