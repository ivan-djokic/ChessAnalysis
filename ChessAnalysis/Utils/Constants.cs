namespace ChessAnalysis.Utils
{
    public static class Constants
    {
        public const string APP_NAME = "Chess Analysis";

        public const int ARG_POSITION_ARGS_COUNT = 8;
        public const int ARG_GAME_ARGS_COUNT = 5;
        public const int ARG_ID_ARGS_COUNT = 2;
        public const int ARG_INPUT_ARGS_COUNT = 3;

        public const char ARG_DELIMITER = ' ';
        public const string ARG_DELIMITER_WITHOUT_QUOTES = " \"";

        public const string ARG_NULL = "-";

        public const int BEST_MOVE_MAX_CHARS = 6; // E.g. Baxd7+
        public const int BEST_MOVE_MIN_CHARS = 2; // E.g. e4

        public const int BOARD_FIELD_DEFAULT_SIZE = 300;
        public const int BOARD_SIZE = 8;

        public const char FEN_NEW_ROW_DELIMITER = '/';

        public const int GAME_DEFENSE_INDEX = 4;
        public const int GAME_OPENING_INDEX = 3;
        public const int GAME_PLAYERS_INDEX = 1;
        public const int GAME_TIMESTAMP_INDEX = 2;

        public const string OPTIONS_FILE_NAME = "Options.xml";

        public const char PLAYER_BLACK_TAG = 'b';
        public const char PLAYER_WHITE_TAG = 'w';

        public const int POSITION_BEST_MOVE_INDEX = 7;
        public const int POSITION_CASTLING_INDEX = 2;
        public const int POSITION_EN_PASSANT_INDEX = 3;
        public const int POSITION_FEN_INDEX = 0;
        public const int POSITION_HALF_MOVES_INDEX = 4;
        public const int POSITION_NEXT_PLAYER_INDEX = 1;
        public const int POSITION_ROUND_INDEX = 5;

        public const char QUOTES = '\"';

        public const string SAVE_IMAGE_FILTER = "PNG (*.png)|*.png|JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|TIFF (*.tif, *.tiff)|*.tif;*.tiff";
        
        public const string SNAPSHOTS_DIR = "Snapshots";

        public const string THEME_FAMILY = "Visual Studio 2013";
    }
}
