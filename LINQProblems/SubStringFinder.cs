using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class SubStringFinder
    {
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics"};

        public static List<string> GetThWords(List<string> input)
        {
            return input.Where(w => w.ToLower().Contains("th")).ToList();
        }
       
    }
}
