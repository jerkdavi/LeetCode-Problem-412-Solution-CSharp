using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class Solution
    {
        public static IList<string> FizzBuzz(int n)
        {
            List<string> output = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string word = "";
                if ((i + 1) % 3 == 0)
                {
                    word += "Fizz";
                }
                if ((i + 1) % 5 == 0)
                {
                    word += "Buzz";
                }
                if (word == "")
                {
                    word += i + 1;
                }
                output.Add(word);
            }
            return output;
        }
    }
}
