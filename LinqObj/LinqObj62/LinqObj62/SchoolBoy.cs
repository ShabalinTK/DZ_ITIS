

namespace LinqObj62
{
    public class SchoolBoy
    {
        public int Class { get; set; }
        public string Surname { get; set; }
        public string Initials { get; set; }
        public int Mark { get; set; }
        public string Object { get; set; }

        public override string ToString()
        {
            return $"Class: {Class}, Surname: {Surname}, Initials: {Initials}, Marks: {Mark}";
        }
    }
}
