using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;

            foreach(int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;

                }
                else
                {
                    sum -= i;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> list = new List<string>(){ str1, str2, str3, str4 };
            return list.Select(s => s.Length).OrderBy(l => l).ElementAt(0);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int GetSmallest(int x, int y)
            {
                return x < y ? x : y;
            }

            return GetSmallest(number1, GetSmallest(number2, GetSmallest(number3, number4)));

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null || input.Length ==0)
            {
                Console.WriteLine("Yes");
                return false;
            }

            foreach (char c in input)
            {
                if (!Char.IsNumber(c) && !(c == '-') && !(c == '.'))
                {
                    return false;
                }
            }
            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int majority = objs.Count() / 2;
            foreach (object obj in objs)
            {
                if (obj ==null)
                {
                    nullCount++;
                }
                if (nullCount > majority)
                {
                    return true;
                }
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var evens = numbers.Where(x => x % 2 == 0);
            return evens.Count() > 0 ? evens.Average(): 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Just positives, please!");
            }
            //I know there's other ways, but I haven't used recursion in a while
            //and I love it.
            if (number <= 1)
            {
                return 1;
            }
            else
                return number * Factorial(number - 1);
        }
    }
}
