public enum Difficulty {
    easy, medium, hard,
}

class Program{
    static void Main(){
        int difficulty = (int)Difficulty.hard; //print by assigned integer
        System.Console.WriteLine(difficulty);
        Difficulty diff = Difficulty.easy; //print by assigned enum
        switch (difficulty){
            case 0:
            System.Console.WriteLine("Wadooh");
            break;
            case 1:
            System.Console.WriteLine("Medium");
            break;
            case 2:
            System.Console.WriteLine("Hard");
            break;
        }
        // System.Console.WriteLine(diff);
    }
}