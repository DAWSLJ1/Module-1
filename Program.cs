namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}
