using System;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] Phrases = { "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product."};

            string[] Events = { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                int rndP = rnd.Next(0, 5);
                int rndE = rnd.Next(0, 5);
                int rndA = rnd.Next(0, 5);
                int rndC = rnd.Next(0, 5);
                Console.WriteLine($"{Phrases[rndP]} {Events[rndE]} {Authors[rndA]} – {Cities[rndC]}");
            }
        }
    }
}
