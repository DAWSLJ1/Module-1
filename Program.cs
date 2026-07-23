using System.Collections.Immutable;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    internal class Program
    {
        static void Main()
        {
            
            int input;
            do
            {
                Console.Clear();
                Console.WriteLine("Which task would you like to visit?");
                Console.WriteLine();
                Console.WriteLine("1. FizzBuzz");
                Console.WriteLine("2. ConvertToSeconds");
                Console.WriteLine("3. Remove Vowels");
                Console.WriteLine("4. Array Average");
                Console.WriteLine("5. Array Operation");
                Console.WriteLine("6. Word Count");
                Console.WriteLine("7. Is Prime");
                Console.WriteLine("8. Is Palindrome");
                Console.WriteLine("9. Is Anagram");
                Console.WriteLine("10. Filter Countries");
                Console.WriteLine("11. Random Joke");
                Console.WriteLine("0. Exit");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        break;
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
                    case 8:
                        Console.Clear();
                        IsPal();
                        break;
                    case 9:
                        Console.Clear();
                        IsAn();
                        break;
                    case 10:
                        Console.Clear();
                        FilterCountries();
                        break;
                        case 11:
                            Console.Clear();
                        RandomJoke();
                        break;
                    default:
                        Console.Clear();
                        //Main();
                        break;
                }

            } while (input != 0);
        }

        public static void IsPrime()
        {
            Console.WriteLine("Enter a number that is either a or not a prime number");
            Console.WriteLine(IsPrime(Convert.ToInt32(Console.ReadLine())));

            Console.ReadLine();
            
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
            Console.WriteLine("The anemone, the wild violet, the hepatica, and the funny little curled-up ferns.");
            Console.WriteLine();
            string[] words = sentence.Split(new char[] { ' ', ',', '.', '-' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (string word in words)
            {
                if (word.Equals("the", StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            Console.WriteLine($"The word 'the' appears {count} times.");
            Console.ReadLine();
            
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
            Console.WriteLine($"The total of all these numbers is {sum}");
            Console.ReadLine();
            
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
         
        }
        public static void RemoveVowels()
        {
            Console.WriteLine("AEIOU");
            Console.WriteLine("bcd fgh");
            Console.WriteLine("C@#omput!er");
            Console.WriteLine("''");
            Console.WriteLine();
            Console.WriteLine("Converted");
            Console.WriteLine();
            Console.WriteLine($"");
            Console.ReadLine();
            


        }
        public static void RemoveVowels(string word)
        {
            string result = new string(word);
            foreach (char c in word)
            {
                if ("aeiouAEIOU".IndexOf(c) == -1)
                {
                    result.Append(c);
                }
            }

        }

        public static void IsPal()
        {
            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            string newsentence = new string(charArray);
            Console.WriteLine();


            if (sentence == newsentence)
            {
                Console.WriteLine("This sentence is a palindrome");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(newsentence);
                Console.WriteLine("This sentence is NOT a palindrome");
                Console.ReadLine();
            }
            
        }
        public static void IsAn()
        {
            bool Is = true;
            Console.WriteLine("Input your first word");
            string first = Console.ReadLine();
            char[] charArray1 = first.ToCharArray();
            Array.Sort(charArray1);
            Console.WriteLine("Input your second word");
            string second = Console.ReadLine();
            char[] charArray2 = second.ToCharArray();
            Array.Sort(charArray2);
            int count = 0;

            if (charArray1.Length != charArray2.Length)
            {
                Is = false;
            }
            else
            {
                for (int i = 0; i < charArray2.Length; i++)
                {


                    if (charArray1[i] != charArray2[i])
                    {
                        Is = false;
                    }


                   

                }
            }
            if (Is == true)
            {
                Console.WriteLine("These sentences are an Anagram");
            }
            else 
            {
                Console.WriteLine("These sentences are NOT an Anagram");
            }
            Console.ReadLine();
            

        }

       public static void FilterCountries()
        {
            try
            {
                StreamReader sr = new StreamReader(@"countries.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    char[] letters = line.ToCharArray();
                    if (Char.ToLower(letters[0]) == 'b')
                    {
                        Console.WriteLine(line);
                    }
                }
                sr.Close();
            }
            catch
            {
                Console.WriteLine("Couldn't find");
            }
            Console.ReadLine();
        }
        public static void RandomJoke()
        {
            try
            {
                StreamReader sr = new StreamReader(@"computer-jokes.txt");
                List<string> jokes = new List<string>();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    jokes.Add(line);
                }
                sr.Close();



                Console.WriteLine(jokes[new Random().Next(0, jokes.Count)]);
            }
            catch
            {
                Console.WriteLine("Couldn't find");
            }
            Console.ReadLine();
        }


    }
}

