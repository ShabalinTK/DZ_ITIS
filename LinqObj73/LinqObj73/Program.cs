using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace LinqObj73
{
    public class Program
    {
        static void Main(string[] args)
        {
            var human = new List<A>
            {
                new A { YearOfBirth = 1990, ConsumerCode = 1, Street = "Street1" },
                new A { YearOfBirth = 1985, ConsumerCode = 2, Street = "Street2" },
                new A { YearOfBirth = 1995, ConsumerCode = 3, Street = "Street1" },
                new A { YearOfBirth = 1980, ConsumerCode = 4, Street = "Street3" },
                new A { YearOfBirth = 1992, ConsumerCode = 5, Street = "Street2" }
            };

            var magaz = new List<C>
            {
                new C { ConsumerCode = 1, StoreName = "Abibas", Discount = 10 },
                new C { ConsumerCode = 2, StoreName = "Rita", Discount = 15 },
                new C { ConsumerCode = 3, StoreName = "Abibas", Discount = 20 },
                new C { ConsumerCode = 4, StoreName = "Abibas", Discount = 10 },
                new C { ConsumerCode = 5, StoreName = "Rita", Discount = 5 }
            };

            var result = human.Join(magaz, p => p.ConsumerCode, d => d.ConsumerCode, (p, d) => new { p, d })
              .OrderBy(x => x.d.StoreName)
              .ThenBy(x => x.p.Street) 
              .GroupBy(x => new 
              { 
                  x.d.StoreName, 
                  x.p.Street 
              })
              .Select(g => new
              {
                  g.Key.StoreName,
                  g.Key.Street,
                  Count = g.Count()
              });

            foreach (var item in result)
            {
                Console.WriteLine($"Магазин: {item.StoreName}, Улица: {item.Street}, Покупатели: {item.Count}");
            }
        }
    }
}
