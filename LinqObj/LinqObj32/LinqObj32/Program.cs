﻿
using System.Drawing;

namespace LinqObj29
{
    public class Program
    {
        static void Main(string[] args)
        {
            var human = new List<Human>();
            human.Add(new Human
            {
                Number = 123,
                Surname = "Ivanov",
                Sum = 5132.145
            });
            human.Add(new Human
            {
                Number = 142,
                Surname = "Smirnov",
                Sum = 5132.1
            });
            human.Add(new Human
            {
                Number = 99,
                Surname = "Petrov",
                Sum = 12.001
            });
            human.Add(new Human
            {
                Number = 102,
                Surname = "Popov",
                Sum = 99.001
            });
            human.Add(new Human
            {
                Number = 71,
                Surname = "Pooshkin",
                Sum = 100000.2
            });
            human.Add(new Human
            {
                Number = 63,
                Surname = "Sokolov",
                Sum = 1.000000001
            });
            human.Add(new Human
            {
                Number = 21,
                Surname = "Shabanov",
                Sum = 6234.574
            });
            human.Add(new Human
            {
                Number = 8,
                Surname = "Leb",
            });
            human.Add(new Human
            {
                Number = 2,
                Surname = "Lebedev",
                Sum = 857205.214124108
            });

            var result = human.GroupBy(n => ((n.Number - 1) % (4 * 9)) / 4 + 1)
                .OrderBy(x => x.Key)
                .Select(g => new 
                { 
                    Floor = g.Key, 
                    First = g.Any() ? g.OrderBy(s => s.Sum).First().Sum : 0.00
                });


            foreach (var item in result)
            {
                Console.WriteLine($"Этаж: {item.Floor}, {item.First}");
            }
        }
    }
}
