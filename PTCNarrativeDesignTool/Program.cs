using PTCNarrativeDesignTool;

NarrativeTool _tool = NarrativeTool.GetInstance();
Console.WriteLine(_tool.CharacterManager);

//Character _firstCharacter = _tool.CharacterManager.CreateCharacter("Harry DuBois");
//Character _secondCharacter = _tool.CharacterManager.CreateCharacter("Kim Kitsuragi");
//Character _thirdCharacter = _tool.CharacterManager.CreateCharacter("Jake Peralta");
//Character _fourthCharacter = _tool.CharacterManager.CreateCharacter("Georges Nguyen Van Loc");

Character _firstCharacter = _tool.CharacterManager.CreateCharacter("Amy Santiago");
Character _secondCharacter = _tool.CharacterManager.CreateCharacter("Jack Traven");



_tool.DialogueFileSave.SaveCharacter(_firstCharacter);
_tool.DialogueFileSave.SaveCharacter(_secondCharacter);


