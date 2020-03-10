using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackLight.Recruitment.UnitTests
{
    class Algorithms
    {
        public static string ReverseWordsInString(string input)
        {
            var reverseSentence = string.Join(" ", input.Split(' ').Reverse());
            return reverseSentence;
        }

        public static string ReverseWordsInStringWithoutUsingAnyLinqMethods(string input)
        {
            string reverseSentence = string.Empty;
            string[] splitSentence = input.Split(' ');
            for (int i = splitSentence.Length - 1; i > -1; i--)
            {
                if (i != 0)
                {
                    reverseSentence = reverseSentence + splitSentence[i] + " ";
                }
                else
                {
                    reverseSentence = reverseSentence + splitSentence[i];
                }
            }

            return reverseSentence;
        }

        internal static int[] SortWithoutUsingBuiltInSortMethods(int[] input)
        {
            int r;
            for (int p = 0; p <= input.Length - 2; p++)
            {
                for (int i = 0; i <= input.Length - 2; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        r = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = r;
                    }
                }
            }

            return input;
        }
    }
}
