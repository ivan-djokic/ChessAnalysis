using ChessAnalysis.Properties;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class BoardImageCreator
    {
        public static Image Create(string fen)
        {
            if (string.IsNullOrWhiteSpace(fen))
            {
                throw new InvalidComponentsNumberException(Components.FEN);
            }

            var fieldSize = GetFieldSize();
            var board = new Bitmap(Constants.BOARD_SIZE * fieldSize, Constants.BOARD_SIZE * fieldSize);
            using var g = Graphics.FromImage(board);

            using var emptyBrush = new SolidBrush(Options.Instance.EmptyFieldsColor);
            using var fillBrush = new SolidBrush(Options.Instance.FillFieldsColor);

            DrawFields(g, fieldSize, emptyBrush, fillBrush);

            if (Options.Instance.DrawCoordinates)
            {
                DrawCoordinates(g, fieldSize, emptyBrush, fillBrush);
            }

            DrawPieces(g, fieldSize, fen, new BestMove("Rh1", true));

            return board;
        }

        private static void DrawBestMove(Graphics g, int fieldSize, BestMove bestMove)
        {
            using var image = Image.FromFile(@"C:\Users\IDjokic\Downloads\Star.png");

            if (image == null)
            {
                return;
            }

            var size = fieldSize / 3;
            g.DrawImage(image, new Rectangle((bestMove.Field.X + 1) * fieldSize - size, bestMove.Field.Y * fieldSize, size, size));
        }

        private static void DrawCoordinates(Graphics g, int fieldSize, SolidBrush emptyBrush, SolidBrush fillBrush)
        {
            using var font = new Font("Segoe UI", fieldSize / 8.0f, FontStyle.Bold);

            var letterY = Constants.BOARD_SIZE * fieldSize - font.Height;

            for (var i = 0; i < Constants.BOARD_SIZE; i++)
            {
                if (i.IsEven())
                {
                    g.DrawString((Constants.BOARD_SIZE - i).ToString(), font, fillBrush, new Point(0, i * fieldSize));
                    g.DrawString(('A' + i).AsString(), font, emptyBrush, new Point(i * fieldSize, letterY));
                    continue;
                }

                g.DrawString((Constants.BOARD_SIZE - i).ToString(), font, emptyBrush, new Point(0, i * fieldSize));
                g.DrawString(('A' + i).AsString(), font, fillBrush, new Point(i * fieldSize, letterY));
            }
        }

        private static void DrawFields(Graphics g, int fieldSize, SolidBrush emptyBrush, SolidBrush fillBrush)
        {
            for (var i = 0; i < Constants.BOARD_SIZE; i++)
            {
                for (var j = 0; j < Constants.BOARD_SIZE; j++)
                {
                    // Even fields are empty (white) and odd are filled (black)
                    if ((i + j).IsEven())
                    {
                        g.FillRectangle(emptyBrush, new Rectangle(i * fieldSize, j * fieldSize, fieldSize, fieldSize));
                        continue;
                    }

                    g.FillRectangle(fillBrush, new Rectangle(i * fieldSize, j * fieldSize, fieldSize, fieldSize));
                }
            }
        }

        private static void DrawPieces(Graphics g, int fieldSize, string fen, BestMove bestMove)
        {
            var x = 0;
            var y = 0;

            for (var i = 0; i < fen.Length; i++)
            {
                if (fen[i] == Constants.FEN_NEW_ROW_DELIMITER)
                {
                    x = 0;
                    y++;
                    continue;
                }

                if (x >= Constants.BOARD_SIZE || y >= Constants.BOARD_SIZE)
                {
                    throw new InvalidComponentsNumberException(Components.FEN);
                }

                using var piece = Resources.GetPiece(fen[i]);

                if (piece == null)
                {
                    var fieldsForSkip = fen[i].AsFormatedDigit();
                    
                    if (!fieldsForSkip.HasValue)
                    {
                        throw new UnallowedCharactersException(Components.FEN);
                    }

                    x += fieldsForSkip.Value;
                    continue;
                }

                if (Options.Instance.MarkIfMoveIsTheBest && bestMove.Equals(fen[i], x, y))
                {
                    DrawBestMove(g, fieldSize, bestMove);
                }

                g.DrawImage(piece, new Rectangle(x * fieldSize, y * fieldSize, fieldSize, fieldSize));

                x++;
            }

            if (x < Constants.BOARD_SIZE || y < Constants.BOARD_SIZE - 1)
            {
                throw new InvalidComponentsNumberException(Components.FEN);
            }
        }

        private static int GetFieldSize()
        {
            using var image = Resources.GetPiece('p');

            if (image == null)
            {
                return Constants.BOARD_FIELD_DEFAULT_SIZE;
            }

            return image.Size.Width;
        }
    }
}
