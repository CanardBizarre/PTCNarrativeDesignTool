using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PTCNarrativeDesignTool
{

    internal sealed class CharacterManager
    {

        private static CharacterManager instance;
        public static CharacterManager GetInstance()
        {
            if (instance == null)
            {
                instance = new CharacterManager();
            }
            return instance;
        }


        public int CHARACTER_INDEX = -1;
        public Dictionary<int, Character> character = new Dictionary<int, Character>();

        public int LastCharacterID
        {
            get
            {
                if (character.Count() == 0) return 0;
                character.OrderBy(p => p.Key);
                return character.Last().Key;
            }

        }

        public Character CreateChracter(string _name)
        {
            Character _newCharacter = new Character(LastCharacterID + 1, _name);
            character.Add(LastCharacterID + 1, _newCharacter);
            return _newCharacter;
        }
    }
}
