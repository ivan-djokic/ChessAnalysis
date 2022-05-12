using System.Media;

namespace ChessAnalysis.Utils
{
    public static class SoundPlay
    {
        public static void Snapshot()
        {
            Play(@"C:\Users\IDjokic\Downloads\CameraSound.wav");
        }

        private static void Play(string input)
        {
            if (!Options.Instance.PlaySound)
            {
                return;
            }

            using var sound = new SoundPlayer(input);
            sound.Play();
        }
    }
}
