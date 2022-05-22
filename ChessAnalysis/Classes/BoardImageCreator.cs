using ChessAnalysis.Models;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
    public class BoardImageCreator : IDisposable
    {
        private readonly SolidBrush m_brushEmpty = new(Options.Instance.FieldEmptyColor.Normalize());
        private readonly SolidBrush m_brushFill = new(Options.Instance.FieldFillColor.Normalize());
        private readonly int m_fieldSize = GetFieldSize();
        private Graphics m_graphics;
        private bool m_isWhiteOriented;

        private BoardImageCreator()
        {
        }

        public static Image Create(Position position, ref bool? isWhiteOriented)
        {
            using var creator = new BoardImageCreator();
            return creator.CreateInternal(position, ref isWhiteOriented);
        }

        public void Dispose()
        {
            m_brushEmpty.Dispose();
            m_brushFill.Dispose();
            m_graphics?.Dispose();
        }

        private Image CreateInternal(Position position, ref bool? isWhiteOriented)
        {
            var board = new Bitmap(Constants.BOARD_SIZE * m_fieldSize, Constants.BOARD_SIZE * m_fieldSize);
            m_graphics = Graphics.FromImage(board);

            var isWhitePlayed = position.NextPlayer == NextPlayer.Black;
            m_isWhiteOriented = isWhiteOriented ?? (!Options.Instance.AutoFlipBoard || isWhitePlayed);
            isWhiteOriented = m_isWhiteOriented;

            DrawFields();

            if (Options.Instance.ShowCoordinates)
            {
                DrawCoordinates();
            }

            DrawPieces(position.Fen, position.BestMove);

            return board;
        }

        private void DrawBestMove(int x, int y)
        {
            using var image = Image.FromFile(@"C:\Users\IDjokic\source\repos\ChessAnalysis\ChessAnalysis\Resources\Icons\Star.png");

            if (image == null)
            {
                return;
            }

            var size = m_fieldSize / Constants.SCALE_FACTOR_BEST_MOVE_IMAGE;

            // Draw in top right corner
            m_graphics.DrawImage(image, new Rectangle(x + m_fieldSize - size, y, size, size));
        }

        private void DrawCoordinates()
        {
            using var font = new Font("Segoe UI", Scaling.GetScaledSize(m_fieldSize / Constants.SCALE_FACTOR_COORDINATE_FONT), FontStyle.Bold);

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

        private void DrawPieces(string fen, BestMove bestMove)
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

                var actualX = GetPieceCoordinate(x) * m_fieldSize;
                var actualY = GetPieceCoordinate(y) * m_fieldSize;

                if (Options.Instance.MarkIfBestMoveIsPlayed && bestMove.Match(fen[i], x, y) == true)
                {
                    DrawBestMove(actualX, actualY);
                }

                m_graphics.DrawImage(piece, new Rectangle(actualX, actualY, m_fieldSize, m_fieldSize));

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
            return image?.Size.Width ?? Constants.BOARD_FIELD_DEFAULT_SIZE;
        }

        private int GetPieceCoordinate(int value)
        {
            if (m_isWhiteOriented)
            {
                return value;
            }

            return Constants.BOARD_SIZE - 1 - value;
        }

        private string GetXCoordinate(int offset)
        {
            if (m_isWhiteOriented)
            {
                return ('A' + offset).AsString();
            }

            return ('H' - offset).AsString();
        }

        private string GetYCoordinate(int offset)
        {
            if (m_isWhiteOriented)
            {
                return (Constants.BOARD_SIZE - offset).ToString();
            }

            return (offset + 1).ToString();
        }
    }
}
