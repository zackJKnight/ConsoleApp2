using System;
using System.Linq;

namespace ConsoleApp2
{
    public static class ExtensionMethods
    {
        public static string GarbleToHeck(this string s)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alphabetUpper = alphabet.ToCharArray();
            char[] alphabetLower = alphabet.ToLower().ToCharArray();
            char[] garbledAlphabetUpper = new char[26];
            char[] garbledAlphabetLower = new char[26];

            string result = string.Empty;
            int i = 0;
            foreach (char c in alphabetUpper)
            {
                i = Array.IndexOf(alphabetUpper, c);
                garbledAlphabetUpper[i] = alphabetUpper[new Random().Next(alphabetUpper.Length - 1)];
                garbledAlphabetLower[i] = alphabetLower[new Random().Next(alphabetLower.Length - 1)];

            }

            foreach (char indexChar in s.ToCharArray())
            {

                var indexArray = char.IsLower(indexChar) ? alphabetLower : alphabetUpper;
                if (indexArray.Contains(indexChar))
                {
                    var garbledArray = char.IsLower(indexChar) ? garbledAlphabetLower : garbledAlphabetUpper;
                    result += garbledArray[Array.IndexOf(indexArray, indexChar)];
                }
                else
                {
                    result += indexChar;
                }
            }
            return result;
        }

    }
}
