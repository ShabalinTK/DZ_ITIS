
<<<<<<< HEAD
using System.Text.RegularExpressions;

namespace LinqObj7
{
=======

namespace LinqObj7
{

>>>>>>> 456944f2bf1a92b6eb328e56192b41bf387d4fe5
    public class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            
        }
    }

    public class Number
    {
        public void NumberInfo()
        {
            int K = 1;

            List<Result> results = FindMaxDuration(clients, K);

            if (results.Count > 0)
            {
                results = results.OrderByDescending(r => r.Year).ToList();

                foreach (Result result in results)
                {
                    Console.WriteLine($"{result.Year}, месяц {result.Month}, продолжительность занятий: {result.Duration} часов");
                }
            }
            else
                Console.WriteLine("Нет данных");
=======
            Info info = new Info();
            info.InfoPerson();
>>>>>>> 456944f2bf1a92b6eb328e56192b41bf387d4fe5
        }
    }

    public class Info
    {
<<<<<<< HEAD
=======
        public int k = 2;
>>>>>>> 456944f2bf1a92b6eb328e56192b41bf387d4fe5
        public void InfoPerson()
        {
            var groups = new List<Person>
            {
<<<<<<< HEAD
                new Person() { СlientСode = 1, Year = 2024, MonthNumber = 4, ClassesInHours = 16 },
                new Person() { СlientСode = 2, Year = 2022, MonthNumber = 3, ClassesInHours = 12 },
                new Person() { СlientСode = 3, Year = 2021, MonthNumber = 4, ClassesInHours = 16 },
                new Person() { СlientСode = 4, Year = 2023, MonthNumber = 6, ClassesInHours = 15 },
                new Person() { СlientСode = 5, Year = 2022, MonthNumber = 7, ClassesInHours = 10 },
                new Person() { СlientСode = 6, Year = 2021, MonthNumber = 8, ClassesInHours = 22 },
                new Person() { СlientСode = 7, Year = 2019, MonthNumber = 9, ClassesInHours = 19 },
                new Person() { СlientСode = 8, Year = 2023, MonthNumber = 3, ClassesInHours = 17 },
                new Person() { СlientСode = 9, Year = 2020, MonthNumber = 7, ClassesInHours = 11 },
            };
        }
        
=======
                Person1(),
                Person2(),
                Person3()
            };
            ProcessData(groups, k);
        }

        private Person Person1()
        {
            return new Person()
            {
                ClientCode = 1,
                Year = new List<int> { 2021, 2022, 2023 },
                Month = new Dictionary<int, List<int>>
                {
                    { 2021, new List<int> { 1, 2, 3 } }, // Год 2021: Январь, Февраль, Март
                    { 2022, new List<int> { 4, 5, 6 } }, // Год 2022: Апрель, Май, Июнь
                    { 2023, new List<int> { 7, 8, 9 } }  // Год 2023: Июль, Август, Сентябрь
                },
                Hours = new Dictionary<int, Dictionary<int, int>>
                {
                    {
                        2021, new Dictionary<int, int>
                        {
                            { 1, 10 }, // Январь (10 часов)
                            { 2, 8 },  // Февраль (8 часов)
                            { 3, 12 }  // Март (12 часов)
                        }
                    },
                    {
                        2022, new Dictionary<int, int>
                        {
                            { 4, 6 },  // Апрель (6 часов)
                            { 5, 9 },  // Май (9 часов)
                            { 6, 7 }   // Июнь (7 часов)
                        }
                    },
                    {
                        2023, new Dictionary<int, int>
                        {
                            { 7, 11 }, // Июль (11 часов)
                            { 8, 5 },  // Август (5 часов)
                            { 9, 10 }  // Сентябрь (10 часов)
                        }
                    }
                }
            };
        }

        private Person Person2()
        {
            return new Person()
            {
                ClientCode = 2,
                Year = new List<int> { 2021, 2022, 2023 },
                Month = new Dictionary<int, List<int>>
                {
                    { 2021, new List<int> { 2, 3, 11 } },   // Год 2021: Февраль, Март, Апрель
                    { 2022, new List<int> { 5, 6, 7 } },   // Год 2022: Май, Июнь, Июль
                    { 2023, new List<int> { 8, 9, 10 } }   // Год 2023: Август, Сентябрь, Октябрь
                },
                Hours = new Dictionary<int, Dictionary<int, int>>
                {
                    {
                        2021, new Dictionary<int, int>
                        {
                            { 2, 9 },  // Февраль (9 часов)
                            { 3, 7 },  // Март (7 часов)
                            { 11, 10 }  // Апрель (10 часов)
                        }
                    },
                    {
                        2022, new Dictionary<int, int>
                        {
                            { 5, 8 },  // Май (8 часов)
                            { 6, 6 },  // Июнь (6 часов)
                            { 7, 15 }  // Июль (11 часов)
                        }
                    },
                    {
                        2023, new Dictionary<int, int>
                        {
                            { 8, 12 }, // Август (12 часов)
                            { 9, 12 },  // Сентябрь (5 часов)
                            { 10, 9 }  // Октябрь (9 часов)
                        }
                    }
                }
            };
        }

        private Person Person3()
        {
            return new Person()
            {
                ClientCode = 3,
                Year = new List<int> { 2020, 2021, 2022 },
                Month = new Dictionary<int, List<int>>
                {
                    { 2020, new List<int> { 1, 3, 5 } },   // Год 2020: Январь, Март, Май
                    { 2021, new List<int> { 7, 8, 10 } },  // Год 2021: Июль, Август, Октябрь
                    { 2022, new List<int> { 2, 4, 6 } }    // Год 2022: Февраль, Апрель, Июнь
                },
                Hours = new Dictionary<int, Dictionary<int, int>>
                {
                    {
                        2020, new Dictionary<int, int>
                        {
                            { 1, 11 }, // Январь (11 часов)
                            { 3, 6 },  // Март (6 часов)
                            { 5, 9 }   // Май (9 часов)
                        }
                    },
                    {
                        2021, new Dictionary<int, int>
                        {
                            { 7, 8 },  // Июль (8 часов)
                            { 8, 10 }, // Август (10 часов)
                            { 10, 7 }  // Октябрь (7 часов)
                        }
                    },
                    {
                        2022, new Dictionary<int, int>
                        {
                            { 2, 7 },  // Февраль (7 часов)
                            { 4, 11 }, // Апрель (11 часов)
                            { 6, 5 }   // Июнь (5 часов)
                        }
                    }
                }
            };
        }

        public void ProcessData(List<Person> groups, int k)
        {
            var result = new List<string>();
            var flag = true;

            foreach (var person in groups)
            {
                if (person.ClientCode == k)
                {
                    flag = false;
                    foreach (var year in person.Year.OrderByDescending(y => y))
                    {
                        var months = person.Month[year];
                        var hours = person.Hours[year];

                        int maxDuration = -1;
                        int maxDurationMonth = 0;

                        foreach (var month in months.OrderBy(m => m))
                        {
                            if (hours[month] > maxDuration)
                            {
                                maxDuration = hours[month];
                                maxDurationMonth = month;
                            }
                        }

                        result.Add($"year:{year}, Month:{maxDurationMonth}, Duration:{maxDuration}");
                    }
                }
            }

            if(flag)
            {
                result.Add("Нет такого клиента");
            }

            foreach (var data in result.OrderByDescending(r => r))
            {
                Console.WriteLine(data);
            }


        }
>>>>>>> 456944f2bf1a92b6eb328e56192b41bf387d4fe5
    }
}
