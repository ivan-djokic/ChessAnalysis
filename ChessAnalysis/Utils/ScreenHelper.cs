// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using System.Windows;

namespace ChessAnalysis.Utils
{
	public static class ScreenHelper
	{
		public static bool IsHD
		{
			get => Screen.PrimaryScreen.Bounds.Height == Constants.HD;
		}

		public static float Scaling
		{
			get => Screen.PrimaryScreen.Bounds.Width / (float)SystemParameters.PrimaryScreenWidth;
		}
	}
}
