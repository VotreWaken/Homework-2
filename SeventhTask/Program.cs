using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _txt = "Hello World Text Lorem Ipsum";
            Console.WriteLine(_txt);
            Console.WriteLine("Enter Bad Word");
            string badWord = Console.ReadLine();
            string Censored = "***";
            string replacedText = _txt.Replace(badWord, Censored);
            short num_rez = 0;
            for (int i = 0; i < replacedText.Length - Censored.Length + 1; i++)
            {
                if (replacedText.Substring(i, Censored.Length) == Censored)
                {
                    num_rez++;
                }
            }
            Console.WriteLine($"\nResult: {replacedText}");
        }
    }
}
