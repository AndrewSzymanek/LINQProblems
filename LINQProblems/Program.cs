using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> thWords;
            thWords = SubStringFinder.GetThWords(words);
            foreach (string word in thWords)
            {
                Console.WriteLine(word);
            }
            
            Console.ReadLine(); 
        }
    }
}
