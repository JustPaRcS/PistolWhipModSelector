using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PistolWhipModSelector.GamePath
{
    public partial class SetGameFolderPath : Form
    {
        public string CustomGamePath { get; set; }
        public string SteamGamePath { get; set; }

        public SetGameFolderPath()
        {
            InitializeComponent();
            GamePathErrorLabel.Text = "";

            this.Size = new Size(462, 175);

            SteamGameFolderPanel.Location = new Point(10, 10);
            CustomFolderPathPanel.Visible = false;
        }

        private void CustomPath_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.SteamGamePath))
            {
                this.SteamGamePath += "\\Pistol Whip.exe";
                SteamGameFolderPathTextBox.Text = this.SteamGamePath;
                CustomFolderPathTextBox.Text = this.SteamGamePath;
            }
            else
            {
                SteamGameFolderPanel.Visible = false;
                CustomFolderSteamButton.Visible = false;
                CustomFolderPathPanel.Visible = true;

                GamePathErrorLabel.ForeColor = Color.Red;
                GamePathErrorLabel.Text = "Steam folder could not be found!";
            }
        }

        private void SteamGameFolderPathUseButton_Click(object sender, EventArgs e)
        {
            if (CheckForExe(this.SteamGamePath))
            {
                GamePathErrorLabel.ForeColor = Color.Green;
                GamePathErrorLabel.Text = "\"Pistol Whip.exe\" found! Press OK";
                CustomGamePath = this.SteamGamePath;
            }
            else
            {
                GamePathErrorLabel.ForeColor = Color.Red;
                GamePathErrorLabel.Text = "\"Pistol Whip.exe\" could not be found! Use custom path!";
                SteamGameFolderPanel.Visible = false;
                CustomFolderPathPanel.Visible = true;
            }
        }

        private void SteamGameFolderNotUseButton_Click(object sender, EventArgs e)
        {
            SteamGameFolderPanel.Visible = false;
            CustomFolderPathPanel.Visible = true;
        }

        private void CustomFolderSearchButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string customFolderPath = openFileDialog1.FileName;
                CustomFolderPathTextBox.Text = customFolderPath;
            }
        }

        private void CustomFolderSteamButton_Click(object sender, EventArgs e)
        {
            SteamGameFolderPanel.Visible = true;
            CustomFolderPathPanel.Visible = false;
            CustomFolderPathTextBox.Text = this.SteamGamePath;
        }

        private void CustomFolderOkButton_Click(object sender, EventArgs e)
        {
            this.CustomGamePath = CustomFolderPathTextBox.Text;

            if (this.CustomGamePath.EndsWith("Pistol Whip.exe"))
                this.CustomGamePath = this.CustomGamePath.Replace("\\Pistol Whip.exe", "");

            if (!Directory.Exists(this.CustomGamePath))
            {
                GamePathErrorLabel.ForeColor = Color.Red;
                GamePathErrorLabel.Text = "Directory could not be found! Try again.";
            }
            else if (!CheckForExe(this.CustomGamePath))
            {
                GamePathErrorLabel.ForeColor = Color.Red;
                GamePathErrorLabel.Text = "\"Pistol Whip.exe\" could not be found! Try again.";
            }
            else
                this.DialogResult = DialogResult.OK;
        }

        private void CustomFolderCancelButton_Click(object sender, EventArgs e)
        {
            this.CustomGamePath = "";
        }

        private void CustomFolderPathTextBox_TextChanged(object sender, EventArgs e)
        {
            GamePathErrorLabel.Text = "";
        }

        private bool CheckForExe(string path)
        {
            if (path.EndsWith("Pistol Whip.exe"))
                path = path.Replace("\\Pistol Whip.exe", "");

            if (File.Exists(path + "\\Pistol Whip.exe"))
                return true;
            else
                return false;
        }
    }
}
