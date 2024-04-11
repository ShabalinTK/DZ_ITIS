

using System.Linq;

namespace LinqObj62
{
    public class Program
    {
        static void Main(string[] args)
        {
            var group = new List<SchoolBoy>();
            group.Add(new SchoolBoy
            {
                Class = 8,
                Surname = "Shabalin",
                Initials = "TK",
                Mark = 5,
                Object = "Algebra"
            });
            group.Add(new SchoolBoy
            {
                Class = 8,
                Surname = "Shabalin",
                Initials = "TK",
                Mark = 4,
                Object = "Algebra"
            });
            group.Add(new SchoolBoy
            {
                Class = 8,
                Surname = "Shabalin",
                Initials = "TK",
                Mark = 5,
                Object = "Algebra"
            });
            group.Add(new SchoolBoy
            {
                Class = 8,
                Surname = "Shabalin",
                Initials = "TK",
                Mark = 4,
                Object = "Informatics"
            }); group.Add(new SchoolBoy
            {
                Class = 8,
                Surname = "Shabalin",
                Initials = "TK",
                Mark = 4,
                Object = "Informatics"
            });
            group.Add(new SchoolBoy
            {
                Class = 8,
                Surname = "Shabalin",
                Initials = "TK",
                Mark = 3,
                Object = "Geometry"
            });

            group.Add(new SchoolBoy
            {
                Class = 11,
                Surname = "Popov",
                Initials = "II",
                Mark = 3,
                Object = "Algebra"
            });
            group.Add(new SchoolBoy
            {
                Class = 11,
                Surname = "Popov",
                Initials = "II",
                Mark = 5,
                Object = "Informatics"
            });

            var result = group.GroupBy(g => new { g.Surname, g.Initials, g.Class })
                .Select(s => new
                {
                    s.Key.Class,
                    s.Key.Surname,
                    s.Key.Initials,
                    Al = s.Count(c => c.Object == "Algebra"),
                    Ge = s.Count(c => c.Object == "Geometry"),
                    In = s.Count(c => c.Object == "Informatics")
                }).OrderBy(o => o.Class);

            foreach (var item in result)
            {
                Console.WriteLine($"Class: {item.Class} | Surname: {item.Surname} | Initials: {item.Initials} | Algebra: {item.Al} | Geometry: {item.Ge} | Informatics: {item.In}");

            }
        }
    }
}
