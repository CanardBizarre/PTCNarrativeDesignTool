namespace PTCNarrativeDesignTool
{
    public class NarrativeTool : Singleton<NarrativeTool>
    {
        public CharacterManager CharacterManager => CharacterManager.GetInstance();
        public DialogueManager DialogueManager => DialogueManager.GetInstance();
        public DialogueFileSave DialogueFileSave => DialogueFileSave.GetInstance();

        public NarrativeTool()
        {
            CharacterManager.Init(DialogueFileSave.LoadCharacters());
        }
    }
}
