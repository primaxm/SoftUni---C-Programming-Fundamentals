using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string inputCommand = Console.ReadLine();

            while (inputCommand != "course start")
            {
                string[] splitedCommand = inputCommand.Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = splitedCommand[0];

                if (command == "Add")
                {
                    string lessonTitle = splitedCommand[1];
                    //check if exist
                    if (!schedule.Contains(lessonTitle))
                    {
                        //add if not exist
                        schedule.Add(lessonTitle);
                    } 
                }
                else if (command == "Insert")
                {
                    string lessonTitle = splitedCommand[1];
                    int index = int.Parse(splitedCommand[2]);
                    //check if exist
                    if (!schedule.Contains(lessonTitle) && schedule.Count > index && index >= 0)
                    {
                        //add if not exist and idex is valid
                        schedule.Insert(index, lessonTitle);
                    }
                }
                else if (command == "Remove")
                {
                    string lessonTitle = splitedCommand[1];
                    //check if exist
                    if (schedule.Contains(lessonTitle))
                    {
                        string exerciseTitle = lessonTitle + "-Exercise";
                        //check if exist Exercise
                        if (schedule.Contains(exerciseTitle))
                        {
                            //remove if exist Exercise
                            schedule.Remove(exerciseTitle);
                        }
                        //remove if exist
                        schedule.Remove(lessonTitle);
                    }
                }
                else if (command == "Swap")
                {
                    string firstLessonTitle = splitedCommand[1];
                    string secondLessonTitle = splitedCommand[2];

                    //check if both exist
                    if (schedule.Contains(firstLessonTitle) && schedule.Contains(secondLessonTitle))
                    {
                        int firstLessonIndex = schedule.IndexOf(firstLessonTitle);
                        int SecondLessonIndex = schedule.IndexOf(secondLessonTitle);

                        string firstExerciseTitle = firstLessonTitle + "-Exercise";
                        string SecondExerciseTitle = secondLessonTitle + "-Exercise";

                        string tmp = schedule[SecondLessonIndex];
                        schedule[SecondLessonIndex] = schedule[firstLessonIndex];
                        schedule[firstLessonIndex] = tmp;

                        if (schedule.Contains(firstExerciseTitle))
                        {
                            int indexFE = schedule.IndexOf(firstExerciseTitle);
                            schedule.RemoveAt(indexFE);
                            int indexF = schedule.IndexOf(firstLessonTitle);
                            schedule.Insert(indexF+1, firstExerciseTitle);
                        }

                        if (schedule.Contains(SecondExerciseTitle))
                        { 
                            int indexFE = schedule.IndexOf(SecondExerciseTitle);
                            schedule.RemoveAt(indexFE);
                            int indexF = schedule.IndexOf(secondLessonTitle);
                            schedule.Insert(indexF + 1, SecondExerciseTitle);
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    string lessonTitle = splitedCommand[1];
                    string exerciseTitle = lessonTitle + "-Exercise";
                    if (schedule.Contains(lessonTitle))
                    {
                        if (!schedule.Contains(exerciseTitle))
                        {
                            //add exercise
                            int LessnonIndex = schedule.IndexOf(lessonTitle);
                            schedule.Insert(LessnonIndex + 1, exerciseTitle);
                        }
                    }
                    else
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add(exerciseTitle);
                    }
                }

                inputCommand = Console.ReadLine();
            }

                for (int i = 0; i < schedule.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{schedule[i]}");
                }

        }
    }
}
