using ChessAnalysis.Forms;
using ChessAnalysis.Utils;

namespace ChessAnalysis
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Theming.ApplyTheme();
            Application.Run(new MainForm());
        }
    }
}