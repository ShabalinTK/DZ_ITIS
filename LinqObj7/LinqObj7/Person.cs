
namespace LinqObj7
{
    public class Person
    {
        public int ClientCode { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Hours { get; set; }

        public override string ToString()
        {
            return $"Year: {Year} | Month: {Month} | Hours: {Hours} | ClientCode: {ClientCode}";
        }
    }
}
