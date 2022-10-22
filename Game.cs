namespace cse21003teach;

class Game {
    private char letter;
    private List<char> guessed = new List<char>();
    private List<char> incorrect = new List<char>();
    public Game() {
        
    }
    public void runGame(string word) {
        letter = 'x';
        Console.WriteLine("\nLetter to guess: ");
        letter = Console.ReadLine()[0];
        //Console.WriteLine(letter);

        FillWord(letter, word);
    }

    private void FillWord(char letter, string word) {
        if (word.Contains(letter)) {
            guessed.Add(letter);
            
        } else {
            incorrect.Add(letter);
            
        }
        for (var i = 0; i < word.Length; i++) {
                if (guessed.Contains(word[i])) {
                    Console.Write(word[i]);
                    
                } else {
                    Console.Write("_");
                }
        }
        
    }

    public bool CheckGuess(string word) {
        HashSet<char> norepeats = new HashSet<char>();
        foreach (var letter in word) 
        {
             norepeats.Add(letter);
        }

        if (guessed.Count == norepeats.Count) {
            guessed.Clear();
            incorrect.Clear();
            return true;
            
        }
        
        return false;
    }

    public int checkIncorrect() {
        return incorrect.Count;
    }

}