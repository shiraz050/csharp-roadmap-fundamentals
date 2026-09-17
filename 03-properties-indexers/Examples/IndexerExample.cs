using _03_properties_indexers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_properties_indexers.Examples
{
    public static class IndexerExample
    {
        public static void Run()
        {
            var schedule = new WeekSchedule();
            schedule[0] = "Gym";
            schedule[1] = "Study C#";

            Console.WriteLine($"Day 0: {schedule[0]}");
            Console.WriteLine($"Day 1: {schedule[1]}");
        }
    }
}
