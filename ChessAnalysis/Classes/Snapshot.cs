using ChessAnalysis.Utils;
using System.IO;

namespace ChessAnalysis.Classes
{
    public static class Snapshot
    {
        public static void Save(Image image, string fileName)
        {
            try
            {
                FileHelper.CreateDirIfNotExists(Options.Instance.SnapshotDirectory);
                image.Save(Path.Combine(Options.Instance.SnapshotDirectory, $"{fileName}{Constants.SNAPSHOT_EXTENSION}"));
                SoundPlay.Snapshot();
            }
            catch
            {
                throw new Exception("Failed to snapshot image. Change Snapshot directory in Options and try again");
            }
        }
    }
}
