using System;
namespace CSharpSandbox
{
    public class Sandbox
    {
        public static void Main(string[] args)
        {
            Algorithms a = new Algorithms();
            LeetCode leet = new LeetCode();

            string s1 = "AB";
            string s2 = "PAYPALISHIRING";
            Console.WriteLine(leet.ZigZagConversion(s1, 1));
            Console.WriteLine(leet.ZigZagConversion(s2, 4));
        }
    }
}
