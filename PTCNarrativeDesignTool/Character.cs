using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PTCNarrativeDesignTool
{
    public class Character
    {
        int id = -1;
        string name = "Name of the character";
        string portraitPath = "Insert the portrait file name here";
        Dictionary<int, Dialogue> characterDialogue =  new Dictionary<int, Dialogue>();

        public int ID => id;
        public string Name => name;
        public string FirstName
        {
            get
            {
                string _motif = @"^[a-zA-Z]+";
                Match _match = Regex.Match(name, _motif);
                return $"{_match}_Portrait";
                
            }
        }
        public string Portrait => portraitPath;
        public Dictionary<int, Dialogue> CharacterDialogue => characterDialogue;
        public int LastDialogueID 
        {
            get
            {
                characterDialogue.OrderBy(p => p.Key);
                if (characterDialogue.Count() == 0) return 0;
                return characterDialogue.Last().Key; 
            }
                
        }

        public Character()
        {
       
        }
        public Character(int _id, string _name)
        {
            id = _id;
            name = _name;

            string _motif = @"^[a-zA-Z]+";
            Match _match = Regex.Match(_name, _motif);
            portraitPath = $"{_match}_Portrait";
        }
        public Character(int _id, string _name, string _portraitPath, Dictionary<int, Dialogue> _characterDialogue)
        {
            id = _id;
            name = _name;
            portraitPath = _portraitPath;
            characterDialogue = _characterDialogue;
        }

        public void AddNewDialog(Dialogue _newDialogue)
        {
            int _index = LastDialogueID + 1;

            _newDialogue.LastId = _index;
            characterDialogue.Add(_index, _newDialogue);
        }

        public void RemoveDialogue(int _index)
        {
            if (characterDialogue.ContainsKey(_index)) return;
            characterDialogue.Remove(_index);
        }

        public override string ToString()
        {
            string _toString = $"Character ID :{id}\n" +
                               $"Character Name : {name}\n" +
                               $"portraitPath : {portraitPath}\n";

            foreach (KeyValuePair<int, Dialogue> _pair in characterDialogue)
            {
                _toString += $"\n{_pair.Value.ToString()}\n";
            }
            return _toString;
        }


    }
}
