namespace ChessAnalysis.Utils
{
    public static class Constants
    {
        public const string APP_NAME = "Chess Analysis";

        public const int ARGS_COUNT_POSITION = 8;
        public const int ARGS_COUNT_GAME = 5;
        public const int ARGS_COUNT_ID = 2;
        public const int ARGS_COUNT_INPUT_DATA = 3;

        public const string ARGS_DELIMITER_QUOTES = " \"";
        public const string ARGS_DELIMITER_SEMICOLON = "; ";
        public const string ARGS_DELIMITER_SPACE = " ";

        public const string ARG_COMMENT = "c0 ";
        public const string ARG_ID = "id ";
        public const string ARG_NULL = "-";

        public const int BEST_MOVE_MAX_CHARS = 6; // E.g. Baxd7+
        public const int BEST_MOVE_MIN_CHARS = 2; // E.g. e4

        public const int BOARD_FIELD_DEFAULT_SIZE = 300;
        public const int BOARD_SIZE = 8;

        public const string DEFAULT_INPUT = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1 bm -; id \"KK03\"; c0 \"\" \"\" \"\" \"\"";

        public const char FEN_NEW_ROW_DELIMITER = '/';

        public const int GAME_DEFENSE_INDEX = 4;
        public const int GAME_OPENING_INDEX = 3;
        public const int GAME_PLAYERS_INDEX = 1;
        public const int GAME_TIMESTAMP_INDEX = 2;

        public const int ID_INDEX = 1;

        public const int INPUT_DATA_GAME_INDEX = 2;
        public const int INPUT_DATA_ID_INDEX = 1;
        public const int INPUT_DATA_POSITION_INDEX = 0;

        public const string OPTIONS_FILE_NAME = "Options.xml";

        public const char PLAYER_BLACK = 'b';
        public const char PLAYER_WHITE = 'w';

        public const int POSITION_BEST_MOVE_INDEX = 7;
        public const int POSITION_CASTLING_INDEX = 2;
        public const int POSITION_EN_PASSANT_INDEX = 3;
        public const int POSITION_FEN_INDEX = 0;
        public const int POSITION_HALF_MOVES_INDEX = 4;
        public const int POSITION_NEXT_PLAYER_INDEX = 1;
        public const int POSITION_ROUND_INDEX = 5;

        public const char QUOTES = '\"';

        public const string SAVE_IMAGE_FILTER = "PNG (*.png)|*.png|JPEG (*.jpg, *.jpeg)|*.jpg;*.jpeg|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|TIFF (*.tif, *.tiff)|*.tif;*.tiff";

        public const int SCALE_FACTOR_BEST_MOVE_IMAGE = 3;
        public const int SCALE_FACTOR_COORDINATE_FONT = 7;

        public const string SNAPSHOTS_DIR = "Snapshots";

        public const string THEME_FAMILY = "Visual Studio 2013";
    }
}
