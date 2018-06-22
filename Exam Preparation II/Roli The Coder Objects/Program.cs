using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Roli_The_Coder_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isCorrect = Regex.IsMatch(input, @".+#{1}");
            
            Dictionary<string, Event> events = new Dictionary<string, Event>();

            while (input != "Time for Code")
            {
                if (isCorrect)
                {
                    string[] splitInput = input.Split(new string[] { " ", "#", "@" }, StringSplitOptions.RemoveEmptyEntries);

                    if (events.ContainsKey(splitInput[0]))
                    {
                        if (events.Values.Any(z => z.ParticipinName == splitInput[1]))
                        {
                            int count = 0;
                            for (int i = 2; i < splitInput.Length; i++)
                            {
                                if (!events[splitInput[0]].Participiant.Any(x=>x == splitInput[i]))
                                {
                                    events[splitInput[0]].Participiant.Add(splitInput[i]);
                                    count++;
                                }
                            }
                            events[splitInput[0]].participianCount += count;
                        }  
                    }
                    else
                    {
                        Event even = new Event();
                        even.Id = splitInput[0];
                        even.ParticipinName = splitInput[1];

                        int count = 0;
                        even.Participiant = new List<string>();
                        for (int i = 2; i < splitInput.Length; i++)
                        {
                            even.Participiant.Add(splitInput[i]);
                            count++;
                        }

                        even.participianCount = count;
                        events.Add(splitInput[0], even);
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var eventPair in events.OrderByDescending(x=>x.Value.participianCount).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{eventPair.Value.ParticipinName} - {eventPair.Value.participianCount}");
       
                    foreach (var participians in eventPair.Value.Participiant.OrderBy(z=>z))
                    {
                        Console.WriteLine($"@{participians}");
                    }
            }
        }

    }


    class Event
    {
        public string Id { get; set; }
        public string ParticipinName { get; set; }
        public List<string> Participiant { get; set; }
        public int participianCount { get; set; }
    }


}
