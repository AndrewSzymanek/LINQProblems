using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class ClassGradeAverage
    {
        public static List<double> AverageGrades(List<string> items)
        {
            
            List<double> averages = new List<double>();
            foreach (string item in items)
            {    
                string[] grades = SplitOffLowestGrade(item);
                double[] gradesAsDoubles = MakeGradesArrayIntoDoubles(grades);
                double average = gradesAsDoubles.Average();
                averages.Add(average);
            }
            return averages;
        }
        public static double AverageGrade(List<double> items)
        {        
            return items.Average();
        }
        public static string[] SplitOffLowestGrade(string item)
        {
            var output = item.Split(',').OrderBy(i => int.Parse(i)).ToList();
            output.RemoveAt(0);
            return output.ToArray();
        }
        public static double[] MakeGradesArrayIntoDoubles(string[] item)
        {
            double[] doubleArray = new double[item.Length];
            for(int i = 0; i < item.Length; i++)
            {
                doubleArray[i] = double.Parse(item[i]);
            }
            return doubleArray;
        }    
    }
}
