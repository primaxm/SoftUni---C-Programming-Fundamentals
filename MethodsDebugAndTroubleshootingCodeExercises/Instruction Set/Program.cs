using System;

namespace Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i < int.MaxValue; i++)
            {
                string opCode = Console.ReadLine();
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne+1;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne-1;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                }

                if (codeArgs[0] == "END")
                {
                    break;
                }
                Console.WriteLine(result);
            }

        }
    }
}
