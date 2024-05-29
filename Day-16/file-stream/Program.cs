using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        using (FileStream fs = new FileStream("text.txt", FileMode.Create, FileAccess.Write, FileShare.None))
        {
            string text = "arsip biru";
            byte[] myBytes = new byte[text.Length];

            myBytes = Encoding.UTF8.GetBytes(text);
            fs.Write(myBytes, 0, myBytes.Length);
            Console.ReadLine();
        }

        using (FileStream fs1 = File.OpenRead("text.txt")){
            byte[] b = new byte[1024];
            UTF8Encoding tmp = new UTF8Encoding(true);
            int readLen;
            while((readLen = fs1.Read(b, 0, b.Length))>0){
                System.Console.WriteLine(tmp.GetString(b, 0, readLen));
            }
        }
    }
}