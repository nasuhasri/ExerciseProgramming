using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ExerciseProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elementary.EX1();

            Console.WriteLine("List and strings exercise: ");

            var numList = new List<int> { 1, 5, 3, 6, 9, 24, 14 };

            
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

        public static void EX6()
        {
            var word = "malayalam";
            var newWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                newWord += word[i];
            }

            Console.WriteLine(newWord);

            if (newWord == word)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }

        public static void EX7()
        {
            var numList = new List<int> { 1, 5, 3, 6, 9, 24, 14 };

            var result = sum_using_recursion(numList);
            Console.WriteLine(result);

            var sumForLoop = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                sumForLoop += numList[i];
            }

            int j = 0;
            var sumWhileLoop = 0;
            while (j < numList.Count)
            {
                sumWhileLoop += numList[j];
                j++;
            }

            Console.WriteLine($"Sum for loop: {sumForLoop}. Sum while loop: {sumWhileLoop}");
        }

        public static int sum_using_recursion(List<int> numList)
        {
            if (numList.Count == 1)
            {
                return numList[0];
            }
            else
            {
                //Return the sum of the first element and the sum of the rest of the elements
                return numList[0] + sum_using_recursion(numList.GetRange(1, numList.Count - 1));
            }
        }

        public static void EX9()
        {
            var numList = new List<int> { 1, 5, 3, 6, 9, 24, 14 };
            var numList1 = new List<int> { 10, 20, 30 };

            numList.AddRange(numList1);

            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
        }

        public static void EX10()
        {
            var numList1 = new List<int> { 10, 20, 30 };
            var numList2 = new List<int> { 1, 2, 3 };

            var newList = new List<int>();
            for (int i = 0; i < numList1.Count; i++)
            {
                newList.Add(numList1[i]);
                newList.Add(numList2[i]);
            }

            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i] + " ");
            }
        }

        public static void EX11()
        {
            var list1 = new List<int> { 1, 4, 6 };
            var list2 = new List<int> { 2, 3, 5 };

            list1.AddRange(list2);
            list1.Sort();

            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }
        }

        public static void EX12()
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5, 6 };

            var elements = 2;

            for (int i = 0; i < elements; i++)
            {
                //this solution is wrong because we are using dynamic i - index number
                //var numToAdd = list1[i];
                //list1.Remove(list1[i]);
                //list1.Add(numToAdd);

                int firstElement = list1[0];
                list1.RemoveAt(0);
                list1.Add(firstElement);
            }

            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i]);
                Console.Write("-");
            }
        }
    }
}
