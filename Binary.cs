using System;

namespace Binarios
{
    public class Binary
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Binary from 0 to 255");
            Console.WriteLine();

            int counter = 0;

            while (counter <= 255)
            {
                string binary = Convert.ToString(counter, 2);
                Console.WriteLine($"{counter} => {binary}");
                counter++;
            }
        }
    }
}
