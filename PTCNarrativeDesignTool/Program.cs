using PTCNarrativeDesignTool;


//new MenuConsole();


//Console.WriteLine(_tool.CharacterManager);

////Character _firstCharacter = _tool.CharacterManager.CreateCharacter("Harry DuBois");
////Character _secondCharacter = _tool.CharacterManager.CreateCharacter("Kim Kitsuragi");
////Character _thirdCharacter = _tool.CharacterManager.CreateCharacter("Jake Peralta");
////Character _fourthCharacter = _tool.CharacterManager.CreateCharacter("Georges Nguyen Van Loc");

//Character _firstCharacter = _tool.CharacterManager.CreateCharacter("Amy Santiago");
//Character _secondCharacter = _tool.CharacterManager.CreateCharacter("Jack Traven");



//_tool.DialogueFileSave.SaveCharacter(_firstCharacter);
//_tool.DialogueFileSave.SaveCharacter(_secondCharacter);


NodeTree _tree = new NodeTree(0, "Test");
Node _firstNode = _tree.CreateNode();
Node _secondNode = _tree.CreateNode();
Node _thirdNode = _tree.CreateNode();
Node _fourthNode = _tree.CreateNode();
Node _fifthNode = _tree.CreateNode();


_tree.ConnectTwoNodes(_firstNode,_secondNode);
_tree.ConnectTwoNodes(_firstNode, _thirdNode);
_tree.ConnectTwoNodes(_firstNode, _fourthNode);

_tree.ConnectTwoNodes(_secondNode, _firstNode);
_tree.ConnectTwoNodes(_secondNode, _secondNode);
_tree.ConnectTwoNodes(_secondNode, _thirdNode);
_tree.ConnectTwoNodes(_secondNode, _fourthNode);

_tree.ConnectTwoNodes(_thirdNode, _fifthNode);
_tree.ConnectTwoNodes(_fourthNode, _fifthNode);

Console.WriteLine(_tree);
_tree.Destroynode(_secondNode);


Console.WriteLine($"\n\n{_tree}");


