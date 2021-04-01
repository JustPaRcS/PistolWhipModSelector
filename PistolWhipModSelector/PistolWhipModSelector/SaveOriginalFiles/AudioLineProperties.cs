using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PistolWhipModSelector.SaveOriginalFiles
{
    public class AudioLineProperties
    {
        public string InMemoryAudio { get; private set; }
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string AudioSourceFile { get; private set; }
        public string WwiseObjectPath { get; private set; }
        public string Notes { get; private set; }
        public string DataSize { get; private set; }
        public string AudioName{ get; private set; }
        public string AudioSectionName { get; private set; }
        public string AudioNameID { get; private set; }

        public AudioLineProperties(string inMemoryAudio, string id, string name, string audioSourceFile, string wWiseObjectPath, string notes, string dataSize)
        {
            this.InMemoryAudio = inMemoryAudio;
            this.ID = id;
            this.Name = name;
            this.AudioSourceFile = audioSourceFile;
            this.WwiseObjectPath = wWiseObjectPath;
            this.Notes = notes;
            this.DataSize = dataSize;

            this.SetOthers();
        }

        private void SetOthers()
        {
            string[] pathSplit = this.Notes.Split('\\');
            this.AudioName = pathSplit[5]; //Only audio name
            this.AudioSectionName = pathSplit[4]; //Section name
            this.AudioNameID = this.ID + " - " + this.AudioName;
        }
    }
}
