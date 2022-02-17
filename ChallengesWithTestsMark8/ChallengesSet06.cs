using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words != null && words.Count() != 0)
            {
                if (ignoreCase)
                {
                    word = word.ToLower();
                    words = words.Select(w => w == null ? w : w.ToLower());
                }

                return words.Contains(word);
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = Convert.ToInt32(Math.Floor(Math.Sqrt(num))); i > 1; i--)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int prevIndex = -1;
            var prevLetters = "";
            if (str != null && str.Length != 0)
            {
                for(int i = 0; i < str.Length; i++)
                {
                    if(!prevLetters.Contains(str[i]))
                    {
                        if(str.Length == i + 1)
                        {
                            prevIndex = i;
                        }
                        else if(!str.Substring(i+1).Contains(str[i]))
                        {
                            prevIndex = i;
                            prevLetters += str[i];
                        }
                        else
                        {
                            prevLetters += str[i];
                        }
                    }
                }
            }

            return prevIndex;



        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var bestSoFar = 0;

            if (numbers != null && numbers.Length != 0)
            {
                bestSoFar = 1;
                for (int x = 0; x < numbers.Length; x++)
                {
                    var currentStreak = 1;

                    for (int y = x + 1; y < numbers.Length; y++)
                    {
                        if (numbers[y] == numbers[x])
                        {
                            currentStreak++;
                            if (currentStreak > bestSoFar)
                            {
                                bestSoFar = currentStreak;
                            }
                        }
                        else
                        {
                            currentStreak = 1;
                            break;
                        }
                    }
                }
            }

            return bestSoFar;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0];
            }

            var results = new double[elements.Count / n];

            for (int i = 1; i <= elements.Count; i++)
            {
                if (i >= n && i % n == 0)
                {
                    results[(i / n) - 1] = (elements[i - 1]);
                }
            }

            return results;
        }
    }
}
