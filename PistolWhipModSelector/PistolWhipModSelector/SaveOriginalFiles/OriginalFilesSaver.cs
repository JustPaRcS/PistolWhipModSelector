using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolWhipModSelector.SaveOriginalFiles
{
    class OriginalFilesSaver
    {
        private List<AudioLineProperties> audioLines;
        public OriginalFilesSaver(List<AudioLineProperties> audioLines)
        {
            this.audioLines = audioLines;
            this.CheckForFiles();
        }

        private void CheckForFiles()
        {
            if(Directory.GetFiles(GlobalVariables.OriginalSongsFolderPath).Count() < audioLines.Count)
            {
                this.BackupOriginalFiles();
            }
        }

        private void BackupOriginalFiles()
        {
            foreach (AudioLineProperties lineProperties in audioLines)
            {
                string file = lineProperties.ID + ".wem";
                File.Copy(GlobalVariables.SongsFolderPath + @"\" + file, GlobalVariables.OriginalSongsFolderPath + @"\" + lineProperties.ID + ".wem", true);
            }
        }
    }
}
