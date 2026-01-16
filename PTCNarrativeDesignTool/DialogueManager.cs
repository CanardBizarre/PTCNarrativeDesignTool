using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
    public sealed class DialogueManager
    {
        private static DialogueManager instance;

        public static DialogueManager GetInstance()
        {
            if (instance == null)
            {
                instance = new DialogueManager();
            }
            return instance;
        }

        public int DIALOGUE_INDEX = 0;

        public void CreateDialogue(Character _character, string _text)
        {
            DIALOGUE_INDEX ++;
            DialogueLine _line = new DialogueLine(DIALOGUE_INDEX, _text);
            DialogueAudio _audio = new DialogueAudio(DIALOGUE_INDEX);

            Dialogue _newDialog = new Dialogue(DIALOGUE_INDEX,_line, _audio);
            _character.AddNewDialog(_newDialog);
        }

        public void DeleteDialogue(Character _character, int _index)
        {
            _character.RemoveDialogue(_index);
        }
    }
}
