using ChessAnalysis.Utils;

namespace ChessAnalysis.Properties
{
    internal partial class Resources
    {
        public static Image? GetIcon(string name)
        {
            return ResourceManager.GetObject($"{Options.Instance.Theme}{name}", resourceCulture) as Bitmap;
        }

        public static Image? GetPiece(char piece)
        {
            return ResourceManager.GetObject($"{Options.Instance.PieceStyle}_{(char.IsUpper(piece) ? Constants.PLAYER_WHITE_TAG : Constants.PLAYER_BLACK_TAG)}{piece}", resourceCulture) as Bitmap;
        }
    }
}
