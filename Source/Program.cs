using System;
using System.Collections.Generic;
using System.Globalization;

namespace Source
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedList<int, int>();
            list.Add(10, 1);
            list.Add(30, 2);
            list.Add(150, 3);

            while(true)
            {
                var line = Console.ReadLine();
                var input = int.Parse(line);
                var found = list.FirstOrNullStruct(input);
                if(found != null)
                {
                    Console.WriteLine($"Found {found.Value.Value} at {found.Value.Key}");
                }
                else
                {
                    Console.WriteLine("Nothing found");
                }
            }
        }
    }
}