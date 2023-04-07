using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDSA.Algorithm
{
    internal static class FactorializeNumber
    {
        public static double Factorialize(double num)
        {
            double result = 1;
            for (int i = 1; i <= num; i++) { result= result* i; }
            return result;
        }
    }
}
