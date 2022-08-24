// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
	public partial class DataInput : XtraUserControl
	{
		public DataInput()
		{
			InitializeComponent();
		}

		public string Input
		{
			get => txtInput.Text;
			set => txtInput.Text = value;
		}

		public Data? ParseInput(DataCollection collection, Data? skipIdValidation = null)
		{
			try
			{
				var data = Parser.Parse(txtInput.Text);
				collection.ValidateIdUniqueness(data.Id, skipIdValidation);
				txtInput.Text = string.Empty;

				return data;
			}
			catch (ExeptionBase ex)
			{
				Messanger.ShowError(this, ex.Message);

				var (start, length) = GetBadInputRange(ex.Component);
				txtInput.Select(start, length);
			}

			return null;
		}

		private (int Start, int Length) GetBadInputRange(Components component)
		{
			if (component == Components.Data)
			{
				return (0, txtInput.Text.Length);
			}

			var arguments = Parser.GetArguments(txtInput.Text);

			switch (component)
			{
				case Components.Position:
					return GetBadInputRange(arguments, ParseConsts.DATA_POSITION_INDEX, ParseConsts.ARGS_DELIMITER_SEMICOLON);

				case Components.Id:
					return GetBadInputRange(arguments, ParseConsts.DATA_ID_INDEX, ParseConsts.ARGS_DELIMITER_SEMICOLON);

				case Components.Comment:
					return GetBadInputRange(arguments, ParseConsts.DATA_COMMENT_INDEX, ParseConsts.ARGS_DELIMITER_SEMICOLON);
			}

			arguments = PositionParser.GetArguments(arguments[ParseConsts.DATA_POSITION_INDEX]);

			switch (component)
			{
				case Components.Fen:
					return GetBadInputRange(arguments, ParseConsts.POSITION_FEN_INDEX, ParseConsts.ARGS_DELIMITER_SPACE);

				case Components.NextPlayer:
					return GetBadInputRange(arguments, ParseConsts.POSITION_NEXT_PLAYER_INDEX, ParseConsts.ARGS_DELIMITER_SPACE);

				case Components.Castling:
					return GetBadInputRange(arguments, ParseConsts.POSITION_CASTLING_INDEX, ParseConsts.ARGS_DELIMITER_SPACE);

				case Components.EnPassant:
					return GetBadInputRange(arguments, ParseConsts.POSITION_EN_PASSANT_INDEX, ParseConsts.ARGS_DELIMITER_SPACE);

				case Components.HalfMoves:
					return GetBadInputRange(arguments, ParseConsts.POSITION_HALF_MOVES_INDEX, ParseConsts.ARGS_DELIMITER_SPACE);

				case Components.Round:
					return GetBadInputRange(arguments, ParseConsts.POSITION_ROUND_INDEX, ParseConsts.ARGS_DELIMITER_SPACE);

				case Components.BestMove:
					return GetBadInputRange(arguments, ParseConsts.POSITION_BEST_MOVE_INDEX, ParseConsts.ARGS_DELIMITER_SPACE);

				default:
					return (0, 0);
			}
		}

		private static (int Start, int Length) GetBadInputRange(
			string[] arguments, int index, string delimiter)
		{
			var start = 0;

			for (var i = 0; i < index; i++)
			{
				// Skip previous characters
				start += arguments[i].Length + delimiter.Length;
			}

			// Returns structure with Start and Length atributes
			return (start, arguments[index].Length);
		}

		private void txtInput_ButtonClick(object sender, EventArgs e)
		{
			var pastedText = Clipboard.GetText();

			if (!string.IsNullOrEmpty(pastedText))
			{
				txtInput.Text = pastedText;
			}
		}
	}
}
