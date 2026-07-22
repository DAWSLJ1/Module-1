using System.Security.Cryptography.X509Certificates;

namespace Test
{
    internal class Program
    {
        static void Main()
        {
            int input;
            double[] num = {45.3, 67.5, -45.6, 20.34, -33.0, 45.6};
            Console.WriteLine("Which task would you like to visit?");
            Console.WriteLine();
            Console.WriteLine("1. FizzBuzz");
            Console.WriteLine("2. ConvertToSeconds");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.Clear();
                    FizzBuzz();
                    break;
                case 2:
                    Console.Clear();
                    ConvertToSeconds();
                    break;
                default:
                    Console.Clear();
                    Main();
                    break;
            }
            
           
        }
        public static void FizzBuzz()
        {
            int number;
            
            Console.WriteLine("Input a number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                Console.ReadLine();
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
                Console.ReadLine();
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
                Console.ReadLine();
            }
            else
            {
                    Console.WriteLine(number);
                    Console.ReadLine();              
            }
            Main();
        }
        public static void ConvertToSeconds()
        {
            int min, hour, convmin, convhour, sec;
            Console.WriteLine("How many hours would you like to convert?");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many minutes would you like to convert?");
            min = Convert.ToInt32(Console.ReadLine());


            convhour = (hour * 60 * 60);
            convmin = (min * 60);
            sec = (convmin + convhour);
            Console.WriteLine($"That amount of time is converted into {sec} seconds");
            Console.ReadLine();
            Main();
        }
        public static void RemoveVowels()
        {
            Console.WriteLine("AEIOU");
            Console.WriteLine("bcd fgh");
            Console.WriteLine("C@#omput!er");
            Console.WriteLine("");
        }
    }
}
