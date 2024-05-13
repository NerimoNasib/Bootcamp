using System;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Exception();
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void Exception()
    {
        string name = null;
        Console.WriteLine(name);

        string[] esteh = {"Es Teh Dingin", "Es Teh Panas", "Es Teh Anget"};
        Console.WriteLine(esteh[3]);

        float x = 10;
        float y = 0;
        Console.WriteLine(x/y);
    }
}
