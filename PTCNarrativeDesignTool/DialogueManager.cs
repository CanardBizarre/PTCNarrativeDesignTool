using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
  
    public sealed class DialogueManager:Singleton<DialogueManager>
    {
        private static DialogueManager instance;

        int DIALOGUE_TREE_ID = -1;
        Dictionary<int, DialogueTree> allTreeDialogue = new Dictionary<int, DialogueTree>();
        Dictionary<int, string> allDialogue = new Dictionary<int, string>();
        DialogueTree currentTree = null;
        DialogueNode currentNode = null;
        public int LastDialogueTreeID
        {
            get
            {
                allTreeDialogue = allTreeDialogue.OrderBy(p => p.Key).ToDictionary();
                if (allTreeDialogue.Count() == 0) return 0;
                return allTreeDialogue.Last().Key;
            }

        }
        public void Init(Dictionary<int, DialogueTree> _allTreeDialogue)
        {
            allTreeDialogue = _allTreeDialogue;
            DIALOGUE_TREE_ID = LastDialogueTreeID;
        }

        public void CreateDialogueTree(List<int> _charactersIndex)
        {
            DIALOGUE_TREE_ID++;
            DialogueTree _newTree = new DialogueTree(DIALOGUE_TREE_ID, _charactersIndex);
            allTreeDialogue.Add(DIALOGUE_TREE_ID, _newTree);
            currentTree = _newTree;
            CreateDialogueNode();
        }

        public void CreateDialogueNode()
        {
            DialogueNode _newDialogueNode = new DialogueNode();
            currentNode = _newDialogueNode;
            if (!currentTree.entryNode)
            {
                currentTree.entryNode = currentNode;
            }
        }

        public void CreateDialogue(Character _character, string _text)
        {
            DIALOGUE_TREE_ID++ ;
            DialogueLine _line = new DialogueLine(DIALOGUE_TREE_ID, _text);
            DialogueAudio _audio = new DialogueAudio(DIALOGUE_TREE_ID);
            Dialogue _newDialog = new Dialogue(DIALOGUE_TREE_ID, _line, _audio);

            _character.AddNewDialog(_newDialog, out int _dialogueIndex);
            allDialogue.Add(DIALOGUE_TREE_ID, $"{_character.Name}_{_dialogueIndex}");
        }

        public void DeleteDialogue(Character _character, int _index)
        {
            Dialogue _toRemove = _character[_index];
            _character.RemoveDialogue(_index);
            allDialogue.Remove(_toRemove.ID);

        }
    }
}
