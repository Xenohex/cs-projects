// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2] { -1, -1 };
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; i++)
        {
            if (nums[i] + nums[j] == target)
            {
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

