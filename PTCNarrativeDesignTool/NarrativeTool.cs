namespace PTCNarrativeDesignTool
{
    public class NarrativeTool : Singleton<NarrativeTool>
    {
        public event Action<Character> OnCharacterMade = null;
        public event Action OnfinishAction = null;

        NarrativeToolConsoleDisplay display = null;
        public CharacterManager CharacterManager => CharacterManager.GetInstance();
        public DialogueManager DialogueManager => DialogueManager.GetInstance();
        public DialogueFileSave DialogueFileSave => DialogueFileSave.GetInstance();

        public NarrativeTool()
        {
            CharacterManager.Init(DialogueFileSave.LoadCharacters());
            display = new NarrativeToolConsoleDisplay();
        }

        public void CreateCharacter()
        {
            display.CreateCharacter(out string _name);
            Character _new = CharacterManager.CreateCharacter(_name);
            OnCharacterMade?.Invoke(_new);
            Console.ReadLine();
            OnfinishAction?.Invoke();
        }
        public void DisplayAllCharacter()
        {
            Console.Clear();
            Console.WriteLine(CharacterManager);
            Console.ReadLine();
            OnfinishAction?.Invoke();
        }

        public void SaveCharacter()
        {
            Console.Clear();
            Console.WriteLine("What Character do you want to save");
            Console.WriteLine(CharacterManager);
            Character _char = CharacterManager[InputRequest.IntRequest("What is the index of the character to save")];
            DialogueFileSave.SaveCharacter(_char);
            Console.ReadLine();
            OnfinishAction?.Invoke();
        }

        public static bool operator !(NarrativeTool _this)
        {
            return _this == null;
        }
    }
}
