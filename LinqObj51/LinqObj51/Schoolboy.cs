

namespace LinqObj51
{
    public class Schoolboy
    {
        public string Ege { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return $"Number: {Number}, Surname: {Surname},  Initials: {Initials}";
        }
    }
}
