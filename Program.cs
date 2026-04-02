
class Program
{
    static int[] Bubblesort(int[] arr)
    {
        for(int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = 0; j < arr.Length - i - 1; j++)
            {
                if(arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                }
            }
        }
        
        return arr;
    }
    static int ReverseInt(int num)
    {
        int reversed = 0;

        while(num != 0)
        {
           int digit = num % 10;

           if(reversed > int.MaxValue / 10 || reversed < int.MinValue / 10)
              return 0;
            
           if(reversed == int.MaxValue / 10 && digit > 7 || reversed == int.MinValue / 10 && digit < -8)
              return 0;
    
           reversed = reversed * 10 + digit;

           num = num / 10;
        }
        
        return reversed;
    }
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
        Console.WriteLine(ReverseInt(1201));
        Console.WriteLine(ReverseString("Hello"));
        Console.WriteLine(ReverseStringRecursive("Hello"));
    }
}