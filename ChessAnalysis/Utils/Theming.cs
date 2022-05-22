using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace ChessAnalysis.Utils
{
	public enum Themes
	{
		Dark,
		Light
	}

	public class Theming
	{
		public static void ApplyTheme()
        {
			SkinManager.EnableFormSkins();
			UserLookAndFeel.Default.SetSkinStyle($"{Constants.THEME_FAMILY} {Options.Instance.Theme}");
		}
	}
}
