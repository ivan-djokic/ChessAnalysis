// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Models;
using ChessAnalysis.Utils;

namespace ChessAnalysis.Classes
{
	public static class HtmlBuilder
	{
		public static string BuildPage(string content, DataCollection collection)
		{
			return string.Format(Constants.HTML_PAGE, content, BuildTable(collection));
		}

		private static string AppendCell(this string input, object value)
		{
			return input + string.Format(Constants.HTML_TABLE_CELL, value);
		}

		private static string AppendHeaderCell(this string input, object value)
		{
			return input + string.Format(Constants.HTML_TABLE_HEADER_CELL, value);
		}

		private static string BuildTable(DataCollection collection)
		{
			return string.Format(Constants.HTML_TABLE, BuildTableHeader(), BuildTableRows(collection));
		}

		private static string BuildTableHeader()
		{
			return string.Format(Constants.HTML_TABLE_ROW,
				string.Empty.AppendHeaderCell("Round").AppendHeaderCell("Next player").AppendHeaderCell("White castling").AppendHeaderCell("Black castling").
					AppendHeaderCell("En passant").AppendHeaderCell("Half moves").AppendHeaderCell("Best move").AppendHeaderCell("Result").AppendHeaderCell("Opening").
					AppendHeaderCell("Defense").AppendHeaderCell("Players"));
		}

		private static string BuildTableRow(Data data)
		{
			return string.Format(Constants.HTML_TABLE_ROW, string.Empty
				.AppendCell(data.Position.Round).AppendCell(data.Position.NextPlayer).AppendCell(data.Position.CastlingWhite).AppendCell(data.Position.CastlingBlack)
				.AppendCell(data.Position.EnPassant).AppendCell(data.Position.HalfMoves).AppendCell(data.Position.BestMove)
				.AppendCell(data.Comment.Result).AppendCell(data.Comment.Opening).AppendCell(data.Comment.Defense).AppendCell(data.Comment.Players));
		}

		private static string BuildTableRows(DataCollection collection)
		{
			return string.Join(string.Empty, collection.Select(data => BuildTableRow(data)));
		}
	}
}
