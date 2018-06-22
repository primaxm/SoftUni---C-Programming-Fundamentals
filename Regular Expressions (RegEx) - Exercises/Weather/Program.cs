using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<string, State> statest = new Dictionary<string, State>();

            while (text != "end")
            {
                string pattern = @"([A-Z]{2})(\d+.\d+)([a-zA-Z]+)(?=\|)";
                var result = Regex.Match(text, pattern);

                if (result.ToString() != "")
                {
                    State state = new State();
                    state.Name = result.Groups[1].ToString();
                    state.Temperature = double.Parse(result.Groups[2].ToString());
                    state.Weather = result.Groups[3].ToString();
                    if (statest.ContainsKey(result.Groups[1].ToString()))
                    {
                        statest[result.Groups[1].ToString()] = state;
                    }
                    else
                    {
                        statest.Add(result.Groups[1].ToString(), state);
                    }
                    
                }

                text = Console.ReadLine();
            }

            foreach (var state in statest.OrderBy(x => x.Value.Temperature))
            {
                Console.WriteLine($"{state.Value.Name} => {state.Value.Temperature:f2} => {state.Value.Weather}");
            }
            //[A-Z](?<state>{2})(?<temperature>\d+.\d)+(?<weather>[a-zA-Z])+(?=\|)
            
        }

        class State
        {
            public string Name { get; set; }
            public double Temperature { get; set; }
            public string Weather { get; set; }
        }
    }
}
