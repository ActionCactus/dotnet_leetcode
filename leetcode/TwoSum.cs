namespace leetcode
{
    /**
     * Problem:
     * Given an array of integers, return indices of the two numbers such that they add up to a specific target.
     * You may assume that each input would have exactly one solution, and you may not use the same element twice.
     * Example:
     * Given nums = [2, 7, 11, 15], target = 9,
     * Because nums[0] + nums[1] = 2 + 7 = 9,
     * return [0, 1].
     *
     * Notes/lessons learned:
     *  - 'new' allocates on the heap (gen 0) for ref types
     *  - 'primitives' are called simple types and they're all actually structs in the System namespace
     *  - trade time for space and vice versa
     */
    public class TwoSum
    {

        /**
         * This is a pretty naive solution which is optimized for space more than it is for time
         * O(n^2) time
         * O(1) space
         */
        public static int[] calc(int[] dataSet, int target)
        {
            int x = 0;
            for (int i = 0; i < dataSet.Length; i++)
            {
                for (x = i + 1; x < dataSet.Length; x++)
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