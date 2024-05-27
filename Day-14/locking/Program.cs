using System;
using System.Threading;

namespace Threading_without_lock
{
    class lookup
    {
        static object LockedIn = new object();
        
        static void Main(string[] args)
        {
            Thread one = new Thread(PrntChar);
            Thread two = new Thread(PrntChar);
            one.Start();
            two.Start();

            Console.ReadLine();
        }

        public static void PrntChar()
        {
            lock (LockedIn)
            {
                string strArray = "Hi kevin";
                int y;
                y = 0;

                for (y = y; y < strArray.Length; y++)
                {
                    Console.Write($"{strArray[y]}");
                    Thread.Sleep(TimeSpan.FromSeconds(0.1));
                }

                Console.Write(" ");
            }
        }
    }
}
