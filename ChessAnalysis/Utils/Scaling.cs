namespace ChessAnalysis.Utils
{
    public static class Scaling
    {
		public static float GetScaledSize(float input)
		{
			return input * Screen.PrimaryScreen.Bounds.Width / (float)System.Windows.SystemParameters.PrimaryScreenWidth;
		}
	}
}
