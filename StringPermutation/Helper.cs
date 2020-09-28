using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringPermutation
{
    public static class Helper
    {
        public static bool CheckWord(string[] mainWord, string expression)
        {
            bool isFound = false;

            if (mainWord.Length == 0)
                return false;
            int factorial = 1;
            for (int i = 2; i <= mainWord.Length; i++)
                factorial *= i;
            for (int v = 0; v < factorial; v++)
            {
                string[] tempArray = mainWord;

                int k = v;
                for (int j = 2; j <= mainWord.Length; j++)
                {
                    int other = (k % j);
                    string temp = tempArray[j - 1];
                    tempArray[j - 1] = tempArray[other];
                    tempArray[other] = temp;
                    k = k / j;
                }

                string joinedString = string.Join("", tempArray);
                Console.WriteLine(joinedString);
                if (joinedString.Contains(expression))
                {
                    isFound = true;
                    break;
                }
            }

            return isFound;
        }
    }
}
