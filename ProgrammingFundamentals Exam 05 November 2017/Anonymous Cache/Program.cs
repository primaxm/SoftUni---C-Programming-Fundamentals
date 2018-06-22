using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpt = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> kache = new Dictionary<string, Dictionary<string, long>>();

            while(inpt != "thetinggoesskrra")
            {
                string[] input = inpt.Split(new string[] { "->", "|" }, StringSplitOptions.RemoveEmptyEntries);

                
                if (input.Length == 1)
                {
                    Dictionary<string, long> tmp = new Dictionary<string, long>();
                    string dataSet = input[0].Trim();
                    //adding dataSet
                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, tmp);

                        //check kache
                        if (kache.ContainsKey(dataSet))
                        {
                            tmp = kache[dataSet];
                            data[dataSet] = tmp;
                        }
                    }
                }
                else
                {
                    string dataKey = input[0].Trim();
                    long dataSize = long.Parse(input[1].Trim());
                    string dataSet = input[2].Trim();

                    Dictionary<string, long> tmp = new Dictionary<string, long>();
                    tmp.Add(dataKey, dataSize);
                    if (!data.ContainsKey(dataSet))
                    {
                        if (kache.ContainsKey(dataSet))
                        {
                            if (kache[dataSet].ContainsKey(dataKey))
                            {
                                kache[dataSet][dataKey] = dataSize;
                            }
                            else
                            {
                                kache[dataSet].Add(dataKey, dataSize);
                            }
                             
                        }
                        else
                        {
                            kache.Add(dataSet, tmp);
                        }
                        
                    }
                    else
                    {
                        if (data[dataSet].ContainsKey(dataKey))
                        {
                            data[dataSet][dataKey] = dataSize;
                        }
                        else
                        {
                            data[dataSet].Add(dataKey, dataSize);
                        }
                    }

                }

                inpt = Console.ReadLine();
            }

            if (data.Count > 0)
            {
                foreach (var dataKeyValue in data.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    Console.WriteLine($"Data Set: {dataKeyValue.Key}, Total Size: {dataKeyValue.Value.Values.Sum()}");
                    foreach (var item in dataKeyValue.Value)
                    {
                        Console.WriteLine($"$.{item.Key}");
                    }
                    break;
                }
            }
        }
    }
}
