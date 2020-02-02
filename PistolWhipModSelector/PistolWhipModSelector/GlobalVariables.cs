using PistolWhipModSelector.SaveOriginalFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolWhipModSelector
{
    public static class GlobalVariables
    {
        public static string SteamPath { get; set; } = "";
        public static string GameFolderPath { get; set; } = "";
        public static string SongsFolderPath { get; set; } = "";
        public static string ModsFolderPath { get; set; } = "";
        public static string OriginalSongsFolderPath { get; set; } = "";
        public static string CustomSongsFolderPath { get; set; } = "";
        public static string CurrentID { get; set; } = "";

        public static string GetCustomSongFolderPath(string ID)
        {
            string result = "";

            string[] directories = Directory.GetDirectories(GlobalVariables.CustomSongsFolderPath);

            foreach (string directory in directories)
            {
                if (directory.Contains(ID))
                    result = directory;
            }

            return result;
        }
    }
}
