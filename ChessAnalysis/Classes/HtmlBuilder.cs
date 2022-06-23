using ChessAnalysis.Models;

namespace ChessAnalysis.Classes
{
	public static class HtmlBuilder
	{
		private const string HTML =
			"<html><head><style>div {{ white-space: pre }} table {{ border-collapse: collapse; }} td, th {{ border: 1px solid gray; padding: 5px; }}</style></head><body><div>{0}</div><hr>{1}</body></html>";

		private const string TABLE = "<table>{0}{1}</table>";
		private const string TABLE_CELL = "<td>{0}</td>";
		private const string TABLE_HEADER_CELL = "<th>{0}</th>";
		private const string TABLE_ROW = "<tr>{0}</tr>";

		public static string BuildPage(string content, DataCollection collection)
		{
			return string.Format(HTML, content, BuildTable(collection));
		}

		private static string AppendCell(this string input, object value)
		{
			return input + string.Format(TABLE_CELL, value);
		}

		private static string AppendHeaderCell(this string input, object value)
		{
			return input + string.Format(TABLE_HEADER_CELL, value);
		}

		private static string BuildTable(DataCollection collection)
		{
			return string.Format(TABLE, BuildTableHeader(), BuildTableRows(collection));
		}

		private static string BuildTableHeader()
		{
			return string.Format(TABLE_ROW,
				string.Empty.AppendHeaderCell("Round").AppendHeaderCell("Next player").AppendHeaderCell("White castling").AppendHeaderCell("Black castling").
					AppendHeaderCell("En passant").AppendHeaderCell("Half moves").AppendHeaderCell("Best move").AppendHeaderCell("Result").AppendHeaderCell("Opening").
					AppendHeaderCell("Defense").AppendHeaderCell("Players"));
		}

		private static string BuildTableRow(Data data)
		{
			return string.Format(TABLE_ROW,
				string.Empty.AppendCell(data.Position.Round).AppendCell(data.Position.NextPlayer).AppendCell(data.Position.CastlingWhite).
					AppendCell(data.Position.CastlingBlack).AppendCell(data.Position.EnPassant).AppendCell(data.Position.HalfMoves).AppendCell(data.Position.BestMove).
					AppendCell(data.Comment.Result).AppendCell(data.Comment.Opening).AppendCell(data.Comment.Defense).AppendCell(data.Comment.Players));
		}

		private static string BuildTableRows(DataCollection collection)
		{
			return string.Join(string.Empty, collection.Select(data => BuildTableRow(data)));
		}
	}
}
