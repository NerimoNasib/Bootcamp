internal class Program
{
    private static void Main()
    {
        Left moveLeft = new();
        Right moveRight = new();
        Forward moveFwd = new();
        Backward moveBck = new();

        int movementTracking = 0;

        Console.WriteLine("Control:\n 'l':left \n 'r': right \n 'f':forward \n 'b':backward");
        Console.WriteLine("Your input: ");
        
        string control = Console.ReadLine();
        switch (control) 
        {
        case "l":
            moveLeft.Move();
            moveRight.Move();
            movementTracking++;
            if (movementTracking >= 1){
                Console.WriteLine("You hit something!");
            }
            break;
        case "r":
            moveRight.Move();
            movementTracking++;
            if (movementTracking >= 1){
                Console.WriteLine("You hit something!");
            }
            break;
        case "f":
            moveFwd.Move();
            movementTracking++;
            if (movementTracking >= 1){
                Console.WriteLine("You reached the finish line!");
            }
            break;
        case "b":
            moveBck.Move();
            movementTracking++;
            if (movementTracking >= 1){
                Console.WriteLine("You tripped!");
            }
            break;
        }
    }
}

class Movement{
    public virtual void Move(){
        Console.WriteLine("Moving...");
    }
}

class Forward: Movement{
    public override void Move(){
        Console.WriteLine("Moving forward in progress...");
        // base.Move();
    }
}

class Backward: Movement{
    public override void Move(){
        Console.WriteLine("Moving backward in progress...");
        // base.Move();
    }
}

class Left: Movement{
    public override void Move(){
        Console.WriteLine("Moving left in progress...");
        // base.Move();
    }
}

class Right: Movement{
    public override void Move(){
        Console.WriteLine("Moving right in progress...");
        // base.Move();
    }
}