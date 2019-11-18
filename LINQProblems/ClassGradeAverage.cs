using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class ClassGradeAverage
    {
        List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
        
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
