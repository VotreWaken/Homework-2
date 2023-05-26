using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            FillArray(arr);
            ShowArray(arr);
            Console.WriteLine("1. Multiply matrix to Number");
            Console.WriteLine("2. Matrix Addition");
            Console.WriteLine("3. Product of Matrix");
            Console.WriteLine("4. Exit");
            Console.Write("\n Enter Choice :");
            int UserChoice = int.Parse(Console.ReadLine());
            switch (UserChoice)
            {
                case 1:
                    Console.Write("\nEnter Number :");
                    int number = int.Parse(Console.ReadLine());
                    MatrixMultiply(arr, number);
                    break;
                case 2:
                    MatrixAddition(arr);
                    break;
                case 3:
                    MatrixProduct(arr);
                    break;
                case 4:
                    return;
                default: Console.WriteLine("Error Input"); break;
            }
        }

        static void FillArray(int[,] _arr)
        {
            Random random = new Random();
            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                for (int j = 0; j < _arr.GetLength(1); j++)
                {
                    _arr[i, j] += random.Next(-100, 100);
                }
            }
        }

        static void ShowArray(int[,] _arr)
        {
            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < _arr.GetLength(1); j++)
                {
                    Console.Write(_arr[i, j] + " ");
                }
            }
        }

        static void MatrixMultiply(int[,] arr, int number)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] *= number;
                }
            }
            ShowArray(arr);
        }

        static void MatrixAddition(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] += arr[i, j];
                }
            }
            ShowArray(arr);
        }

        static void MatrixProduct(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] *= arr[i, j];
                }
            }
            ShowArray(arr);
        }
    }
}
