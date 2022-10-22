using cse21003teach;

// current list of possible words. Could obvioulsy be expanded...
List<string> words = new List<string>{"incredible", "whiskey", "bottle", "horseshoe", "ridiculous", "performative", "explicit"};

Game game = new Game();
Word word = new Word(words);
Paratrooper trooper = new Paratrooper();
Messages message = new Messages();

// creates first word
string current = word.NewWord();

// welcome!!!
message.DisplayWelcomeMessage();
// loop continuously
while (!trooper.isDead(game.checkIncorrect())) {
    trooper.drawBody(game.checkIncorrect());
    game.runGame(current);
    
    if (game.CheckGuess(current)) {
        Console.WriteLine(" is CORRECT!");
        current = word.NewWord();
    }
}

message.DisplayLosingMessage();




