
class Program
{
    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            var num = target - nums[i];

            if(map.ContainsKey(num))
                 return new int[] { map[num], i };
            
            map[nums[i]] = i;
        }
        
        throw new Exception("No solution found");
    }
    static int[] SelectionSort(int[] nums)
    {
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            int index = i ;

            for(int j = 0; j < i; j++)
            {
                if(nums[j] > nums[index])
                   index = j;
            }

            if(index != i)
               (nums[i], nums[index]) = (nums[index], nums[i]);
        }

        return nums;
    }
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
    }
}