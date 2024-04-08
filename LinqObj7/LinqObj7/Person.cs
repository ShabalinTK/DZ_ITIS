using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqObj7
{
    public class Person
    {
        public int ClassesInHours { get; set; }
        public int Year { get; set; }
        public int MonthNumber{ get; set; }
        public int СlientСode { get; set; }

        public override string ToString()
        {
            return $"{Year} {MonthNumber} {ClassesInHours} {СlientСode}";
        }
    }
}
