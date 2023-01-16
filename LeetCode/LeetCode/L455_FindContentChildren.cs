using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class L455_FindContentChildren
    {
        //贪心思想
        //因为最小的孩子最容易得到满足，因此先满足最小孩子。给一个孩子的饼干应当尽量小又能满足该孩子，
        //这样大饼干就能拿来给满足度比较大的孩子。
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);//对数组从小到大排序
            Array.Sort(s);
            int i = 0, j = 0;
            while (i < g.Length && j < s.Length)
            {
                if (g[i] <= s[j]) i++;
                j++;
            }
            return i;
        }
    }
}

