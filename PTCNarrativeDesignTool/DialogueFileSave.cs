using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace PTCNarrativeDesignTool
{
    public class DialogueFileSave : Singleton<DialogueFileSave>
    {
        const string extension = ".json";
        string folder = "Debug";
        string Extension => extension;
        string Folder => folder;
        public void SaveCharacter(Character _characterToSave)
        {
            string _charJson = JsonConvert.SerializeObject(_characterToSave, Formatting.Indented);
            Directory.CreateDirectory(folder);
            string _path = Path.Combine(folder, _characterToSave.FormattedName + Extension);
            FilesSystem.WriteFile(_path, _charJson);

            Console.WriteLine($"Character: {_characterToSave.Name} has been saved in {_path}");
        }
        public Character LoadCharacter(string _characterName)
        {
            string _path = Path.Combine(folder, _characterName + Extension);
            string[] _file = FilesSystem.ReadAllLines(_path);
            string _json = string.Join(Environment.NewLine, _file);
            return JsonConvert.DeserializeObject<Character>(_json);
        }

        public Dictionary<int, Character> LoadCharacters()
        {
            Dictionary<int, Character> _characters = new Dictionary<int, Character>();
            foreach (string _file in Directory.EnumerateFiles(folder))
            {
                string _motif = @"([^\\]+)(?=\.json$)";
                Match _match = Regex.Match(_file, _motif);
                Character _chara = LoadCharacter(_match.Value);
                _characters.Add(_chara.ID, _chara);
            }
            return _characters;

        }

    }
}
