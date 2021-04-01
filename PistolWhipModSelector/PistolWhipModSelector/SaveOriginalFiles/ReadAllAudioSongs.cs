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

        public ReadAllAudioSongs()
        {
            this.AudioLines = this.GetAudioLines();
        }

        private List<AudioLineProperties> GetAudioLines(bool tryAgain = false)
        {
            string filePath = GlobalVariables.GameFolderPath + @"\Pistol Whip_Data\StreamingAssets\Audio\GeneratedSoundBanks\Windows\Global.txt";

            List<AudioLineProperties> audios = new List<AudioLineProperties>();

            try
            {
                using (StreamReader file = new StreamReader(filePath))
                {
                    string line;
                    bool memoryAudioSectionFound = false;

                    while ((line = file.ReadLine()) != null)
                    {
                        if (memoryAudioSectionFound && !String.IsNullOrWhiteSpace(line) && line.Contains("\\Music\\") && !line.Contains("mus_landing_area_lp") && !line.Contains("mus_tutorial") && !line.Contains("visualizer"))
                        {
                            AudioLineProperties currentAudioLine = this.TrimAudioLines(line);
                            if(!audios.Exists(x=> x.ID == currentAudioLine.ID))
                                audios.Add(currentAudioLine);
                        }
                        else
                        {
                            if (line.Contains("In Memory Audio"))
                                memoryAudioSectionFound = true;
                        }
                    }
                    file.Close();
                }
            }
            catch(DirectoryNotFoundException)
            {
                if (!tryAgain)
                {
                    GamePath.FolderPath folderPath = new GamePath.FolderPath(true);
                    audios = this.GetAudioLines(true);
                }
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
