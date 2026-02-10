using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PTCNarrativeDesignTool
{

    public class CharacterManager: Singleton<CharacterManager>
    {
        public Dictionary<int, Character> characters = new Dictionary<int, Character>();
        public Dictionary<string, Character> charactersByName = new Dictionary<string, Character>();
        int characterIndex = -1;

        public int LastCharacterID
        {
            get
            {
                if (characters.Count() == 0) return characterIndex = 0;
                return characterIndex = characters.Last().Value.ID;
            }

        }
        public  int CharacterIndex => characterIndex;
        public void Init(Dictionary<int, Character> _characters)
        {
            characters = _characters;
            characters = characters.OrderBy(p => p.Value.ID).ToDictionary();
            foreach (var _character in characters)
            {
                charactersByName.Add(_character.Value.FormattedName, _character.Value);
            }
        }
        public Character CreateCharacter(string _name)
        {
            string _formatedName = Character.GetFormatedName(_name);
            if (charactersByName.ContainsKey(_formatedName)) return charactersByName[_formatedName];
            // Recursive With To Add Number of same character 

            characterIndex = LastCharacterID == 0  && characters.Count() == 0 ? 0 : characterIndex + 1;
            Character _newCharacter = new Character(characterIndex, _name);
            characters.Add(characterIndex, _newCharacter);
            return _newCharacter;
        }

        public override string ToString()
        {
            characters = characters.OrderBy(p => p.Value.ID).ToDictionary();
            string _toString = string.Empty;
            if (characters.Count() < 1) return _toString;
            foreach (KeyValuePair<int, Character> _pair in characters)
            {
                _toString += $"{_pair.Key} - {_pair.Value.Name}\n";
            }
            return _toString;
        }
    }
}
