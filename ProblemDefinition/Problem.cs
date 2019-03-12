using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemDefinition
{
    public class Problem
    {
        public static double[] low;
        public static double[] high;
        public static string filePath;
        

        public static double[] lowerBand() { return low; }

        public static double[] upperBand() { return high; }

        public static string getFilePath() { return filePath; }
    }
}
