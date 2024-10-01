using System;

/*
Time Complexity: O(n), where n is the number of elements in the array. The entire array is iterated over only once, making it very efficient.
Space Complexity: O(1), since we only use a constant amount of extra space.
*/

class Program
{
    static void Main()
    {
        int[] nums = { 1, 3, 2, 5, 1, 1, 2, 6, 7 };
        int k = 3;
        int maxSum = FindMaxSum(nums, k);
        Console.WriteLine("Maximum sum of subarray of size " + k + " is: " + maxSum);
    }

    static int FindMaxSum(int[] nums, int k)
    {
        if (nums.Length < k)
        {
            Console.WriteLine("The array is too small for the given window size.");
            return -1;
        }

        // Find the sum of the first window
        int windowSum = 0;
        for (int i = 0; i < k; i++)
        {
            windowSum += nums[i];
        }

        int maxSum = windowSum;

        // Slide the window over the array
        for (int i = k; i < nums.Length; i++)
        {
            windowSum += nums[i] - nums[i - k]; // Add the next element and subtract the first element of the previous window
            maxSum = Math.Max(maxSum, windowSum);
        }

        return maxSum;
    }
}
