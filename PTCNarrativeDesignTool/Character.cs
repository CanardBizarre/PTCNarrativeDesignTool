using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace PTCNarrativeDesignTool
{
    public class Character
    {
        public int ID { get; set; } = -1;
        public string Name { get; set; } = "Name of the characters";
        public string FormattedName => Name.Replace(" ", "");
        public string PortraitPath { get; set; } = "Insert the portrait file name here";
        public Dictionary<int, Dialogue> CharacterDialogues { get; set; } = new Dictionary<int, Dialogue>();
        public Dialogue this[int _index] => CharacterDialogues[_index];
        public string FirstName
        {
            get
            {
                string _motif = @"^[a-zA-Z]+";
                Match _match = Regex.Match(Name, _motif);
                return $"{_match}";

            }
        }
        public int LastDialogueID
        {
            get
            {
                CharacterDialogues = CharacterDialogues.OrderBy(p => p.Key).ToDictionary();
                if (CharacterDialogues.Count() == 0) return 0;
                return CharacterDialogues.Last().Key;
            }

        }

        public Character()
        {

        }
        public Character(int _id, string _name)
        {
            ID = _id;
            Name = Regex.Replace(_name, @"\s+", " ").Trim();

            string _motif = @"^[a-zA-Z]+";
            Match _match = Regex.Match(Name, _motif);
            PortraitPath = $"{_match}_Portrait";
        }
        public Character(int _id, string _name, string _portraitPath, Dictionary<int, Dialogue> _characterDialogue)
        {
            ID = _id;
            Name = _name;
            PortraitPath = _portraitPath;
            CharacterDialogues = _characterDialogue;
        }

        public void AddNewDialog(Dialogue _newDialogue, out int _index)
        {
            _index = LastDialogueID + 1;
            _newDialogue.LastId = _index;
            CharacterDialogues.Add(_index, _newDialogue);
        }
        public void RemoveDialogue(int _index)
        {
            if (CharacterDialogues.ContainsKey(_index)) return;
            CharacterDialogues.Remove(_index);
        }
        public static string GetFormatedName(string _name)
        {
            return Regex.Replace(_name, @"\s+", "");
        }
        public override string ToString()
        {
            string _toString = $"Character ID :{ID}\n" +
                               $"Character Name : {Name}\n" +
                               $"portraitPath : {PortraitPath}\n";

            foreach (KeyValuePair<int, Dialogue> _pair in CharacterDialogues)
            {
                _toString += $"\n{_pair.Value.ToString()}\n";
            }
            return _toString;
        }

    }
}
