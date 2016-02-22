using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrUtilities;

namespace StringManipulationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi str: ");
            string input = Console.ReadLine();
            var str = new StringUtils(input);
            Console.WriteLine("Word count: {0}", str.GetWordCount());
            Console.WriteLine("Reverse: {0}", str.GetReverseString());
            Console.WriteLine("Reverse words: {0}", str.GetReverseWords());
            Console.WriteLine("Num of \"a\" char is: {0}", str.GetCharCount('a'));
            Console.WriteLine("Num of sentances: {0}", str.GetSentenceCount());

        }
    }
}
