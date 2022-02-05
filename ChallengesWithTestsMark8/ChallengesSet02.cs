using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            char[] lowerCase = {'a','b','c','d','e','f','g','h','i','j','k','l',
                'm','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] upperCase = {'A','B','C','D','E','F','G','H','I','J','K','L',
                'M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

            foreach (char l in lowerCase)
            {
                if (l == c)
                {
                    return true;
                }
            }

            foreach (char u in upperCase)
            {
                if (u == c)
                {
                    return true;
                }
            }

            return false;
        }


        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return !IsNumberEven(num);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double min = double.PositiveInfinity;
            double max = double.NegativeInfinity;

            foreach(double d in numbers)
            {
                if (d < min)
                {
                    min = d;
                }

                if (d > max)
                {
                    max = d;
                }
            }

            return (double.IsFinite(min) && double.IsFinite(max)) ? min + max : 0;
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length)? str1.Length: str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int counter = 0;
            foreach(int i in numbers)
            {
                counter += i;
            }
            return counter;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int counter = 0;
            foreach (int i in numbers)
            {
                if (IsNumberEven(i))
                {
                    counter += i;
                }
            }
            return counter;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }
            int counter = 0;
            foreach (int i in numbers)
            {
                counter += i;
            }
            return IsNumberOdd(counter);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }
            return (number % 2 == 0)? number / 2 : (number - 1) / 2;
        }
    }
}
