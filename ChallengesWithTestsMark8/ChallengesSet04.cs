using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                   
                    result += num;
                }
                else
                {
                    
                    result -= num;
                }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = int.MaxValue;

            if (str1 != null && str1.Length < shortestLength)
            {
                shortestLength = str1.Length;
            }

            if (str2 != null && str2.Length < shortestLength)
            {
                shortestLength = str2.Length;
            }

            if (str3 != null && str3.Length < shortestLength)
            {
                shortestLength = str3.Length;
            }

            if (str4 != null && str4.Length < shortestLength)
            {
                shortestLength = str4.Length;
            }

            return shortestLength == int.MaxValue ? 0 : shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = int.MaxValue;

            if (number1 < smallestNumber)
            {
                smallestNumber = number1;
            }

            if (number2 < smallestNumber)
            {
                smallestNumber = number2;
            }

            if (number3 < smallestNumber)
            {
                smallestNumber = number3;
            }

            if (number4 < smallestNumber)
            {
                smallestNumber = number4;
            }

            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }

          
            return (sideLength1 + sideLength2 > sideLength3) &&
                   (sideLength1 + sideLength3 > sideLength2) &&
                   (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false; // Return false for null string
            }

            double result;
            return double.TryParse(input, out result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (objs == null || objs.Length == 0)
            {
                return false; // Return false for null or empty array
            }

            int nullCount = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
            }

            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0; // Return 0 for null or empty array
            }

            int sum = 0;
            int count = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            return count > 0 ? (double)sum / count : 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                // Handle negative input if needed
                return -1;
            }

            if (number == 0 || number == 1)
            {
                return 1; // Factorial of 0 and 1 is 1
            }

            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
