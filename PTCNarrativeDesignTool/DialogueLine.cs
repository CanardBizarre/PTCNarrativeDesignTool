using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
    public class DialogueLine
    {
        int id = -1;
        string text = "";

        public int ID => id;
        public string Text => text;

        public  DialogueLine() { }
        public DialogueLine(int _id, string _text)
        {
            id = _id;
            text = _text;
        }

    }
}
