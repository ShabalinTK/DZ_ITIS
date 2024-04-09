

namespace LinqObj29
{
    public class Human
    {
        public int Number { get; set; }
        public string Surname { get; set; }
        public double Sum { get; set; }

        public override string ToString()
        {
            return $"Number: {Number}, Surname: {Surname}, Sum: {Sum}";
        }
    }
}
