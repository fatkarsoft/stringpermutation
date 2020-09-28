using System;
using System.Collections.Generic;
using System.Linq;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {

            string mainWordInput = Console.ReadLine();
            string searchText = Console.ReadLine();

            string[] mainWord = mainWordInput.ToCharArray().Select(s => s.ToString()).ToArray();
            bool result = Helper.CheckWord(mainWord, searchText);

            Console.WriteLine(result);

            Console.Read();
        }
    }
}
