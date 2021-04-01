using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PistolWhipModSelector.GamePath;
using PistolWhipModSelector.Settings;

namespace PistolWhipModSelector
{
    static class Program
    {
        public static PistolWhipModSettings modSettings;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program.modSettings = new PistolWhipModSettings();
            FolderPath folderPath = new FolderPath();

            if (folderPath.ForceExit == false)
            {
                folderPath.RenewGlobalPaths();

                ModsFolder modsFolder = new ModsFolder();

                Application.Run(new MainForm(modsFolder));
            }
        }
    }
}
