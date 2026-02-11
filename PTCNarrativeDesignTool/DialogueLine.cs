namespace PTCNarrativeDesignTool
{
    public class DialogueLine
    {
        public int ID { get; set; } = -1;
        public string Text { get; set; } = "";

        public DialogueLine() { }
        public DialogueLine(int _id, string _text)
        {
            ID = _id;
            Text = _text;
        }

    }
}
