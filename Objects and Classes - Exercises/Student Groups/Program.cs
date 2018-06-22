using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var listOfTowns = new List<Town>();
            List<Group> groups = new List<Group>();
            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    string[] inp = input.Split(new char[] {'=', '>'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string[] opt = inp[1].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                    Town town = new Town();
                    town.Name = inp[0].Trim();
                    town.SeatsCount = int.Parse(opt[0].Trim());
                    town.Students = new List<Student>();
                    listOfTowns.Add(town);
                }
                else
                {
                    string[] inp = input.Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    inp[2] = inp[2].Trim();
                    if (inp[2].Length != 11) inp[2] = inp[2].Insert(0, "1");

                    Student student = new Student();
                    student.Name = inp[0].Trim();
                    student.Email = inp[1].Trim();
                    student.RegDate = DateTime.ParseExact(inp[2].Trim(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                    listOfTowns[listOfTowns.Count - 1].Students.Add(student);
                }

                input = Console.ReadLine();
            }

            foreach (var town in listOfTowns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town.Students.OrderBy(d => d.RegDate).ThenBy(x => x.Name).ThenBy(x => x.Email);
                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {listOfTowns.Distinct().Count()} towns:");
            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                List<string> eml = new List<string>();
                foreach (var item in group.Students)
                {
                    eml.Add(item.Email);
                }
                string email = string.Join(", ", eml);

                Console.WriteLine($"{group.Town.Name} => {email}");
            }
        }


    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
