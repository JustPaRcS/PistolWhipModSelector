using PistolWhipModSelector.SaveOriginalFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolWhipModSelector.Settings
{
    public class ModsFolder
    {
        public ModsFolder()
        {
            GlobalVariables.ModsFolderPath = GlobalVariables.GameFolderPath + @"\Mods";
            GlobalVariables.OriginalSongsFolderPath = GlobalVariables.ModsFolderPath + @"\Original";
            GlobalVariables.CustomSongsFolderPath = GlobalVariables.ModsFolderPath + @"\Custom Songs";

            this.CheckModsFolder();
            this.CheckOriginalSongsFolder();
            this.CheckCustomSongsFolder();
        }

        private void CheckModsFolder()
        {
            if (!Directory.Exists(GlobalVariables.ModsFolderPath))
            {
                this.CreateModsFolder();
            }
        }
        private void CreateModsFolder()
        {
            Directory.CreateDirectory(GlobalVariables.ModsFolderPath);
        }

        private void CheckOriginalSongsFolder()
        {
            if (!Directory.Exists(GlobalVariables.OriginalSongsFolderPath))
            {
                this.CreateOriginalSongsFolder();
            }
        }
        private void CreateOriginalSongsFolder()
        {
            Directory.CreateDirectory(GlobalVariables.OriginalSongsFolderPath);
        }

        private void CheckCustomSongsFolder()
        {
            if (!Directory.Exists(GlobalVariables.CustomSongsFolderPath))
            {
                this.CreateCustomSongsFolder();
            }
        }
        private void CreateCustomSongsFolder()
        {
            Directory.CreateDirectory(GlobalVariables.CustomSongsFolderPath);
        }

        public void AvaiableCustomSongsFolder(List<AudioLineProperties> audioLines)
        {
            string path = "";

            foreach (AudioLineProperties properties in audioLines)
            {
                path = GlobalVariables.CustomSongsFolderPath + $@"\{properties.ID} - {properties.AudioName}";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
        }
    }
}
