using DevExpress.LookAndFeel;

namespace ChessAnalysis.Utils
{
	public enum Themes
	{
		Dark,
		Light
	}

	public class Theme
	{
		public static void ApplyTheme()
		{
			UserLookAndFeel.Default.SetSkinStyle($"{Constants.THEME_FAMILY} {Options.Instance.Theme}");
		}
	}
}
