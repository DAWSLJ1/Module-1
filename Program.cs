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
            Console.WriteLine("5. Array Operation");
            Console.WriteLine("6. Word Count");
            Console.WriteLine("7. Is Prime");
            Console.WriteLine("8.");
            Console.WriteLine("9.");
            Console.WriteLine("10.");
            Console.WriteLine("11.");
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
                case 5:
                    Console.Clear();
                    ArrayOp();
                    break;
                case 6:
                    Console.Clear();
                    WordCount();
                    break;
                case 7:
                    Console.Clear();
                    IsPrime();
                    break;
                default:
                    Console.Clear();
                    Main();
                    break;
            }
            
           
        }

        public static void IsPrime()
        {
        Console.WriteLine(IsPrime(7));  
        Console.WriteLine(IsPrime(10));  
        Console.WriteLine(IsPrime(2));   
        Console.WriteLine(IsPrime(1));

            Console.ReadLine();
            Main();
        }

         static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }
        
        public static void WordCount()
        {
 string sentence = "The anemone, the wild violet, the hepatica, and the funny little curled-up ferns.";

        string[] words = sentence.Split(new char[] { ' ', ',', '.', '-' }, StringSplitOptions.RemoveEmptyEntries);

        int count = 0;

        foreach (string word in words)
        {
            if (word.Equals("the", StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }

        Console.WriteLine($"The word "the" appears {count} times.");
    }
        }

        public static void ArrayOp()
        {
            Console.WriteLine("21, 19, 68, 55, 42, 12");
            Console.WriteLine();
             int[] nums = { 21, 19, 68, 55, 42, 12 };

        Console.WriteLine("Odd numbers:");
        foreach (int num in nums)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }
        }
            Console.WriteLine();

        Array.Sort(nums);

        Console.WriteLine("Sorted array:");
        foreach (int num in nums)
        {
            Console.WriteLine(num);
        }
            Console.ReadLine();
            Main();
        }
        
        public static void ArrayAv()
        {
            double[] nums = { 45.3, 67.5, -45.6, 20.34, -33.0, 45.6 };
            Console.WriteLine("45.3, 67.5, -45.6, 20.34, -33.0, 45.6");
            Console.ReadLine();
          
            double sum = 0;

        foreach (double num in nums)
        {
            sum += num;
        }

        double average = sum / nums.Length;
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
           Console.WriteLine($"\"{RemoveVowels("AEIOU")}\"");       
            Console.WriteLine($"\"{RemoveVowels("bcd fgh")}\"");  
            Console.WriteLine($"\"{RemoveVowels("C@#omput!er")}\"");
            Console.WriteLine($"\"{RemoveVowels("")}\"");  
            Console.ReadLine();
            Main();
        }
    static string RemoveVowels(string word)
    {
        if (string.IsNullOrEmpty(word))
            return word;

        StringBuilder result = new StringBuilder();

        foreach (char c in word)
        {
            if ("aeiouAEIOU".IndexOf(c) == -1)
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
    }
}
