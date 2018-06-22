using System;

namespace Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());

            long outputID = long.MinValue;


            for (int i = 0; i < n; i++)
            {
                long ids = long.Parse(Console.ReadLine());

                if (numeralType == "sbyte")
                {
                    if (ids >= sbyte.MinValue && ids <= sbyte.MaxValue)
                    {
                        if (ids > outputID)
                        {
                            outputID = ids;
                        }
                    }
                }
                else if (numeralType == "int")
                {
                    if (ids >= int.MinValue && ids <= int.MaxValue)
                    {
                        if (ids > outputID)
                        {
                            outputID = ids;
                        }
                    }
                }
                else if (numeralType == "long")
                {
                    if (ids >= long.MinValue && ids <= long.MaxValue)
                    {
                        if (ids > outputID)
                        {
                            outputID = ids;
                        }
                    }
                }

            }
 
            int dev = 127;
            if (outputID < 0) dev = -128;
            double output = (double)outputID / dev;

            if (Math.Ceiling(output) == 1)
            {
                Console.WriteLine($"Prisoner with id {outputID} is sentenced to {Math.Ceiling(output)} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {outputID} is sentenced to {Math.Ceiling(output)} years");
            }
                
            
        }
    }
}
