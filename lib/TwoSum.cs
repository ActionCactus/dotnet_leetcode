using System;

/**
 * 'new' is heap memory
 * ints are fully allocated during initialization (IE: 32bit)
 * O(1) memory space growth
 * O(n^2) execution time
 * It's very common that you trade space for time, or vice versa.
 */
namespace lib
{
    /**
     * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.
     * Example:
     * Given nums = [2, 7, 11, 15], target = 9,
     * Because nums[0] + nums[1] = 2 + 7 = 9,
     * return [0, 1].
     */
    public class TwoSum
    {
        public static int[] calc(int[] dataSet, int target)
        {
            int x = 0;
            for (int i = 0; i < dataSet.Length; i++)
            {
                for (x = 0; x < dataSet.Length; x++)
                {
                    if (x == i)
                    {
                        continue;
                    }

                    if (dataSet[x] + dataSet[i] == target)
                    {
                        return new int[] { x, i };
                    }
                }
            }

            return null;
        }
    }
}