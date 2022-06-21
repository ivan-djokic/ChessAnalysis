using System.IO;
using System.Xml.Serialization;
using Color = System.Windows.Media.Color; // XML serialization can not serialize System.Drawing.Color, so here is an alternative

namespace ChessAnalysis.Utils
{
    public partial class Options
	{
		private static readonly Lazy<Options> s_instance = new(CreateInstance);

		public Color FieldEmptyColor { get; set; }

		public Color FieldFillColor { get; set; }

		public static Options Instance
		{
			get => s_instance.Value;
		}

		public string LastInputDirectory { get; set; }

		public string LastOutputDirectory { get; set; }

		public string MailContent { get; set; }

		public bool MarkIfBestMoveIsPlayed { get; set; }

		public string OptionsDirectory { get; set; }

		public PieceStyles PieceStyle { get; set; }

		public bool PlaySound { get; set; }

		public string ReceiverMail { get; set; }

		public string SenderMail { get; set; }

		public string SenderPassword { get; set; }

		public bool ShowCoordinates { get; set; }

		public string SmtpClient { get; set; }

		public string SnapshotDirectory { get; set; }

		public Themes Theme { get; set; }

		public bool WhiteOrientedBoard { get; set; }

		public void Save()
		{
			var senderPassword = SenderPassword;

			try
            {
				SenderPassword = Crypto.Encrypt(SenderPassword);

				using var writer = new StreamWriter(Path.Combine(OptionsDirectory, Constants.OPTIONS_FILE_NAME));
				new XmlSerializer(typeof(Options)).Serialize(writer, this);
			}
			finally
            {
				SenderPassword = senderPassword;
            }
		}

		public void SetDefaults(bool raiseOnChange = true)
		{
			FieldEmptyColor = Color.FromArgb(255, 238, 236, 225);
			FieldFillColor = Color.FromArgb(255, 79, 129, 189);
			MarkIfBestMoveIsPlayed = true;
			OptionsDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Constants.APP_NAME);
			PieceStyle = PieceStyles.Classic;
			PlaySound = true;
			SenderMail = "chess.analysis.bot@gmail.com";
			SenderPassword = "ihlwdcigekjkqonl";
			ShowCoordinates = true;
			SmtpClient = "smtp.gmail.com";
			SnapshotDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), Constants.APP_NAME, Constants.SNAPSHOTS_DIR);
			Theme = Themes.Dark;
			WhiteOrientedBoard = true;

			if (raiseOnChange)
			{
				RaiseOnChange();
			}
		}

		private void CopyTo(Options options)
		{
			options.FieldEmptyColor = FieldEmptyColor;
			options.FieldFillColor = FieldFillColor;
			options.LastInputDirectory = LastInputDirectory;
			options.LastOutputDirectory = LastOutputDirectory;
			options.MailContent = MailContent;
			options.MarkIfBestMoveIsPlayed = MarkIfBestMoveIsPlayed;
			options.OptionsDirectory = OptionsDirectory;
			options.PieceStyle = PieceStyle;
			options.PlaySound = PlaySound;
			options.ReceiverMail = ReceiverMail;
			options.SenderMail = SenderMail;
			options.SenderPassword = Crypto.Decrypt(SenderPassword);
			options.ShowCoordinates = ShowCoordinates;
			options.SmtpClient = SmtpClient;
			options.SnapshotDirectory = SnapshotDirectory;
			options.Theme = Theme;
			options.WhiteOrientedBoard = WhiteOrientedBoard;
		}

		private static Options CreateInstance()
        {
			var options = new Options();
			options.Load();
			options.CreateDirsIfNotExist();
			return options;
		}

		private void CreateDirsIfNotExist()
        {
			FileHelper.CreateDirIfNotExists(OptionsDirectory);
			FileHelper.CreateDirIfNotExists(SnapshotDirectory);
        }

		private void Load()
		{
			try
			{
				using var reader = new StreamReader(Path.Combine(OptionsDirectory, Constants.OPTIONS_FILE_NAME));
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
