using System;

namespace MethodsDebuggingAndTroubleshootingCode_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            
        }

        static void PrintHeader ()
        {
            PrintTop();
            PrintBody();
            PrintBottom();
        }

        static void PrintTop()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintBottom()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
