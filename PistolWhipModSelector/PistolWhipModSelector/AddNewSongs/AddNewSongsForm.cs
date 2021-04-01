using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PistolWhipModSelector.AddNewSongs
{
    public partial class AddNewSongsForm : Form
    {
        private string[] FileList;
        public List<NewSongProperties> newSongs;

        public AddNewSongsForm(string[] fileList)
        {
            this.FileList = fileList;
            InitializeComponent();
        }

        private void AddNewSongsForm_Load(object sender, EventArgs e)
        {
            this.NewSongsCreate();
            this.AddSongsToList();
        }

        private void NewSongsCreate()
        {
            this.newSongs = new List<NewSongProperties>();

            foreach(string file in FileList)
            {
                bool move = false;

                if (CustomSongMoveCheckBox.Checked)
                    move = true;

                NewSongProperties newSong;

                string pattern = ".*\\\\\\d*(-{1})(.*)(-{1})(.*)";
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(file))
                {
                    string[] values = Path.GetFileNameWithoutExtension(file).Split('-');
                    newSong = new NewSongProperties(values[1], values[2], file, "", move);
                }
                else
                {
                    newSong = new NewSongProperties("", "", file, "", move);
                }
                this.newSongs.Add(newSong);
            }
        }

        private void AddSongsToList()
        {
            FilesListBox.DisplayMember = "SongDestinationFileName";

            FilesListBox.DataSource = this.newSongs;
        }

        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewSongProperties destinationPath = FilesListBox.SelectedItem as NewSongProperties;

            CustomSongFileFullPathLabel.Text = destinationPath.SongDestinationPath;
            CustomSongTitleTextBox.Text = destinationPath.SongTitle;
            CustomSongAuthorTextBox.Text = destinationPath.SongAuthor;

            if (destinationPath.MoveInstedOfCopy)
                CustomSongMoveCheckBox.Checked = true;
            else
                CustomSongMoveCheckBox.Checked = false;

            CustomSongTitleTextBox.BackColor = default(Color);
            CustomSongAuthorTextBox.BackColor = default(Color);
        }

        private void SongSaveButton_Click(object sender, EventArgs e)
        {
            NewSongProperties destinationPath = FilesListBox.SelectedItem as NewSongProperties;
            
            destinationPath.SongTitle = CustomSongTitleTextBox.Text;
            destinationPath.SongAuthor = CustomSongAuthorTextBox.Text;

            if (CustomSongMoveCheckBox.Checked)
                destinationPath.MoveInstedOfCopy = true;
            else
                destinationPath.MoveInstedOfCopy = false;

            CustomSongTitleTextBox.BackColor = Color.LightGreen;
            CustomSongAuthorTextBox.BackColor = Color.LightGreen;
        }

        private void CustomSongMoveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomSongMoveCheckBox.Checked)
            {
                /*var result = MessageBox.Show("Your anti-virus program might get triggered!\n \nStill wanna enable?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    CustomSongMoveCheckBox.Checked = true;
                }

                if (result == DialogResult.Cancel)
                {
                    CustomSongMoveCheckBox.Checked = false;
                }
                */
            }
        }
    }
}
