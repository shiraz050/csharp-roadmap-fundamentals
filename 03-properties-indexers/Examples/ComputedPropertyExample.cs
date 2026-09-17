using _03_properties_indexers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_properties_indexers.Examples
{
    public static class ComputedPropertyExample
    {
        public static void Run()
        {
            var temp = new Temperature { Celsius = 25 };
            Console.WriteLine($"{temp.Celsius}°C = {temp.Fahrenheit}°F");

            try
            {
                temp.Celsius = -300; // triggers validation in the setter
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Caught expected error: {ex.Message}");
            }
        }
    }
}
