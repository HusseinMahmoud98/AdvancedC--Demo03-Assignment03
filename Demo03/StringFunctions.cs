using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    internal static class StringFunctions
    {
        public static int GetCountOfUpperCaseChars(string word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                        count++;
                }
            }

            return count;
        }

        public static int GetCountOfLowerCaseChars(string word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                        count++;
                }
            }

            return count;
        }
    }
}
