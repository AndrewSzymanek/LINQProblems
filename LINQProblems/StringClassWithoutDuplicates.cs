using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class StringClassWithoutDuplicates
    {
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        public static List<string> ListWithoutDuplicates(List<string> items)
        {
            return items.Distinct().ToList();
        }

    }
}
