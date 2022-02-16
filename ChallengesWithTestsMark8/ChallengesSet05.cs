using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber < n)
            {
                return n;
            }

            int next = startNumber + 1;
            return next % n == 0 ? next : GetNextNumberDivisibleByN(next, n);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business b in businesses)
            {
                if(b.TotalRevenue <= 0)
                {
                    b.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] > numbers[i])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if(numbers != null && numbers.Length != 0)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i-1] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                }
            }

            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string result = "";

            if (words == null)
            {
                return result;
            }

            if (words.Length != 0)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    var w = words[i];
                    if (w.Contains(" "))
                    {
                        w = w.Replace(" ", "");
                    }

                    if (i == (words.Length - 1) && result.Length > 0)
                    {
                        result += $"{w}.";
                    }
                    else if (w != "")
                    {
                        result += $"{w} ";
                    }
                }
            }

            return result;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            var results = new double[elements.Count/4];
            
            for (int i = 1; i <= elements.Count; i++)
            {
                if(i >= 4 && i % 4 == 0)
                {
                    results[(i / 4) - 1] = (elements[i - 1]);
                }
            }

            return results;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums != null && nums.Length != 0)
            {
                for(int x = 0; x < nums.Length; x++)
                {
                    for(int y = x + 1; y < nums.Length; y++)
                    {
                        if(nums[x] + nums[y] == targetNumber)
                        {
                            return true;
                        }
                    }

                }
            }

            return false;
        }
    }
}
