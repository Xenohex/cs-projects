﻿using System;
namespace CSharpSandbox
{
    public class Sandbox
    {
        public static void Main(string[] args)
        {
            Algorithms a = new Algorithms();
            LeetCode leet = new LeetCode();


            string s = "aaaa";
            Console.WriteLine(leet.LongestPalindrome(s));
        }
    }
}
