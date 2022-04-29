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
            return ResourceManager.GetObject($"{Options.Instance.PieceStyle}_{(char.IsUpper(piece) ? Constants.PLAYER_WHITE : Constants.PLAYER_BLACK)}{piece}", resourceCulture) as Bitmap;
        }
    }
}
