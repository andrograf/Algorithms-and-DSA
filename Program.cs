using AlgorithmsAndDSA.Algorithm;

namespace AlgorithmsAndDSA

{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintToConsol.Print(ConvertTemperature.CelsiusToFarenheit(30.5));
            PrintToConsol.Print(ConvertTemperature.FarenheitToCelsius(86));
            PrintToConsol.Print(ReverseString.GetReversedWord("amazing"));
            PrintToConsol.Print(FactorializeNumber.Factorialize(5));
            PrintToConsol.Print(FindLongestWordInString.FindLongestWordLength("What if we try a super-long word such as otorhinolaryngology"));

        }
    }
}