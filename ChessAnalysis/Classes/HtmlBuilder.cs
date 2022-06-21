using ChessAnalysis.Models;

namespace ChessAnalysis.Classes
{
    public class HtmlBuilder
    {
        private const string HTML = "<html><head><style>div {{ white-space: pre }} table {{ border-collapse: collapse; }} td, th {{ border: 1px solid gray; padding: 5px; }}</style></head><body><div>{0}</div><hr>{1}</body></html>";
        private const string TABLE = "<table>{0}{1}</table>";
        private const string TABLE_HEADER = "<tr><th>{0}</th><th>{1}</th><th>{2}</th><th>{3}</th><th>{4}</th><th>{5}</th><th>{6}</th><th>{7}</th><th>{8}</th><th>{9}</th><th>{10}</th></tr>";
        private const string TABLE_ROW = "<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td>{8}</td><td>{9}</td><td>{10}</td></tr>";

        public static string BuildPage(string text, DataCollection collection)
        {
            return string.Format(HTML, text, BuildTable(collection));
        }

        private static string BuildTable(DataCollection collection)
        {
            return string.Format(TABLE, BuildTableHeader(), BuildTableRows(collection));
        }

        private static string BuildTableHeader()
        {
            return string.Format(TABLE_HEADER, "Round", "Next player", "White castling", "Black castling", "En passant", "Half moves", "Best move", "Opening", "Defense", "Players", "Result");
        }

        private static string BuildTableRow(Data data)
        {
            return string.Format(TABLE_ROW, data.Position.Round, data.Position.NextPlayer, data.Position.CastlingWhite, data.Position.CastlingBlack, data.Position.EnPassant, data.Position.HalfMoves, data.Position.BestMove.Value, 
                data.Comment.Opening, data.Comment.Defense, data.Comment.Players, data.Comment.Result);
        }

        private static string BuildTableRows(DataCollection collection)
        {
            return string.Join(string.Empty, collection.Select(data => BuildTableRow(data)));
        }
    }
}
