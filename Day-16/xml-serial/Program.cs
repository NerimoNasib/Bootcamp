using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

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

        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

        using (StreamWriter streamWriter = new StreamWriter("file.xml"))
        {
            serializer.Serialize(streamWriter, blueArcip);
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student() { }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
