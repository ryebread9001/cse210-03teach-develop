namespace cse21003teach;

class Word {
    List<string> words;
    public Word(List<string> w) {
        
        words = w;
    }

    public string NewWord() {
        var random = new Random();
        
        int index = random.Next(words.Count);
        // HashSet<char> norepeats = new HashSet<char>();
        // foreach (var letter in words[index]) {
        //     norepeats.Add
        // }
        
        return words[index];
    }

    

}