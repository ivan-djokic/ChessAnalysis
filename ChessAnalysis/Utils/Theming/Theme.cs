using DevExpress.LookAndFeel;

namespace ChessAnalysis.Utils
{
    public class Theme
    {
        public static void ApplyTheme()
        {
            UserLookAndFeel.Default.SetSkinStyle($"{Constants.THEME_FAMILY} {Options.Instance.Theme}");
        }
    }
}
