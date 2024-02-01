using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elementry exercises: ");

            
        }

        public static void EX1()
        {
            Console.WriteLine("Hello World!");
        }

        public static void EX2()
        {
            /*
             * Console.Read() is a method that is used to read the next character from the standard input stream
             * Console.readline() is a method that is used to read the next line of characters from the standard input stream
             */
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
        }

        public static void EX3()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter your name: ");
                var name = Console.ReadLine();

                if (name.ToLower() != "alice" && name.ToLower() != "bob")
                {
                    Console.WriteLine("Hello there!");
                }
                else
                {
                    Console.WriteLine($"Hello {name}");
                }
            }
        }

        public static void EX4()
        {
            Console.Write("Please enter a number: ");
            var number = int.Parse(Console.ReadLine());

            var result = number + 1;

            Console.WriteLine($"Sum of the numbers 1 to your input: {result}");
        }

        public static void EX5()
        {
            Console.Write("Please enter a number: ");
            var number = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine($"Number divisible number by 3 and 5: {i}");
                    sum += i;
                }
            }

            Console.WriteLine($"Sum of the numbers: {sum}");
        }

        public static void EX6()
        {
            Console.WriteLine("Please enter a number: ");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1 for product or 2 for sum: ");
            var operation = int.Parse(Console.ReadLine());

            var sum = 0;
            var product = 0;

            if (operation == 1)
            {
                for (int i = 1; i <= number; i++)
                {
                    product = product * i;
                }
            }
            else if (operation == 2)
            {
                for (int i = 1; i <= number; i++)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine($"Product operation: {product}");
            Console.WriteLine($"Sum operation: {sum}");
        }

        public static void EX7()
        {
            Console.Write("Please enter a number to multiply: ");
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                var result = i * number;
                Console.WriteLine($"{i} x {number} = {result}");
            }
        }

        public static void EX8()
        {
            Console.WriteLine("Prime numbers: ");
            for (int num = 1; num <= 10; num++)
            {
                var isPrime = IsPrime2(num);

                if (isPrime)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static bool IsPrime2(int number)
        {
            // 0 and 1 is not prime number
            if (number == 0 || number == 1) return false;

            // run a loop from 2 to n-1
            //i = number = 2, then with condition <, so it goes back to true
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;

            }

            return true;
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void EX9()
        {
            var rand = new Random();

            var secretNumber = rand.Next(1, 100);

            Console.Write("Guess a number: ");
            var number = int.Parse(Console.ReadLine());
            var previousNumber = number;

            var count = 1;

            while (number != secretNumber)
            {
                if (number < secretNumber)
                {
                    Console.WriteLine("Your number is too small");
                }
                else
                {
                    Console.WriteLine("Your number is too large");
                }

                Console.Write("Guess a number: ");
                number = int.Parse(Console.ReadLine());

                if (number != previousNumber) count++;

                previousNumber = number;
            }

            Console.WriteLine($"Number of tries: {count}");
        }

        public static void EX10()
        {
            var year = DateTime.Now.Year;
            var next20years = year + 20;

            for (int i = year; i <= next20years; i++)
            {
                //exactly divided by 4 (/)
                //exactly divided by 100, then it isn't (x)
                //exactly divided by 400 (/)

                if (i % 4 == 0)
                {
                    if (i % 100 != 0)
                    {
                        Console.WriteLine($"{i} is a leap year.");
                    }
                    else if (i % 400 == 0)
                    {
                        Console.WriteLine($"{i} is a leap year.");
                    }
                }
            }
        }
    }
}
