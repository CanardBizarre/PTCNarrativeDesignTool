using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
    public class DialogueAudio
    {

        int id = -1;
        string audioFilePath = "";
        float audioLength = 0f;


        public int ID => id;
        public string AudioFilePath => audioFilePath;
        public float AudioLength { get; set; } = 0f;

        public DialogueAudio(){ }

        public DialogueAudio(int iD)
        {
            id = iD;
            audioFilePath = $"VO[{id}]";
            // TODO Make audio thing
        }
    }
}
