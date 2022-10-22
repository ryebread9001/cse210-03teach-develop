namespace cse21003teach;

class Paratrooper {
    private int health;
    private List<string> body = new List<string>{"  ======", @" //    \\", " ||_____|", @" \\    //", @"  \\  // ", "   ||_|  ", "    o", @"   /|\", @"    /\"};

    public void drawBody(int health) {
        Console.WriteLine(" ");
        for (var i = health; i < body.Count; i++) {
            Console.WriteLine(body[i]);
        }
    }

    public bool isDead(int health) {
        if (health > 6) {
            Console.WriteLine(" ");
            Console.WriteLine("    x");
            for (var i = health; i < body.Count; i++) 
            {

                Console.WriteLine(body[i]);
            }
            return true;
        }
        else return false;
    }
}