

namespace LinqObj18
{
    public class Program
    {
        static void Main(string[] args)
        {
            var abitur = new List<Applicant>();
            abitur.Add(new Applicant
            {
                Year = 2012,
                Number = 123,
                Surname = "Shabalin"
            });

            abitur.Add(new Applicant
            {
                Year = 2012,
                Number = 32,
                Surname = "Ivanov"
            });

            abitur.Add(new Applicant
            {
                Year = 2010,
                Number = 52,
                Surname = "Petrov"
            });

            abitur.Add(new Applicant
            {
                Year = 2010,
                Number = 92,
                Surname = "Sidorov"
            });

            abitur.Add(new Applicant
            {
                Year = 2011,
                Number = 1,
                Surname = "Smirnov"
            });

            abitur.Add(new Applicant
            {
                Year = 2011,
                Number = 74,
                Surname = "Kuznetsov"
            });

            abitur.Add(new Applicant
            {
                Year = 2011,
                Number = 37,
                Surname = "Popov"
            });

            abitur.Add(new Applicant
            {
                Year = 2011,
                Number = 19,
                Surname = "Novikov"
            });

            var years = abitur.GroupBy(a => a.Year)
                .Select(g => new
                {
                    Year = g.Key,
                    Count = g.Count()
                })
                .Where(a => a.Count >= abitur.Count / abitur.GroupBy(a => a.Year).Count())
                .OrderByDescending(a => a.Count)
                .ThenBy(a => a.Year);

            foreach (var year in years)
            {
                Console.WriteLine($"{year.Count} -- {year.Year}");
            }
        }
    }
}
