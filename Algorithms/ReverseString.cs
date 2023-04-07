namespace AlgorithmsAndDSA.Algorithm
{
    internal static class ReverseString
    {
        static char[]? _original;
        static IEnumerable<char>? _reversed;

        static char[] WordToArray(string s) {
            return s.ToCharArray();
        }

        static IEnumerable<char> Reverse(char[] s) {
            return s.Reverse<char>();
        }

        static string JoinString(IEnumerable<char> s) {
            return String.Join("", s);
        }
        public static string GetReversedWord(string s)
        {
            _original = WordToArray(s);
            _reversed = Reverse(_original);
            return JoinString(_reversed);
        }
    }
}
