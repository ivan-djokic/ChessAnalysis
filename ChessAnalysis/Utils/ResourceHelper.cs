// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using System.IO;
using ChessAnalysis.Properties;

namespace ChessAnalysis.Utils
{
	public class ResourceHelper
	{
		public static Image GetPiece(char input = Constants.PIECE_KING)
		{
			if (Resources.ResourceManager.GetObject($"{Options.Instance.PieceStyle}_{GetPieceColor(input)}{input}", Resources.Culture) is Bitmap result)
			{
				return result;
			}

			throw new Exception("Could not found piece");
		}

		public static Stream? GetSound(Sounds input)
		{
			return Resources.ResourceManager.GetStream(input.ToString());
		}

		private static string GetPieceColor(char input)
		{
			return char.IsUpper(input) ? Constants.PLAYER_WHITE : Constants.PLAYER_BLACK;
		}
	}
}
