using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{

    public enum ConnectionType
    {
        CT_Unique,
        CT_Positive,
        CT_Negatif
    }
    public struct FChildNodeData
    {
        public DialogueNode child = new DialogueNode();
        public ConnectionType connectionType = ConnectionType.CT_Unique;
        public FChildNodeData() { }
        public FChildNodeData(DialogueNode _child, ConnectionType _type)
        {
            child = _child;
            connectionType = _type;
        }
    }

    /// <summary>
    /// Node to be displayed on the node graph 
    /// </summary>
    public class DialogueNode
    {
        Character character = new Character();
        Dialogue dialogue = new Dialogue();

        DialogueNode parent = new DialogueNode();
        List<FChildNodeData> children = new List<FChildNodeData>();
        



    }
}
