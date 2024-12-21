using System;

namespace homeWorkSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 7;
            int numberMin = 5;
            int numberMax = 103;

            for (int i = numberMin; i <= numberMax; i += steps)
            {
                Console.WriteLine(i);
            }
        }
    }
}
