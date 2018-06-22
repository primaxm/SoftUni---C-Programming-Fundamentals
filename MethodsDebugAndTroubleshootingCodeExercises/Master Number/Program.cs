using System;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                bool isDevBySeven = SumOfDigits(num);
                if (isDevBySeven)
                {
                    bool hasEven = ContainsEvenDigit(num);
                    if (hasEven)
                    {
                        bool isPalindrome = IsPalindrome(num);
                        if (isPalindrome)
                        {
                            Console.WriteLine(num);
                        }
                    }
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            bool isPalindrome = true;
            if (num > 9)
            {
                for (int i = 0; i < num.ToString().Length; i++)
                {
                    if (num.ToString().Substring(i, 1) != num.ToString().Substring(num.ToString().Length - 1 - i, 1))
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }

            return isPalindrome;
        }

        static bool SumOfDigits(int num)
        {
            long sum = 0;
            bool isDevBySeven = false;
            //for (int i = 0; i < num.ToString().Length; i++)
            //{
            //    sum += long.Parse(num.ToString().Substring(i, 1));
            //}

            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 7 == 0) isDevBySeven = true;
            return isDevBySeven;
        }

        static bool ContainsEvenDigit(int num)
        {
            bool hasEven = false;

            while (num != 0)
            {
                int curNum = num % 10;
                if (curNum % 2 == 0)
                {
                    hasEven = true;
                    break;
                }
                num /= 10;
            }

            //for (int i = 0; i < num.ToString().Length; i++)
            //{
            //    byte digit = byte.Parse(num.ToString().Substring(i, 1));
            //    if (digit % 2 == 0)
            //    {
            //        hasEven = true;
            //        break;
            //    }
            //}
            return hasEven;
        }
    }
}
