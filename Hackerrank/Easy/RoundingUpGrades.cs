using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hackerrank.Easy
{
    public class RoundingUpGrades
    {
        // https://www.hackerrank.com/challenges/grading/problem
        static int[] gradingStudents(int[] grades)
        {
            int[] roundedGrades = new int[grades.Count()];

            int i = 0;

            foreach (int grade in grades)
            {
                roundedGrades[i] = grade;

                if (grade > 37)
                {
                    int remainder = grade % 5;

                    if (remainder > 2) roundedGrades[i] = grade + (5 - remainder);
                }

                i++;
            }

            return roundedGrades;
        }
        //static void Main(string[] args)
        //{
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    int[] grades = new int[n];

        //    for (int gradesItr = 0; gradesItr < n; gradesItr++)
        //    {
        //        int gradesItem = Convert.ToInt32(Console.ReadLine());
        //        grades[gradesItr] = gradesItem;
        //    }

        //    int[] result = gradingStudents(grades);
        //}
    }
}
