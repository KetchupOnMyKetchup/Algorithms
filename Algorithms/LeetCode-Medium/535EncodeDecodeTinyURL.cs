using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.LeetCode_Medium
{
    class _535EncodeDecodeTinyURL
    {
        // Encodes a URL to a shortened URL
        public static string encode(string longUrl)
        {

            var plainTextBytes = Encoding.UTF8.GetBytes(longUrl);
            var result = Convert.ToBase64String(plainTextBytes);

            return $"http://tinyurl.com/{result}";
        }

        // Decodes a shortened URL to its original URL.
        public static string decode(string shortUrl)
        {

            return "";
        }

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(encode("https://leetcode.com/problems/design-tinyurl"));
        //    Console.WriteLine(decode("http://tinyurl.com/4e9iAk"));
        //    Console.ReadLine();
        //}
    }
}
