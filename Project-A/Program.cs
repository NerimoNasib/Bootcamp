// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// class Program{
//     static void Main(){
//         Cat caty = new Cat();
//         caty.Eat();
//     }
// }

// class Cat{
//     int age;
//     string color;
//     string species;

//     public void Eat(){
//         Console.WriteLine("meong");
//     }
// }

public class Solution {
    public int MySqrt(int x) {
        double i=0;
        while(i*i<=x)
        {
            
            if( (i*i) <= x && (i+1)*(i+1) > x)
                return (int)i;
                i++;
        }
        return 0;
    }
}