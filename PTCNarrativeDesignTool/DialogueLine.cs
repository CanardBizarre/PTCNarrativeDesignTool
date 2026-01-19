using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PTCNarrativeDesignTool
{
    public class DialogueLine
    {

        public int ID { get; set; } = -1;
        public string Text { get; set; } = "";

        public  DialogueLine() { }
        public DialogueLine(int _id, string _text)
        {
            ID = _id;
            Text = _text;
        }

    }
}
