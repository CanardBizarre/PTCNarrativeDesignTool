using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PTCNarrativeDesignTool
{
    internal class PrintNodeTree
    {
        private const string CROSS = "├─";
        private const string CORNER = "└─";
        private const string VERTICAL = "│ ";
        private const string SPACE = "  ";

        public static void ToStringPrintNode(Node _node, string _indent, ref string _string)
        {
            if(!_node) return;
            _string += $"{_node}\n";
            int _childCount = _node.Children.Count;

            for (int i = 0; i < _childCount; i++)
            {
                Node _child = _node.Children[i];
                bool _isLast = (i == (_childCount - 1));
                ToStringChildNode(_child, _indent, _isLast, ref _string);
            }
        }
        static void ToStringChildNode(Node _node, string _indent, bool _isLast, ref string _string)
        {
            _string += $"{_indent}";

            if (_isLast)
            {
                _string += $"{CORNER}";
                _indent += SPACE;
            }
            else
            {
                _string += $"{CROSS}";
                _indent += VERTICAL;
            }

            ToStringPrintNode(_node, _indent, ref _string);

        }

    }
}
