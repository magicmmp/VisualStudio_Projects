using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class L7_Reverse
    {
        public int Reverse(int x)
        {
            long res = 0;
            for (; x != 0; x /= 10)
                res = res * 10 + x % 10;
            return res > int.MaxValue || res < int.MinValue ? 0 : (int)res;
        }
    }
}