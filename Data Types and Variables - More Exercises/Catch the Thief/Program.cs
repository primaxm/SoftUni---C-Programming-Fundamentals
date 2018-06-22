using System;

namespace Catch_the_Thief
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

            Console.WriteLine(outputID);
        }
    }
}
