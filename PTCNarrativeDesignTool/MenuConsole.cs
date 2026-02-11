using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTCNarrativeDesignTool
{
    internal class MenuConsole
    {
        NarrativeTool tool = NarrativeTool.GetInstance();

        List<MenuSelectorConsole> mainMenu = new List<MenuSelectorConsole>();
        public MenuConsole()
        {
            tool.OnfinishAction += ResetMenu;

            mainMenu.Add(new MenuSelectorConsole("Create Character", tool.CreateCharacter));
            mainMenu.Add(new MenuSelectorConsole("Display Character", tool.DisplayAllCharacter));
            mainMenu.Add(new MenuSelectorConsole("Save Character", tool.SaveCharacter));
            mainMenu.Add(new MenuSelectorConsole("Exit", Exit));
            ShowMenu();

        }
        void Exit()
        {
            Environment.Exit(0);
        }
        void ResetMenu()
        {
            Console.Clear();
            ShowMenu();
        }
        void ShowMenu()
        {
            if (!tool) return;
            Console.WriteLine(tool);
            int _size = mainMenu.Count;
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine($"{i + 1} - {mainMenu[i].Label}");
            }
            Select();
        }

        void Select()
        {

            int _index = InputRequest.IntRequest("Select: ") - 1;
            if (_index < 0 || _index > mainMenu.Count)
            {
                Select();
                return;
            }
            mainMenu[_index].Execute();


        }
    }
}
