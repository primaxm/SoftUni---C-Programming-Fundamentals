using System;
using System.Linq;

public class SequenceOfCommands_broken
{
	private const char ArgumentsDelimiter = ' ';

	public static void Main()
	{
		int sizeOfArray = int.Parse(Console.ReadLine());

		long[] array = Console.ReadLine()
			.Split(" ", StringSplitOptions.RemoveEmptyEntries)
			.Select(long.Parse)
			.ToArray();

		string command = "";

		while (!command.Equals("stop"))
		{
			string line = Console.ReadLine().Trim();
			int[] args = new int[2];

            string[] stringParams = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            args[0] = int.Parse(stringParams[0]);
            args[1] = int.Parse(stringParams[1]);
            Console.WriteLine(stringParams[0]);
            // string command = stringParams[0];

            if (command.Equals("add") ||
            	command.Equals("substract") ||
            	command.Equals("multiply"))
            {


            		PerformAction(array, command, args);
            }

            //	PerformAction(array, command, args);

            //	PrintArray(array);
            //	Console.WriteLine('\n');
            Console.WriteLine("muuuuuuuuuuuuuuuu");
		}
	}

	static void PerformAction(long[] arr, string action, int[] args)
	{
		long[] array = arr.Clone() as long[];
		int pos = args[0];
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
	}

	private static void ArrayShiftRight(long[] array)
	{
		for (int i = array.Length - 1; i >= 1; i--)
		{
			array[i] = array[i - 1];
		}
	}

	private static void ArrayShiftLeft(long[] array)
	{
		for (int i = 0; i < array.Length - 1; i++)
		{
			array[i] = array[i + 1];
		}
	}

	private static void PrintArray(long[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine(array[i] + " ");
		}
	}
}
