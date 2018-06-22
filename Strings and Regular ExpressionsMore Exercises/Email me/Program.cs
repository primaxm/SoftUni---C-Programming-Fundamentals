using System;
using System.Linq;

namespace Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string[] parts = email.Split("@").ToArray();

            int leftSum = parts[0].Select(x => (int)x).Sum();
            int rightSum = parts[1].Select(x => (int)x).Sum();
            int sum = leftSum - rightSum;
            if (sum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
