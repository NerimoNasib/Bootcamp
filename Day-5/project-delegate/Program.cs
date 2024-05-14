// using Delegate;

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program(){
    static void Main(){
        Func<double, double, double, double>circle = CircleCalc; //Function normal
        Action<double, double, double>cicrleAction = CircleCalcAction; //Action normal

        //lambda expression
        Func<double, double, double, double> multiple = (x, y, z) => x * y * z; //Function with lambda exp.
        Action<double, double, double> multipleAction = (x, y, z) => System.Console.WriteLine(x*y*z); //Action with lambda exp.
        
        //non delegate
        var add = (int x, int y) => x + y;
        System.Console.WriteLine(add(1, 2));

        //anonymous method
        Func<double, double, double, double> multipleAnon = delegate (double x, double y, double z) {return x * y *z;}; //Function with lambda exp.
        Action<double, double, double> multipleActionAnon = delegate (double x, double y, double z) {System.Console.WriteLine(x*y*z);}; //Action with lambda exp.

        MyDelegate my = new(Avdruk.PrintMethod); //normal delegate
        MyDelegate myAvdruk = new(Avdruk.AvdrukMethod); // normal delegate
        CalcDelegate square = Calculator.Square; //normal delegate
        CalcDelegate cube = Calculator.Cubic; //normal delegate

        System.Console.WriteLine(multiple(22/7, 7, 7));
        // System.Console.WriteLine(cicrleAction(1, 2, 3));
        System.Console.WriteLine(circle(22/7, 7, 7));
        System.Console.WriteLine(square(7));
        System.Console.WriteLine(cube(7));
        my(); //shorthand
        myAvdruk(); //shorthand
        my.Invoke(); //not shorthand
        myAvdruk.Invoke(); //not shorthand
    }
    
    //Delegate is an object that knows how to call a method
    private static double CircleCalc(double x, double y, double z){
        return x * y * z;
    }

    private static void CircleCalcAction(double x, double y, double z){
        double result = x * y * z;
        System.Console.WriteLine(result);
    }

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