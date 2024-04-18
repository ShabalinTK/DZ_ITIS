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

            var result = E.Join(C,productConsumer => new { productConsumer.StoreName, productConsumer.ConsumerCode },discount => new { discount.StoreName, discount.ConsumerCode },(productConsumer, discount) => new { productConsumer, discount })
              .GroupJoin(D,x => new { x.productConsumer.StoreName, x.productConsumer.ProductCode },productPrice => new { productPrice.StoreName, productPrice.ProductCode },(x, prices) => new { x.productConsumer, x.discount, ProductPrices = prices.DefaultIfEmpty() })
              .SelectMany(x => x.ProductPrices, (x, productPrice) => new 
              { 
                  x.productConsumer, 
                  x.discount, 
                  ProductPrice = productPrice 
              })
              .GroupBy(x => new 
              { 
                  x.productConsumer.StoreName, 
                  x.productConsumer.ProductCode 
              })
              .OrderBy(g => g.Key.StoreName)
              .ThenBy(g => g.Key.ProductCode)
              .Select(g => new
              {
                  g.Key.StoreName,
                  g.Key.ProductCode,
                  PurchaseCount = g.Count(x => x.ProductPrice != null),
                  TotalDiscountedPrice = g.Where(x => x.ProductPrice != null).Sum(x => (decimal)x.ProductPrice.Price * (100 - x.discount.Discount) / 100)
              });

            if (result.Any())
            {
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.StoreName}, {item.ProductCode}, {item.PurchaseCount}, {item.TotalDiscountedPrice}");
                }
            }
            else
            {
                Console.WriteLine("Требуемые данные не найдены");
            }
        }
    }
}
