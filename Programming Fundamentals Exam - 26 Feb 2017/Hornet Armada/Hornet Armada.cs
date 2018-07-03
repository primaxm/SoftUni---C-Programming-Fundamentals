using System;
using System.Collections.Generic;
using System.Linq;

namespace Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Legion> legions = new Dictionary<string, Legion>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int lastActivity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                int soldierCount = int.Parse(input[3]);


                if (legions.ContainsKey(legionName))
                {
                    //update
                    //IN BOTH cases, stated above, you should update the last activity, with the newly entered one, 
                    //ONLY if the entered one is GREATER than the previous one.
                    if (legions[legionName].LastActivity < lastActivity)
                    {
                        legions[legionName].LastActivity = lastActivity;
                    }
                    //If a given legion already exists, you must add the new soldier type, with its count. 
                    //If the soldier type exists ALSO, you should just add the soldier count. 
                    if (legions[legionName].Soldiers.ContainsKey(soldierType))
                    {
                        legions[legionName].Soldiers[soldierType] += soldierCount;
                    }
                    else
                    {
                        legions[legionName].Soldiers.Add(soldierType, soldierCount);
                    }
                }
                else
                {
                    //add
                    Legion legion = new Legion();
                    legion.LegionName = legionName;
                    legion.LastActivity = lastActivity;
                    Dictionary<string, long> tmp = new Dictionary<string, long>();
                    tmp.Add(soldierType, soldierCount);
                    legion.Soldiers = tmp;
                    legions.Add(legionName, legion);
                }
            }

            string[] command = Console.ReadLine().Split('\\').ToArray();
            if (command.Length == 1)
            {
                //{lastActivity} : {legionName}
                //you must print all legions which have the given soldier type, with last activity, and legion name.
                //The legions must be printed in descending order of their activity.
                var leg = legions.Where(x => x.Value.Soldiers.Keys.Contains(command[0])).OrderByDescending(x => x.Value.LastActivity);

                if (leg.Count() != 0)
                {
                    foreach (var legionsPair in leg)
                    {
                        Console.WriteLine($"{legionsPair.Value.LastActivity} : {legionsPair.Key}");
                    }
                }

            }
            else
            {
                //input  - {activity}\{soldierType}
                //{legionName} -> {soldierCount}
                //In the first case, you must print all legions, and the count of soldiers they have from the given soldier type, 
                //who’s last activity is LOWER than the given activity. The legions must be printed in descending order by soldier count.

                var leg = legions.Where(x => x.Value.LastActivity < int.Parse(command[0]) && x.Value.Soldiers.ContainsKey(command[1]))
                    .OrderByDescending(x => x.Value.Soldiers[command[1]]);

                if (leg.Count() != 0)
                {
                    foreach (var item in leg)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value.Soldiers[command[1]]}");
                    }
                }
            }
        }
    }

    class Legion
    {
        public string LegionName { get; set; }
        public int LastActivity { get; set; }
        public Dictionary<string, long> Soldiers { get; set; }
    }
}
