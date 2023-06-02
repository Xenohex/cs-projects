public class LeetCode
{
    public void execute()
    {
        string test = "";
        test = "babad";
        //Console.WriteLine("Expected: bab");
        //Console.WriteLine(LongestPalindrome(test));
        //test = "cbbd";
        //Console.WriteLine("Expected: bb");
        //Console.WriteLine(LongestPalindrome(test));
        //test = "racecar";
        //Console.WriteLine("Expected: racecar");
        //Console.WriteLine(LongestPalindrome(test));
        //test = "lopobuup";
        //Console.WriteLine("Expected: opo");
        //Console.WriteLine(LongestPalindrome(test));
        //test = "a";
        //Console.WriteLine("Expected: a");
        //Console.WriteLine(LongestPalindrome(test));
        //test = "anugnxshgonmqydttcvmtsoaprxnhpmpovdolbidqiyqubirkvhwppcdyeouvgedccipsvnobrccbndzjdbgxkzdbcjsjjovnhpnbkurxqfupiprpbiwqdnwaqvjbqoaqzkqgdxkfczdkznqxvupdmnyiidqpnbvgjraszbvvztpapxmomnghfaywkzlrupvjpcvascgvstqmvuveiiixjmdofdwyvhgkydrnfuojhzulhobyhtsxmcovwmamjwljioevhafdlpjpmqstguqhrhvsdvinphejfbdvrvabthpyyphyqharjvzriosrdnwmaxtgriivdqlmugtagvsoylqfwhjpmjxcysfujdvcqovxabjdbvyvembfpahvyoybdhweikcgnzrdqlzusgoobysfmlzifwjzlazuepimhbgkrfimmemhayxeqxynewcnynmgyjcwrpqnayvxoebgyjusppfpsfeonfwnbsdonucaipoafavmlrrlplnnbsaghbawooabsjndqnvruuwvllpvvhuepmqtprgktnwxmflmmbifbbsfthbeafseqrgwnwjxkkcqgbucwusjdipxuekanzwimuizqynaxrvicyzjhulqjshtsqswehnozehmbsdmacciflcgsrlyhjukpvosptmsjfteoimtewkrivdllqiotvtrubgkfcacvgqzxjmhmmqlikrtfrurltgtcreafcgisjpvasiwmhcofqkcteudgjoqqmtucnwcocsoiqtfuoazxdayricnmwcg";
        var watch = System.Diagnostics.Stopwatch.StartNew();
        Console.WriteLine(LongestPalindrome(test));
        watch.Stop();
        var elapsedMs = watch.ElapsedMilliseconds;
        Console.WriteLine(elapsedMs);
    }

    // Old code
    /*for (int j = i; j < n; j++)
            {
                current = "";
                currentReverse = "";
                if (s[i] == s[j])
                {
                    int k;
                    for (k = i; k <= j; k++)
                    {
                        current += s[k];
                    }
                    for (k = current.Length - 1; k >= 0; k--)
                    {
                        currentReverse += current[k];
                    }
                    if (current != currentReverse)
                    {
                        current = "";
                    }
                    else
                    {
                        if (current.Length > longest.Length)
                        {
                            longest = current;
                        }
                    }
                }
            }*/

    public string LongestPalindrome(string s)
    {
        int n = s.Length;
        string longest = "";
        string current;
        string currentReverse;
        for (int i = 0; i < n; i++)
        {
            
        }
        return longest;
    }
}