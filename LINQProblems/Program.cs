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
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            StringClassWithoutDuplicates.ListWithoutDuplicates(names);

            Console.ReadLine();
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        }
    }
}
