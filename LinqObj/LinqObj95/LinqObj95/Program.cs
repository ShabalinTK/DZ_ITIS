
namespace LinqObj95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Alist = new List<A>
            {
                new A { BirthYear = 1990, ConsumerCode = 101, Street = "Main St" },
                new A { BirthYear = 1985, ConsumerCode = 102, Street = "Elm St" },
                new A { BirthYear = 1995, ConsumerCode = 103, Street = "Oak St" },
                new A { BirthYear = 1980, ConsumerCode = 104, Street = "Maple St" },
                new A { BirthYear = 1992, ConsumerCode = 105, Street = "Pine St" }
            };

            var Clist = new List<C>
            {
                new C { ConsumerCode = 101, StoreName = "Store1", DiscountPercentage = 10 },
                new C { ConsumerCode = 102, StoreName = "Store2", DiscountPercentage = 15 },
                new C { ConsumerCode = 103, StoreName = "Store1", DiscountPercentage = 20 },
                new C { ConsumerCode = 104, StoreName = "Store1", DiscountPercentage = 10 },
                new C { ConsumerCode = 105, StoreName = "Store2", DiscountPercentage = 5 }
            };

            var Dlist = new List<D>
            {
                new D { Price = 100, StoreName = "Store1", ProductCode = "A123-4567" },
                new D { Price = 200, StoreName = "Store2", ProductCode = "B234-5678" },
                new D { Price = 300, StoreName = "Store1", ProductCode = "A123-4567" },
                new D { Price = 400, StoreName = "Store1", ProductCode = "C345-6789" },
                new D { Price = 500, StoreName = "Store2", ProductCode = "B234-5678" }
            };

            var Elist = new List<E>
            {
                new E { ConsumerCode = 101, StoreName = "Store1", ProductCode = "A123-4567" },
                new E { ConsumerCode = 102, StoreName = "Store2", ProductCode = "B234-5678" },
                new E { ConsumerCode = 103, StoreName = "Store1", ProductCode = "A123-4567" },
                new E { ConsumerCode = 104, StoreName = "Store1", ProductCode = "C345-6789" },
                new E { ConsumerCode = 105, StoreName = "Store2", ProductCode = "B234-5678" }
            };

            var result = Elist.Join(Dlist, e => new { e.ProductCode, e.StoreName }, d => new { d.ProductCode, d.StoreName }, (e, d) => new { EData = e, DData = d })
                .Join(Alist, edData => edData.EData.ConsumerCode, a => a.ConsumerCode, (edData, a) => new { EdDataAndAData = edData, AData = a })
                .Join(Clist, edaData => new { edaData.EdDataAndAData.EData.ConsumerCode, edaData.EdDataAndAData.EData.StoreName }, c => new { c.ConsumerCode, c.StoreName }, (edaData, c) => new { EdaDataAndCData = edaData, CData = c })
                .GroupBy(edac => new { edac.EdaDataAndCData.EdDataAndAData.EData.ProductCode, edac.EdaDataAndCData.AData.Street }, edac => new { edac.EdaDataAndCData.EdDataAndAData.DData.Price, edac.CData.DiscountPercentage })
                .Select(g => new
                {
                    ProductC = g.Key.ProductCode,
                    Streett = g.Key.Street,
                    TotalDiscount = (int)g.Sum(x => x.Price * x.DiscountPercentage / 100)
                })
                .OrderBy(x => x.ProductC)
                .ThenBy(x => x.Streett);

            foreach (var item in result)
            {
                Console.WriteLine($"Артикул: {item.ProductC} улица: {item.Streett} суммаа со скидкой: {item.TotalDiscount}");
            }

        }
    }
}
