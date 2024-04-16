

using System.Globalization;

namespace LinqObj7
{

    public class Program
    {
        static void Main(string[] args)
        {
            int k = 4;
            var group = new List<Person>();
            group.Add(new Person
            {
                ClientCode = 1,
                Year = 2021,
                Month = 5,
                Hours = 30
            }) ;
            group.Add(new Person
            {
                ClientCode = 1,
                Year = 2023,
                Month = 9,
                Hours = 60
            });
            group.Add(new Person
            {
                ClientCode = 2,
                Year = 2021,
                Month = 5,
                Hours = 30
            });
            group.Add(new Person
            {
                ClientCode = 3,
                Year = 2021,
                Month = 5,
                Hours = 30
            });
            group.Add(new Person
            {
                ClientCode = 3,
                Year = 2022,
                Month = 1,
                Hours = 43
            });
            group.Add(new Person
            {
                ClientCode = 3,
                Year = 2023,
                Month = 7,
                Hours = 20
            });

            var result = group.Where(g => g.ClientCode == k).GroupBy(p => p.ClientCode)
               .Select(g => g.OrderByDescending(p => p.Hours).First());


            if(result.Any())
                foreach(var item in result)
                    Console.WriteLine(item);
            else
                Console.WriteLine("Нет данных");
        }
    }
}