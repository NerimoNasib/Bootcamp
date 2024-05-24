internal class Program
{
    private static void Main(string[] args)
    {
        string fileName = "file.txt";
        FileManager fm = new();
        fm.Write(fileName, "Hello world!");
        string read = fm.ReadLine(fileName);
        System.Console.WriteLine(read);
        System.Console.WriteLine(fm.ReadLine(fileName));
    }
}

class FileManager{
    public void Write(string path, string message){
        using (StreamWriter stream = new(path)){
            stream.WriteLine(message);
        }
    }

    public string ReadLine(string path){
        string result;
        using (StreamReader stream = new(path)){
            result = stream.ReadLine();
        }
        return result;
    }
}