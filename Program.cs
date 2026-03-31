
class Program
{
    static string ReverseString(string str)
    {
        var chars = str.ToArray();
        int left = 0;
        int right = chars.Length - 1;

        while(left < right)
        {
            (chars[left], chars[right]) = (chars[right], chars[left]);

            left++;
            right--;
        }

        return new string(chars);
    }

    static string ReverseStringRecursive(string str)
    {
        if(str == "")
           return str;

        return ReverseString(str.Substring(1)) + str[0];
    }
    static void Main(string[] args)
    {
    }
}