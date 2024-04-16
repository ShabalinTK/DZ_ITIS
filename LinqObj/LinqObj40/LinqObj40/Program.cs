namespace LinqObj40
{
    public class Program
    {
        static void Main(string[] args)
        {
            var group = new List<Azs>();
            group.Add(new Azs
            {
                Comp = "Татнефть",
                Street = "1",
                Number = 92,
                Sum = 4910
            });
            group.Add(new Azs
            {
                Comp = "Татнефть",
                Street = "1",
                Number = 98,
                Sum = 6035
            });
            group.Add(new Azs
            {
                Comp = "Татнефть",
                Street = "2",
                Number = 92,
                Sum = 4910
            });
            group.Add(new Azs
            {
                Comp = "Татнефть",
                Street = "2",
                Number = 95,
                Sum = 5315
            });
            group.Add(new Azs
            {
                Comp = "Татнефть",
                Street = "2",
                Number = 98,
                Sum = 6035
            });


            group.Add(new Azs
            {
                Comp = "Лукойл",
                Street = "1",
                Number = 92,
                Sum = 4940
            });
            group.Add(new Azs
            {
                Comp = "Лукойл",
                Street = "2",
                Number = 95,
                Sum = 5395
            });


            group.Add(new Azs
            {
                Comp = "Газпромнефть",
                Street = "1",
                Number = 92,
                Sum = 4915
            });
            group.Add(new Azs
            {
                Comp = "Газпромнефть",
                Street = "2",
                Number = 98,
                Sum = 5965
            });

            var result = group.GroupBy(g => g.Street)
            .Select(g => new
            {
                Street = g.Key,
                Num92 = g.Count(s => s.Number == 92),
                Num95 = g.Count(s => s.Number == 95),
                Num98 = g.Count(s => s.Number == 98)
            }).OrderBy(r => r.Street);

            foreach (var item in result)
            {
                Console.WriteLine($"Street: {item.Street}, Nuber 92: {item.Num92}, 95: {item.Num95}, 98: {item.Num98}");
            }
        }
    }
}