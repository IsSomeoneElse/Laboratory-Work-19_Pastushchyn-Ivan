using System;

namespace LW19
{
    class Program
    {
        static string RemoveDigits(string input)
        {
            string result = "";

            foreach (char ch in input)
            {
                if (!Char.IsDigit(ch))
                {
                    result += ch;
                }
            }

            return result;
        }

        static string ReplaceSubstring(string input, string oldSubstring, string newSubstring)
        {
            string result = input.Replace(oldSubstring, newSubstring);
            return result;
        }

        static void Main()
        {
            string sequence = "A1B2C3D4E5F6";
            Console.WriteLine("Послідовність символів: " + sequence);

            // Витираємо всі цифри з послідовності
            string resultWithoutDigits = RemoveDigits(sequence);
            Console.WriteLine("Послідовність символів без цифр: " + resultWithoutDigits);

            string sequence2 = "10 карб";
            Console.WriteLine("Послідовність символів зі словом карб: " + sequence2);

            // Замінюємо 'карб' на 'грн'
            string resultReplacingSubstring = ReplaceSubstring(sequence2, "карб", "грн");
            Console.WriteLine("Послідовність зі зміною 'карб' на 'грн': " + resultReplacingSubstring);
        }
    }
}