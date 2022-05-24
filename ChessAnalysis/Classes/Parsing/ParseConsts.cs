namespace ChessAnalysis.Classes
{
    public static class ParseConsts
    {
        public const string ARG_COMMENT = "c0 ";
        public const string ARG_ID = "id ";
        public const string ARG_NULL = "-";

        public const int ARGS_COUNT_COMMENT = 5;
        public const int ARGS_COUNT_DATA = 3;
        public const int ARGS_COUNT_EN_PASSANT = 2;
        public const int ARGS_COUNT_ID = 2;
        public const int ARGS_COUNT_NEXT_PLAYER = 1;
        public const int ARGS_COUNT_POSITION = 8;

        public const string ARGS_DELIMITER_QUOTES = " \"";
        public const string ARGS_DELIMITER_SEMICOLON = "; ";
        public const string ARGS_DELIMITER_SLASH = "/";
        public const string ARGS_DELIMITER_SPACE = " ";

        public const int COMMENT_DEFENSE_INDEX = 4;
        public const int COMMENT_OPENING_INDEX = 3;
        public const int COMMENT_PLAYERS_INDEX = 1;
        public const int COMMENT_TIMESTAMP_INDEX = 2;

        public const int DATA_COMMENT_INDEX = 2;
        public const int DATA_ID_INDEX = 1;
        public const int DATA_POSITION_INDEX = 0;

        public const int ID_INDEX = 1;

        public const int POSITION_BEST_MOVE_INDEX = 7;
        public const int POSITION_CASTLING_INDEX = 2;
        public const int POSITION_EN_PASSANT_INDEX = 3;
        public const int POSITION_FEN_INDEX = 0;
        public const int POSITION_HALF_MOVES_INDEX = 4;
        public const int POSITION_NEXT_PLAYER_INDEX = 1;
        public const int POSITION_ROUND_INDEX = 5;

        public const char QUOTES = '\"';
    }
}
