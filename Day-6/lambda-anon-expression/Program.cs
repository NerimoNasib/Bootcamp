internal class Program
{
    private static void Main(string[] args)
    {
        //lambda expression
        Func<double, double, double, double> multiple = (x, y, z) => x * y * z; //Function with lambda exp.
        Action<double, double, double> multipleAction = (x, y, z) => System.Console.WriteLine(x*y*z); //Action with lambda exp.

        System.Console.WriteLine(multiple(1, 2, 3));
        multipleAction(1, 2, 3);
        
        //non delegate
        var add = (int x, int y) => x + y;
        System.Console.WriteLine(add(1, 2));

        //anonymous method
        Func<double, double, double, double> multipleAnon = delegate (double x, double y, double z) {return x * y *z;}; //Function with lambda exp.
        Action<double, double, double> multipleActionAnon = delegate (double x, double y, double z) {System.Console.WriteLine(x*y*z);}; //Action with lambda exp.

        System.Console.WriteLine(multipleAnon(1, 2, 3));;
        multipleActionAnon(1, 2, 3);

        //Lambda practice
        Action<string, long> person = (name, id) => System.Console.WriteLine($"Hello, {name} \nYour social security number is {id} ");

        try{
        Console.WriteLine("Enter name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter ID: ");
        long id = Int64.Parse(Console.ReadLine());
        person(name, id);
        }
        
        catch (Exception ex){
            System.Console.WriteLine("Nguwawor, Error:\n" + ex.Message);
        }

    }
}