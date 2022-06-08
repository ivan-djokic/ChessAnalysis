using ChessAnalysis.Models;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class BoardImage : IDisposable
    {
        private readonly SolidBrush m_brushEmpty = new(Options.Instance.FieldEmptyColor.Normalize());
        private readonly SolidBrush m_brushFill = new(Options.Instance.FieldFillColor.Normalize());
        private readonly int m_fieldSize;
        private Graphics m_graphics;
        private readonly bool m_isWhiteOriented;

        private BoardImage(bool isWhitePlayed, bool? isWhiteOriented)
        {
            m_isWhiteOriented = isWhiteOriented ?? (!Options.Instance.AutoFlipBoard || isWhitePlayed);

            using var image = Resources.GetPiece('K');
            m_fieldSize = image.Size.Width;
        }

        public static Image Create(Position position, ref bool? isWhiteOriented)
        {
            using var boardImage = new BoardImage(position.NextPlayer == NextPlayer.Black, isWhiteOriented);
            return boardImage.Create(position.Board, position.BestMove, out isWhiteOriented);
        }

        public void Dispose()
        {
            m_brushEmpty.Dispose();
            m_brushFill.Dispose();
            m_graphics?.Dispose();
        }

        private Image Create(char[][] board, BestMove bestMove, out bool? isWhiteOriented)
        {
            var result = new Bitmap(Constants.BOARD_SIZE * m_fieldSize, Constants.BOARD_SIZE * m_fieldSize);
            m_graphics = Graphics.FromImage(result);

            DrawFields();
            DrawCoordinates();
            DrawBestMove(board, bestMove);
            DrawPieces(board);

            isWhiteOriented = m_isWhiteOriented;
            return result;
        }

        private void DrawBestMove(char[][] board, BestMove bestMove)
        {
            if (!Options.Instance.MarkIfBestMoveIsPlayed || !board.Contains(bestMove))
            {
                return;
            }

            // Draw in top right corner of the field
            var size = m_fieldSize / Constants.SCALE_FACTOR_BEST_MOVE_IMAGE;
            var x = GetPieceCoordinate(bestMove.Field.X) * m_fieldSize + m_fieldSize - size;
            var y = GetPieceCoordinate(bestMove.Field.Y) * m_fieldSize;

            using var image = Resources.Star;
            m_graphics.DrawImage(image, new Rectangle(x, y, size, size));
        }

        private void DrawCoordinates()
        {
            if (!Options.Instance.ShowCoordinates)
            {
                return;
            }

            using var font = new Font("Segoe UI", GetScaledFontSize(), FontStyle.Bold);

            var letterY = Constants.BOARD_SIZE * m_fieldSize - font.Height;

            for (var i = 0; i < Constants.BOARD_SIZE; i++)
            {
                if (i.IsEven())
                {
                    m_graphics.DrawString(GetXCoordinate(i), font, m_brushEmpty, new Point(i * m_fieldSize, letterY));
                    m_graphics.DrawString(GetYCoordinate(i), font, m_brushFill, new Point(0, i * m_fieldSize));
                    continue;
                }

                m_graphics.DrawString(GetXCoordinate(i), font, m_brushFill, new Point(i * m_fieldSize, letterY));
                m_graphics.DrawString(GetYCoordinate(i), font, m_brushEmpty, new Point(0, i * m_fieldSize));
            }
        }

        private void DrawFields()
        {
            for (var i = 0; i < Constants.BOARD_SIZE; i++)
            {
                for (var j = 0; j < Constants.BOARD_SIZE; j++)
                {
                    // Even fields are filled (black) and odd are empty (white)
                    if ((i + j).IsEven())
                    {
                        m_graphics.FillRectangle(m_brushEmpty, new Rectangle(i * m_fieldSize, j * m_fieldSize, m_fieldSize, m_fieldSize));
                        continue;
                    }

                    m_graphics.FillRectangle(m_brushFill, new Rectangle(i * m_fieldSize, j * m_fieldSize, m_fieldSize, m_fieldSize));
                }
            }
        }

        private void DrawPieces(char[][] board)
        {
            for (var x = 0; x < board.Length; x++)
            {
                for (var y = 0; y < board.Length; y++)
                {
                    if (board[y][x].IsEmpty())
                    {
                        continue;
                    }

                    var actualX = GetPieceCoordinate(x) * m_fieldSize;
                    var actualY = GetPieceCoordinate(y) * m_fieldSize;

                    using var piece = Resources.GetPiece(board[y][x]);
                    m_graphics.DrawImage(piece, new Rectangle(actualX, actualY, m_fieldSize, m_fieldSize));
                }
            }
        }

        private int GetPieceCoordinate(int input)
        {
            if (m_isWhiteOriented)
            {
                return input;
            }

            return (input + 1).AsBoardRow();
        }

        private float GetScaledFontSize()
        {
            return m_fieldSize * (float)System.Windows.SystemParameters.PrimaryScreenWidth / (Constants.SCALE_FACTOR_COORDINATE_FONT * Screen.PrimaryScreen.Bounds.Width);
        }

        private string GetXCoordinate(int input)
        {
            if (m_isWhiteOriented)
            {
                return ('A' + input).AsString();
            }

            return ('H' - input).AsString();
        }

        private string GetYCoordinate(int input)
        {
            if (m_isWhiteOriented)
            {
                return input.AsBoardRow().ToString();
            }

            return (input + 1).ToString();
        }
    }
}
