using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            bool isLoop = false;
            while (arr.Length > 1)
            {
                int[] newArr = new int[arr.Length - 1];
                for (int i = 0; i < newArr.Length; i++)
                {
                    newArr[i] = arr[i] + arr[i + 1];
                }
                arr = newArr;
                if(arr.Length == 1) Console.WriteLine(string.Join(" ", arr));
                isLoop = true;
            }  
            if(!isLoop) Console.WriteLine(string.Join(" ", arr));
        }
    }
}
