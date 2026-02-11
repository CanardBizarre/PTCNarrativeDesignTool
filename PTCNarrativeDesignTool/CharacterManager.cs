namespace PTCNarrativeDesignTool
{

    public class CharacterManager : Singleton<CharacterManager>
    {
        Dictionary<int, Character> characters = new Dictionary<int, Character>();
        Dictionary<string, Character> charactersByName = new Dictionary<string, Character>();
        int characterIndex = -1;

        public Character this[int _value] => characters[_value];

        public int LastCharacterID
        {
            get
            {
                if (characters.Count() == 0) return characterIndex = 0;
                return characterIndex = characters.Last().Value.ID;
            }

        }
        public int CharacterIndex => characterIndex;
        public void Init(Dictionary<int, Character> _characters)
        {
            characters = _characters;
            characterIndex = LastCharacterID;
            foreach (var _character in characters)
            {
                charactersByName.Add(_character.Value.FormattedName, _character.Value);
            }
        }
        public Character CreateCharacter(string _name)
        {
            string _formatedName = Character.GetFormatedName(_name);
            if (charactersByName.ContainsKey(_formatedName))
            {
                Console.WriteLine("Character already exist with given name");
                return charactersByName[_formatedName];
            }


            Character _newCharacter = new Character(characterIndex, _name);
            characters.Add(characterIndex, _newCharacter);
            charactersByName.Add(_newCharacter.FormattedName, _newCharacter);
            Console.WriteLine("Character sucefully created");
            return _newCharacter;
        }

        public override string ToString()
        {
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
