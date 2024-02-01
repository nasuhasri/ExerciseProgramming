using System;
using System.Collections.Generic;
using System.Threading;

namespace ExerciseProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elementary.EX1();

            Console.WriteLine("List and strings exercise: ");

            var numList = new List<int> { 1, 5, 3, 6, 9, 24, 14 };
            getTotalList(numList);
        }

        public static void EX1()
        {
            var numList = new List<int> { 1, 5, 3, 6, 9, 24, 14 };

            var largestElement = getLargestElement(numList);

            Console.WriteLine($"Largest element: {largestElement}");
        }

        public static int getLargestElement(List<int> numList)
        {
            var largestElement = numList[0];

            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] > largestElement)
                {
                    largestElement = numList[i];
                }
            }

            return largestElement;
        }

        public static void EX2()
        {
            // function in C# list - reverse()
            // example: numList.Reverse();

            var numList = new List<int> { 1, 5, 3, 6, 9, 24, 14 };

            int length = numList.Count - 1;
            var reverseList = new List<int>();

            while (length >= 0)
            {
                reverseList.Add(numList[length]);
                length--;
            }

            for (int i = 0; i < reverseList.Count; i++)
            {
                Console.WriteLine(reverseList[i]);
            }
        }

        public static void EX3()
        {
            // function in C# list: contains()
            // example: numList.Contains(3);

            var numList = new List<int> { 1, 5, 3, 6, 9, 24, 14 };

            Console.WriteLine(IsExist(numList, 5));
        }

        public static bool IsExist(List<int> numList, int elem)
        {
            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] == elem)
                {
                    return true;
                }
            }

            return false;
        }

        public static void EX4()
        {
            var numList = new List<int> { 1, 5, 3, 6, 9, 24, 14 };
            getElementsOnOddPosition(numList);
        }

        public static void getElementsOnOddPosition(List<int> numList)
        {
            var elemOnOddPositionList = new List<int>();

            for (int i = 0; i < numList.Count; i++)
            {
                if (i % 2 != 0)
                {
                    elemOnOddPositionList.Add(numList[i]);
                }
            }

            for (int i = 0; i < elemOnOddPositionList.Count; i++)
            {
                Console.WriteLine(elemOnOddPositionList[i]);
            }
        }

        public static void EX5()
        {
            var numList = new List<int> { 1, 5, 3, 6, 9, 24, 14 };
            getTotalList(numList);
        }

        public static void getTotalList(List<int> numList)
        {
            var sum = 0;

            for (int i = 0; i < numList.Count; i++)
            {
                sum += numList[i];
            }

            Console.WriteLine($"Total sum: {sum}");
        }
    }
}
