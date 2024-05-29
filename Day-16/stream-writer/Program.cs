internal class Program
{
    private static void Main(string[] args)
    {
        using (FileStream fileStream = new FileStream(String.Format("text.txt"), FileMode.OpenOrCreate))
        using (StreamWriter streamWriter = new StreamWriter(fileStream))
        {
            streamWriter.WriteLine("Jawa!!!!");
        }
    }
}