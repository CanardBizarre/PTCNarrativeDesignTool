// See https://aka.ms/new-console-template for more information
using PTCNarrativeDesignTool;

//Character _firstCharacter = CharacterManager.GetInstance().CreateChracter("Kim Kitsuragi");
//DialogueManager.GetInstance().CreateDialogue(_firstCharacter, "I am lieutenant Kim Kitsuragi, I will be your partner.");
//DialogueManager.GetInstance().CreateDialogue(_firstCharacter, "Talking like a true detective.");

Character _secondCharacter = CharacterManager.GetInstance().CreateChracter("Jake Peralta");
DialogueManager.GetInstance().CreateDialogue(_secondCharacter, "Title of your sextape.");
DialogueManager.GetInstance().CreateDialogue(_secondCharacter, "Cool motive, still murder");



//Console.WriteLine(_firstCharacter.ToString());
//Console.WriteLine("\n\n" + _secondCharacter.ToString());

DialogueFileSave _saver = new DialogueFileSave();
_saver.SaveCharacter(_secondCharacter);

Character _firstCharacter = _saver.LoadCharacter("kim");
Character _thirdCharecter = _saver.LoadCharacter("jake");

Console.WriteLine(_firstCharacter.ToString());
Console.WriteLine(_thirdCharecter.ToString());
