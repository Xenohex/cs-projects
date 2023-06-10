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
            } catch (IndexOutOfRangeException ex)
            {
                return false;
            }
        }
        if (queueIndex == 0)
            return true;
        return false;
    }
}