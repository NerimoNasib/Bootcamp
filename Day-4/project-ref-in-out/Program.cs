class Program
{
    private static void Main(string[] args)
    {
        double r = 0;
        double variable = 1.25;
        double pi;
        System.Console.WriteLine("Enter the radius of the circle: ");


        Ball(out pi, in variable, ref r);
        double res = variable * pi * r * r * r;
        System.Console.WriteLine(res);

        Circle(out pi, ref r);
        double res_circle = pi * r * r;
        System.Console.WriteLine(res_circle);


    }
    public static void Ball(out double pi, in double variable, ref double r){
        pi = 22/7;
        r = double.Parse(Console.ReadLine());
    }

    public static void Circle(out double pi, ref double r){
        pi = 22/7;
    }
}