using System;
using System.Collections.Generic;
using System.Text;

namespace Hackerrank
{
    // https://www.hackerrank.com/challenges/time-conversion/problem
    class TimeConversion
    {
        // alternative method: could have parsed it to a Datetime and outputted it to military time
        static string timeConversion_problem(string s)
        {
            // Parse if AM or PM
            string amOrPm = s.Substring(8);
            string hours = s.Substring(0, 2);
            string minsAndSeconds = s.Substring(2, 6);

            // if / else for am PM and return
            if (amOrPm == "PM" && hours != "12")
            {
                int hoursInt = 0;
                int.TryParse(hours, out hoursInt);

                hoursInt += 12;

                hours = hoursInt.ToString();
            }
            else if (amOrPm == "AM" && hours == "12") hours = "00";

            return string.Concat(hours, minsAndSeconds);
        }

        // Input
        // 07:05:45PM

        // output should be 19:05:45

        //static void Main(string[] args)
        //{
        //    string s = Console.ReadLine();

        //    string result = timeConversion(s);
        //}
    }
}
