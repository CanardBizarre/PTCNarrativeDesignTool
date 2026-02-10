namespace PTCNarrativeDesignTool
{
    public class DialogueAudio
    {
        public int ID { get; set; } = -1;
        public string AudioFilePath { get; set; } = "";
        public float AudioLength { get; set; } = 0f;

        public DialogueAudio() { }

        public DialogueAudio(int iD)
        {
            ID = iD;
            AudioFilePath = $"VO[{ID}]";
            // TODO Make audio thing
        }
    }
}
