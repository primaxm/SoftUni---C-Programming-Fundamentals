using System;

namespace Programming_Fundamentals_25._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double headsetPriceint = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int count = 1; count <= n; count++)
            {
                if (count % 2 == 0) headsetCount++;
                if (count % 3 == 0) mouseCount++;
                if (count % 2 == 0 && count % 3 == 0)
                {
                    keyboardCount++;
                    if (keyboardCount % 2 == 0 && keyboardCount > 0) displayCount++;
                }
                    
            }

           /* Console.WriteLine(headsetCount);
            Console.WriteLine(mouseCount);
            Console.WriteLine(keyboardCount);
            Console.WriteLine(displayCount);*/

            double sum = headsetCount * headsetPriceint + mouseCount * mousePrice + keyboardCount * keyboardPrice + displayCount * displayPrice;
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
