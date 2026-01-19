using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace PTCNarrativeDesignTool
{
    internal class DialogueFileSave
    {
        const string extension = ".json";
        string folder = "Debug";
        string Extension => extension;
        string Folder => folder;
        public void SaveCharacter(Character _characterToSave)
        {
            string _charJson = JsonConvert.SerializeObject(_characterToSave, Formatting.Indented);
            Directory.CreateDirectory(folder);
            string _path = Path.Combine(folder, _characterToSave.FirstName + Extension);
            FilesSystem.WriteFile(_path, _charJson);

        }
        public Character LoadCharacter(string _characterName)
        {
            string _path = Path.Combine(folder, _characterName + Extension);
            string[] _file = FilesSystem.ReadAllLines(_path);
            string _json = string.Join(Environment.NewLine, _file);
            return JsonConvert.DeserializeObject<Character>(_json);
        }

    }
}
