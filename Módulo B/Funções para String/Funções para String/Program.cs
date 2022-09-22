using System;

namespace Funções_para_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde ABCDE ABC abc DEFG";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            int n1 = original.IndexOf("ABC");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Replace("ABC", "Fanta");

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original: {original}");
            Console.WriteLine($"ToUpper: {s1}");
            Console.WriteLine($"ToLower: {s2}");
            Console.WriteLine($"Trim: {s3}");
            Console.WriteLine($"IndexOf 'ABC': {n1}");
            Console.WriteLine($"LastIndexOf 'bc': {n2}");
            Console.WriteLine($"Substring: {s4}");
            Console.WriteLine($"Replace 'ABC' por 'Fanta': {s5}");
            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");

        }
    }
}
