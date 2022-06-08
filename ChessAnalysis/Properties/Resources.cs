using System.IO;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Properties
{
    internal partial class Resources
    {
        public static Image GetPiece(char input)
        {
            if (ResourceManager.GetObject($"{Options.Instance.PieceStyle}_{GetPieceColor(input)}{input}", resourceCulture) is Bitmap result)
            {
                return result;
            }

            throw new Exception("Could not found piece");
        }

        public static Stream? GetSound(Sounds input)
        {
            return ResourceManager.GetStream(input.ToString());
        }

        private static string GetPieceColor(char input)
        {
            return char.IsUpper(input) ? Constants.PLAYER_WHITE : Constants.PLAYER_BLACK;
        }
    }
}
