using System;
using System.Threading;

namespace Search_in_Rotated_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 5, 6, 0, 1, 2, 3, 4 }; // 5 1 3
            var target = 5;
            Console.WriteLine(Search(nums, target));
        }

        static int Search(int[] nums, int target)
        {
            if (nums.Length == 0) return -1;
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target) return mid;
                if (nums[low] <= nums[mid]) // 3 4 5 6 0 1 2
                {
                    if (target >= nums[low] && target <= nums[mid])
                        high = mid;
                    else
                        low = mid + 1;
                }
                else // 5 6 0 1 2 3 4
                {
                    if (target >= nums[mid] && target <= nums[high])
                        low= mid;
                    else
                        high = mid - 1;
                }
            }
            return -1;
        }
    }
}
