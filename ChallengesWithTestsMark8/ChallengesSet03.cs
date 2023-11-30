using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }

            foreach (bool val in vals)
            {
                if (!val)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 != 0) // Check if the number is odd
                {
                    sum += num;
                }
            }

            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasNumber = false;

            foreach (char character in password)
            {
                if (char.IsUpper(character))
                {
                    hasUpperCase = true;
                }
                else if (char.IsLower(character))
                {
                    hasLowerCase = true;
                }
                else if (char.IsDigit(character))
                {
                    hasNumber = true;
                }
            }

            return hasUpperCase && hasLowerCase && hasNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();

            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper();
                }
            }
        }
    }
}
