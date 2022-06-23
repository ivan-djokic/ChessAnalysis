using System.IO;

namespace ChessAnalysis.Utils
{
	public static class FileHelper
	{
		public static void CreateDirIfNotExists(string input)
		{
			input = GetDirectoryName(input);

			if (string.IsNullOrEmpty(input) || Directory.Exists(input))
			{
				return;
			}

			try
			{
				Directory.CreateDirectory(input);
			}
			catch
			{
			}
		}

		public static string GetDirectoryName(string input)
		{
			if (IsDirectory(input))
			{
				return input;
			}

			return Path.GetDirectoryName(input) ?? string.Empty;
		}

		public static void Save(string fileName, string content)
		{
			CreateDirIfNotExists(fileName);
			File.WriteAllText(fileName, content);
		}

		private static bool IsDirectory(string input)
		{
			return string.IsNullOrEmpty(Path.GetExtension(input));
		}
	}
}
