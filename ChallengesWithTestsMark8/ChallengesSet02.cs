using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
           if (number % 2 == 0)
                return true;
           else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            else
                return false;

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            var minNumber = numbers.Min(); //finds the lowest number in the list
            var maxNumber = numbers.Max(); //finds the highest number in the list

            return minNumber + maxNumber;    

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var length1 = str1.Length; // finds the length of string 
            var length2 = str2.Length;
           
            return Math.Min(length1, length2); // Math.Min(var 1, var 2) finds the minimum value
        }

        public int Sum(int[] numbers)
        {
           return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            return numbers.Where(num => num % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            
                var sum = numbers.Sum();
            if (sum % 2 != 0)
                return true;

            else
                return false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)//if the input (NUMBER) is not positive
            {
                return 0; //there are no odd numbers below it
            }

            long count = 0;

                for (long i = 1; i < number; i += 2 ) // makes LONG (i) = 1 
                {
                    count++; // then adds increments by 2 (keeps it an odd number)
            }
            return count;
        }
    }
}
