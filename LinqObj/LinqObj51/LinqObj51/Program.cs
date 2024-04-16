namespace LinqObj51
{
    public class Program
    {
        static void Main(string[] args)
        {
            var group = new List<Schoolboy>();
            group.Add(new Schoolboy
            {
                Ege = "100 100 100",
                Surname = "Shabalin",
                Initials = "TK",
                Number = 14
            });
            group.Add(new Schoolboy
            {
                Ege = "67 89 100",
                Surname = "Hramov",
                Initials = "VS",
                Number = 14
            });
            group.Add(new Schoolboy
            {
                Ege = "90 92 92",
                Surname = "Petrov",
                Initials = "EI",
                Number = 35
            });
            group.Add(new Schoolboy
            {
                Ege = "50 51 52",
                Surname = "Ivanov",
                Initials = "II",
                Number = 19
            });

            var result = group.GroupBy(g => g.Number)
                .Select(s => s.OrderByDescending(s => s.Ege.Split(' ')[2]).First())
                .OrderBy(x => x.Number);

            foreach(var item in result)
                Console.WriteLine($"{item}, Ege: {item.Ege.Split(' ')[2]}");
        }
    }
}
