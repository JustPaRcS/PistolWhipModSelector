using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PistolWhipModSelector.Settings;
using PistolWhipModSelector.SaveOriginalFiles;

namespace PistolWhipModSelector
{
    public partial class MainForm : Form
    {
        private PistolWhipModSettings folderSettings;
        public MainForm(PistolWhipModSettings modSettings)
        {
            this.folderSettings = modSettings;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadAllAudioSongs readAllAudioSongs = new ReadAllAudioSongs(this.folderSettings.GetGameFolderPath());
        }
    }
}
