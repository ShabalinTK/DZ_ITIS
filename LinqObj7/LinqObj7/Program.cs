
using System.Text.RegularExpressions;

namespace LinqObj7
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Number
    {
        public void NumberInfo()
        {
            int K = 1;

            List<Result> results = FindMaxDuration(clients, K);

            if (results.Count > 0)
            {
                results = results.OrderByDescending(r => r.Year).ToList();

                foreach (Result result in results)
                {
                    Console.WriteLine($"{result.Year}, месяц {result.Month}, продолжительность занятий: {result.Duration} часов");
                }
            }
            else
                Console.WriteLine("Нет данных");
        }
    }

    public class Info
    {
        public void InfoPerson()
        {
            var groups = new List<Person>
            {
                new Person() { СlientСode = 1, Year = 2024, MonthNumber = 4, ClassesInHours = 16 },
                new Person() { СlientСode = 2, Year = 2022, MonthNumber = 3, ClassesInHours = 12 },
                new Person() { СlientСode = 3, Year = 2021, MonthNumber = 4, ClassesInHours = 16 },
                new Person() { СlientСode = 4, Year = 2023, MonthNumber = 6, ClassesInHours = 15 },
                new Person() { СlientСode = 5, Year = 2022, MonthNumber = 7, ClassesInHours = 10 },
                new Person() { СlientСode = 6, Year = 2021, MonthNumber = 8, ClassesInHours = 22 },
                new Person() { СlientСode = 7, Year = 2019, MonthNumber = 9, ClassesInHours = 19 },
                new Person() { СlientСode = 8, Year = 2023, MonthNumber = 3, ClassesInHours = 17 },
                new Person() { СlientСode = 9, Year = 2020, MonthNumber = 7, ClassesInHours = 11 },
            };
        }
        
    }
}
