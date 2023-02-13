using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashmap = new Dictionary<int, int>();
            int diff = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                diff = target - nums[i];
                if (hashmap.ContainsKey(diff))
                {
                    return new int[] { hashmap[diff], i };
                }
                hashmap[nums[i]] = i;

            }
            return null;
        }
    }
}
