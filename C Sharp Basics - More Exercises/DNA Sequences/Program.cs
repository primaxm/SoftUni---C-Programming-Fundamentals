using System;

namespace DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            char firstPosition = 'A';
            char SecondPosition = 'A';
            char tirthPosition = 'A';
            char before = 'X';
            
            for (int a = 1; a <= 4; a++)
            {
                for (int b = 1; b <= 4; b++)
                {
                    for (int c = 1; c <= 4; c++)
                    {
                        if (a == 1) firstPosition = 'A';
                        if (a == 2) firstPosition = 'C';
                        if (a == 3) firstPosition = 'G';
                        if (a == 4) firstPosition = 'T';

                        if (b == 1) SecondPosition = 'A';
                        if (b == 2) SecondPosition = 'C';
                        if (b == 3) SecondPosition = 'G';
                        if (b == 4) SecondPosition = 'T';

                        if (c == 1) tirthPosition = 'A';
                        if (c == 2) tirthPosition = 'C';
                        if (c == 3) tirthPosition = 'G';
                        if (c == 4) tirthPosition = 'T';

                        if (a + b + c >= sum)
                        {
                            before = 'O';
                        }
                        Console.Write($"{before}{firstPosition}{SecondPosition}{tirthPosition}{before}");
                        if (c < 4) Console.Write(" ");
                    }
                    Console.WriteLine("");
                    before = 'X';
                }
            }
            
        }
    }
}
