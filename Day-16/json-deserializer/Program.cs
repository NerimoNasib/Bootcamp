using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Student shun = new Student("Shun", 15);
        Student hoshino = new Student("Hoshino", 17);
        Student shiroko = new Student("Shiroko", 16);
        Student hifumi = new Student("Hifumi", 17);
        Student izuna = new Student("Izuna", 15);

        List<Student> blueArcip = new List<Student>(){
            shun, hoshino, shiroko, hifumi, izuna
        };

        // string json = JsonSerializer.Serialize(blueArcip);
        // using(StreamWriter streamWriter = new("file.json")){
        //     streamWriter.WriteLine(json);
        // }

        string result;
        using(StreamReader sr = new("file.json")){
            result = sr.ReadToEnd();
        }
        Console.WriteLine(result);
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