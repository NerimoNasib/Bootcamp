// using Delegate;

internal class Program(){
    static void Main(){
        MyDelegate my = new(Avdruk.PrintMethod);
        MyDelegate myAvdruk = new(Avdruk.AvdrukMethod);
        CalcDelegate square = Calculator.Square;
        CalcDelegate cube = Calculator.Cubic;

        System.Console.WriteLine(square(7));
        System.Console.WriteLine(cube(7));
        my(); //shorthand
        myAvdruk(); //shorthand
        my.Invoke(); //not shorthand
        myAvdruk.Invoke(); //not shorthand
    }
    
    //Delegate is an object that knows how to call a method

    public delegate void MyDelegate();
    public delegate int CalcDelegate(int x);
}

public class Avdruk{
    public static void PrintMethod(){
        Console.WriteLine("Print");
    }
    public static void AvdrukMethod(){
        Console.WriteLine("Avdruk");
    }
}

public class Calculator{
    public static int Square(int x){
        return x * x;
    }

    public static int Cubic(int x){
        return x * x * x;
    }
}