namespace ChessAnalysis.Utils
{
    public static class Constants
    {
        public const string APP_NAME = "Chess Analysis";

        public const int BOARD_SIZE = 8;

        public const string DEFAULT_INPUT = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR b KQkq - 0 1 bm -; id \"ID\"; c0 \"\" \"\" \"\" \"\""; // Hardcoded nextPlayer because of orientation

        public const char EMPTY_CHAR = '\0';

        public const string OPTIONS_FILE_NAME = "Options.xml";

        public const char PAWN = 'P';

        public const string PIECES = "BKNPQR";

        public const char PLAYER_BLACK = 'b';
        public const char PLAYER_WHITE = 'w';

        public const string SAVE_IMAGE_FILTER = "PNG (*.png)|*.png|JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|TIFF (*.tif, *.tiff)|*.tif;*.tiff";

        public const int SCALE_FACTOR_BEST_MOVE_IMAGE = 3;

        public const float SCALE_FACTOR_COORDINATE_FONT = 7;

        public const string SNAPSHOTS_DIR = "Snapshots";

        public const string THEME_FAMILY = "Visual Studio 2013";
    }
}
