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
        private List<AudioLineProperties> audioLines = null;
        private ModsFolder modsFolder = null;

        public MainForm(ModsFolder modsFolder)
        {
            this.modsFolder = modsFolder;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadAllAudioSongs readAllAudioSongs = new ReadAllAudioSongs(GlobalVariables.GameFolderPath);
            this.audioLines = readAllAudioSongs.AudioLines;

            OriginalFilesSaver originalFilesSaver = new OriginalFilesSaver(this.audioLines);
            modsFolder.AvaiableCustomSongsFolder(audioLines);

            this.FillOriginalSongNamesList();
        }

        private void OriginalSongCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OriginalSongNamesListBox.Items.Clear();
            FillOriginalSongNamesList();
        }
        private void FillOriginalSongNamesList()
        {
            foreach (AudioLineProperties properties in audioLines)
            {
                string newItem = "";

                if (OriginalSongShowIDCheckBox.Checked && OriginalSongShowNameCheckBox.Checked)
                {
                    newItem = properties.ID + " - " + properties.AudioName;
                }
                else if (OriginalSongShowIDCheckBox.Checked)
                {
                    newItem = properties.ID;
                }
                else if (OriginalSongShowNameCheckBox.Checked)
                {
                    newItem = properties.AudioName;
                }
                else
                {
                    break;
                }

                OriginalSongNamesListBox.Items.Add(newItem);
            }
        }
    }
}
