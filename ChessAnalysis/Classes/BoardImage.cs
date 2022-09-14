// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Models;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public class BoardImage : IDisposable
	{
		private readonly SolidBrush m_brushEmpty = new(Options.Instance.FieldEmptyColor.Normalize());
		private readonly SolidBrush m_brushFill = new(Options.Instance.FieldFillColor.Normalize());
		private readonly int m_fieldSize;
		private Graphics m_graphics;
		private readonly IWin32Window m_owner;
		private readonly bool m_whiteOrientedBoard;

		private BoardImage(IWin32Window owner, bool whiteOrientedBoard)
		{
			using var piece = ResourceHelper.GetPiece();
			m_fieldSize = piece.Size.Width;

			m_owner = owner;
			m_whiteOrientedBoard = whiteOrientedBoard;
		}

		public static Image Create(IWin32Window owner, Position position, bool whiteOrientedBoard)
		{
			using var boardImage = new BoardImage(owner, whiteOrientedBoard);
			return boardImage.Create(position);
		}

		public void Dispose()
		{
			m_brushEmpty.Dispose();
			m_brushFill.Dispose();
			m_graphics.Dispose();
		}

		private static float CalculatePoint(float start, float end, double angle, double length)
		{
			var offset = (float)(angle * length);

			if (start > end)
			{
				return start - offset;
			}

			return start + offset;
		}

		private Image Create(Position position)
		{
			var result = new Bitmap(Constants.BOARD_SIZE * m_fieldSize, Constants.BOARD_SIZE * m_fieldSize);
			m_graphics = Graphics.FromImage(result);

			DrawFields();
			DrawCoordinates();
			DrawPieces(position.Board);
			DrawBestMove(position);

			return result;
		}

		private void DrawArrow(Point start, Point end)
		{
			var color = m_brushEmpty.Color.Blend(m_brushFill.Color);
			var pen = new Pen(color, Constants.LINE_WIDTH);

			// Draw the line
			m_graphics.DrawLine(pen, start, end);

			// Draw the triangle
			var arrowPoints = GetArrowPoints(start, end);
			m_graphics.DrawPolygon(pen, arrowPoints);
			m_graphics.FillPolygon(new SolidBrush(color), arrowPoints);
		}

		private void DrawBestMove(Position position)
		{
			if (!Options.Instance.ShowBestMove)
			{
				return;
			}

			try
			{
				var (Start, End) = BestMovePointsParser.Parse(position.BestMove, position.Board, position.NextPlayer == NextPlayer.White, position.EnPassant);
				DrawArrow(FormatPoint(Start), FormatPoint(End));
			}
			catch (ExeptionBase ex)
			{
				Messanger.ShowError(m_owner, ex.Message);
			}
		}

		private void DrawCoordinates()
		{
			if (!Options.Instance.ShowCoordinates)
			{
				return;
			}

			var size = m_fieldSize / Constants.SCALE_FACTOR_COORDINATE_FONT / ScreenHelper.Scaling;
			using var font = new Font(Constants.FONT_NAME, size, FontStyle.Bold);
			var letterY = Constants.BOARD_SIZE * m_fieldSize - font.Height;

			for (var i = 0; i < Constants.BOARD_SIZE; i++)
			{
				m_graphics.DrawString(GetXCoordinate(i), font, GetBrush(i), new Point(i * m_fieldSize, letterY));
				m_graphics.DrawString(GetYCoordinate(i), font, GetBrush(i, true), new Point(0, i * m_fieldSize));
			}
		}

		private void DrawFields()
		{
			for (var i = 0; i < Constants.BOARD_SIZE; i++)
			{
				for (var j = 0; j < Constants.BOARD_SIZE; j++)
				{
					m_graphics.FillRectangle(GetBrush(i + j), new Rectangle(i * m_fieldSize, j * m_fieldSize, m_fieldSize, m_fieldSize));
				}
			}
		}

		private void DrawPieces(char[][] board)
		{
			for (var x = 0; x < board.Length; x++)
			{
				for (var y = 0; y < board.Length; y++)
				{
					if (board[y][x] == Constants.EMPTY_CHAR)
					{
						continue;
					}

					var actualX = GetPieceCoordinate(x) * m_fieldSize;
					var actualY = GetPieceCoordinate(y) * m_fieldSize;

					using var piece = ResourceHelper.GetPiece(board[y][x]);
					m_graphics.DrawImage(piece, new Rectangle(actualX, actualY, m_fieldSize, m_fieldSize));
				}
			}
		}

		private static PointF[] GetArrowPoints(Point start, Point end)
		{
			var length = Math.Sqrt(Math.Pow(Math.Abs(start.X - end.X), 2) + Math.Pow(Math.Abs(start.Y - end.Y), 2));

			var angleA = Math.Atan2(Math.Abs(start.Y - end.Y), Math.Abs(start.X - end.X));
			var angleB = Math.Atan2(Constants.LINE_WIDTH, length - Constants.LINE_WIDTH);
			var angleC = Math.PI / 2 - angleA - angleB;

			var secondaryLength = Constants.LINE_WIDTH / Math.Sin(angleB);

			// Get x and y of the left point
			var pointX = CalculatePoint(start.X, end.X, Math.Sin(angleC), secondaryLength);
			var pointY = CalculatePoint(start.Y, end.Y, Math.Cos(angleC), secondaryLength);
			var leftPoint = new PointF(pointX, pointY);

			// Move to the right point
			pointX = CalculatePoint(start.X, end.X, Math.Cos(angleA - angleB), secondaryLength);
			pointY = CalculatePoint(start.Y, end.Y, Math.Sin(angleA - angleB), secondaryLength);
			var rightPoint = new PointF(pointX, pointY);

			return new[]
			{
				end,
				leftPoint,
				rightPoint
			};
		}

		private SolidBrush GetBrush(int input, bool invert = false)
		{
			if (!invert)
			{
				return input % 2 == 0 ? m_brushEmpty : m_brushFill;
			}

			return input % 2 == 0 ? m_brushFill : m_brushEmpty;
		}

		private int GetPieceCoordinate(int input)
		{
			if (m_whiteOrientedBoard)
			{
				return input;
			}

			return (input + 1).AsBoardRow();
		}

		private string GetXCoordinate(int input)
		{
			if (m_whiteOrientedBoard)
			{
				return ('A' + input).AsString();
			}

			return ('H' - input).AsString();
		}

		private string GetYCoordinate(int input)
		{
			if (m_whiteOrientedBoard)
			{
				return input.AsBoardRow().ToString();
			}

			return (input + 1).ToString();
		}

		private Point FormatPoint(Point input)
		{
			var halfField = m_fieldSize / 2;
			return new Point(GetPieceCoordinate(input.X) * m_fieldSize + halfField, GetPieceCoordinate(input.Y) * m_fieldSize + halfField);
		}
	}
}
