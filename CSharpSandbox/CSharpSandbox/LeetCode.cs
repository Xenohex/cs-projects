public class LeetCode
{
    public bool IsValid(string s) {
        // brackets: (), {}, []
        // opening: (, {, [
        // closing: ), }, ]
        char[] queue = new char[s.Length];
        int queueIndex = 0;
        for(int stringIndex = 0; stringIndex < s.Length; stringIndex++)
        {
            try {
                char c = s[stringIndex];
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        queue[queueIndex] = c;
                        queueIndex++;
                        break;
                    case ')':
                        if (queue[queueIndex - 1] == '(')
                            queueIndex--;
                        else
                            return false;
                        break;
                    case '}':
                        if (queue[queueIndex - 1] == '{')
                            queueIndex--;
                        else
                            return false;
                        break;
                    case ']':
                        if (queue[queueIndex - 1] == '[')
                            queueIndex--;
                        else
                            return false;
                        break;
                }
            } catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
        if (queueIndex == 0)
            return true;
        return false;
    }

    public string LongestPalindrome(string s)
    {
        int n = s.Length;
        if (n == 0)
            return "";
        if (n == 1)
            return s[0].ToString();
        if (n == 2)
            if (s[0] == s[1])
                return s[0].ToString() + s[1].ToString();
            else
                return s[0].ToString();
        string longestPalindromeString = "";
        string currentString = "";

        // Odd n Palindrome Loop
        for (int i = 0; i < n; i++) 
        {
            if (i == 0)
            {
                longestPalindromeString = s[i].ToString();
            }
            currentString = s[i].ToString();
            int l = i - 1;
            int r = i + 1;
            while (l >= 0 && r < n) 
            {
                if (s[l] != s[r])
                    break;
                currentString = s[l] + currentString + s[r];
                if (currentString.Length > longestPalindromeString.Length)
                {
                    longestPalindromeString = currentString;
                }
                l--; r++;
            }
        }

        // Even n Palindrome Loop
        for (int i = 0; i < n-1; i++) 
        {
            if (s[i] != s[i + 1])
                continue;
            else
            {
                if (longestPalindromeString.Length < 2)
                {
                    longestPalindromeString = s[i].ToString() + s[i + 1].ToString();
                }
            }
            currentString = s[i].ToString() + s[i + 1].ToString();
            int l = i - 1;
            int r = i + 2;
            while (l >= 0 && r < n) 
            {
                if (s[l] != s[r])
                    break;
                currentString = s[l] + currentString + s[r];
                if (currentString.Length >= longestPalindromeString.Length)
                {
                    longestPalindromeString = currentString;
                }
                l--; r++;
            }
        }
        return longestPalindromeString;
    }

    public string ZigZagConversion(string s, int numRows)
    {
        string result = "";
        bool increasing = true;
        
        for (int targetPosition = 1; targetPosition <= numRows; targetPosition++)
        {
            int zzposition = 1;
            for (int j = 0; j < s.Length; j++)
            {
                if (numRows == 1)
                    zzposition = 1;
                else if (zzposition == 1)
                    increasing = true;
                else if (zzposition == numRows)
                    increasing = false;
                /////////////////////////
                
                if(targetPosition == zzposition)
                    result += s[j];

                /////////////////////////
                if (increasing)
                    zzposition++;
                else
                    zzposition--;
            }
        }

        return result;
    }

}