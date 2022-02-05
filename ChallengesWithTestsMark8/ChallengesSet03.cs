using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0)
            {
                return false;
            }
            else
            {
                foreach (bool v in vals)
                {
                    if (!v)
                    {
                        return true;
                    }
                }
                return false;

            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }

            int accum = 0;
            foreach(int n in numbers)
            {
                if (n % 2 != 0)
                {
                    accum += n;
                }
            }
            return accum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUp = false;
            bool hasLow = false;
            bool hasNum = false;
            foreach(char c in password)
            {
                hasUp = hasUp || Char.IsUpper(c);
                hasLow = hasLow || Char.IsLower(c);
                hasNum = hasNum ||Char.IsNumber(c);
            }
            return hasUp && hasLow && hasNum;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (dividend == 0 || divisor == 0)? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return (nums == null || nums.Length ==0)? 0 : nums[nums.Length-1]-nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] oddsToOneHundList = new int[50];
            for (int i = 0; i < 50; i++)
            {
                oddsToOneHundList[i] = (i * 2) + 1;
            }
            return oddsToOneHundList;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
