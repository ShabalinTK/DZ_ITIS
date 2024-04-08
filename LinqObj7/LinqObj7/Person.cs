<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
=======
﻿
>>>>>>> 456944f2bf1a92b6eb328e56192b41bf387d4fe5

namespace LinqObj7
{
    public class Person
    {
<<<<<<< HEAD
        public int ClassesInHours { get; set; }
        public int Year { get; set; }
        public int MonthNumber{ get; set; }
        public int СlientСode { get; set; }

        public override string ToString()
        {
            return $"{Year} {MonthNumber} {ClassesInHours} {СlientСode}";
=======
        public int ClientCode { get; set; }
        public List<int> Year { get; set; }
        public Dictionary<int, List<int>> Month { get; set; }
        public Dictionary<int, Dictionary<int, int>> Hours { get; set; }

        public Person()
        {
            Year = new List<int>();
            Month = new Dictionary<int, List<int>>();
            Hours = new Dictionary<int, Dictionary<int, int>>();
>>>>>>> 456944f2bf1a92b6eb328e56192b41bf387d4fe5
        }
    }
}
