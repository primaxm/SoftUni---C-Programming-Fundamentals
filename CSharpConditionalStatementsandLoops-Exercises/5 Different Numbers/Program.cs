using System;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int countA = 0;

            int cE = 0;
            int cD = 0;
            int cC = 0;
            int cB = 0;

            if (Math.Abs(second - first) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int a = first; a <= second - 4; a++)
                {
                    cB = first + 1 + countA;
                    if (cB > second) cB = second - 3;
                    for (int b = cB; b <= second - 3; b++)
                    {
                        cC = first + 2 + countA;
                        if (cC > second) cC = second -2;
                        for (int c = cC; c <= second - 2; c++)
                        {
                            cD = first + 3 + countA;
                            if (cD > second) cD = second - 1;
                            for (int d = cD; d <= second - 1; d++)
                            {
                                cE = first + 4 + countA;
                                if (cE > second) cE = second;
                                for (int e = cE; e <= second; e++)
                                {
                                    if (d >= e || c >= d || c >= e || b >= c || b >= d || b >= e || a >= b || a >= c || a >= d|| a >= e)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        Console.Write(a + " ");
                                        Console.Write(b + " ");
                                        Console.Write(c + " ");
                                        Console.Write(d + " ");
                                        Console.WriteLine(e);
                                    }

                                }
                                
                            }
                          
                        }

                    }
                    countA++;
                }

            }
         
        }
    }
}
