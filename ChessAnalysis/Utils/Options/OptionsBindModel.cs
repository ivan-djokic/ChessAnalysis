﻿// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using DevExpress.Mvvm;

namespace ChessAnalysis.Utils
{
	public class OptionsBindModel : ViewModelBase
	{
		public Color FieldEmptyColor
		{
			get => Options.Instance.FieldEmptyColor.Normalize();
			set
			{
				var color = value.Normalize();

				if (Options.Instance.FieldEmptyColor != color)
				{
					Options.Instance.FieldEmptyColor = color;
					RaiseBoardOptionsChanged();
				}
			}
		}

		public Color FieldFillColor
		{
			get => Options.Instance.FieldFillColor.Normalize();
			set
			{
				var color = value.Normalize();

				if (Options.Instance.FieldEmptyColor != color)
				{
					Options.Instance.FieldFillColor = color;
					RaiseBoardOptionsChanged();
				}
			}
		}

		public bool PieceClassic
		{
			get => Options.Instance.PieceStyle == PieceStyles.Classic;
			set
			{
				if (value)
				{
					Options.Instance.PieceStyle = PieceStyles.Classic;
					RaiseBoardOptionsChanged();
				}
			}
		}

		public bool PieceNeo
		{
			get => Options.Instance.PieceStyle == PieceStyles.Neo;
			set
			{
				if (value)
				{
					Options.Instance.PieceStyle = PieceStyles.Neo;
					RaiseBoardOptionsChanged();
				}
			}
		}

		public bool PieceWood
		{
			get => Options.Instance.PieceStyle == PieceStyles.Wood;
			set
			{
				if (value)
				{
					Options.Instance.PieceStyle = PieceStyles.Wood;
					RaiseBoardOptionsChanged();
				}
			}
		}

		public bool PlaySound
		{
			get => Options.Instance.PlaySound;
			set => Options.Instance.PlaySound = value;
		}

		public string ReceiverMail
		{
			get => Options.Instance.ReceiverMail;
			set => Options.Instance.ReceiverMail = value;
		}

		public string SenderMail
		{
			get => Options.Instance.SenderMail;
			set => Options.Instance.SenderMail = value;
		}

		public string SenderPassword
		{
			get => Options.Instance.SenderPassword;
			set => Options.Instance.SenderPassword = value;
		}

		public bool ShortComment
		{
			get => Options.Instance.ShortComment;
			set => Options.Instance.ShortComment = value;
		}

		public bool ShortFen
		{
			get => Options.Instance.ShortFen;
			set => Options.Instance.ShortFen = value;
		}

		public bool ShowBestMove
		{
			get => Options.Instance.ShowBestMove;
			set
			{
				if (Options.Instance.ShowBestMove != value)
				{
					Options.Instance.ShowBestMove = value;
					RaiseBoardOptionsChanged();
				}
			}
		}

		public bool ShowCoordinates
		{
			get => Options.Instance.ShowCoordinates;
			set
			{
				Options.Instance.ShowCoordinates = value;
				RaiseBoardOptionsChanged();
			}
		}

		public string SmtpClient
		{
			get => Options.Instance.SmtpClient;
			set => Options.Instance.SmtpClient = value;
		}

		public string SnapshotDirectory
		{
			get => Options.Instance.SnapshotDirectory;
			set => Options.Instance.SnapshotDirectory = value;
		}

		public bool ThemeDark
		{
			get => Options.Instance.Theme == Themes.Dark;
			set
			{
				if (value && Options.Instance.Theme != Themes.Dark)
				{
					Options.Instance.Theme = Themes.Dark;
					Theme.ApplyTheme();
				}
			}
		}

		public bool ThemeLight
		{
			get => Options.Instance.Theme == Themes.Light;
			set
			{
				if (value && Options.Instance.Theme != Themes.Light)
				{
					Options.Instance.Theme = Themes.Light;
					Theme.ApplyTheme();
				}
			}
		}

		public void RaisePropertiesChanged()
		{
			RaisePropertiesChanged(() => FieldEmptyColor, () => FieldFillColor);
			RaisePropertiesChanged(() => PieceClassic, () => PieceNeo, () => PieceWood);
			RaisePropertyChanged(() => PlaySound);
			RaisePropertiesChanged(() => SenderMail, () => SenderPassword);
			RaisePropertiesChanged(() => ShortComment, () => ShortFen);
			RaisePropertiesChanged(() => ShowBestMove, () => ShowCoordinates);
			RaisePropertyChanged(() => SmtpClient);
			RaisePropertyChanged(() => SnapshotDirectory);
			RaisePropertiesChanged(() => ThemeDark, () => ThemeLight);
		}

		private static void RaiseBoardOptionsChanged()
		{
			Options.BoardOptionsChanged?.Invoke();
		}
	}
}
