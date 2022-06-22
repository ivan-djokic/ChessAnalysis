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

		public string MailContent
		{
			get => Options.Instance.MailContent;
			set => Options.Instance.MailContent = value;
		}

		public bool MarkIfBestMoveIsPlayed
		{
			get => Options.Instance.MarkIfBestMoveIsPlayed;
			set
			{
				if (Options.Instance.MarkIfBestMoveIsPlayed != value)
                {
					Options.Instance.MarkIfBestMoveIsPlayed = value;
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
			RaisePropertyChanged(() => MarkIfBestMoveIsPlayed);
			RaisePropertiesChanged(() => PieceClassic, () => PieceNeo, () => PieceWood);
			RaisePropertyChanged(() => PlaySound);
			RaisePropertiesChanged(() => SenderMail, () => SenderPassword);
			RaisePropertyChanged(() => ShowCoordinates);
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
