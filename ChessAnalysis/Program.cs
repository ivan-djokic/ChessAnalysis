using ChessAnalysis.Forms;
using ChessAnalysis.Utils;

namespace ChessAnalysis
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //TODO: check this to swap these 2 lines
            ApplicationConfiguration.Initialize();

            Theming.ApplyTheme();
            Application.Run(new MainForm());
        }
    }
}