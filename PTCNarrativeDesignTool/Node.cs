namespace PTCNarrativeDesignTool
{

    public enum ConnectionType
    {
        CT_None,
        CT_Start,
        CT_End,
        CT_Unique,
        CT_Positive,
        CT_Negatif,
        CT_Count
    }

    /// <summary>
    /// Node to be displayed on the node graph 
    /// </summary>
    public class Node
    {
        public int ID { get; set; } = -1;
        public List<Node> Parents { get; set; } = new List<Node>();
        public List<Node> Children { get; set; } = new List<Node>();

        public ConnectionType ConnectionType { get; set; }

        public Node(int _nodeId)
        {
            ID = _nodeId;
        }
       
        public void AddChild(Node _node)
        {
            if(_node == this || Children.Contains(_node)) return;
            Children.Add(_node);
        }

        public void RemoveChild(Node _node)
        {
            if (_node == this || !Children.Contains(_node)) return;
            Children.Remove(_node);
        }

        public void AddParent(Node _node)
        {
            if (_node == this || Parents.Contains(_node)) return;
            Parents.Add(_node);
        }

        public void RemoveParent(Node _node)
        {
            if(_node == this || !Parents.Contains(_node)) return;
            Parents.Remove(_node);
        }

        public void OnDestroy()
        {
            foreach (Node _child in Children)
            {
                _child.RemoveParent(this);
            }
            foreach (Node _parent in Parents)
            {
                _parent.RemoveChild(this);
            }

        }

        public static bool operator !(Node _this)
        {
            return _this == null;
        }

        public override string ToString()
        {
            return $"{ID}";
        }
    }
}