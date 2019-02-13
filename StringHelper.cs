using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            if (str == "")
            {
                throw new ArgumentException();
            }
            int count = 0;
            char[] pattern = { 'a', 'e', 'u', 'i', 'o' };

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (str[i] == pattern[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
