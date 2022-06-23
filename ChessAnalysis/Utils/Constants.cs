namespace ChessAnalysis.Utils
{
	public static class Constants
	{
		public const string APP_NAME = "Chess Analysis";

		public const int BOARD_SIZE = 8;

		public const string COMA_SEPARATOR = ", ";

		public const string CRYPTO_PASSWORD = "abcdef0123456789";
		public const string CRYPTO_SALT = "ABCD12efGHIjKl3m";
		public const int CRYPTO_SIZE = 16;

		public const string DEFAULT_INPUT =
			"rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR b KQkq - 0 1 bm -; id \"ID\"; c0 \"\" \"\" \"\" \"\""; // Hardcoded nextPlayer because of orientation

		public const string DIALOG_FILTER = "Text files (*.txt)|*.txt";

		public const char EMPTY_CHAR = '\0';

		public const string ERROR_CAPTION = "Error message";

		public const int HD = 1080;

		public const string OPTIONS_FILE_NAME = "Options.xml";

		public const char PIECE_KING = 'K';
		public const char PIECE_PAWN = 'P';
		public const string PIECES = "BKNPQR";

		public const string PLAYER_BLACK = "b";
		public const string PLAYER_WHITE = "w";

		public const int SCALE_FACTOR_BEST_MOVE_IMAGE = 3;

		public const int SCALE_FACTOR_COORDINATE_FONT = 8;

		public const string SNAPSHOT_FILE = "{0}.png";
		public const string SNAPSHOT_FILE_DUPLICATE = "{0} ({1}).png";

		public const string SNAPSHOTS_DIR = "Snapshots";

		public const string THEME_FAMILY = "Visual Studio 2013";
	}
}
