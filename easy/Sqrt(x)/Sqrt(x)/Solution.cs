using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt_x_
{
    internal class Solution
    {
        public int MySqrt(int x)
        {
            if (x == 0) return 0;
            int low = 1, high = x, ans = 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (x / mid == mid) return mid;
                else if (x / mid > mid)
                {
                    low = mid + 1; ans = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans;
        }
    }
}
