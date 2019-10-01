using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// Given a list of people with their birth and death years, implement a method to
    /// compute the year with the most number of people alive.You may assume that all people were born
    /// between 1900 and 2000 (inclusive). If a person was alive during any portion of that year, they should
    /// be included in that year's count. For example, Person (birth = 1908, death = 1909) is included in the
    /// counts for both 1908 and 1909
    /// </summary>
    class _16_10LivingPeople
    {
        static int FindMostAlivePeople(List<Person> people)
        {
            // check every year and save # alive people in dictionary, hold max value
            // benefit is that you can add on more people easily and be able to answer multiple years
            // time is 100 * n .. rounds to n..
            Dictionary<int, int> YearsIndex = new Dictionary<int, int>();

            int _year = 0;
            int _max = 0;

            for (int year = 1900; year <= 2000; year++)
            {
                YearsIndex.TryAdd(year, 0);

                foreach (var person in people)
                {
                    if (year >= person.BirthYear && year <= person.DeathYear)
                    {
                        YearsIndex[year]++;
                    }
                }

                // can change to array and dump array if larger value is found to get multiple max years
                if (YearsIndex[year] > _max)
                {
                    _year = year;
                    _max = YearsIndex[year];
                } 
            }

            Console.WriteLine($"The max is in the year: {_year} with {_max} folk alive.");

            return _year;
        }

        //static void Main(string[] arg)
        //{
        //    List<Person> people = new List<Person>()
        //    {
        //        new Person(){ Id = 1, BirthYear = 1900, DeathYear = 1999}, 
        //        new Person(){ Id = 2, BirthYear = 1991, DeathYear = 2050}, 
        //        new Person(){ Id = 3, BirthYear = 1950, DeathYear = 2000}, 
        //        new Person(){ Id = 4, BirthYear = 1900, DeathYear = 2000}, 
        //        new Person(){ Id = 5, BirthYear = 1904, DeathYear = 1987}, 
        //        new Person(){ Id = 6, BirthYear = 1967, DeathYear = 2090}, 
        //        new Person(){ Id = 7, BirthYear = 1952, DeathYear = 1980}, 
        //        new Person(){ Id = 8, BirthYear = 1920, DeathYear = 1963}, 
        //        new Person(){ Id = 9, BirthYear = 1910, DeathYear = 1960}
        //    };

        //    FindMostAlivePeople(people);
        //}
    }

    public class Person
    {
        public int Id { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
    }
}
