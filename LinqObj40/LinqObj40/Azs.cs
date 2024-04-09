

namespace LinqObj40
{
    public class Azs
    {
        public string Comp { get; set; }

        public Dictionary<string, Dictionary<int, List<int>>> Str { get; set; }

        public Dictionary<int, List<int>> Number { get; set; }

        public List<int> Sum { get; set; }

        public override string ToString()
        {
            return $"Comp: {Comp}, Str: {Str}, Number: {Number}, Sum: {Sum}";
        }
    }
}
