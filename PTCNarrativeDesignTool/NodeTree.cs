using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PTCNarrativeDesignTool
{
    public class NodeTree
    {
        public string TreeName { get; set; } = "Tree Name";
        public int DialogueTreeID { get; set; } = -1;
        public Node entryNode { get; set; } = null;
        public Dictionary<int, Node> nodes { get; set; } = new Dictionary<int, Node>();
        public int NODE_ID { get; set; } = -1;

        public NodeTree(int _dialogueIndex, string _name)
        {
            DialogueTreeID = _dialogueIndex;
            TreeName = _name;
        }

        public Node CreateNode()
        {
            NODE_ID++;
            Node _newDialogueNode = new Node(NODE_ID);
            if (!entryNode)
                entryNode = _newDialogueNode;
            nodes.Add(NODE_ID, _newDialogueNode);

            return _newDialogueNode;
        }

        public void Destroynode(Node _node)
        {
            if (!_node) return;
            nodes.Remove(_node.ID);
            _node.OnDestroy();
        }

        public void ConnectTwoNodes(Node _parent, Node _child)
        {
            if (!nodes.ContainsKey(_parent.ID) ||
                !nodes.ContainsKey(_child.ID) ||
                _child == entryNode) return;

            _parent.AddChild(_child);
            _child.AddParent(_parent);
        }

        
        public override string ToString()
        {
            string _string = string.Empty;
            PrintNodeTree.ToStringPrintNode(entryNode, "", ref _string);

            return _string;
        }

    }
}
