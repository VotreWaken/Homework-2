using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Text :");
            string _txt = Console.ReadLine();
            string[] sentences = _txt.Split('.');
            string output = "";

            foreach (string intem in sentences)
            {
                if (!string.IsNullOrEmpty(intem))
                {
                    string sentence_With_Upper = intem.TrimStart() ==
                        "" ? "" : char.ToUpper(intem.TrimStart()[0])
                        + intem.TrimStart().Substring(1);
                    output += sentence_With_Upper + ".";
                }
            }
            Console.WriteLine(output);
        }
    }
}
