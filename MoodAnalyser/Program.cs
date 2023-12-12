using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            MoodAnalysers ma=new MoodAnalysers();
            string str1 = "I am in Sad Mood";
            string res=ma.analyseMood(str1);
            Console.WriteLine($"Mood of the user is:{res}");

            string str2 = "I am in good Mood";
            string res1 = ma.analyseMood(str2);
            Console.WriteLine($"Mood of the user is:{res1}");

        }
    }
}
