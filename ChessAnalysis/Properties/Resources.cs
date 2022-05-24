using ChessAnalysis.Utils;

namespace ChessAnalysis.Properties
{
    internal partial class Resources
    {
        public static Image? GetThemedIcon(string input)
        {
            return ResourceManager.GetObject($"{input}{Options.Instance.Theme}", resourceCulture) as Bitmap;
        }

        public static Image GetPiece(char input)
        {
            return ResourceManager.GetObject($"{Options.Instance.PieceStyle}_{GetColoredPiece(input)}", resourceCulture) as Bitmap;
        }

        private static string GetColoredPiece(char input)
        {
            return $"{(char.IsUpper(input) ? Constants.PLAYER_WHITE : Constants.PLAYER_BLACK)}{input}";
        }
    }
}
