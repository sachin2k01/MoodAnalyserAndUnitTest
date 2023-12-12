using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalysers
    {
        public string analyseMood(string txt)
        {
            string text=txt.ToLower();
            if(text.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";

            }
            
        }
    }
}
