using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
    public class Dialogue
    {

        int id = -1;
        DialogueLine line = new DialogueLine();
        DialogueAudio audio = new DialogueAudio();

        public int ID => id;

        // ID given by the character
        public int LastId { set; get; }
        public DialogueLine Line =>  line;
        public DialogueAudio Audio => audio;

        public Dialogue() { }
        public Dialogue(int _id, DialogueLine _line, DialogueAudio _audio)
        {
            id = _id;
            line = _line;
            audio = _audio;
        }

        public override string ToString()
        {
            return $"Dialogue ID :{id}\n" +
                   $"FULL_ID : {LastId}\n" +
                   $"Line : {Line.Text}\n" +
                   $"Audio Path : {audio.AudioFilePath}\n" +
                   $"Audio Length: {audio.AudioLength}";
          
        }

    }
}
