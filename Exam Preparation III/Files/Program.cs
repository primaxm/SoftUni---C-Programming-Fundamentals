using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<File>> fileData = new Dictionary<string, List<File>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputData = input.Split(new string[] { "\\", ".", ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string fileRoot = inputData[0];
                string fileSize = inputData[inputData.Length - 1];
                string FileExtension = inputData[inputData.Length - 2];
                string fileName = inputData[inputData.Length-3];

                File file = new File();

                file.Root = fileRoot;
                file.FileName = fileName;
                file.FileExtension = FileExtension;
                file.FileSize = long.Parse(fileSize);

                if (fileData.ContainsKey(fileRoot))
                {
                    if (fileData[fileRoot].Any(x=>x.FileName == fileName && x.FileExtension == FileExtension))
                    {
                        var classes = fileData[fileRoot].Where(x => x.FileName == fileName && x.FileExtension == FileExtension);
                        foreach (var item in classes)
                        {
                            item.FileSize = long.Parse(fileSize);
                        }
                    }
                    else
                    {
                        fileData[fileRoot].Add(file);
                    }
                   
                    
                }
                else
                {
                    List<File> tmp = new List<File>();
                    tmp.Add(file);
                    fileData.Add(fileRoot, tmp);
                }
            }
            string[] printCondituions = Console.ReadLine().Split(new string[] { " ", "in" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            


            if (!fileData.ContainsKey(printCondituions[1]))
            {
                Console.WriteLine("No");
            }
            else
            {
                var print = fileData[printCondituions[1]].Where(x => x.FileExtension == printCondituions[0])
    .OrderByDescending(x => x.FileSize).ThenBy(x => x.FileName);
                if (print.Count() == 0)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    foreach (var item in print)
                    {
                        Console.WriteLine($"{item.FileName}.{item.FileExtension} - {item.FileSize} KB");
                    }
                }

            }

        }
    }

    class File
    {
        public string Root { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public long FileSize { get; set; }
    }
}
