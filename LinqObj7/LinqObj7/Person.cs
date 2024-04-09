
namespace LinqObj7
{
    public class Person
    {
        public int ClientCode { get; set; }
        public List<int> Year { get; set; }
        public Dictionary<int, List<int>> Month { get; set; }
        public Dictionary<int, Dictionary<int, int>> Hours { get; set; }

        public override string ToString()
        {
            return $"{Year} {Month} {Hours} {ClientCode}";
        }
        public Person()
        {
            Year = new List<int>();
            Month = new Dictionary<int, List<int>>();
            Hours = new Dictionary<int, Dictionary<int, int>>();
        }
    }
}
