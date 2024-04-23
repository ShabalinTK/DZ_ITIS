using System.Security.Cryptography.X509Certificates;

namespace LinqObj95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consumer = new List<A>
            {
                new A { BirthYear = 1990, ConsumerCode = 101, Street = "Main St" },
                new A { BirthYear = 1985, ConsumerCode = 102, Street = "Elm St" },
                new A { BirthYear = 1995, ConsumerCode = 103, Street = "Oak St" },
                new A { BirthYear = 1980, ConsumerCode = 104, Street = "Maple St" },
                new A { BirthYear = 1992, ConsumerCode = 105, Street = "Pine St" }
            };

            var storeDiscount = new List<C>
            {
                new C { ConsumerCode = 101, StoreName = "Store1", DiscountPercentage = 10 },
                new C { ConsumerCode = 102, StoreName = "Store2", DiscountPercentage = 15 },
                new C { ConsumerCode = 103, StoreName = "Store1", DiscountPercentage = 20 },
                new C { ConsumerCode = 104, StoreName = "Store1", DiscountPercentage = 10 },
                new C { ConsumerCode = 105, StoreName = "Store2", DiscountPercentage = 5 }
            };

            var product = new List<D>
            {
                new D { Price = 100, StoreName = "Store1", ProductCode = "A123-4567" },
                new D { Price = 200, StoreName = "Store2", ProductCode = "B234-5678" },
                new D { Price = 300, StoreName = "Store1", ProductCode = "A123-4567" },
                new D { Price = 400, StoreName = "Store1", ProductCode = "C345-6789" },
                new D { Price = 500, StoreName = "Store2", ProductCode = "B234-5678" }
            };

            var purchase = new List<E>
            {
                new E { ConsumerCode = 101, StoreName = "Store1", ProductCode = "A123-4567" },
                new E { ConsumerCode = 102, StoreName = "Store2", ProductCode = "B234-5678" },
                new E { ConsumerCode = 103, StoreName = "Store1", ProductCode = "A123-4567" },
                new E { ConsumerCode = 104, StoreName = "Store1", ProductCode = "C345-6789" },
                new E { ConsumerCode = 105, StoreName = "Store2", ProductCode = "B234-5678" }
            };

            var result = purchase.Join(storeDiscount, t => new { ConsumerCode = t.ConsumerCode, StoreName = t.StoreName}, r => new { ConsumerCode = r.ConsumerCode, StoreName = r.StoreName}, (t, r) => new 
            {
                ConsumerCode = t.ConsumerCode
            });
            Console.WriteLine();
        }
    }
}
