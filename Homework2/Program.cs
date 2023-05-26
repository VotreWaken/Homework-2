using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            FillFirst(ref A);
            ShowFirst(ref A);
            FillSecond(ref B);
            ShowSecond(ref B);
            SumOddElements(ref B);
        }

        static void FillSecond(ref double[,] array)
        {
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = rand.NextDouble() * (10 - 1) + 1;
                }
            }
        }

        static void FillFirst(ref int[] array)
        {
            Console.WriteLine("Enter Values");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
        }

        static void ShowFirst(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void ShowSecond(ref double[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine("");
        }

        static void FindCommonMax(ref int[] FirstArray, double[,] SecondArray)
        {
            int FirstArrayMax = FirstArray[0];
            for (int i = 0; i < FirstArray.Length; i++)
            {
                if (FirstArray[i] > FirstArrayMax)
                {
                    FirstArrayMax = FirstArray[i];
                }
            }
            double SecondArrayMax = SecondArray[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (SecondArray[i, j] > SecondArrayMax)
                    {
                        SecondArrayMax = SecondArray[i, j];
                    }
                }
            }

            Console.WriteLine(FirstArrayMax > SecondArrayMax ? FirstArrayMax : SecondArrayMax);
        }

        static void FindCommonMin(ref int[] FirstArray, double[,] SecondArray)
        {
            int FirstArrayMax = FirstArray[0];
            for (int i = 0; i < FirstArray.Length; i++)
            {
                if (FirstArray[i] < FirstArrayMax)
                {
                    FirstArrayMax = FirstArray[i];
                }
            }
            double SecondArrayMax = SecondArray[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (SecondArray[i, j] < SecondArrayMax)
                    {
                        SecondArrayMax = SecondArray[i, j];
                    }
                }
            }
            Console.WriteLine(FirstArrayMax > SecondArrayMax ? FirstArrayMax : SecondArrayMax);
        }

        static void TotalSum(ref int[] FirstArray, double[,] SecondArray)
        {
            int FirstArraySum = FirstArray[0];
            for (int i = 0; i < FirstArray.Length; i++)
            {
                FirstArraySum += FirstArray[i];
            }

            double SecondArraySum = SecondArray[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    SecondArraySum += SecondArray[i, j];
                }
            }

            Console.WriteLine(SecondArraySum + FirstArraySum);
        }

        static void CommonProduct(ref int[] FirstArray, double[,] SecondArray)
        {
            int FirstArraySum = FirstArray[0];
            for (int i = 0; i < FirstArray.Length; i++)
            {
                FirstArraySum *= FirstArray[i];
            }

            double SecondArraySum = SecondArray[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    SecondArraySum *= SecondArray[i, j];
                }
            }

            Console.WriteLine(SecondArraySum + FirstArraySum);
        }

        static void SumEvenElements(ref int[] FirstArray)
        {
            int FirstArraySum = 0;
            for (int i = 0; i < FirstArray.Length; i++)
            {
                if ((FirstArray[i] % 2) == 0)
                    FirstArraySum += FirstArray[i];
            }
            Console.WriteLine(FirstArraySum);
        }

        static void SumOddElements(ref double[,] SecondArray)
        {
            double SecondArraySum = 0;
            for (int i = 0; i < SecondArray.GetLength(0); i++)
            {
                for (int j = 1; j < SecondArray.GetLength(1); j += 2)
                {
                    SecondArraySum += SecondArray[i, j];
                }
            }
            Console.WriteLine(SecondArraySum);
        }
    }
}
