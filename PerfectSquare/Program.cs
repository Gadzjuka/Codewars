using System;

namespace PerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareDigits(0));
        }

        public static bool IsTriangle(int a, int b, int c)
        {
            //mplement a method that accepts 3 integer values a, b, c.
            //The method should return true if a triangle can be
            //built with the sides of given length and false in any other case.

            if ((a + b) > c && (a + c) > b && (b + c) > a) return true;
            return false;
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            //Create a function that returns the sum of the
            //two lowest positive numbers given an array of minimum 4 positive
            //integers. No floats or non-positive integers will be passed.
            //For example, when an array is passed like [19, 5, 42, 2, 77],
            //the output should be 7.

            System.Array.Sort(numbers);
            return numbers[0] + numbers[1];            
        }

        public static int SquareDigits(int n)
        {
            //Welcome.In this kata, you are asked to square every digit
            //of a number and concatenate them.
            //For example, if we run 9119 through the function,
            //811181 will come out, because 92 is 81 and 12 is 1.
            double square = 0;
            string answer="";
            if (n == 0) return 0;
            while (n > 0)
            {
                square = Math.Pow(n%10,2);
                n /= 10;
                answer = square.ToString()+answer;
            }
            return Convert.ToInt32(answer);
        }

        public static bool IsSquare(int n) //Perfect square or not?
        {
            if (n < 0)
            {
                return false;
            }
            double buf;
            buf = Math.Sqrt(n);
            if (((int)buf * (int)buf) == n)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
