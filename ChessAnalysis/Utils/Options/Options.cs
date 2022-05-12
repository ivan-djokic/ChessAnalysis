using System.IO;
using System.Xml.Serialization;
using Color = System.Windows.Media.Color; // XML serialization can not serialize System.Drawing.Color, so here is an alternative

namespace ChessAnalysis.Utils
{
	public partial class Options
	{
		private readonly string m_optionsFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
				Constants.APP_NAME, Constants.OPTIONS_FILE_NAME);

		private static readonly Lazy<Options> s_instance = new(() => CreateOptions());

		public bool AutoFlipBoard { get; set; }

		public string DefaultSnapshotDirectory { get; set; }

		public Color FieldEmptyColor { get; set; }

		public Color FieldFillColor { get; set; }

		public static Options Instance
		{
			get => s_instance.Value;
		}

		public Languages Language { get; set; }

		public bool MarkIfBestMoveIsPlayed { get; set; }

		public PieceStyles PieceStyle { get; set; }

		public bool PlaySound { get; set; }

		public bool ShowCoordinates { get; set; }

		public Themes Theme { get; set; }

		public void Save()
		{
			using var writer = new StreamWriter(m_optionsFileName);
			new XmlSerializer(typeof(Options)).Serialize(writer, this);
		}

		public void SetDefaults(bool raiseOnChange = true)
		{
			AutoFlipBoard = true;
			DefaultSnapshotDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Constants.APP_NAME, Constants.SNAPSHOTS_DIR);
			FieldEmptyColor = Color.FromArgb(255, 230, 230, 230);
			FieldFillColor = Color.FromArgb(255, 135, 206, 235);
			Language = Languages.English;
			MarkIfBestMoveIsPlayed = true;
			PieceStyle = PieceStyles.Classic;
			PlaySound = true;
			ShowCoordinates = true;
			Theme = Themes.Dark;

			if (raiseOnChange)
			{
				RaiseOnChange();
			}
		}

		private void CopyTo(Options options)
		{
			options.AutoFlipBoard = AutoFlipBoard;
			options.DefaultSnapshotDirectory = DefaultSnapshotDirectory;
			options.FieldEmptyColor = FieldEmptyColor;
			options.FieldFillColor = FieldFillColor;
			options.Language = Language;
			options.MarkIfBestMoveIsPlayed = MarkIfBestMoveIsPlayed;
			options.PieceStyle = PieceStyle;
			options.PlaySound = PlaySound;
			options.ShowCoordinates = ShowCoordinates;
			options.Theme = Theme;
		}

		private static Options CreateOptions()
        {
			var options = new Options();
			options.Load();
			options.CreateDirsIfNotExist();
			return options;
		}

		private void CreateDirsIfNotExist()
        {
			FileHelper.CreateDirIfNotExists(m_optionsFileName);
			FileHelper.CreateDirIfNotExists(DefaultSnapshotDirectory);
        }

		private void Load()
		{
			try
			{
				using var reader = new StreamReader(m_optionsFileName);
				var options = new XmlSerializer(typeof(Options)).Deserialize(reader) as Options;
				options?.CopyTo(this);
			}
			catch
			{
				SetDefaults(false);
			}
		}
    }
}
