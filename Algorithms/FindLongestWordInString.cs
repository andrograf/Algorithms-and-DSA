using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDSA.Algorithm
{
    internal static class FindLongestWordInString
    {
        public static int FindLongestWordLength(string str)
        {
            var words = str.Split(' ');
            var longest = "";
            Array.ForEach(words,(x)=> { if (x.Length > longest.Length) { longest = x; } });
            return longest.Length;
        }
    }
}
