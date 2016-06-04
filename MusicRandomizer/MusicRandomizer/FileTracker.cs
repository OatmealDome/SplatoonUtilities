using System;
using System.Collections.Generic;

namespace MusicRandomizer
{
    class FileTracker
    {
        public List<MusicFile> files = new List<MusicFile>();
        private List<MusicFile> playedFiles = new List<MusicFile>();
        private int playlistIndex = -1;

        public MusicFile getTrack(PlayMode mode)
        {
            if (files.Count == 0)
            {
                return null;
            }

            if (mode != PlayMode.InOrder)
            {
                if (playedFiles.Count == files.Count)
                {
                    playedFiles.Clear();
                }

                random:
                int chosenIndex = MainForm.random.Next(0, files.Count);
                MusicFile musicFile = files[chosenIndex];

                if (mode == PlayMode.Shuffle && playedFiles.Contains(musicFile))
                {
                    goto random;
                }

                playedFiles.Add(musicFile);
                return musicFile;
            }
            else
            {
                playlistIndex++;

                if (playlistIndex >= files.Count)
                {
                    playlistIndex = 0;
                }

                return files[playlistIndex];
            }
        }
    }
}
