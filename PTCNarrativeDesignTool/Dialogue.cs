using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
    public class Dialogue
    {
        public int ID { get; set; } = -1;

        // ID given by the character
        public int LastId { set; get; }
        public DialogueLine Line { get; set; } = new DialogueLine();
        public DialogueAudio Audio { get; set; } = new DialogueAudio();

        public Dialogue() { }
        public Dialogue(int _id, DialogueLine _line, DialogueAudio _audio)
        {
            ID = _id;
            Line = _line;
            Audio = _audio;
        }

        public override string ToString()
        {
            return $"Dialogue ID :{ID}\n" +
                   $"FULL_ID : {LastId}\n" +
                   $"Line : {Line.Text}\n" +
                   $"Audio Path : {Audio.AudioFilePath}\n" +
                   $"Audio Length: {Audio.AudioLength}";

        }

    }
}
