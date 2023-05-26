using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "Hello world";
            int shift = 3;

            Console.WriteLine("\nEncrypt: " + CaesarEncrypt(txt, shift));
            Console.WriteLine("Decrypt: " + CaesarDecrypt(txt, shift));
        }
        static string CaesarEncrypt(string input, int shift)
        {
            string result = "";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    int charCode = (int)c;
                    int shiftAmount = shift % 26;
                    if (charCode + shiftAmount > 90 && charCode <= 90 || charCode + shiftAmount > 122)
                    {
                        charCode -= 26;
                    }
                    char shiftedChar = (char)(charCode + shiftAmount);
                    result += shiftedChar;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
        static string CaesarDecrypt(string input, int shift = 0)
        {
            return CaesarEncrypt(input, 3 - shift);
        }
    }
}
