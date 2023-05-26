using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Second
    {
        static void Main(string[] args)
        {
            int[,] _arr = new int[4, 4];
            FillArray(_arr);
            ShowArray(_arr);
            SumDiapason(_arr);
            FindMinIndex(_arr);
            FindMaxIndex(_arr);
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

        static void SumDiapason(int[,] _arr)
        {
            int min = -100;
            int max = 100;
            int rezalt = 0;
            foreach (var item in _arr)
            {
                if (item > -100 && item < 100)
                {
                    rezalt += item;
                }
            }
            Console.WriteLine($"Cумма elemets = {rezalt}");
        }

        static int FindMinIndex(int[,] FirstArray)
        {
            int IndexMinRow = 0;
            int IndexMinCol = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (FirstArray[i, j] < FirstArray[IndexMinRow, IndexMinCol])
                    {
                        IndexMinRow = i;
                        IndexMinCol = j;
                    }
                }
            }
            Console.WriteLine($"Min elemets = {FirstArray[IndexMinRow, IndexMinCol]}");
            return IndexMinRow;
        }

        static int FindMaxIndex(int[,] FirstArray)
        {
            int IndexMinRow = 0;
            int IndexMinCol = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (FirstArray[i, j] > FirstArray[IndexMinRow, IndexMinCol])
                    {
                        IndexMinRow = i;
                        IndexMinCol = j;
                    }
                }
            }
            Console.WriteLine($"Max elemets = {FirstArray[IndexMinRow, IndexMinCol]}");
            return IndexMinRow;
        }
    }


}
