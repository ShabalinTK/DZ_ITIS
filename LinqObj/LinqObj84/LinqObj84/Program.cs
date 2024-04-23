namespace LinqObj84
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var C = new List<C>
            {
                new C { Discount = 10, StoreName = "Store1", ConsumerCode = 1 },
                new C { Discount = 15, StoreName = "Store2", ConsumerCode = 2 },
                new C { Discount = 20, StoreName = "Store1", ConsumerCode = 3 },
                new C { Discount = 10, StoreName = "Store3", ConsumerCode = 4 },
                new C { Discount = 5, StoreName = "Store2", ConsumerCode = 5 }
            };
            var D = new List<D>
            {
                new D { ProductCode = "P001-1234", StoreName = "Store1", Price = 100 },
                new D { ProductCode = "P002-5678", StoreName = "Store2", Price = 200 },
                new D { ProductCode = "P001-1234", StoreName = "Store3", Price = 150 },
                new D { ProductCode = "P002-5678", StoreName = "Store1", Price = 250 },
                new D { ProductCode = "P003-9876", StoreName = "Store2", Price = 300 }
            };
            var E = new List<E>
            {
                new E { ProductCode = "P001-1234", StoreName = "Store1", ConsumerCode = 1 },
                new E { ProductCode = "P002-5678", StoreName = "Store2", ConsumerCode = 2 },
                new E { ProductCode = "P001-1234", StoreName = "Store3", ConsumerCode = 3 },
                new E { ProductCode = "P002-5678", StoreName = "Store1", ConsumerCode = 4 },
                new E { ProductCode = "P003-9876", StoreName = "Store2", ConsumerCode = 5 }
            };

            var result = D.Join(E, d => new { d.ProductCode, d.StoreName }, e => new { e.ProductCode, e.StoreName }, (d, e) => new { d, e })
                .Join(C, de => de.e.ConsumerCode, c => c.ConsumerCode, (de, c) => new { de.d, c })
                .GroupBy(x => new { x.d.StoreName, x.d.ProductCode })
                .Select(g => new
                {
                    Store = g.Key.StoreName,
                    Product = g.Key.ProductCode,
                    TotalDiscount = g.Count(),
                    PriceDiscount = g.Sum(x => x.d.Price * (100 - x.c.Discount) / 100)
                });

            if (result.Any())
            {
                foreach (var item in result.OrderBy(x => x.Store).ThenBy(x => x.Product))
                {
                    Console.WriteLine($"{item.Store} {item.Product} {item.TotalDiscount} {item.PriceDiscount}");
                }
            }
            else
            {
                Console.WriteLine("Требуемые данные не найдены");
            }

        }
    }
}



