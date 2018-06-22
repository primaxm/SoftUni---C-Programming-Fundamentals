using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentData = new Dictionary<string, Student>();

            string input = Console.ReadLine();
            while (input != "end of dates")
            {
                string[] inputDates = input.Split(' ').ToArray();
                List<string> d = inputDates[1].Split(',').ToList();

                if (studentData.ContainsKey(inputDates[0]))
                {
                    for (int i = 0; i < d.Count; i++)
                    {
                        studentData[inputDates[0]].Dates
                            .Add(DateTime.ParseExact(d[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }

                }
                else
                {
                    
                    List<DateTime> tmp = new List<DateTime>();
                    for (int i = 0; i < d.Count; i++)
                    {
                        tmp.Add(DateTime.ParseExact(d[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        //student.Dates.Add(DateTime.ParseExact(d[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                    Student student = new Student(tmp, new List<string>());
                    studentData.Add(inputDates[0], student);
                }

                input = Console.ReadLine();
            }

            string inputC = Console.ReadLine();

            while (inputC != "end of comments")
            {
                string[] inputComments = inputC.Split('-').ToArray();
                if (studentData.ContainsKey(inputComments[0]))
                {
                    studentData[inputComments[0]].Comments.Add(inputComments[1]);
                }

                inputC = Console.ReadLine();
            }

            foreach (var data in studentData.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{data.Key}");
                Console.WriteLine("Comments:");
                foreach (var comm in data.Value.Comments)
                {
                    Console.WriteLine($"- {comm}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var item in data.Value.Dates.OrderBy(x => x.Date))
                {
                    Console.WriteLine($"-- {item:dd/MM/yyyy}");
                }
            }
        }
    }

    class Student
    {
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }

        public Student(List<DateTime> dates, List<string> com)
        {
            Dates = dates;
            Comments = com;
        }

    }
}
