using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //string input = "foo=poo%20&value=valley&dog=wow+&url=https://softuni.bg/trainings/coursesinstances/details/1070?trainer=nakov&course=oop&course=php";
            //string input = "foo=ivan&foo=pepi";

            while (input != "END")
            {
                string[] splitedDD = input.Split('?', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int index = 0;
                if (splitedDD.Length > 1) index = 1;

                string[] splitedInput = splitedDD[index].Split('&', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < splitedInput.Length; i++)
                {
                    splitedInput[i] = splitedInput[i].Replace("%20", " ");
                    splitedInput[i] = splitedInput[i].Replace("+", " ");
                    splitedInput[i] = Regex.Replace(splitedInput[i], @"\s+", " ");
                }

                Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
                foreach (var item in splitedInput)
                {
                    List<string> values = item.Split('=').ToList();
                    if (output.ContainsKey(values[0]))
                    {
                        output[values[0]].Add(values[1].Trim());
                    }
                    else
                    {
                        List<string> tmp = new List<string> { values[1].Trim() };
                        output.Add(values[0], tmp);
                    }
                }

                foreach (var outputPair in output)
                {
                    Console.Write($"{outputPair.Key.Trim()}=[{string.Join(", ", outputPair.Value)}]");
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }


            /*
            while (input != "END")
            {
                List<string> pairs = input.Split('&', StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < pairs.Count; i++)
                {
                    if (pairs[i].Contains('?'))
                    {

                        List<string> splited = pairs[i].Split('?', StringSplitOptions.RemoveEmptyEntries).ToList();
                        pairs.RemoveAt(i);
                        for (int a = 0; a < splited.Count; a++)
                        {
                            if (splited[a].Contains('='))
                            {
                                pairs.Add(splited[a]);
                            }   
                        }

                    }
                }


                for (int i = 0; i < pairs.Count; i++)
                {
                    pairs[i] = pairs[i].Replace("%20", " ");
                    pairs[i] = pairs[i].Replace("+", " ");
                    pairs[i] = Regex.Replace(pairs[i], @"\s+", " ");
                }

                Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();
                foreach (var item in pairs)
                {
                    List<string> values = item.Split('=').ToList();
                    if (output.ContainsKey(values[0]))
                    {
                        output[values[0]].Add(values[1].Trim());
                    }
                    else
                    {
                        List<string> tmp = new List<string> { values[1].Trim() };
                        output.Add(values[0], tmp);
                    }
                }

                foreach (var outputPair in output)
                {
                    Console.Write($"{outputPair.Key}=[{string.Join(", ", outputPair.Value)}]");
                }

                Console.WriteLine();
                input = Console.ReadLine();
            }*/

        }
    }
}
