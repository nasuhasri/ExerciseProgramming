﻿using System;
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
    }
}
