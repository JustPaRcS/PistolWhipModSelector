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
using System.IO;

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

            GlobalVariables.GetCustomSongFolderPath(audioLines[3].ID);

            this.FillOriginalSongNamesList();
        }
        private void ReloadAllButton_Click(object sender, EventArgs e)
        {
            this.ReloadSongs();
        }

        private void ReloadSongs()
        {
            OriginalSongNamesListBox.SetSelected(OriginalSongNamesListBox.SelectedIndex, true);
        }

        private void OriginalSongCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OriginalSongNamesListBox.Items.Clear();
            FillOriginalSongNamesList();
        }
        private void FillOriginalSongNamesList()
        {
            OriginalSongNamesListBox.Items.Clear();

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

        private void OriginalSongNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomSongsDataGridView.Rows.Clear();

            string customSongsFolderPath = GlobalVariables.GetCustomSongFolderPath(audioLines[OriginalSongNamesListBox.SelectedIndex].ID);

            GlobalVariables.CurrentID = audioLines[OriginalSongNamesListBox.SelectedIndex].ID;

            string[] files = Directory.GetFiles(customSongsFolderPath, "*.wem");

            if (files.Count() > 0)
            {
                CustomSongsDataGridView.Rows.Add(files.Count());
                int counter = 0;
                foreach (string file in files)
                {
                    var row = CustomSongsDataGridView.Rows[counter];
                    row.Cells["songPath"].Value = file;

                    string fileName = file.Replace(customSongsFolderPath + "\\", "");
                    fileName = fileName.Replace(".wem", "");

                    string[] sort = fileName.Split('-');

                    Array.Resize(ref sort, 4);

                    string id = sort[0];
                    string title = sort[1];
                    string author = sort[2];

                    row.Cells["songTitle"].Value = title;
                    row.Cells["songAuthor"].Value = author;

                    counter++;
                }
            }

            CustomSongsDataGridView.AllowDrop = true;
            CustomSongsDeleteButton.Enabled = true;
            CustomSongsEditButton.Enabled = true;
            CustomSongsReplaceButton.Enabled = true;
            CustomSongsResetButton.Enabled = true;
            ReloadAllButton.Enabled = true;
        }

        private void CustomSongsDataGridView_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            AddNewSongs.AddNewSongs addNewSongs = new AddNewSongs.AddNewSongs(fileList);

            this.ReloadSongs();
        }

        private void CustomSongsDataGridView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void CustomSongsResetButton_Click(object sender, EventArgs e)
        {
            string destinationPath = GlobalVariables.ModsFolderPath + "\\Original\\" + GlobalVariables.CurrentID + ".wem";

            this.ReplaceSong(destinationPath);
        }

        private void CustomSongsReplaceButton_Click(object sender, EventArgs e)
        {
            string destinationPath = this.GetDestinationPath();

            if (!String.IsNullOrWhiteSpace(destinationPath))
            {
                this.ReplaceSong(destinationPath);
            }
        }

        private void CustomSongsDeleteButton_Click(object sender, EventArgs e)
        {
            string path = this.GetDestinationPath();

            if (!String.IsNullOrWhiteSpace(path))
            {
                File.Delete(path);
            }
            this.ReloadSongs();
        }

        private void CustomSongsEditButton_Click(object sender, EventArgs e)
        {
            string[] path = { this.GetDestinationPath() };

            if (!String.IsNullOrWhiteSpace(path[0]))
            {
                AddNewSongs.AddNewSongs songs = new AddNewSongs.AddNewSongs(path);

                if(songs.changed)
                    File.Delete(path[0]);

                this.ReloadSongs();
            }
        }

        private void ReplaceSong(string destinationPath)
        {
            string targetPath = GlobalVariables.SongsFolderPath + "\\" + GlobalVariables.CurrentID + ".wem";
            File.Copy(destinationPath, targetPath, true);
        }

        private string GetDestinationPath()
        {
            if (CustomSongsDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = CustomSongsDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = CustomSongsDataGridView.Rows[selectedrowindex];
                string destinationPath = Convert.ToString(selectedRow.Cells["songPath"].Value);

                return destinationPath;
            }

            return null;
        }
    }
}
