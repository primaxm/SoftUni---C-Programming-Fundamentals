using System;
using System.Linq;
using System.Numerics;

namespace Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(input[0]);
            BigInteger number = new BigInteger();
            number = BigInteger.Parse(input[1]);
            BigInteger rest = 0;
            string result = string.Empty;

            while(number > 0)
            {
                rest = number % n;
                number /= n;
                result = rest.ToString() + result;
            }

            Console.WriteLine(result);
        }
    }
}
