
namespace LinqObj18
{
    public class Applicant
    {
        public int Year { get; set; }
        public int Number { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"Year: {Year}, Number: {Number}, Surname: {Surname}";
        }
    }
}
