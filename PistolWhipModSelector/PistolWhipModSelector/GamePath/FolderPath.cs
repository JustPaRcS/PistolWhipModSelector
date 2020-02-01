using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PistolWhipModSelector
{
    class FolderPath
    {
        public string SteamPath { get; private set; }
        public string SteamGamePath { get; private set; }
        public string GameFolderPath { get; private set; }

        public FolderPath()
        {
            this.SteamPath = this.GetSteamPath();
            if (!String.IsNullOrWhiteSpace(this.SteamPath))
            {
                this.SteamGamePath = this.GetSteamGamePath(this.SteamPath);
            }

            using (var test = new PistolWhipModSelector.GamePath.SetGamePath())
            {
                test.SteamGamePath = this.SteamGamePath;

                var result = test.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.GameFolderPath = test.CustomGamePath;
                }
            }
        }

        private string GetSteamPath()
        {
            string steamPath = "";
            steamPath = (string) Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam", "InstallPath", "");          //Get steam path from an 64-Bit system

            if(String.IsNullOrEmpty(steamPath))
                steamPath = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", "");                   //Get steam path from an 32-Bit system

            return steamPath;
        }

        private string GetSteamGamePath(string steamPath)
        {
            string gamePath = $@"{steamPath}\steamapps\common\Pistol Whip";                                                             //Try to get normal Pistol Whip steam installation path

            if (Directory.Exists(gamePath))
                return gamePath;
            else
                return "";
        }
    }
}
