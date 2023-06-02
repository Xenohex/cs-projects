using System;
namespace CSharpSandbox
{
    public class Sandbox
    {
        public static void Main(string[] args)
        {
            Algorithms a = new Algorithms();
            LeetCode leet = new LeetCode();

            //Console.WriteLine(leet.LongestPalindrome("babad"));
            int[] A = { 1, 2, 3, 4};
            a.HeapPerm(A, 4, 4);
        }
    }
}
