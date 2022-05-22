using ChessAnalysis.Utils;

namespace ChessAnalysis.Properties
{
    internal partial class Resources
    {
        public static Image? GetThemedIcon(string name)
        {
            return ResourceManager.GetObject($"{name}{Options.Instance.Theme}", resourceCulture) as Bitmap;
        }

        public static Image? GetPiece(char piece)
        {
            return ResourceManager.GetObject($"{Options.Instance.PieceStyle}_{(char.IsUpper(piece) ? Constants.PLAYER_WHITE : Constants.PLAYER_BLACK)}{piece}", resourceCulture) as Bitmap;
        }
    }
}
