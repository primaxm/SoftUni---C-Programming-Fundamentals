using System;
using System.Linq;

namespace Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int count1 = s1.Length;
            int count2 = s2.Length;

            if (count1 < count2)
            {
                s1 = s1.PadLeft(count2,'0');
            }
            else if (count1 > count2)
            {
                s2 = s2.PadLeft(count1, '0');
            }

            string resultt = string.Empty;
            int ten = 0;
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                int num = 0;
                {
                    num = s1[i] - 48 + s2[i] - 48 + ten;
                    
                    if (num >= 10 && i > 0)
                    {
                        num -= 10;
                        ten = 1;
                    }
                    else
                    {
                        ten = 0;
                    }
                }
                
                resultt = num + resultt;

            }

            Console.WriteLine(resultt.TrimStart('0'));
        }
    }
}
