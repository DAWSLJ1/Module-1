using System.Security.Cryptography.X509Certificates;

namespace Test
{
    internal class Program
    {
        static void Main()
        {
            int input;
            Console.WriteLine("Which task would you like to visit?");
            Console.WriteLine();
            Console.WriteLine("1. FizzBuzz");
            Console.WriteLine("2. ConvertToSeconds");
            Console.WriteLine("3. Remove Vowels");
            Console.WriteLine("4. Array Average");
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
                case 3:
                    Console.Clear();
                    RemoveVowels();
                    break;
                case 4:
                    Console.Clear();
                    ArrayAv();
                    break;
                default:
                    Console.Clear();
                    Main();
                    break;
            }
            
           
        }
        public static void ArrayAv()
        {
            double[] num = { 45.3, 67.5, -45.6, 20.34, -33.0, 45.6 };
            Console.WriteLine("45.3, 67.5, -45.6, 20.34, -33.0, 45.6");
            Console.ReadLine();
            double average, total;
            total = ((num[1] + num[2] + num[3] + num[4] + num[5] + num[0]));
            average = (num[1] + num[2] + num[3] + num[4] + num[5] + num[0]) / (double)num.Length;
            Console.WriteLine($"The average of these numbers is {average}");
            Console.WriteLine($"The total of all these numbers is {total}");
            Console.ReadLine();
            Main();
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
