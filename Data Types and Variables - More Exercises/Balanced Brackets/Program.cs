using System;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 0;
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                if (word == "(")
                {
                    left++;
                }
                else if (word == ")")
                {
                    if (right < left || (left == 0 && right == 0)) right++;    
                }
            }

            if (left == right && left != 0 && right != 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED"); 
            }
            
        }
    }
}
