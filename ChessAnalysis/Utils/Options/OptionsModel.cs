using DevExpress.Mvvm;

namespace ChessAnalysis.Utils
{
	public class OptionsModel : ViewModelBase
	{
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
				Options.Instance.FieldEmptyColor = value.Normalize();
				Options.BoardOptionsChanged?.Invoke();
			}
		}
		
		public Color FieldFillColor
		{
			get => Options.Instance.FieldFillColor.Normalize();
			set
			{
				Options.Instance.FieldFillColor = value.Normalize();
				Options.BoardOptionsChanged?.Invoke();
			}
		}
		
		public bool LanguageEnglish
		{
			get => Options.Instance.Language == Languages.English;
			set
			{
				Options.Instance.Language = Languages.English;
				//TODO: Invoke language changer here
			}
		}

		public bool LanguageSrpski
		{
			get => Options.Instance.Language == Languages.Srpski;
			set
			{
				Options.Instance.Language = Languages.Srpski;
				//TODO: Invoke language changer here
			}
		}
		
		public bool MarkIfBestMoveIsPlayed
		{
			get => Options.Instance.MarkIfBestMoveIsPlayed;
			set
			{
				Options.Instance.MarkIfBestMoveIsPlayed = value;
				Options.BoardOptionsChanged?.Invoke();
			}
		}

		public bool PieceClassic
		{
			get => Options.Instance.PieceStyle == PieceStyles.Classic;
			set
			{
				Options.Instance.PieceStyle = PieceStyles.Classic;
				Options.BoardOptionsChanged?.Invoke();
			}
		}

		public bool PieceNeo
		{
			get => Options.Instance.PieceStyle == PieceStyles.Neo;
			set
			{
				Options.Instance.PieceStyle = PieceStyles.Neo;
				Options.BoardOptionsChanged?.Invoke();
			}
		}

		public bool PieceWood
		{
			get => Options.Instance.PieceStyle == PieceStyles.Wood;
			set
			{
				Options.Instance.PieceStyle = PieceStyles.Wood;
				Options.BoardOptionsChanged?.Invoke();
			}
		}

		public bool ShowCoordinates
		{
			get => Options.Instance.ShowCoordinates;
			set
			{
				Options.Instance.ShowCoordinates = value;
				Options.BoardOptionsChanged?.Invoke();
			}
		}

		public bool ThemeDark
        {
			get => Options.Instance.Theme == Themes.Dark;
			set
			{
				Options.Instance.Theme = Themes.Dark;
				Theming.ApplyTheme();
			}
        }

		public bool ThemeLight
		{
			get => Options.Instance.Theme == Themes.Light;
			set
			{
				Options.Instance.Theme = Themes.Light;
				Theming.ApplyTheme();
			}
		}

		public void RaisePropertiesChanged()
        {
			RaisePropertyChanged(() => DefaultSnapshotDirectory);
			RaisePropertyChanged(() => FieldEmptyColor);
			RaisePropertyChanged(() => FieldFillColor);
			RaisePropertiesChanged(() => LanguageEnglish, () => LanguageSrpski);
			RaisePropertyChanged(() => MarkIfBestMoveIsPlayed);
			RaisePropertiesChanged(() => PieceClassic, () => PieceNeo, () => PieceWood);
			RaisePropertyChanged(() => ShowCoordinates);
			RaisePropertiesChanged(() => ThemeDark, () => ThemeLight);
		}
	}
}
