using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolWhipModSelector.SaveOriginalFiles
{
    class ReadAllAudioSongs
    {
        public List<AudioLineProperties> AudioLines { get; private set; }
        private string GameFolderPath { get; set; }

        public ReadAllAudioSongs(string gameFolderPath)
        {
            this.GameFolderPath = gameFolderPath;

            this.AudioLines = this.GetAudioLines();
        }

        private List<AudioLineProperties> GetAudioLines()
        {
            string filePath = GameFolderPath + @"\Pistol Whip_Data\StreamingAssets\Audio\GeneratedSoundBanks\Windows\Global.txt";

            List<AudioLineProperties> audios = new List<AudioLineProperties>();

            using (StreamReader file = new StreamReader(filePath))
            {
                string line;
                bool found = false;

                while ((line = file.ReadLine()) != null)
                {
                    if(found == true && !String.IsNullOrWhiteSpace(line) && !line.Contains("visualizer") && !line.Contains("tutorial"))
                    {
                        audios.Add(TrimAudioLines(line));
                    }

                    if (line.Contains("Streamed Audio"))
                        found = true;
                }
                file.Close();
            }

            return audios;

        }

        private AudioLineProperties TrimAudioLines(string line)
        {
            AudioLineProperties newProperties = null;

            string[] properties = line.Split("\t".ToCharArray());
            Array.Resize(ref properties, 7);

            newProperties = new AudioLineProperties(properties[0], properties[1], properties[2], properties[3], properties[4], properties[5], properties[6]);

            return newProperties;
        }
    }
}
