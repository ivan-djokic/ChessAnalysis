using System.IO;

namespace ChessAnalysis.Utils
{
    public static class FileHelper
    {
        public static void CreateDirIfNotExists(string path)
        {
            path = GetDirectoryName(path);

            if (string.IsNullOrEmpty(path) || Directory.Exists(path))
            {
                return;
            }

            try
            {
                Directory.CreateDirectory(path);
            }
            catch
            {
            }
        }

        private static string GetDirectoryName(string path)
        {
            if (string.IsNullOrEmpty(Path.GetExtension(path)))
            {
                return path;
            }

            return Path.GetDirectoryName(path) ?? string.Empty;
        }
    }
}
