using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolWhipModSelector.AddNewSongs
{
    public class NewSongProperties
    {
        public string SongTitle { get; set; }
        public string SongAuthor { get; set; }
        public string SongDestinationPath { get; private set; }
        public string SongDestinationFileName { get => SeperateFileName(this.SongDestinationPath); }
        public string SongTargetPath { get; set; }
        public bool MoveInstedOfCopy { get; set; } = false;

        public NewSongProperties(string songTitle, string songAuthor, string songDestinationPath, string songTargetPath, bool moveInstedOfCopy)
        {
            this.SongTitle = songTitle;
            this.SongAuthor = songAuthor;
            this.SongDestinationPath = songDestinationPath;
            this.SongTargetPath = songTargetPath;
            this.MoveInstedOfCopy = moveInstedOfCopy;
        }

        private string SeperateFileName(string path)
        {
            return path.Split('\\').Last();
        }
    }
}
