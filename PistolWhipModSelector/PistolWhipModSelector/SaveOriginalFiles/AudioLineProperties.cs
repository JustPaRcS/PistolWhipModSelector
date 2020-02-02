using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolWhipModSelector.SaveOriginalFiles
{
    public class AudioLineProperties
    {
        public string StreamedAudio { get; private set; }
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string AudioSourceFile { get; private set; }
        public string GeneratedAudioFile { get; private set; }
        public string WwiseObjectPath { get; private set; }
        public string Notes { get; private set; }
        public string AudioName{ get => this.GetComparedName(); }
        public string AudioNameID { get => this.GetComparedNameID(); }

        public AudioLineProperties(string streamedAudio, string id, string name, string audioSourceFile, string generatedAudioFile, string wWiseObjectPath, string notes)
        {
            this.StreamedAudio = streamedAudio;
            this.ID = id;
            this.Name = name;
            this.AudioSourceFile = audioSourceFile;
            this.GeneratedAudioFile = generatedAudioFile;
            this.WwiseObjectPath = wWiseObjectPath;
            this.Notes = notes;
        }

        private string GetComparedName()
        {
            string result = null;

            result = this.WwiseObjectPath.Replace("\\" + this.Name, "");
            result = result.Split('\\').Last();

            return result;
        }

        private string GetComparedNameID()
        {
            string result = null;

            result = this.AudioNameID + " - " + this.AudioName;

            return result;
        }
    }
}
