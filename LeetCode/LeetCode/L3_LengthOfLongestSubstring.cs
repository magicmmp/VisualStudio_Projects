using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    
    public class L3_LengthOfLongestSubstring
    {
        //利用了滑动窗口的思想，leftIdx表示当前不重复子串的左端起始位置
        //如果当前字符c已经在之前位置p出现过，leftIdx就跳到下一个字母的位置p+1
        //这样，leftIdx到当前位置i之间的子串总是不重复的
        public int LengthOfLongestSubstring(string s)
        {
            //如果是空串
			if (s == null || s.Length == 0)
				return 0;
            //新子串起始索引，从0开始
            int leftIdx = 0;
            //结果
            int maxLen = 0;
            int tmpLen;
            //记录每个字符最新出现的索引位置，从1开始
            //数组初始化为0
            //char类型可安全转换为int，字母取值小于128可直接作为下标值
            int[] charPosition = new int[128];
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                //发现重复字符则重新记录新子串起始位置
                if (charPosition[c] > leftIdx)
                    leftIdx = charPosition[c];
                //当前子串的长度
                tmpLen = i - leftIdx + 1;
                if (tmpLen > maxLen)
                    maxLen = tmpLen;
                //更新每个出现字符的新位置
                charPosition[c] = i + 1;
            }
            return maxLen;
        }
    }
}
