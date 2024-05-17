internal class Program
{
    private static void Main(string[] args)
    {
        foreach (var item in GetNumbers())
        {
            System.Console.WriteLine(item);
        }
        // int n = Convert.ToInt32(Console.ReadLine());
        // for (int i = 1; i <= n; i++){
        //     if (i % 15 == 0){
        //         System.Console.WriteLine("FooBar");
        //     }
        //     else if (i % 3 == 0){
        //         System.Console.WriteLine("Foo");
        //     }
        //     else if (i % 5 == 0){
        //         System.Console.WriteLine("Bar");
        //     }
        //     else{
        //         System.Console.WriteLine(i);
        //     }
        // }

    }

    public static IEnumerable<int> GetNumbers(){
        // int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < 50 + 1; i++){
            if (i % 15 == 0 ){
                System.Console.WriteLine("FooBar");
            }
            else if (i % 3 == 0){
                System.Console.WriteLine("Foo");
            }
            else if (i % 5 == 0){
                System.Console.WriteLine("Bar");
            }
            else{
                yield return i;
            }
        }
    }
}