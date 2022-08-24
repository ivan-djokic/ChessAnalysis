﻿// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

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
		private readonly bool m_whiteOrientedBoard;

		private BoardImage(bool whiteOrientedBoard)
		{
			using var piece = ResourceHelper.GetPiece();
			m_fieldSize = piece.Size.Width;
			m_whiteOrientedBoard = whiteOrientedBoard;
		}

		public static Image Create(Position position, bool whiteOrientedBoard)
		{
			using var boardImage = new BoardImage(whiteOrientedBoard);
			return boardImage.Create(position.Board, position.BestMove);
		}

		public void Dispose()
		{
			m_brushEmpty.Dispose();
			m_brushFill.Dispose();
			m_graphics.Dispose();
		}

		private Image Create(char[][] board, BestMove bestMove)
		{
			var result = new Bitmap(Constants.BOARD_SIZE * m_fieldSize, Constants.BOARD_SIZE * m_fieldSize);
			m_graphics = Graphics.FromImage(result);

			DrawFields();
			DrawCoordinates();
			DrawPieces(board);
			DrawBestMove(board, bestMove);

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

			using var font = new Font(Constants.FONT_NAME, m_fieldSize / Constants.SCALE_FACTOR_COORDINATE_FONT / ScreenHelper.Scaling, FontStyle.Bold);
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
	}
}
