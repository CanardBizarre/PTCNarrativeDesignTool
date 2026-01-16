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
            string _charJson = JsonConvert.SerializeObject(_characterToSave);

            Directory.CreateDirectory(folder);
            string _path = Path.Combine(folder, _characterToSave.FirstName + Extension);
            FilesSystem.WriteFile(_path, _charJson);
        }

    }
}
