internal class Program
{
    private static void Main()
    {
        float f = 78;
        float c = (f - 32) * 5/9;
        Console.WriteLine("Today's temp. is " + c + " celcius");
        Robot robot = new();
        Human human = new();
        Random random = new();

        Console.WriteLine("Please choose your movement type(human/robot): ");
        string control = Console.ReadLine();
        if (control == "human"){
            Console.WriteLine("As a human, i want to move (type 'help' for command list!): ");
            string commandHuman = Console.ReadLine();
            switch (commandHuman){
                case "help":
                Console.WriteLine("forward/back/left/right/crouch/stand");
                break;
                case "forward":
                human.MoveFwd();
                Console.WriteLine("How many steps do you want to take? ");
                int stepFwd = Convert.ToInt32(Console.ReadLine());
                if (stepFwd >= 5){
                    Console.WriteLine("You felt tired and stopped after your " + random.Next(4, 9) + " step");
                }
                else if (stepFwd == 0){
                    Console.WriteLine("You did not move!");
                }
                else{
                    System.Console.WriteLine("You walked for about " + stepFwd + "steps!");
                }
                break;

                case "back":
                human.MoveBck();
                Console.WriteLine("How many steps do you want to take? ");
                int stepBck = Convert.ToInt32(Console.ReadLine());
                if (stepBck >= 3){
                    Console.WriteLine("You tripped on something during your " + random.Next(4, 9) + " step!");
                }
                else if (stepBck == 0){
                    Console.WriteLine("You did not move!");
                }
                else{
                    System.Console.WriteLine("You walked for about " + stepBck + "steps!");
                }
                break;

                case "left":
                human.MoveLeft();
                Console.WriteLine("How many steps do you want to take? ");
                int stepLeft = Convert.ToInt32(Console.ReadLine());
                if (stepLeft >= 4){
                    Console.WriteLine("You tripped on something during your " + random.Next(4, 9) + " step!");
                }
                else if (stepLeft == 0){
                    Console.WriteLine("You did not move!");
                }
                else{
                    System.Console.WriteLine("You walked for about " + stepLeft + "steps!");
                }
                break;

                case "right":
                human.MoveRight();
                Console.WriteLine("How many steps do you want to take? ");
                int stepRight = Convert.ToInt32(Console.ReadLine());
                if (stepRight >= 4){
                    Console.WriteLine("You tripped on something during your " + random.Next(4, 9) + " step!");
                }
                else if (stepRight == 0){
                    Console.WriteLine("You did not move!");
                }
                else{
                    System.Console.WriteLine("You walked for about " + stepRight + "steps!");
                }
                break;

                case "stand":
                human.MoveStand();
                break;

                case "crouch":
                human.MoveCrouchDown();
                break;

                case "time":
                human.MoveWatch();
                break;
            }

        }
        
        else if (control == "robot"){
            Console.WriteLine("As a robot i want to move: ");
            string commandBot = Console.ReadLine();
            switch (commandBot){
                case "forward":
                robot.MoveFwd();
                break;
                case "back":
                robot.MoveBck();
                break;
            }
        }

        else{
            Console.WriteLine("You typed the wrong type!");
        }
}

interface IMovement{
    void MoveRight();
    void MoveLeft();
}

interface IMoveCrouch{
    void MoveCrouchDown();
    void MoveStand();
}

interface IMoveWatch{
    void MoveWatch();
}


class Human : Movement, IMovement, IMoveCrouch, IMoveWatch
{
    public override void MoveBck()
    {
        Console.WriteLine("You moved back!");
    }

    public override void MoveFwd()
    {
        Console.WriteLine("You moved forward!");    
    }

    public void MoveRight()
    {
        Console.WriteLine("You moved Right!");
    }

    public void MoveLeft()
    {
        Console.WriteLine("You moved Left!");
    }

    public void MoveCrouchDown(){
        Console.WriteLine("You crouched!");
    }

    public void MoveStand(){
        Console.WriteLine("You stood up!");
    }

    public void MoveWatch(){
        Random rng = new();
        Console.WriteLine("Currently it is " + rng.Next(0, 24) + " O'clock");
    }
}

abstract class Movement{
    public abstract void MoveFwd();
    public abstract void MoveBck();
}

class Robot : Movement
{
    public override void MoveBck()
    {
        Console.WriteLine("You moved back!");
    }

    public override void MoveFwd()
    {
        Console.WriteLine("You moved forward!");    
    }
    
    }
    
    }
