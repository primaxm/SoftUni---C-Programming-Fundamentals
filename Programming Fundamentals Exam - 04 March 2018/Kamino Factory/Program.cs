using System;
using System.Collections.Generic;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<List<int>> dna = new List<List<int>>();

            while (input != "Clone them!")
            {
                List<int> splitedDna = input.Split(new char[] { '!' }, StringSplitOptions.None).Select(int.Parse).ToList();
                List<int> tmp = new List<int>();

                dna.Add(splitedDna);
                input = Console.ReadLine();
            }

            
            int startIndex = 0;
            int sequenceLenght = 0;
            int bestSample = 0;

            for (int i = 0; i < dna.Count; i++)
            {
                int tmpStartIndex = 0;
                int tmpSequenceLenght = 0;
                int rowStartIndex = 0;
                int rowSequencemaxLenght = 0;
                for (int count = 0; count < dna[i].Count; count++)
                {
                    if (dna[i][count] == 1)
                    {
                        if (tmpStartIndex == 0) tmpStartIndex = count;
                        tmpSequenceLenght++;
                        if (tmpSequenceLenght > rowSequencemaxLenght)
                        {
                            rowStartIndex = tmpStartIndex;
                            rowSequencemaxLenght = tmpSequenceLenght;
                        }
                    }
                    else
                    {
                        tmpStartIndex = 0;
                        tmpSequenceLenght = 0;
                    }

                }


                if (rowSequencemaxLenght > sequenceLenght)
                {
                    bestSample = i;
                    startIndex = rowStartIndex;
                    sequenceLenght = rowSequencemaxLenght;
                }
                else if (rowSequencemaxLenght == sequenceLenght)
                {
                    if (rowStartIndex < startIndex)
                    {
                        bestSample = i;
                        startIndex = rowStartIndex;
                        sequenceLenght = rowSequencemaxLenght;
                    }
                    else if (rowStartIndex == startIndex)
                    {
                        if (dna[i].Sum(x => x) > dna[bestSample].Sum(x => x))
                        {
                            bestSample = i;
                        }
                    }
                }
                rowStartIndex = 0;
                rowSequencemaxLenght = 0;
                tmpStartIndex = 0;
                tmpSequenceLenght = 0;

            }

            

            int sumBestDna = dna[bestSample].Sum(x => x);
            Console.WriteLine($"Best DNA sample {bestSample+1} with sum: {sumBestDna}.");
            Console.WriteLine(string.Join(" ", dna[bestSample]));
        }

        
    }
}
