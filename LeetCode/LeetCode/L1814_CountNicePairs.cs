using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /**
     * 参考官方题解
     */
    internal class L1814_CountNicePairs
    {
        public int CountNicePairs(int[] nums)
        {
            const int MOD = 1000000007;
            int res = 0;
            Dictionary<int, int> h = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                int temp = i, j = 0;
                while (temp > 0)
                {
                    j = j * 10 + temp % 10;
                    temp /= 10;
                }
             
                h.TryAdd(i - j, 0);//API有TryAdd这个方法的，但这里提示没有？
                res = (res + h[i - j]) % MOD;
                h[i - j]++;
            }
            return res;
        }
    }
}
