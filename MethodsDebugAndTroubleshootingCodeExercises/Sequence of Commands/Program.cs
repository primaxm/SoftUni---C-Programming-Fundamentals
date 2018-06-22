using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();

        string command = "";

        while (!command.Equals("stop"))
        {
            string line = Console.ReadLine().Trim();
            int[] args = new int[2];

            string[] stringParams = line.Split(' ');

            command = stringParams[0];
            if (command.Equals("add") ||
                command.Equals("subtract") ||
                command.Equals("multiply"))
            {
                args[0] = int.Parse(stringParams[1]);
                args[1] = int.Parse(stringParams[2]);
                PerformAction(array, command, args);
            }
            else if (command.Equals("rshift") || command.Equals("lshift"))
            {
                PerformAction(array, command, args);
            }
        }
    }

    static void PerformAction(long[] array, string action, int[] args)
    {
        int pos = args[0]-1;
        int value = args[1];
        
        switch (action)
        {
            case "multiply":
                array[pos] *= value;
                break;
            case "add":
                array[pos] += value;
                break;
            case "subtract":
                array[pos] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }
        PrintArray(array);
    }

    private static void ArrayShiftRight(long[] array)
    {
        long tmp = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = tmp;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long tmp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = tmp;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("");
    }
}
