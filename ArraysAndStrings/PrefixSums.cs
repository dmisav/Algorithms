using System;

/*
Preprocessing Time Complexity: O(n), where n is the length of the array. The prefix sum array is built in one pass through the original array.
Query Time Complexity: O(1) per query, since the sum of any subarray can be found using simple arithmetic on the prefix array.
Space Complexity: O(n), required for storing the prefix sums.
*/

class Program
{
    static void Main()
    {
        int[] nums = { 1, 3, 5, 7, 9, 2 };
        int left = 1;
        int right = 4;

        int[] prefixSum = CalculatePrefixSum(nums);
        
        // Get the sum of the subarray between indices `left` and `right`
        int subarraySum = GetSubarraySum(prefixSum, left, right);
        Console.WriteLine($"Sum of elements between indices {left} and {right} is: {subarraySum}");
    }

    static int[] CalculatePrefixSum(int[] nums)
    {
        int[] prefix = new int[nums.Length + 1]; // Create an extra space to simplify sum calculations
        prefix[0] = 0; // Prefix sum of an empty subarray is 0

        // Fill the prefix array
        for (int i = 1; i <= nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] + nums[i - 1];
        }

        return prefix;
    }

    static int GetSubarraySum(int[] prefixSum, int left, int right)
    {
        // Get the sum using the prefix array
        return prefixSum[right + 1] - prefixSum[left];
    }
}
