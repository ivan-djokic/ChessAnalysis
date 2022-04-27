using System.IO;
using System.Xml.Serialization;

namespace ChessAnalysis.Utils
{
	public class Options
	{
		private static readonly Lazy<Options> s_instance = new(Create);

		private readonly string m_optionsFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
				Constants.APP_NAME, Constants.OPTIONS_FILE_NAME);

		private Options()
		{
		}

		public string DefaultSnapshotDirectory { get; set; }

		public bool DrawCoordinates { get; set; }

		public Color EmptyFieldsColor { get; set; }

		public Color FillFieldsColor { get; set; }

		public static Options Instance
		{
			get => s_instance.Value;
		}

		public bool MarkIfMoveIsTheBest { get; set; }

		public PieceStyles PieceStyle { get; set; }

		public Themes Theme { get; set; }

		public Options Clone()
		{
			var options = new Options();
			CopyTo(options);
			return options;
		}

		public void Save()
		{
			using var writer = new StreamWriter(m_optionsFileName);
			new XmlSerializer(typeof(Options)).Serialize(writer, this);
		}

		public void SetDefaults()
		{
			DefaultSnapshotDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Constants.APP_NAME, Constants.SNAPSHOTS_DIR);
			DrawCoordinates = true;
			EmptyFieldsColor = Color.LightGray;
			FillFieldsColor = Color.SkyBlue;
			MarkIfMoveIsTheBest = true;
			PieceStyle = PieceStyles.Wood;
			Theme = Themes.Dark;
		}

		public void CopyTo(Options options)
		{
			options.DefaultSnapshotDirectory = DefaultSnapshotDirectory;
			options.DrawCoordinates = DrawCoordinates;
			options.EmptyFieldsColor = EmptyFieldsColor;
			options.FillFieldsColor = FillFieldsColor;
			options.MarkIfMoveIsTheBest = MarkIfMoveIsTheBest;
			options.PieceStyle = PieceStyle;
			options.Theme = Theme;
		}

		private static Options Create()
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
				SetDefaults();
			}
		}
    }
}
