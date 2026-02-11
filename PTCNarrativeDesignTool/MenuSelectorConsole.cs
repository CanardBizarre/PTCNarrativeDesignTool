using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
    internal class MenuSelectorConsole
    {
        public string Label { get; private set; } = "Label";
        Action callback = null;

        public MenuSelectorConsole()
        {
        }
        public MenuSelectorConsole(string _label, Action _callback)
        {
            Label = _label;
            callback = _callback;
        }

        public void Execute() => callback?.Invoke();
    }
}
