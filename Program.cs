using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrays();
        }

        public static void Arrays()
        {
            Console.Write("N:");
            string numberOfRandoms = Console.ReadLine();
            int N = int.Parse(numberOfRandoms);

            int[] randomArrays = new int[N];

            for (int i = 0; i <= randomArrays.Length - 1; i++)
            {
                randomArrays[i] = new Random().Next(1, 26);
            }

            //countEven
            int countEven = 0;
            for (int i = 0; i < randomArrays.Length; i++)
            {
                if (randomArrays[i] % 2 == 1)
                {
                    countEven++;
                }
            }

            //countOdd
            int countOdd = 0;
            for (int i = 0; i < randomArrays.Length; i++)
            {
                if (randomArrays[i] % 2 == 0)
                {
                    countOdd++;
                }
            }

            int[] arrayEvenNumbers = new int[countEven];
            int[] arrayOddNumbers = new int[countOdd];

            int even = 0, odd = 0;


            //arrayEvenNumbers
            for (int i = 0; i < randomArrays.Length; i++)
            {
                if (randomArrays[i] % 2 == 1)
                {
                    arrayEvenNumbers[even] = randomArrays[i];
                    even++;
                }
            }

            //arrayOddNumbers
            for (int i = 0; i < randomArrays.Length; i++)
            {
                if (randomArrays[i] % 2 == 0)
                {
                    arrayOddNumbers[odd] = randomArrays[i];
                    odd++;
                }
            }

            Console.WriteLine();

            List<char> list = new List<char>();

       
            for (char c = '`'; c <= 'z'; ++c)
            {
                    list.Add(c);
            }

            char[] alphabet = list.ToArray();

            char[] numbersToCharEven = new char[arrayEvenNumbers.Length];
            char[] numbersToCharOdd = new char[arrayOddNumbers.Length];

            for (int i = 0; i < numbersToCharEven.Length; i++)
            {
                numbersToCharEven[i] = alphabet[arrayEvenNumbers[i]];
            }

            for (int i = 0; i < numbersToCharOdd.Length; i++)
            {
                numbersToCharOdd[i] = alphabet[arrayOddNumbers[i]];
            }


            // aeidhj to uppercase for Even             
            int countEvenUpper = 0;

            for (int i = 0; i < numbersToCharEven.Length; i++)
            {
                
                if (numbersToCharEven[i] == 'a' || numbersToCharEven[i] == 'e' || numbersToCharEven[i] == 'i' || numbersToCharEven[i] == 'd' || numbersToCharEven[i] == 'h' || numbersToCharEven[i] == 'j' )
                {
                    numbersToCharEven[i] = char.ToUpper(numbersToCharEven[i]);
                    countEvenUpper++;
                }
                else
                { 
                    numbersToCharEven[i] = alphabet[arrayEvenNumbers[i]];
                }
            }


            // aeidhj to uppercase for Odd
            int countOddUpper = 0;

            for (int i = 0; i < numbersToCharOdd.Length; i++)
            {

                if (numbersToCharOdd[i] == 'a' || numbersToCharOdd[i] == 'e' || numbersToCharOdd[i] == 'i' || numbersToCharOdd[i] == 'd' || numbersToCharOdd[i] == 'h' || numbersToCharOdd[i] == 'j')
                {
                    numbersToCharOdd[i] = char.ToUpper(numbersToCharOdd[i]);
                    countOddUpper++;
                }
                else
                {
                    numbersToCharOdd[i] = alphabet[arrayOddNumbers[i]];
                }
            }


            // Output
            Console.WriteLine();
            Console.WriteLine("0) randomArrays: " + "\t(" + randomArrays.Length + ")");


            for (int i = 0; i < randomArrays.Length; i++)
            {
                Console.Write(randomArrays[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("1) arrayOddNumbers: " + "\t(" + countOdd + ")");

            for (int i = 0; i < arrayOddNumbers.Length; i++)
            {
                Console.Write(arrayOddNumbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("2) arrayEvenNumbers: " + "\t(" + countEven + ")");

            for (int i = 0; i < arrayEvenNumbers.Length; i++)
            {
                Console.Write(arrayEvenNumbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("1.Char Odd Array: ");

            for (int i = 0; i < numbersToCharOdd.Length; i++)
            {
                Console.Write(numbersToCharOdd[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("2.Char Even Array: ");

            for (int i = 0; i < numbersToCharEven.Length; i++)
            {
                Console.Write(numbersToCharEven[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            if (countOddUpper > countEvenUpper)
            {
                Console.WriteLine("У 1 массивi бiльше лiтер у верхньому регiстрi.");
            }
            else if (countOddUpper < countEvenUpper)
            {
                Console.WriteLine("У 2 массивi бiльше лiтер у верхньому регiстрi.");
            }
            else if (countOddUpper == 0 && countEvenUpper == 0)
            {
                Console.WriteLine("В обох массивах немає лiтер у верхньому регiстрi.");
            }
            else if (countOddUpper == countEvenUpper)
            {
                Console.WriteLine("В обох массивах однакова кiлькiсть лiтер у верхньому регiстрi.");
            }
            Console.WriteLine();
        }

    }
}