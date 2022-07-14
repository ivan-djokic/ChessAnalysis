// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using System.Media;

namespace ChessAnalysis.Utils
{
	public enum Sounds
	{
		Error,
		Flip,
		Mail,
		Save,
		Piece,
		Snapshot,
		Start
	}

	public static class Sound
	{
		public static void Play(Sounds input)
		{
			if (!Options.Instance.PlaySound)
			{
				return;
			}

			if (input == Sounds.Error)
			{
				SystemSounds.Hand.Play();
				return;
			}

			using var stream = ResourceHelper.GetSound(input);
			using var sound = new SoundPlayer(stream);
			sound.Play();
		}
	}
}
