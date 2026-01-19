using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{

    public enum ConnectionType
    {
        CT_None,
        CT_Unique,
        CT_Positive,
        CT_Negatif,
        CT_Count
    }

    /// <summary>
    /// Node to be displayed on the node graph 
    /// </summary>
    public class DialogueNode
    {


        Dialogue dialogue = new Dialogue();
        DialogueNode parent = new DialogueNode();
        List<DialogueNode> children = new List<DialogueNode>();

        public Character Character { get; set; } = new Character();
        public int DialogueID { get; set; } = -1;
        public ConnectionType ConnectionType { get; set; }




    }
}
