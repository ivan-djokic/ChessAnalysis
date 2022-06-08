﻿using System.Media;
using ChessAnalysis.Properties;

namespace ChessAnalysis.Utils
{
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

            using var stream = Resources.GetSound(input);
            using var sound = new SoundPlayer(stream);
            sound.Play();
        }
    }
}
