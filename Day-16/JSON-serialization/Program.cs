using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> blueArcip = new List<Student>();

        bool continueAdding = true;
        while (continueAdding)
        {
            Console.Write("Name: ");
            string? name = Console.ReadLine();

            int age;
            while (true){
                Console.Write("Age: ");
                if (int.TryParse(Console.ReadLine(), out age)){
                    break;
                }else{
                    Console.WriteLine("Invalid age. Please enter a valid integer.");
                }
            }

            blueArcip.Add(new Student(name, age));

            Console.Write("Do you want to add another student? (y/n): ");
            string? choice = Console.ReadLine().ToLower();
            continueAdding = choice == "y";
        }
        // Student shun = new Student("Shun", 15);
        // Student hoshino = new Student("Hoshino", 17);
        // Student shiroko = new Student("Shiroko", 16);
        // Student hifumi = new Student("Hifumi", 17);
        // Student izuna = new Student("Izuna", 15);

        // List<Student> blueArcip = new List<Student>(){
        //     shun, hoshino, shiroko, hifumi, izuna
        // }
        System.Console.Write("Enter file name: ");
        string? fileName = Console.ReadLine();
        string json = JsonSerializer.Serialize(blueArcip);
        using(StreamWriter streamWriter = new($"{fileName}.json")){
            streamWriter.WriteLine(json);
        }
    }
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}