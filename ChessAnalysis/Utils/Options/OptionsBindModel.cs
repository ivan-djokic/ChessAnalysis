using DevExpress.Mvvm;

namespace ChessAnalysis.Utils
{
	public class OptionsBindModel : ViewModelBase
	{
		public bool AutoFlipBoard
		{
			get => Options.Instance.AutoFlipBoard;
			set
			{
				if (Options.Instance.AutoFlipBoard != value)
                {
					Options.Instance.AutoFlipBoard = value;
					RaiseBoardOptionsChanged(true);
				}
			}
		}
		
		public string DefaultSnapshotDirectory
		{
			get => Options.Instance.DefaultSnapshotDirectory;
			set => Options.Instance.DefaultSnapshotDirectory = value;
		}

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
		
		public bool LanguageEnglish
		{
			get => Options.Instance.Language == Languages.English;
			set
			{
				if (value)
				{
					Options.Instance.Language = Languages.English;
					//TODO: Invoke language changer here
				}
			}
		}

		public bool LanguageSrpski
		{
			get => Options.Instance.Language == Languages.Srpski;
			set
			{
				if (value)
				{
					Options.Instance.Language = Languages.Srpski;
					//TODO: Invoke language changer here
				}
			}
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

		public bool ShowCoordinates
		{
			get => Options.Instance.ShowCoordinates;
			set
			{
				Options.Instance.ShowCoordinates = value;
				RaiseBoardOptionsChanged();
			}
		}

		public bool ThemeDark
        {
			get => Options.Instance.Theme == Themes.Dark;
			set
			{
				if (value)
				{
					Options.Instance.Theme = Themes.Dark;
					Theming.ApplyTheme();
				}
			}
        }

		public bool ThemeLight
		{
			get => Options.Instance.Theme == Themes.Light;
			set
			{
				if (value)
                {
					Options.Instance.Theme = Themes.Light;
					Theming.ApplyTheme();
				}
			}
		}

		public void RaisePropertiesChanged()
        {
			RaisePropertyChanged(() => AutoFlipBoard);
			RaisePropertyChanged(() => DefaultSnapshotDirectory);
			RaisePropertiesChanged(() => FieldEmptyColor, () => FieldFillColor);
			RaisePropertiesChanged(() => LanguageEnglish, () => LanguageSrpski);
			RaisePropertyChanged(() => MarkIfBestMoveIsPlayed);
			RaisePropertiesChanged(() => PieceClassic, () => PieceNeo, () => PieceWood);
			RaisePropertyChanged(() => PlaySound);
			RaisePropertyChanged(() => ShowCoordinates);
			RaisePropertiesChanged(() => ThemeDark, () => ThemeLight);
		}

		private void RaiseBoardOptionsChanged(bool autoFlipBoardChanged = false)
		{
			Options.BoardOptionsChanged?.Invoke(autoFlipBoardChanged);
		}
	}
}
