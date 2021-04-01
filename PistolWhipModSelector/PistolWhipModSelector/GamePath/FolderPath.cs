using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PistolWhipModSelector.Settings;

namespace PistolWhipModSelector.GamePath
{
    class FolderPath
    {
        public string SteamGamePath { get; private set; }
        public bool ForceExit { get; private set; } = false;

        public FolderPath(bool forceChange = false)
        {
            if (String.IsNullOrWhiteSpace(Program.modSettings.GetGameFolderPath()) || forceChange == true)
            {
                GlobalVariables.SteamPath = this.GetSteamPath();
                if (!String.IsNullOrWhiteSpace(GlobalVariables.SteamPath))
                {
                    this.SteamGamePath = this.GetSteamGamePath(GlobalVariables.SteamPath);
                }

                using (var form = new SetGameFolderPathForm())
                {
                    form.SteamGamePath = this.SteamGamePath;

                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        GlobalVariables.GameFolderPath = form.CustomGamePath;
                        Program.modSettings.SetGameFolderPath(GlobalVariables.GameFolderPath);
                    }

                    if (result == DialogResult.Cancel)
                    {
                        if (String.IsNullOrWhiteSpace(Program.modSettings.GetGameFolderPath()))
                        {
                            MessageBox.Show("Forced exit because no game folder is set!", "No folder set!");
                            this.ForceExit = true;
                        }
                    }
                }

                this.RenewGlobalPaths();
            }
        }

        public void RenewGlobalPaths()
        {
            GlobalVariables.GameFolderPath = Program.modSettings.GetGameFolderPath();
            GlobalVariables.SongsFolderPath = Program.modSettings.GetGameFolderPath() + @"\Pistol Whip_Data\StreamingAssets\Audio\GeneratedSoundBanks\Windows";
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
