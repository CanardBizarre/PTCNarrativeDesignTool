using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
    internal class NarrativeToolConsoleDisplay
    {

        public void CreateCharacter(out string _nameCharacter)
        {
            _nameCharacter = InputRequest.StringRequest("Name your character");
        }

        public void SaveCharacter()
        {

        }

    }
}
