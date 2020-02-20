using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Easy
{
    class _929UniqueEmail
    {
        //public static void Main()
        //{
        //    string[] emails = { "test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" };

        //    int result = NumUniqueEmails(emails);

        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        public static int NumUniqueEmails(string[] emails)
        {
            HashSet<string> emailList = new HashSet<string>();

            foreach (var email in emails)
            {
                //int i;
                //for (i = 0; i < email.Length; i++)
                //{
                //    if (email[i] == '+' || email[i] == '@') break;
                //}
                //string finalName = email.Substring(0, i).Replace(".", string.Empty) + email.Substring(email.IndexOf('@'));

                string[] parts = email.Split('@');
                string[] local = parts[0].Split('+');

                string finalName = local[0].Replace(".", string.Empty) + "@" + parts[1];

                emailList.Add(finalName);
            }

            return emailList.Count;
        }
    }
}
