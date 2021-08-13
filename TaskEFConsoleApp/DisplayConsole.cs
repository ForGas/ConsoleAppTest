using System;
using System.Linq;
using System.Collections.Generic;
using TaskEFConsoleApp.Interfaces;
using TaskEFConsoleApp.Data.Model.Base;

namespace TaskEFConsoleApp
{
    public class DisplayConsole : IDisplay
    {
        public void Print<T>(ICollection<T> models) where T : IEntity
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\t\t\t Table");
            Console.ForegroundColor = ConsoleColor.Blue;

            var properties = models.AsQueryable().ElementType.GetProperties().ToList();
            var entities = models.ToList();

            entities.ForEach(entry =>
            {
                properties.ForEach(property =>
                {
                    Console.Write($"{property.Name} - ");
                    Console.WriteLine($"{entry.GetType().GetProperty(property.Name).GetValue(entry, null)}    ");
                });

                Console.WriteLine();
            });
        }
    }
}
